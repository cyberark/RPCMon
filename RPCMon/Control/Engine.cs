using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RPCMon.Control
{
    public delegate void BuildRPCDBEventHandler(string i_File, string i_FileStatus, int i_NumOfFilesWithRPC, int i_TotalNumberOfFiles);
    public delegate void DoneRPCSearchEventHandler(List<IEnumerable<NtApiDotNet.Win32.RpcServer>> i_RPCServers);
    static class Engine
    {
        public static event BuildRPCDBEventHandler BuildRPCDBStatusUpdate;
        public static event DoneRPCSearchEventHandler DoneRPCSearchUpdate;
        private const string m_SymbolsPath = @"srv*c:\symbols*http://msdl.microsoft.com/download/symbols";
        private static List<IEnumerable<NtApiDotNet.Win32.RpcServer>> m_RPCServersDB;
        private static string m_DbgHelp = @"C:\Windows\system32\dbghelp.dll";
        private static int m_TotalNumberOfFiles, m_NumOfFilesWithRPC;
        private const string c_FolderToSearch = @"C:\Windows\";
        private static bool m_IsDoneRPCSearch = false;
        private static Dictionary<string, bool> m_ExcludedFoldersMap = new Dictionary<string, bool>();
        public static void StopRPCSearch()
        {
            m_IsDoneRPCSearch = true;
        }

        public static string DbgHelpFilePath
        {
            get { return m_DbgHelp; }
            set { m_DbgHelp = value; }
        }

        public static void BuildRPCDataBase(string i_FolderToSearch, string i_SavedFilePath, bool i_Recursive, string[] i_ExcludedFolders, params string[] i_Extensions)
        {
            m_TotalNumberOfFiles = 0;
            m_NumOfFilesWithRPC = 0;
            m_IsDoneRPCSearch = false;
            m_RPCServersDB = new List<IEnumerable<NtApiDotNet.Win32.RpcServer>>();
            if (i_FolderToSearch == "")
            {
                i_FolderToSearch = c_FolderToSearch;
            }

            m_ExcludedFoldersMap.Clear();
            foreach (string folder in i_ExcludedFolders)
            {
                m_ExcludedFoldersMap.Add(folder.ToLower(), true);
            }

            buildRPCServersList(i_FolderToSearch, i_Recursive, i_Extensions);

            OnDoneRPCSearchUpdate(m_RPCServersDB);
            saveDBAsJson(m_RPCServersDB, i_SavedFilePath);

            // var a = NtApiDotNet.Win32.RpcAlpcServer.GetAlpcServers();
        }

        private static void saveDBAsJson(List<IEnumerable<NtApiDotNet.Win32.RpcServer>> i_RPCList, string i_FileName)
        {
            int i = 0;
            Dictionary<string, RPCServerInfo> rpcDB = new Dictionary<string, RPCServerInfo>();
            foreach (IEnumerable<NtApiDotNet.Win32.RpcServer> rpcServerEnumerator in i_RPCList)
            {
                foreach (NtApiDotNet.Win32.RpcServer rpcServer in rpcServerEnumerator)
                {
                    // Maybe it is not enough to check only by UUID and add version to the check.
                    // But it will require to change the key.
                    if (rpcDB.ContainsKey(rpcServer.InterfaceId.ToString()))
                    {
                        continue;
                    }

                    i = 0;
                    List<string> functions = new List<string>();
                    foreach (var function in rpcServer.Procedures)
                    {
                        functions.Add(function.Name);
                        // We are assuming the functions are already in order, but are they?
                        // It is better to check with ProcNum of each function
                        //if (i != function.ProcNum)
                        //{
                        //    int b = 2;
                        //}
                        i += 1;
                    }

                    RPCServerInfo serverInfo = new RPCServerInfo(
                        rpcServer.Name,
                        rpcServer.FilePath,
                        rpcServer.InterfaceId.ToString(),
                        rpcServer.Offset,
                        rpcServer.ProcedureCount,
                        functions,
                        rpcServer.ServiceName,
                        rpcServer.IsServiceRunning
                    );

                    rpcDB.Add(rpcServer.InterfaceId.ToString(), serverInfo);
                }
            }
            

            string json = JsonConvert.SerializeObject(rpcDB);

            File.WriteAllText(i_FileName, json);

        }

        public static void OnDoneRPCSearchUpdate(List<IEnumerable<NtApiDotNet.Win32.RpcServer>> i_RPCServers)
        {
            if (DoneRPCSearchUpdate != null)
            {
                DoneRPCSearchUpdate.Invoke(i_RPCServers);
            }
        }

        public static void OnBuildRPCDBStatusUpdate(string i_File, string i_FileStatus, int i_NumOfFilesWithRPC, int i_TotalNumberOfFiles)
        {
            if (BuildRPCDBStatusUpdate != null)
            {
                BuildRPCDBStatusUpdate.Invoke(i_File, i_FileStatus, i_NumOfFilesWithRPC, i_TotalNumberOfFiles);
            }
        }

        public static IEnumerable<FileInfo> GetFilesByExtensions(this DirectoryInfo dir, params string[] extensions)
        {
            if (extensions == null)
                throw new ArgumentNullException("extensions");
            IEnumerable<FileInfo> files = dir.EnumerateFiles();
            return files.Where(f => extensions.Contains(f.Extension));
        }

        private static bool isBinaryMZFile(string i_FileName)
        {
            bool isBinary = false;
            int numBytesToRead = 2;
            int numBytesRead = 0;
            byte[] bytes = new byte[2];
            int n;
            using (FileStream fsSource = new FileStream(i_FileName, FileMode.Open, FileAccess.Read))
            {
                n = fsSource.Read(bytes, numBytesRead, numBytesToRead);
            }

            //const Int32 BufferSize = 4;
            //using (var fileStream = File.OpenRead(name))
            //{
            //    using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            //    {
            //        String line;
            //        line = streamReader.ReadLine();
            //        int a =  line.Length;
            //    }
            //}

            // 77 = 'M', 90 = 'Z'
            if (n > 0 && bytes[0] == 77 && bytes[1] == 90)
            {
                isBinary = true;
            }

            return isBinary;
        }

        // Original: https://stackoverflow.com/questions/172544/ignore-folders-files-when-directory-getfiles-is-denied-access
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-iterate-through-a-directory-tree
        private static void buildRPCServersList(string root, bool isRecursive, params string[] extensions)
        {
            // Data structure to hold names of subfolders to be
            // examined for files.
            Stack<string> dirs = new Stack<string>(10);
            IEnumerable<NtApiDotNet.Win32.RpcServer> rpcServer = Enumerable.Empty<NtApiDotNet.Win32.RpcServer>();
            if (!System.IO.Directory.Exists(root))
            {
                throw new ArgumentException();
            }
            dirs.Push(root);

            while (dirs.Count > 0)
            {
                if (m_IsDoneRPCSearch)
                {
                    break;
                }

                string currentDir = dirs.Pop();
                if (m_ExcludedFoldersMap.ContainsKey(currentDir.ToLower()))
                {
                    continue;
                }
                //updateStatusToolStrip(currentDir);
                string[] subDirs;
                try
                {
                    subDirs = System.IO.Directory.GetDirectories(currentDir);
                }
                // An UnauthorizedAccessException exception will be thrown if we do not have
                // discovery permission on a folder or file. It may or may not be acceptable 
                // to ignore the exception and continue enumerating the remaining files and 
                // folders. It is also possible (but unlikely) that a DirectoryNotFound exception 
                // will be raised. This will happen if currentDir has been deleted by
                // another application or thread after our call to Directory.Exists. The 
                // choice of which exceptions to catch depends entirely on the specific task 
                // you are intending to perform and also on how much you know with certainty 
                // about the systems on which this code will run.
                catch (UnauthorizedAccessException e)
                {
                    //Console.WriteLine(e.Message);
                    continue;
                }
                catch (System.IO.DirectoryNotFoundException e)
                {
                    //Console.WriteLine(e.Message);
                    continue;
                }

                //string[] files = null;
                IEnumerable<FileInfo> files;
                try
                {
                    //files = System.IO.Directory.GetFiles(currentDir, extension);
                    DirectoryInfo dInfo = new DirectoryInfo(currentDir);
                    files = dInfo.GetFilesByExtensions(extensions);
                    m_TotalNumberOfFiles += files.Count();
                }

                catch (UnauthorizedAccessException e)
                {

                    //Console.WriteLine(e.Message);
                    continue;
                }

                catch (System.IO.DirectoryNotFoundException e)
                {
                    //Console.WriteLine(e.Message);
                    continue;
                }
                // Perform the required action on each file here.
                // Modify this block to perform your required task.
                foreach (FileInfo file in files)
                {
                    if (m_IsDoneRPCSearch)
                    {
                        break;
                    }

                    try
                    {

                        // Eviatar: Error when trying to load this file. There are more.
                       // string name = @"C:\Windows\winsxs\x86_wcf-system.identitymodel_b03f5f7f11d50a3a_10.0.19041.1_none_e690fdc7d17e3f70\System.IdentityModel.dll";
                        // We are doing this check to avoid the uncatchable exception of Bad Image
                        // It won't help against the file C:\Windows\winsxs\x86_microsoft-windows-n..nd-syswow64-payload_31bf3856ad364e35_1.0.19041.1_none_beac3411b23832d5\compobj.dll 
                        // which have "MZ" in the beginning but Bad Image. I add work around to execlude some folders.
                        // The "MZ" is not enough because there are files like 
                        // C:\Windows\winsxs\x86_microsoft-windows-n..nd-syswow64-payload_31bf3856ad364e35_1.0.19041.1_none_beac3411b23832d5\compobj.dll
                        // Which have bad image and starts with "MZ". The workaround might be by trying to load it as data file first and if succeed call the ParsePe function.

                        //if (isBinaryMZFile(file.FullName))
                        if (Win32NativeMethods.isSucceedLoadLibrary(file.FullName, LoadLibraryFlags.LoadLibraryAsDataFile))
                        {
                            rpcServer = NtApiDotNet.Win32.RpcServer.ParsePeFile(file.FullName, m_DbgHelp, m_SymbolsPath, NtApiDotNet.Win32.RpcServerParserFlags.None);
                        }

                        if (rpcServer.Count() > 0)
                        {
                            m_RPCServersDB.Add(rpcServer);
                            m_NumOfFilesWithRPC += 1;
                            OnBuildRPCDBStatusUpdate(file.FullName, "Yes", m_NumOfFilesWithRPC, m_TotalNumberOfFiles);
                        } else
                        {
                            OnBuildRPCDBStatusUpdate(file.FullName, "No", m_NumOfFilesWithRPC, m_TotalNumberOfFiles);
                        }
                        //ManifestInfo info = Engine.GetManifestInfo(file);
                        /*if (info != null && (String.Empty != info.Level + info.uiAccess + info.autoElevate + info.dpiAware))
                        {
                            if (UserMatchesFilters(info))
                            {
                                //if(isFilteredByCheckboxes(info)){
                                updateTable(info, file);
                            }
                        }*/
                    }
                    catch (System.IO.FileNotFoundException e)
                    {
                        // If file was deleted by a separate application
                        //  or thread since the call to TraverseTree()
                        // then just continue.
                        //Console.WriteLine(e.Message);
                        continue;
                    }
                }

                if (!isRecursive)
                {
                    break;
                }

                // Push the subdirectories onto the stack for traversal.
                // This could also be done before handing the files.
                foreach (string str in subDirs)
                    dirs.Push(str);
            }

            //this.toolStripStatusLabel1.Text = "Done";
        }
    }
}
