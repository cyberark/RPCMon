using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPCMon.Control;

namespace RPCMon
{
    public partial class FormBuildDB : Form
    {
        private ListViewColumnSorter m_LvwColumnSorter;
        private const string c_DBDefaultName = "RPC_DB";
        public FormBuildDB()
        {
            InitializeComponent();
            m_LvwColumnSorter = new ListViewColumnSorter();
            this.listViewRPCFiles.ListViewItemSorter = m_LvwColumnSorter;

            this.textBoxSaveFile.Text = generateDBName();
            this.comboBox1.SelectedIndex = 0;
            this.buttonJumpFolder.Image = (Image)(new Bitmap(global::RPCMon.Properties.Resources.share, new Size(15, 15)));
            this.buttonJumpFolder.TabStop = false;
            this.buttonJumpFolder.FlatStyle = FlatStyle.Flat;
            this.buttonJumpFolder.FlatAppearance.BorderSize = 0;
        }

        private string generateDBName()
        {
            string newPathNoExtension = Path.Combine(Directory.GetCurrentDirectory(), c_DBDefaultName);
            int num = 0;
            bool isExist = false;
            while (!isExist)
            {
                if (File.Exists(newPathNoExtension + num.ToString() + ".rpcdb.json"))
                {
                    num += 1;
                } else
                {
                    isExist = true;
                    newPathNoExtension = newPathNoExtension + num.ToString();
                }
            }

            return newPathNoExtension + ".rpcdb.json";
        }

        //public Thread m_SearchingRPCThread;
        //CancellationTokenSource cts = new CancellationTokenSource();
        private void buttonBuild_Click(object sender, EventArgs e)
        {
            Engine.BuildRPCDBStatusUpdate -= Engine_BuildRPCDBStatusUpdate;
            Engine.DoneRPCSearchUpdate -= Engine_DoneRPCSearchUpdate;
            Engine.BuildRPCDBStatusUpdate += Engine_BuildRPCDBStatusUpdate;
            Engine.DoneRPCSearchUpdate += Engine_DoneRPCSearchUpdate;
            //string[] extensions = {".exe", ".dll", ".com" };
            string[] extensions = new string[1];
            switch (comboBox1.Text)
            {
                case (".exe"):
                    extensions[0] = ".exe";
                    break;
                case (".dll"):
                    extensions[0] = ".exe";
                    break;
                case (".com"):
                    extensions[0] = ".com";
                    break;
                default:
                    extensions = new string[3]{ ".exe", ".dll", ".com" };
                    break;
            }

            string[] excludedFolders = textBoxExcludedFolders.Text.Split(';');

            ThreadPool.QueueUserWorkItem(o => Engine.BuildRPCDataBase(textBoxFolderForRPC.Text, textBoxSaveFile.Text, checkBoxRecursive.Checked, excludedFolders, extensions));

            //ThreadPool.QueueUserWorkItem(o =>
            //{ CancellationToken token = (CancellationToken)o;

            //    while (!token.IsCancellationRequested)
            //    {
            //        Engine.BuildRPCDataBase(textBoxFolderForRPC.Text);
            //    }
            
            //ThreadPool.QueueUserWorkItem(s =>
            //{
            //    CancellationToken token = (CancellationToken)s;
            //    if (token.IsCancellationRequested)
            //        return;
            //    Engine.BuildRPCDataBase(textBoxFolderForRPC.Text);
            //    token.WaitHandle.WaitOne(1000);
            //}, cts.Token);

            //}, cts.Token);
            //List<IEnumerable<NtApiDotNet.Win32.RpcServer>> rpcList = Engine.BuildRPCDataBase(textBoxFolderForRPC.Text);
            //var rpcList = Engine.BuildRPCDataBase(textBoxFolderForRPC.Text);

            //MessageBox.Show("Done!", "Creating DB", MessageBoxButtons.OK);
            // progressBar1.Refre
        }

