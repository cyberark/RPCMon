using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NtApiDotNet.Win32;

namespace RPCMon.Control
{

    public static class Win32NativeMethods
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern SafeLoadLibraryHandle LoadLibraryEx(string name, IntPtr reserved, LoadLibraryFlags flags);
        public static bool isSucceedLoadLibrary(string i_Name, LoadLibraryFlags flags)
        {
            bool isSuceed = false;
            SafeLoadLibraryHandle ret = LoadLibraryEx(i_Name, IntPtr.Zero, flags);
            if (!ret.IsInvalid)
            {
                isSuceed = true;
            }

            return isSuceed;
        }
    }

    public enum LoadLibraryFlags
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,
        /// <summary>
        /// Don't resolve DLL references
        /// </summary>
        DontResolveDllReferences = 0x00000001,
        /// <summary>
        /// Load library as a data file.
        /// </summary>
        LoadLibraryAsDataFile = 0x00000002,
        /// <summary>
        /// Load with an altered search path.
        /// </summary>
        LoadWithAlteredSearchPath = 0x00000008,
        /// <summary>
        /// Ignore code authz level.
        /// </summary>
        LoadIgnoreCodeAuthzLevel = 0x00000010,
        /// <summary>
        /// Load library as an image resource.
        /// </summary>
        LoadLibraryAsImageResource = 0x00000020,
        /// <summary>
        /// Load library as a data file exclusively.
        /// </summary>
        LoadLibraryAsDataFileExclusive = 0x00000040,
        /// <summary>
        /// Add the DLL's directory temporarily to the search list.
        /// </summary>
        LoadLibrarySearchDllLoadDir = 0x00000100,
        /// <summary>
        /// Search application directory for the DLL.
        /// </summary>
        LoadLibrarySearchApplicationDir = 0x00000200,
        /// <summary>
        /// Search the user's directories for the DLL.
        /// </summary>
        LoadLibrarySearchUserDirs = 0x00000400,
        /// <summary>
        /// Search system32 for the DLL.
        /// </summary>
        LoadLibrarySearchSystem32 = 0x00000800,
        /// <summary>
        /// Search the default directories for the DLL.
        /// </summary>
        LoadLibrarySearchDefaultDirs = 0x00001000,
    }
}
