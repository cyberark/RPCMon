using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Diagnostics.Tracing.Parsers;
using Microsoft.Diagnostics.Tracing.Session;
using Newtonsoft.Json;
using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsRPC;
using RPCMon.Control;
using System.Reflection;
using System.Security.Principal;

namespace RPCMon
{
    public partial class Form1 : Form
    {
        TraceEventSession m_TraceSession;
        private static Dictionary<int, string> m_ProcessPIDsDictionary = new Dictionary<int, string>();
        private string m_RPCDBPath = "";
        private static Dictionary<string, Dictionary<string, dynamic>> m_RPCDB;
        private bool m_IsCaptureButtonPressed = false;
        private Thread m_CaptureThread;
        private int m_TotalNumberOfEvents = 0;
        private const string RPC_DB_KEY_Module = "Module";
        private const string RPC_DB_KEY_ModulePath = "ModulePath";
        private const string RPC_DB_KEY_ProceduresCount = "ProceduresCount";
        private const string RPC_DB_KEY_Service = "Service";
        private const string RPC_DB_KEY_Procedures = "Procedures";
        private const string NA_STRING = "N\\A";
        private string m_LastSearchValue;
        //private ListView m_LastListViewColumnFilter = new ListView();
        //private ListView m_LastListViewHighlighFilter = new ListView();
        int m_CurrentRowIndexRightClick, m_CurrentColumnIndexRightClick;
        bool m_IsElevated = false;
        private bool autoScroll = false;

        // ListView i_ListView, Utils.eFormNames i_FormName
        private ListView m_highLightListView = new ListView();
        private ListView m_filterListView = new ListView();
        private IDictionary<string, List<ListViewItem>> m_includeFilterDict = new Dictionary<string, List<ListViewItem>>();
        private IDictionary<string, List<ListViewItem>> m_excludeFilterDict = new Dictionary<string, List<ListViewItem>>();
        private IDictionary<string, List<ListViewItem>> m_includeHighlightDict = new Dictionary<string, List<ListViewItem>>();
        private IDictionary<string, List<ListViewItem>> m_excludeHighlightDict = new Dictionary<string, List<ListViewItem>>();

        public Form1()
        {
            InitializeComponent();
            configureFormBasedPrivileges();


            this.m_RPCDBPath = getDBFromCurrentFolder();
            this.toolStripStatusLabelDBPath.Text = "DB File: " + Path.GetFileName(this.m_RPCDBPath);
            Process[] processCollection = Process.GetProcesses();
            foreach (Process p in processCollection)
            {
                m_ProcessPIDsDictionary.Add(p.Id, p.ProcessName);
            }

            //Thread t1 = new Thread(checkIdDBGHelpExist);
            //t1.Start();

            //dummRowsForDebug();
            //DataGridViewRow row = new DataGridViewRow();
            //DataGridViewCellCollection cells = new DataGridViewCellCollection(row);
            //dataGridView1.Rows.Add(cells);
            //dataGridView1.Rows[0].Cells[0].Value = "";

            //https://10tec.com/articles/why-datagridview-slow.aspx
            //if (!System.Windows.Forms.SystemInformation.TerminalServerSession)
            //{
            //    Type dgvType = dataGridView1.GetType();
            //    PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
            //      BindingFlags.Instance | BindingFlags.NonPublic);
            //    pi.SetValue(dataGridView1, value, null);
            //}

            // Remove grid from gridview
            //this.dataGridView1.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;

            // https://stackoverflow.com/a/10277205/2153777
            // For better performance when scrolling the DataGridView

            typeof(DataGridView).InvokeMember(
               "DoubleBuffered",
               BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
               null,
               dataGridView1,
               new object[] { true });
        }