        private void Engine_DoneRPCSearchUpdate(List<IEnumerable<NtApiDotNet.Win32.RpcServer>> i_RPCServers)
        {
            MessageBox.Show("Done!", "Creating DB", MessageBoxButtons.OK);
            //progressBar1.Value = progressBar1.Maximum;
        }

        //private void Engine_BuildRPCDBStatusUpdate(string i_File, string i_FileStatus, int i_NumOfFilesWithRPC, int i_TotalNumberOfFiles)
        //{
        //    //textBoxLogs.Text += "\n" + i_FileStatus;
        //    ListViewItem item = new ListViewItem(i_File);
        //    item.SubItems.Add(i_FileStatus);
        //    listViewRPCFiles.Items.Add(item);
        //    progressBar1.Value += (int)((i_NumOfFilesWithRPC / i_TotalNumberOfFiles)*100);
        //}


        private delegate void buildRPCDBStatusUpdateCallBack(string i_File, string i_FileStatus, int i_NumOfFilesWithRPC, int i_TotalNumberOfFiles);
        private void Engine_BuildRPCDBStatusUpdate(string i_File, string i_FileStatus, int i_NumOfFilesWithRPC, int i_TotalNumberOfFiles)
        {

            if (this.InvokeRequired)
            {
                buildRPCDBStatusUpdateCallBack s = new buildRPCDBStatusUpdateCallBack(Engine_BuildRPCDBStatusUpdate);
                this.Invoke(s, i_File, i_FileStatus, i_NumOfFilesWithRPC, i_TotalNumberOfFiles);
            }
            else
            {
                ListViewItem item = new ListViewItem(i_File);
                item.SubItems.Add(i_FileStatus);
                listViewRPCFiles.Items.Add(item);
                if (i_FileStatus == "Yes")
                {
                    item.BackColor = Color.Cyan;
                }

                toolStripStatusLabelRPCFiles.Text = "RPC Files: " + i_NumOfFilesWithRPC.ToString();
                toolStripStatusLabelTotalFiles.Text = "Total Searched Files: " + i_TotalNumberOfFiles.ToString();
               // progressBar1.Value += (int)(((double)i_NumOfFilesWithRPC / (double)i_TotalNumberOfFiles) * 100);
                //progressBar1.Maximum += progressBar1.Value;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
           Engine.StopRPCSearch();
           // cts.Cancel();
            //if (m_SearchingRPCThread != null)
            //{
            //    m_SearchingRPCThread.Abort();
            //}
        }

        // https://docs.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/general/sort-listview-by-column
        private void listViewRPCFiles_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == m_LvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (m_LvwColumnSorter.Order == SortOrder.Ascending)
                {
                    m_LvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    m_LvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                m_LvwColumnSorter.SortColumn = e.Column;
                m_LvwColumnSorter.Order = SortOrder.Ascending;
            }

            this.listViewRPCFiles.Sort();
        }

        private void FormBuildDB_FormClosing(object sender, FormClosingEventArgs e)
        {
           Engine.StopRPCSearch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string directory = Path.GetDirectoryName(textBoxSaveFile.Text);
            if (Directory.Exists(directory))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = directory,
                    FileName = "explorer.exe"
                };

                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show(string.Format("{0} Directory does not exist!", directory));
            }
        }

        private void buttonJumpFolder_MouseHover(object sender, EventArgs e)
        {
            toolTipJumpButton.Show("Jump to Saved Folder", buttonJumpFolder);
        }

        private void buttonJumpFolder_MouseLeave(object sender, EventArgs e)
        {
            toolTipJumpButton.Hide(buttonJumpFolder);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listViewRPCFiles.Items.Clear();
            Engine.BuildRPCDBStatusUpdate -= Engine_BuildRPCDBStatusUpdate;
            Engine.DoneRPCSearchUpdate -= Engine_DoneRPCSearchUpdate;

            toolStripStatusLabelRPCFiles.Text = "RPC Files: ";
            toolStripStatusLabelTotalFiles.Text = "Total Searched Files: 0";
        }
    }
}
