using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPCMon
{
    public delegate void selectColumnsEventHandler(GroupBox i_RPCClient, GroupBox i_RPCServer, GroupBox i_RPCMisc);
    public partial class ColumnSelection : Form
    {
        public event selectColumnsEventHandler selectColumnsUpdate;
        public ColumnSelection(System.Windows.Forms.DataGridView dataGridView1)
        {
            List<string> visableColumns = new List<string>();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                
                if (column.Visible)
                {
                    visableColumns.Add(column.HeaderText);
                }
            }
            InitializeComponent();
            initializeCheckboxes(visableColumns);
        }

        private void initializeCheckboxes(List<string> visableColumns)
        {
            this.checkBoxProcessName.Checked = visableColumns.Contains("ProcessName");
            this.checkBoxTID.Checked = visableColumns.Contains("TID"); ;
            this.checkBoxPID.Checked = visableColumns.Contains("PID");
            this.checkBoxImpersonationLevel.Checked = visableColumns.Contains("ImpersonationLevel");
            this.checkBoxAuthenticationLevel.Checked = visableColumns.Contains("AuthenticationLevel");
            this.checkBoxAuthenticationService.Checked = visableColumns.Contains("AuthenticationService");
            this.checkBoxOptions.Checked = visableColumns.Contains("Options");
            this.checkBoxEndpoint.Checked = visableColumns.Contains("Endpoint");
            this.checkBoxProtocol.Checked = visableColumns.Contains("Protocol");
            this.checkBoxNetworkAddress.Checked = visableColumns.Contains("NetworkAddress");
            this.checkBoxService.Checked = visableColumns.Contains("Service");
            this.checkBoxUUID.Checked = visableColumns.Contains("UUID");
            this.checkBoxModulePath.Checked = visableColumns.Contains("ModulePath");
            this.checkBoxModule.Checked = visableColumns.Contains("Module");
            this.checkBoxProceduresCount.Checked = visableColumns.Contains("ProceduresCount");
            this.checkBoxFunction.Checked = visableColumns.Contains("Function");
        }

        public virtual void OnselectColumnsUpdate(GroupBox i_RPCClient, GroupBox i_RPCServer, GroupBox i_RPCMisc)
        {
            if (selectColumnsUpdate != null)
            {
                selectColumnsUpdate.Invoke(i_RPCClient, i_RPCServer, i_RPCMisc);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            OnselectColumnsUpdate(groupBoxProcessManagement, groupBoxRPCServer, groupBoxRPC);
            this.Close();
        }
    }
}