        private void configureFormBasedPrivileges()
        {
            bool isElevated;
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                isElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);
                m_IsElevated = isElevated;
                if (isElevated)
                {
                    this.Text = "RPCMon - RPC Monitor Based Windows Events (Administrator)";
                }
            }
        }


        private void checkIdDBGHelpExist()
        {
            if (!File.Exists(Engine.DbgHelpFilePath))
            {
                MessageBox.Show("Can't find DbgHelp file: " + Engine.DbgHelpFilePath + ".\nGo to \"Option | Set DbgHelp File Path\" and set it.", "DbgHelp File Path");
            }
        }

        private string getDBFromCurrentFolder()
        {
            string dbFile = "** No DataBase File ! **";
            string currentFolder = Directory.GetCurrentDirectory();
            string[] files = Directory.GetFiles(currentFolder);
            foreach (string file in files)
            {
                if (file.EndsWith(".rpcdb.json"))
                {
                    dbFile = file;
                    break;
                }
            }

            return dbFile;
        }

        public static string getFunctionName(string uuid, int i_functionID)
        {
            try
            {
                var value = m_RPCDB[uuid][RPC_DB_KEY_Procedures];
                List<string> list = value.ToObject<List<string>>();
                return list[i_functionID];
            }
            catch
            {
                return NA_STRING;
            }
        }

        private void dummRowsForDebug()
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1);

            //row.Cells[(int)Utils.eColumnNames.PID].Value = "1234";
            //row.Cells[(int)Utils.eColumnNames.TID].Value = "543";
            //row.Cells[(int)Utils.eColumnNames.UUID].Value = "";
            //row.Cells[(int)Utils.eColumnNames.Function].Value = "func1";
            //row.Cells[(int)Utils.eColumnNames.ProcessName].Value = "Process1";
            //row.Cells[(int)Utils.eColumnNames.NetworkAddress].Value = "n1";
            //row.Cells[(int)Utils.eColumnNames.Protocol].Value = "protocol1";
            //row.Cells[(int)Utils.eColumnNames.Endpoint].Value = "endpoint1";

            //row.Cells[(int)Utils.eColumnNames.Options].Value = "option1";
            //row.Cells[(int)Utils.eColumnNames.AuthenticationLevel].Value = "auth1";
            //row.Cells[(int)Utils.eColumnNames.AuthenticationService].Value = "authS1";
            //row.Cells[(int)Utils.eColumnNames.ImpersonationLevel].Value = "imper1";
            //row.DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Regular);
            //dataGridView1.Rows.Add(row);
            //for (int i = 0; i < 16000; i++)
            //{
            //    row = new DataGridViewRow();
            //    row.CreateCells(dataGridView1);

            //    row.Cells[(int)Utils.eColumnNames.PID].Value = "654";
            //    row.Cells[(int)Utils.eColumnNames.TID].Value = "222";
            //    row.Cells[(int)Utils.eColumnNames.UUID].Value = "";
            //    row.Cells[(int)Utils.eColumnNames.Function].Value = "func2";
            //    row.Cells[(int)Utils.eColumnNames.ProcessName].Value = "Process2";
            //    row.Cells[(int)Utils.eColumnNames.NetworkAddress].Value = "n2";
            //    row.Cells[(int)Utils.eColumnNames.Protocol].Value = "protocol2";
            //    row.Cells[(int)Utils.eColumnNames.Endpoint].Value = "endpoint2";

            //    row.Cells[(int)Utils.eColumnNames.Options].Value = "option2";
            //    row.Cells[(int)Utils.eColumnNames.AuthenticationLevel].Value = "auth2";
            //    row.Cells[(int)Utils.eColumnNames.AuthenticationService].Value = "authS2";
            //    row.Cells[(int)Utils.eColumnNames.ImpersonationLevel].Value = "imper2";
            //    row.DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Regular);
            //    dataGridView1.Rows.Add(row);


            //}
            row = new DataGridViewRow();
            row.CreateCells(dataGridView1);

            row.Cells[(int)Utils.eColumnNames.PID].Value = "1";
            row.Cells[(int)Utils.eColumnNames.TID].Value = "222";
            row.Cells[(int)Utils.eColumnNames.UUID].Value = "";
            row.Cells[(int)Utils.eColumnNames.Function].Value = "a";
            row.Cells[(int)Utils.eColumnNames.ProcessName].Value = "Process2";
            row.Cells[(int)Utils.eColumnNames.NetworkAddress].Value = "n2";
            row.Cells[(int)Utils.eColumnNames.Protocol].Value = "protocol2";
            row.Cells[(int)Utils.eColumnNames.Endpoint].Value = "endpoint2";

            row.Cells[(int)Utils.eColumnNames.Options].Value = "option2";
            row.Cells[(int)Utils.eColumnNames.AuthenticationLevel].Value = "auth2";
            row.Cells[(int)Utils.eColumnNames.AuthenticationService].Value = "authS2";
            row.Cells[(int)Utils.eColumnNames.ImpersonationLevel].Value = "imper2";
            row.DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Regular);
            dataGridView1.Rows.Add(row);

            row = new DataGridViewRow();
            row.CreateCells(dataGridView1);

            row.Cells[(int)Utils.eColumnNames.PID].Value = "2";
            row.Cells[(int)Utils.eColumnNames.TID].Value = "222";
            row.Cells[(int)Utils.eColumnNames.UUID].Value = "";
            row.Cells[(int)Utils.eColumnNames.Function].Value = "a";
            row.Cells[(int)Utils.eColumnNames.ProcessName].Value = "Process2";
            row.Cells[(int)Utils.eColumnNames.NetworkAddress].Value = "n2";
            row.Cells[(int)Utils.eColumnNames.Protocol].Value = "protocol2";
            row.Cells[(int)Utils.eColumnNames.Endpoint].Value = "endpoint2";

            row.Cells[(int)Utils.eColumnNames.Options].Value = "option2";
            row.Cells[(int)Utils.eColumnNames.AuthenticationLevel].Value = "auth2";
            row.Cells[(int)Utils.eColumnNames.AuthenticationService].Value = "authS2";
            row.Cells[(int)Utils.eColumnNames.ImpersonationLevel].Value = "imper2";
            row.DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Regular);
            dataGridView1.Rows.Add(row);
            row = new DataGridViewRow();
            row.CreateCells(dataGridView1);

            row.Cells[(int)Utils.eColumnNames.PID].Value = "1";
            row.Cells[(int)Utils.eColumnNames.TID].Value = "222";
            row.Cells[(int)Utils.eColumnNames.UUID].Value = "";
            row.Cells[(int)Utils.eColumnNames.Function].Value = "b";
            row.Cells[(int)Utils.eColumnNames.ProcessName].Value = "Process2";
            row.Cells[(int)Utils.eColumnNames.NetworkAddress].Value = "n2";
            row.Cells[(int)Utils.eColumnNames.Protocol].Value = "protocol2";
            row.Cells[(int)Utils.eColumnNames.Endpoint].Value = "endpoint2";

            row.Cells[(int)Utils.eColumnNames.Options].Value = "option2";
            row.Cells[(int)Utils.eColumnNames.AuthenticationLevel].Value = "auth2";
            row.Cells[(int)Utils.eColumnNames.AuthenticationService].Value = "authS2";
            row.Cells[(int)Utils.eColumnNames.ImpersonationLevel].Value = "imper2";
            row.DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Regular);
            dataGridView1.Rows.Add(row);

            row = new DataGridViewRow();
            row.CreateCells(dataGridView1);

            row.Cells[(int)Utils.eColumnNames.PID].Value = "3";
            row.Cells[(int)Utils.eColumnNames.TID].Value = "222";
            row.Cells[(int)Utils.eColumnNames.UUID].Value = "";
            row.Cells[(int)Utils.eColumnNames.Function].Value = "a";
            row.Cells[(int)Utils.eColumnNames.ProcessName].Value = "Process2";
            row.Cells[(int)Utils.eColumnNames.NetworkAddress].Value = "n2";
            row.Cells[(int)Utils.eColumnNames.Protocol].Value = "protocol2";
            row.Cells[(int)Utils.eColumnNames.Endpoint].Value = "endpoint2";

            row.Cells[(int)Utils.eColumnNames.Options].Value = "option2";
            row.Cells[(int)Utils.eColumnNames.AuthenticationLevel].Value = "auth2";
            row.Cells[(int)Utils.eColumnNames.AuthenticationService].Value = "authS2";
            row.Cells[(int)Utils.eColumnNames.ImpersonationLevel].Value = "imper2";
            row.DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Regular);
            dataGridView1.Rows.Add(row);
        }

        private void startEventTracing()
        {
            if (File.Exists(m_RPCDBPath))
            {
                string jsonText = File.ReadAllText(m_RPCDBPath);
                m_RPCDB = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, dynamic>>>(jsonText);
            } else
            {
                m_RPCDB = new Dictionary<string, Dictionary<string, dynamic>>();
            }
            //filterRowsByFilterRules(highLightListView, highLightFormName);

            using (var session = new TraceEventSession("MySimpleSession"))
            {

                m_TraceSession = session;

                session.EnableProvider("Microsoft-Windows-RPC", Microsoft.Diagnostics.Tracing.TraceEventLevel.Verbose);
                var parser = new MicrosoftWindowsRPCTraceEventParser(session.Source);

                // Do we want to include more events? server events?

                parser.RpcClientCallStart += e2 =>
                {
                    // addEventToListView(e2);
                    //filterRowsByFilterRules(highLightListView, highLightFormName);
                    addEventToDataGridView(e2);

                    /* 
                      // Throws an error "Cross-thread operation not valid: Control 'textBox1' accessed from a thread other than the thread it was created on."
                     string funcName = getFunctionName(e2.InterfaceUuid.ToString(), e2.ProcNum);
                     ListViewItem item = new ListViewItem(e2.ProcessID.ToString());
                     item.SubItems.Add(e2.ThreadID.ToString());
                     item.SubItems.Add(e2.InterfaceUuid.ToString());
                     item.SubItems.Add(funcName);
                     listView1.Items.Add(item);*/
                    // Console.WriteLine($"{e2.ID}                {funcName}");
                };
                session.Source.Process();
            }
        }

        private void setRpcFields(ref DataGridViewRow i_Row, string i_UUID)
        {
            if (m_RPCDB.ContainsKey(i_UUID))
            {
                i_Row.Cells[(int)Utils.eColumnNames.Module].Value = m_RPCDB[i_UUID][RPC_DB_KEY_Module];
                i_Row.Cells[(int)Utils.eColumnNames.ModulePath].Value = m_RPCDB[i_UUID][RPC_DB_KEY_ModulePath];
                i_Row.Cells[(int)Utils.eColumnNames.ProceduresCount].Value = m_RPCDB[i_UUID][RPC_DB_KEY_ProceduresCount];
                i_Row.Cells[(int)Utils.eColumnNames.Service].Value = m_RPCDB[i_UUID][RPC_DB_KEY_Service];
            }
            else
            {
                i_Row.Cells[(int)Utils.eColumnNames.Module].Value = NA_STRING;
                i_Row.Cells[(int)Utils.eColumnNames.ModulePath].Value = NA_STRING;
                i_Row.Cells[(int)Utils.eColumnNames.ProceduresCount].Value = NA_STRING;
                i_Row.Cells[(int)Utils.eColumnNames.Service].Value = NA_STRING;
            }
        }

        // https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-make-thread-safe-calls?view=netdesktop-6.0
        private delegate void addEventToDataGridViewCallBack(Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsRPC.RpcClientCallStartArgs_V1TraceData i_Event);
        private void addEventToDataGridView(Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsRPC.RpcClientCallStartArgs_V1TraceData i_Event)
        {
            if (this.InvokeRequired)
            {
                addEventToDataGridViewCallBack s = new addEventToDataGridViewCallBack(addEventToDataGridView);
                this.Invoke(s, i_Event);
            }
            else
            {
                string funcName = getFunctionName(i_Event.InterfaceUuid.ToString(), i_Event.ProcNum);

                //DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                //dataGridView1.Rows.Add(cells);
                //dataGridView1.Rows[0].Cells[0].Value = "";

                row.Cells[(int)Utils.eColumnNames.PID].Value = i_Event.ProcessID.ToString();
                row.Cells[(int)Utils.eColumnNames.TID].Value = i_Event.ThreadID.ToString();
                setProcessName(i_Event, ref row);

                row.Cells[(int)Utils.eColumnNames.UUID].Value = i_Event.InterfaceUuid.ToString();
                if (i_Event.InterfaceUuid.ToString() != null && i_Event.InterfaceUuid.ToString() != "")
                {
                    setRpcFields(ref row, i_Event.InterfaceUuid.ToString());
                }

                row.Cells[(int)Utils.eColumnNames.Function].Value = funcName;

                row.Cells[(int)Utils.eColumnNames.NetworkAddress].Value = i_Event.NetworkAddress.ToString();
                row.Cells[(int)Utils.eColumnNames.Protocol].Value = i_Event.Protocol.ToString();
                row.Cells[(int)Utils.eColumnNames.Endpoint].Value = i_Event.Endpoint.ToString();

                row.Cells[(int)Utils.eColumnNames.Options].Value = i_Event.Options.ToString();
                row.Cells[(int)Utils.eColumnNames.AuthenticationLevel].Value = i_Event.AuthenticationLevel.ToString();
                row.Cells[(int)Utils.eColumnNames.AuthenticationService].Value = i_Event.AuthenticationService.ToString();
                row.Cells[(int)Utils.eColumnNames.ImpersonationLevel].Value = i_Event.ImpersonationLevel.ToString();
                row.DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Regular);
                dataGridView1.Rows.Add(row);
                if (!m_includeHighlightDict.Count.Equals(0) || !m_excludeHighlightDict.Count.Equals(0))
                {
                    filterSingleRowByFilterRules(Utils.eFormNames.FormHighlighFilter, row);
                }
                if (!m_includeFilterDict.Count.Equals(0) || !m_excludeFilterDict.Count.Equals(0))
                {
                    filterSingleRowByFilterRules(Utils.eFormNames.FormColumnFilter, row);
                }
                if (row.Visible && autoScroll)
                    dataGridView1.FirstDisplayedCell = row.Cells[(int)Utils.eColumnNames.ImpersonationLevel];
                this.m_TotalNumberOfEvents += 1;
                this.toolStripStatusLabelTotalEvents.Text = "Total events: " + this.m_TotalNumberOfEvents;
            }
        }

        private void setProcessName(Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsRPC.RpcClientCallStartArgs_V1TraceData i_Event, ref DataGridViewRow row)
        {
            if (i_Event.ProcessName == "")
            {
                if (m_ProcessPIDsDictionary.ContainsKey(i_Event.ProcessID))
                {
                    row.Cells[(int)Utils.eColumnNames.ProcessName].Value = m_ProcessPIDsDictionary[i_Event.ProcessID];
                }
                else
                {
                    try
                    {
                        using (var p = Process.GetProcessById(i_Event.ProcessID))
                        {
                            row.Cells[(int)Utils.eColumnNames.ProcessName].Value = p.ProcessName;
                            m_ProcessPIDsDictionary.Add(p.Id, p.ProcessName);
                        }
                    }
                    catch
                    {
                        row.Cells[(int)Utils.eColumnNames.ProcessName].Value = "N\\A";
                        m_ProcessPIDsDictionary.Add(i_Event.ProcessID, "N\\A");
                    }

                }

            }
            else
            {
                row.Cells[(int)Utils.eColumnNames.ProcessName].Value = i_Event.ProcessName;
            }
        }

        private void toolStripButtonStart_Click(object sender, EventArgs e)
        {

            if (!m_IsCaptureButtonPressed)
            {
                toolStripButtonStart.Image = global::RPCMon.Properties.Resources.pause_button;
                m_IsCaptureButtonPressed = true;
                m_CaptureThread = new Thread(new ThreadStart(startEventTracing));
                m_CaptureThread.Start();
            }
            else
            {
                toolStripButtonStart.Image = global::RPCMon.Properties.Resources.startIcon;
                m_IsCaptureButtonPressed = false;
                m_TraceSession.Source.StopProcessing();
                m_TraceSession.Dispose();
                m_CaptureThread.Abort();
            }
        }

        private void toolStripButtonAutoScroll_Click(object sender, EventArgs e)
        {
            if (autoScroll)
            {
                autoScroll = false;
                toolStripButtonAutoScroll.Image = global::RPCMon.Properties.Resources.scroll_disable;
            }
            else
            {
                autoScroll = true;
                toolStripButtonAutoScroll.Image = global::RPCMon.Properties.Resources.scroll;
            }

        }
        /*private void toolStripButtonStop_Click(object sender, EventArgs e)
        {
            m_TraceSession.Source.StopProcessing();
            m_TraceSession.Dispose();

        }*/

        private void toolStripButtonFilter_Click(object sender, EventArgs e)
        {
            openColumnFilterWindow();
        }

        private void openColumnFilterWindow()
        {
            //ColumnFilter columnFilter = new ColumnFilter(listView1);
            // ColumnFilter columnFilter = new ColumnFilter(ref dataGridView1);
            ColumnFilter columnFilter = new ColumnFilter(ref m_filterListView);
            columnFilter.FilterOKUpdate += new FilterOKEventHandler(ColumnFilter_OKFilter);
            columnFilter.ShowDialog();
        }

        private void openColumnSelectionWindow()
        {
            //ColumnFilter columnFilter = new ColumnFilter(listView1);
            ColumnSelection columnSelection = new ColumnSelection(dataGridView1);
            columnSelection.selectColumnsUpdate += new selectColumnsEventHandler(this.ColumnSelection_selectColumnsUpdate);
            columnSelection.ShowDialog();
        }

        private void openFindWindow()
        {
            FormSearch findWindow = new FormSearch();
            findWindow.searchForMatch += new searchEventHandler(FindWindow_searchForMatch);
            findWindow.ShowDialog();
        }

        private void openHighlightWindows()
        {
            FormHighlighting hightlightWindow = new FormHighlighting(ref m_highLightListView);
            hightlightWindow.hightlightRowsUpdate += HightlightWindow_hightlightRowsUpdate;
            hightlightWindow.ShowDialog();
        }

        private void buildDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuildDB buildDBForm = new FormBuildDB();
            //hightlightWindow.hightlightRowsUpdate += HightlightWindow_hightlightRowsUpdate;
            buildDBForm.ShowDialog();
        }

        private void HightlightWindow_hightlightRowsUpdate(ListView i_ListView)
        {
            m_highLightListView = i_ListView;
            updateFilterDicts(i_ListView, Utils.eFormNames.FormHighlighFilter);
            if (m_includeHighlightDict.Count.Equals(0))
            {
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {
                    this.dataGridView1.Rows[row.Index].DefaultCellStyle.BackColor = Color.White;
                }
                return;
            }
            filterRowsByFilterRules(Utils.eFormNames.FormHighlighFilter);
            //int columnCounter = 0;
            //foreach (DataGridViewRow row in this.dataGridView1.Rows)
            //{
            //    if (columnCounter != this.dataGridView1.Rows.Count - 1)
            //    {
            //        foreach (ListViewItem rule in i_ListView.Items)
            //        {
            //            if (rule.Checked)
            //            {
            //                DataGridViewCell cellValueFromGridViewCell = row.Cells["Column" + rule.SubItems[0].Text];
            //                string valueFromFilter = rule.SubItems[(int)Utils.eFilterNames.Value].Text;
            //                if (rule.SubItems[(int)Utils.eFilterNames.Relation].Text == "contains")
            //                {

            //                    if ((cellValueFromGridViewCell.Value.ToString()).Contains(valueFromFilter))
            //                    {
            //                        if (rule.SubItems[(int)Utils.eFilterNames.Action].Text == "Include")
            //                        {
            //                            this.dataGridView1.Rows[row.Index].DefaultCellStyle.BackColor = Color.Cyan;
            //                        }
            //                        else
            //                        {
            //                            this.dataGridView1.Rows[row.Index].DefaultCellStyle.BackColor = Color.White;

            //                        }
            //                    }
            //                    else
            //                    {
            //                        this.dataGridView1.Rows[row.Index].DefaultCellStyle.BackColor = Color.White;
            //                    }

            //                }

            //            }
            //        }
            //    }

            //    columnCounter++;
            //}

            //m_LastListViewHighlighFilter = i_ListView;
        }

        private void cleanAllSelectedCells()
        {
            for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
            {
                dataGridView1.SelectedCells[i].Selected = false;
            }
        }


        private void FindWindow_searchForMatch(string i_SearchString, bool i_SearchDown, bool i_MatchWholeWord, bool i_MatchSensitive)
        {
            int startIndex = 0;
            m_LastSearchValue = i_SearchString;
            bool foundMatch = false;
            int step = 1;
            if (!i_SearchDown)
            {
                step = -1;
            }

            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                startIndex = selectedRow.Index;
            }

            if (dataGridView1.SelectedCells != null && dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];
                startIndex = selectedCell.RowIndex;
            }

            startIndex += step;
            for (int i = startIndex; i < dataGridView1.Rows.Count; i += step)
            {

                if (i < 0)
                {
                    break;
                }

                foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                {
                    if (dataGridView1.Rows[i].Visible && cell.Value != null && cell.Value.ToString().Contains(i_SearchString))
                    {
                        cleanAllSelectedCells();
                        dataGridView1.Rows[i].Selected = true;
                        foundMatch = true;
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                        break;
                    }
                }

                if (foundMatch)
                {
                    break;
                }

            }

            if (!foundMatch)
            {
                MessageBox.Show(string.Format("Cannot find string \"{0}\"", i_SearchString), "RPC Monitor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void modifyColumnSelection(DataGridViewColumn i_Column, GroupBox i_GroupBox)
        {
            foreach (CheckBox checkBox in i_GroupBox.Controls)
            {
                if (checkBox.Text == i_Column.HeaderText)
                {
                    if (checkBox.Checked)
                    {
                        dataGridView1.Columns[i_Column.Index].Visible = true;
                    }
                    else
                    {
                        dataGridView1.Columns[i_Column.Index].Visible = false;
                    }
                }
            }
        }
        private void ColumnSelection_selectColumnsUpdate(GroupBox i_RPCClient, GroupBox i_RPCServer, GroupBox i_RPCMisc)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                modifyColumnSelection(column, i_RPCClient);
                modifyColumnSelection(column, i_RPCServer);
                modifyColumnSelection(column, i_RPCMisc);
            }
        }

        //private Color getHighlighColorIfRequired(string i_Action)
        //{
        //    Color resultColor = Color.White;
        //    if (i_Action == "Include")
        //    {
        //        resultColor = Color.Cyan;
        //    }

        //    return resultColor;
        //}

        private void filterRowBasedOnForm(Utils.eFormNames i_FormName, int i_RowIndex, string i_Action)
        {

            if (i_FormName == Utils.eFormNames.FormColumnFilter)
            {
                this.dataGridView1.Rows[i_RowIndex].Visible = (i_Action == "Include");
            }
            else
            {
                this.dataGridView1.Rows[i_RowIndex].DefaultCellStyle.BackColor = (i_Action == "Include") ? Color.Cyan : Color.White;
            }
        }

        private void hideFilterRowBasedOnForm(Utils.eFormNames i_FormName, int i_RowIndex)
        {
            if (i_FormName == Utils.eFormNames.FormColumnFilter)
            {
                this.dataGridView1.Rows[i_RowIndex].Visible = false;
            }
            else
            {
                this.dataGridView1.Rows[i_RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private bool checkIfShouldBeVisable(ListViewItem rule, DataGridViewRow row, String key)
        {
            DataGridViewCell cellValueFromGridViewCell = row.Cells["Column" + rule.SubItems[0].Text];
            string valueFromFilter = rule.SubItems[(int)Utils.eFilterNames.Value].Text;
            if (rule.SubItems[(int)Utils.eFilterNames.Relation].Text == "contains")
            {
                if (row.Cells["Column" + key].Value.ToString().Contains(rule.SubItems[(int)Utils.eFilterNames.Value].Text))
                {
                    if (cellValueFromGridViewCell.Value.ToString().Contains(valueFromFilter))
                    {
                        return true;
                    }
                }
            }
            else if (rule.SubItems[(int)Utils.eFilterNames.Relation].Text == "is")
            {
                if (cellValueFromGridViewCell.Value.ToString() == valueFromFilter)
                {
                    return true;
                }
            }
            else if (rule.SubItems[(int)Utils.eFilterNames.Relation].Text == "begins with")
            {
                if (cellValueFromGridViewCell.Value.ToString().StartsWith(valueFromFilter))
                {
                    return true;
                }
            }
            else if (rule.SubItems[(int)Utils.eFilterNames.Relation].Text == "ends with")
            {

                if (cellValueFromGridViewCell.Value.ToString().EndsWith(valueFromFilter))
                {
                    return true;
                }
            }
            return false;
        }

        private void filterRow(Utils.eFormNames i_FormName, DataGridViewRow row, IDictionary<string, List<ListViewItem>> includeDict, IDictionary<string, List<ListViewItem>> excludeDict)
        {
            bool visable = false;
            foreach (var pair in excludeDict)
            {
                foreach (var rule in pair.Value)
                {
                    if (checkIfShouldBeVisable(rule, row, pair.Key))
                    {
                        hideFilterRowBasedOnForm(i_FormName, row.Index);
                        return;
                    }
                }
            }
            if (!excludeDict.Count.Equals(0))
            {
                filterRowBasedOnForm(i_FormName, row.Index, "Include");
            }


            foreach (var pair in includeDict)
            {
                foreach (var rule in pair.Value)
                {
                    if (checkIfShouldBeVisable(rule, row, pair.Key))
                    {
                        visable = true;
                        break;
                    }
                }
                if (!visable)
                {
                    hideFilterRowBasedOnForm(i_FormName, row.Index);
                    return;
                }
                visable = false;
            }
            if (!includeDict.Count.Equals(0))
            {
                filterRowBasedOnForm(i_FormName, row.Index, "Include");
            }
        }
        private void filterSingleRowByFilterRules(Utils.eFormNames i_FormName, DataGridViewRow row)
        {
            
            //int rowCounter = 0;
            if(i_FormName == Utils.eFormNames.FormColumnFilter)
            {
                filterRow(i_FormName, row, m_includeFilterDict, m_excludeFilterDict);
            }
            else
            {
                filterRow(i_FormName, row, m_includeHighlightDict, m_excludeHighlightDict);
            }
            


            //if (rowCounter <= this.dataGridView1.Rows.Count - 1)
            //{
            //    foreach (ListViewItem rule in i_ListView.Items)
            //    {
            //        if (rule.Checked)
            //        {
            //            DataGridViewCell cellValueFromGridViewCell = row.Cells["Column" + rule.SubItems[0].Text];
            //            string valueFromFilter = rule.SubItems[(int)Utils.eFilterNames.Value].Text;
            //            if (rule.SubItems[(int)Utils.eFilterNames.Relation].Text == "contains")
            //            {
            //                if ((cellValueFromGridViewCell.Value.ToString()).Contains(valueFromFilter))
            //                {

            //                    filterRowBasedOnForm(i_FormName, row.Index, rule.SubItems[(int)Utils.eFilterNames.Action].Text);
            //                    return;
            //                    //if (i_FormName == Utils.eFormNames.FormColumnFilter)
            //                    //{
            //                    //    this.dataGridView1.Rows[row.Index].Visible = (rule.SubItems[(int)Utils.eFilterNames.Action].Text == "Include");

            //                    //} else
            //                    //{
            //                    //    this.dataGridView1.Rows[row.Index].DefaultCellStyle.BackColor = getHighlighColorIfRequired(rule.SubItems[(int)Utils.eFilterNames.Action].Text);
            //                    //}
            //                }
            //                else
            //                {

            //                    hideFilterRowBasedOnForm(i_FormName, row.Index);
            //                    //if (i_FormName == Utils.eFormNames.FormColumnFilter)
            //                    //{
            //                    //    this.dataGridView1.Rows[row.Index].Visible = false;
            //                    //}
            //                    //else
            //                    //{
            //                    //    this.dataGridView1.Rows[row.Index].DefaultCellStyle.BackColor = Color.White;
            //                    //}
            //                }

            //            }
            //            else if (rule.SubItems[(int)Utils.eFilterNames.Relation].Text == "is")
            //            {
            //                if (cellValueFromGridViewCell.Value.ToString() == valueFromFilter)
            //                {
            //                    filterRowBasedOnForm(i_FormName, row.Index, rule.SubItems[(int)Utils.eFilterNames.Action].Text);
            //                    return;
            //                    // this.dataGridView1.Rows[row.Index].Visible = (rule.SubItems[(int)Utils.eFilterNames.Action].Text == "Include");
            //                }
            //                else
            //                {
            //                    hideFilterRowBasedOnForm(i_FormName, row.Index);
            //                    //this.dataGridView1.Rows[row.Index].Visible = false;
            //                }

            //            }
            //            else if (rule.SubItems[(int)Utils.eFilterNames.Relation].Text == "begins with")
            //            {

            //                if (cellValueFromGridViewCell.Value.ToString().StartsWith(valueFromFilter))
            //                {
            //                    filterRowBasedOnForm(i_FormName, row.Index, rule.SubItems[(int)Utils.eFilterNames.Action].Text);
            //                    return;
            //                    //this.dataGridView1.Rows[row.Index].Visible = (rule.SubItems[(int)Utils.eFilterNames.Action].Text == "Include");
            //                }
            //                else
            //                {
            //                    hideFilterRowBasedOnForm(i_FormName, row.Index);
            //                    //this.dataGridView1.Rows[row.Index].Visible = false;
            //                }

            //            }
            //            else if (rule.SubItems[(int)Utils.eFilterNames.Relation].Text == "ends with")
            //            {

            //                if (cellValueFromGridViewCell.Value.ToString().EndsWith(valueFromFilter))
            //                {
            //                    filterRowBasedOnForm(i_FormName, row.Index, rule.SubItems[(int)Utils.eFilterNames.Action].Text);
            //                    return;
            //                    //this.dataGridView1.Rows[row.Index].Visible = (rule.SubItems[(int)Utils.eFilterNames.Action].Text == "Include");
            //                }
            //                else
            //                {
            //                    hideFilterRowBasedOnForm(i_FormName, row.Index);
            //                    //this.dataGridView1.Rows[row.Index].Visible = false;
            //                }

            //            }

            //        }
            //    }
            //}

            //rowCounter++;
        }

        private void addItemToFilterDict(ListViewItem rule, bool addToExcludeList, Utils.eFormNames i_FormName)
        {
            if(i_FormName == Utils.eFormNames.FormColumnFilter)
            {
                if (addToExcludeList)
                {
                    if (!m_excludeFilterDict.ContainsKey(rule.SubItems[0].Text))
                    {
                        m_excludeFilterDict.Add(rule.SubItems[0].Text, new List<ListViewItem>());
                    }
                    m_excludeFilterDict[rule.SubItems[0].Text].Add(rule);
                }
                else
                {
                    if (!m_includeFilterDict.ContainsKey(rule.SubItems[0].Text))
                    {
                        m_includeFilterDict.Add(rule.SubItems[0].Text, new List<ListViewItem>());
                    }
                    m_includeFilterDict[rule.SubItems[0].Text].Add(rule);
                }
            }
            else
            {
                if (addToExcludeList)
                {
                    if (!m_excludeHighlightDict.ContainsKey(rule.SubItems[0].Text))
                    {
                        m_excludeHighlightDict.Add(rule.SubItems[0].Text, new List<ListViewItem>());
                    }
                    m_excludeHighlightDict[rule.SubItems[0].Text].Add(rule);
                }
                else
                {
                    if (!m_includeHighlightDict.ContainsKey(rule.SubItems[0].Text))
                    {
                        m_includeHighlightDict.Add(rule.SubItems[0].Text, new List<ListViewItem>());
                    }
                    m_includeHighlightDict[rule.SubItems[0].Text].Add(rule);
                }
            } 
        }

        private void updateFilterDicts(ListView i_ListView, Utils.eFormNames i_FormName)
        {
            if (i_FormName == Utils.eFormNames.FormColumnFilter)
            {
                m_includeFilterDict.Clear();
                m_excludeFilterDict.Clear();
            }
            else
            {
                m_includeHighlightDict.Clear();
                m_excludeHighlightDict.Clear();
            }
            foreach (ListViewItem rule in i_ListView.Items)
            {
                if (rule.Checked)
                {
                    addItemToFilterDict(rule, rule.SubItems[(int)Utils.eFilterNames.Action].Text == "Exclude", i_FormName);
                }
            }
        }

        private void filterRowsByFilterRules(Utils.eFormNames i_FormName)
        {
            
            // TODO: What happens if one row is already Filtered\Highlight? It will hide it. Need to fix it
            // so there will be OR between the rules
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                filterSingleRowByFilterRules(i_FormName, row);
            }

            //if (i_FormName == Utils.eFormNames.FormColumnFilter)
            //{
            //    m_LastListViewColumnFilter = i_ListView;
            //} else
            //{
            //    m_LastListViewHighlighFilter = i_ListView;
            //}
        }

        private void ColumnFilter_OKFilter(ListView i_ListView)
        {

            m_filterListView = i_ListView;
            updateFilterDicts(i_ListView, Utils.eFormNames.FormColumnFilter);
            if (m_includeFilterDict.Count.Equals(0))
            {
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {
                    row.Visible = true;
                }
            }
            filterRowsByFilterRules(Utils.eFormNames.FormColumnFilter);

            //int rowCounter = 0;
            //bool shouldInclude = false;
            //foreach (DataGridViewRow row in this.dataGridView1.Rows)
            //{
            //    if (rowCounter <= this.dataGridView1.Rows.Count - 1)
            //    {
            //        foreach (ListViewItem rule in i_ListView.Items)
            //        {
            //            if (rule.Checked)
            //            {
            //                DataGridViewCell cellValueFromGridViewCell = row.Cells["Column" + rule.SubItems[0].Text];
            //                string valueFromFilter = rule.SubItems[(int)Utils.eFilterNames.Value].Text;
            //                if (rule.SubItems[(int)Utils.eFilterNames.Relation].Text == "contains")
            //                {
            //                    if ((cellValueFromGridViewCell.Value.ToString()).Contains(valueFromFilter))
            //                    {
            //                       this.dataGridView1.Rows[row.Index].Visible = (rule.SubItems[(int)Utils.eFilterNames.Action].Text == "Include");
            //                    }
            //                    else
            //                    {
            //                        this.dataGridView1.Rows[row.Index].Visible = false;
            //                    }

            //                } else if (rule.SubItems[(int)Utils.eFilterNames.Relation].Text == "is")
            //                {
            //                    if (cellValueFromGridViewCell.Value.ToString() == valueFromFilter)
            //                    {
            //                        this.dataGridView1.Rows[row.Index].Visible = (rule.SubItems[(int)Utils.eFilterNames.Action].Text == "Include");
            //                    }
            //                    else
            //                    {
            //                        this.dataGridView1.Rows[row.Index].Visible = false;
            //                    }
            //                } else if (rule.SubItems[(int)Utils.eFilterNames.Relation].Text == "begins with") {

            //                    if (cellValueFromGridViewCell.Value.ToString().StartsWith(valueFromFilter))
            //                    {
            //                        this.dataGridView1.Rows[row.Index].Visible = (rule.SubItems[(int)Utils.eFilterNames.Action].Text == "Include");
            //                    }
            //                    else
            //                    {
            //                        this.dataGridView1.Rows[row.Index].Visible = false;
            //                    }
            //                }
            //                else if (rule.SubItems[(int)Utils.eFilterNames.Relation].Text == "ends with")
            //                {

            //                    if (cellValueFromGridViewCell.Value.ToString().EndsWith(valueFromFilter))
            //                    {
            //                        this.dataGridView1.Rows[row.Index].Visible = (rule.SubItems[(int)Utils.eFilterNames.Action].Text == "Include");
            //                    }
            //                    else
            //                    {
            //                        this.dataGridView1.Rows[row.Index].Visible = false;
            //                    }
            //                }

            //            }
            //        }
            //    }

            //    rowCounter++;
            //}

            //m_LastListViewColumnFilter = i_ListView;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool result = false;

            if (keyData == (Keys.Control | Keys.L))
            {
                openColumnFilterWindow();
                result = true;
            } else if (keyData == (Keys.Control | Keys.B))
            {
                Font boldFont = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Bold);
                Font font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Regular);

                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    
                    if (!dataGridView1.Rows[cell.RowIndex].DefaultCellStyle.Font.Bold)
                    {
                        font = boldFont;
                    }

                    dataGridView1.Rows[cell.RowIndex].DefaultCellStyle.Font = font;
                }

                foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
                {

                    if (!selectedRow.DefaultCellStyle.Font.Bold)
                    {
                        font = boldFont;
                    }

                    dataGridView1.Rows[selectedRow.Index].DefaultCellStyle.Font = font;

                }
                result = true;
            } else if (keyData == (Keys.Control | Keys.F))
            {
                openFindWindow();
                result = true;
            } else if (keyData == (Keys.Control | Keys.H))
            {
                openHighlightWindows();
                result = true;
            }
            else if (keyData == (Keys.F3))
            {
                // We need to implement the options for the search
                FindWindow_searchForMatch(m_LastSearchValue, true, false, false);
            } else if (keyData == (Keys.Shift | Keys.F3))
            {
                // We need to implement the options for the search
                FindWindow_searchForMatch(m_LastSearchValue, false, false, false);
            }

            return result;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right) {
                openColumnSelectionWindow();
            }
        }

        /// <summary>
        /// Right Click On Data Grid View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.ColumnIndex.Equals(-1) && e.RowIndex.Equals(-1))
            {
                dataGridView1_ColumnHeaderMouseClick(sender, e);
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                m_CurrentRowIndexRightClick = e.RowIndex;
                m_CurrentColumnIndexRightClick = e.ColumnIndex;
                contextMenuStripRightClickGridView.Show(Cursor.Position.X, Cursor.Position.Y);
                autoScroll = false;
                toolStripButtonAutoScroll.Image = global::RPCMon.Properties.Resources.scroll_disable;
            }
        }

        private void copyRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string copiedRow = "";

            foreach (DataGridViewCell cell in dataGridView1.Rows[m_CurrentRowIndexRightClick].Cells)
            {
                copiedRow += cell.Value + " ";
            }

            if (copiedRow != "")
            {
                System.Windows.Forms.Clipboard.SetText(copiedRow);
            }
        }

        private void copyCellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string copiedCell = "";
            if (dataGridView1.Rows[m_CurrentRowIndexRightClick] != null)
            {
                if (dataGridView1.Rows[m_CurrentRowIndexRightClick].Cells[m_CurrentColumnIndexRightClick].Value != null)
                {
                    copiedCell = dataGridView1.Rows[m_CurrentRowIndexRightClick].Cells[m_CurrentColumnIndexRightClick].Value.ToString();
                }
            }
            
            if (copiedCell != "")
            {
                System.Windows.Forms.Clipboard.SetText(copiedCell);
            }
        }

        private void toolStripButtonClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Authors: Eviatar Gerzi (@g3rzi) and Yaniv Yakobovich\nVersion: 1.2\n\nCopyright (c) 2022 CyberArk Software Ltd. All rights reserved", "About");
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            openFindWindow();
        }

        private void toolStripButtonHighlight_Click(object sender, EventArgs e)
        {
            openHighlightWindows();
        }

        // Taken from https://stackoverflow.com/a/26259909/2153777
        private void saveDataGridViewToCSV(string filename)
        {
            DataGridView tempDataGridView = dataGridView1;
            foreach (DataGridViewColumn column in tempDataGridView.Columns)
            {
                tempDataGridView.Columns[column.Index].Visible = true;
            }
            // Choose whether to write header. Use EnableWithoutHeaderText instead to omit header.
            tempDataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            // Select all the cells
            tempDataGridView.SelectAll();
            // Copy selected cells to DataObject
            DataObject dataObject = tempDataGridView.GetClipboardContent();
            // Get the text of the DataObject, and serialize it to a file
            File.WriteAllText(filename, dataObject.GetText(TextDataFormat.CommaSeparatedValue));
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save results as CSV";
            saveDialog.InitialDirectory = @"c:\";
            saveDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveDialog.FilterIndex = 2;
            saveDialog.RestoreDirectory = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                saveDataGridViewToCSV(saveDialog.FileName);
            }
        }

        private void toolStripStatusLabelDBPath_MouseHover(object sender, EventArgs e)
        {
            toolTipDBPath.Show(this.m_RPCDBPath,
                                 this.statusStrip1,
                             new Point(toolStripStatusLabelDBPath.Bounds.Left,
                             toolStripStatusLabelDBPath.Bounds.Top + 20));
        }

        private void toolStripStatusLabelDBPath_MouseLeave(object sender, EventArgs e)
        {
            toolTipDBPath.Hide(this.statusStrip1);
        }

        private void loadDBToolStripMenuItemLoadDB_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadDBDialog = new OpenFileDialog();
            loadDBDialog.Title = "Load RPC DataBase";
            loadDBDialog.InitialDirectory = @"c:\";
            loadDBDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            loadDBDialog.FilterIndex = 1;
            loadDBDialog.RestoreDirectory = true;
            if (loadDBDialog.ShowDialog() == DialogResult.OK)
            {
                this.m_RPCDBPath = loadDBDialog.FileName;
                updateToolStripStatusLabelDBPath(loadDBDialog.FileName);
            }
        }

        private bool m_IsGridButtonPressed = false;
        private void toolStripButtonGrid_Click(object sender, EventArgs e)
        {
            if (!m_IsGridButtonPressed)
            {
                toolStripButtonGrid.Image = global::RPCMon.Properties.Resources.grid;
                m_IsGridButtonPressed = true;
                this.dataGridView1.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;

            }
            else
            {
                toolStripButtonGrid.Image = global::RPCMon.Properties.Resources.grid_disable;
                m_IsGridButtonPressed = false;
                this.dataGridView1.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single;
            }
        }

        private void hideOrShowAllRows(bool i_ShowAll)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (i_ShowAll)
                {
                    dataGridView1.Rows[row.Index].Visible = true;
                }
                else
                {
                    dataGridView1.Rows[row.Index].Visible = false;
                }
            }
        }

        private bool m_IsRemoveDuplicateButtonPressed = false;
        private void toolStripButtonRemoveDuplicate_Click(object sender, EventArgs e)
        {
            if (!m_IsRemoveDuplicateButtonPressed)
            {
                toolStripButtonRemoveDuplicate.Image = global::RPCMon.Properties.Resources.duplicate;
                m_IsRemoveDuplicateButtonPressed = true;
                Dictionary<string, int> dict = new Dictionary<string, int>();
                string rawRow;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    rawRow = "";
                    // Maybe can be reforma with the Copy function
                    foreach (DataGridViewCell cell in dataGridView1.Rows[row.Index].Cells)
                    {
                        rawRow += cell.Value + " ";
                    }

                    if (!dict.ContainsKey(rawRow))
                    {
                        dict.Add(rawRow, row.Index);
                    }
                }

                hideOrShowAllRows(false);
                foreach (int index in dict.Values)
                {
                    dataGridView1.Rows[index].Visible = true;
                }

                //https://stackoverflow.com/questions/28336370/how-to-remove-duplicate-row-from-datagridview-in-c
                //DataTable items = new DataTable();
                //items.Columns.Add("PID");
                //items.Columns.Add("TID");
                //for (int i = 0; i < dataGridView1.Rows.Count; i++)
                //{
                //    DataRow rw = items.NewRow();
                //    rw[0] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                //    rw[1] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                //    var a = rw["PID"];
                //    if (!items.Rows.Cast<DataRow>().Any(row => row["PID"].Equals(rw["PID"]) && row["TID"].Equals(rw["TID"])))
                //        items.Rows.Add(rw);
                //}
                //dataGridView1.DataSource = items;
            }
            else
            {
                toolStripButtonRemoveDuplicate.Image = global::RPCMon.Properties.Resources.duplicate_disable;
                m_IsRemoveDuplicateButtonPressed = false;
                hideOrShowAllRows(true);
            }
        }

        private void setDbgHelpFilePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Set DbgHelp File Path";
            fileDialog.InitialDirectory = @"c:\";
            fileDialog.Filter = "DLL files (*.dll)|*.dll|All files (*.*)|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Engine.DbgHelpFilePath = fileDialog.FileName;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            checkIdDBGHelpExist();
        }

        private void updateToolStripStatusLabelDBPath(string i_DBPath)
       {
            this.toolStripStatusLabelDBPath.Text = "DB File: " + Path.GetFileName(this.m_RPCDBPath);
       }
    }
}
