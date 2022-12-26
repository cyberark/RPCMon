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
            this.checkBoxProcessName.Checked = visableColumns.Contains(this.checkBoxProcessName.Text);
            this.checkBoxTID.Checked = visableColumns.Contains(this.checkBoxTID.Text);
            this.checkBoxPID.Checked = visableColumns.Contains(this.checkBoxPID.Text);
            this.checkBoxImpersonationLevel.Checked = visableColumns.Contains(this.checkBoxImpersonationLevel.Text);
            this.checkBoxAuthenticationLevel.Checked = visableColumns.Contains(this.checkBoxAuthenticationLevel.Text);
            this.checkBoxAuthenticationService.Checked = visableColumns.Contains(this.checkBoxAuthenticationService.Text);
            this.checkBoxOptions.Checked = visableColumns.Contains(this.checkBoxOptions.Text);
            this.checkBoxEndpoint.Checked = visableColumns.Contains(this.checkBoxEndpoint.Text);
            this.checkBoxProtocol.Checked = visableColumns.Contains(this.checkBoxProtocol.Text);
            this.checkBoxNetworkAddress.Checked = visableColumns.Contains(this.checkBoxNetworkAddress.Text);
            this.checkBoxService.Checked = visableColumns.Contains(this.checkBoxService.Text);
            this.checkBoxUUID.Checked = visableColumns.Contains(this.checkBoxUUID.Text);
            this.checkBoxModulePath.Checked = visableColumns.Contains(this.checkBoxModulePath.Text);
            this.checkBoxModule.Checked = visableColumns.Contains(this.checkBoxModule.Text);
            this.checkBoxProceduresCount.Checked = visableColumns.Contains(this.checkBoxProceduresCount.Text);
            this.checkBoxFunction.Checked = visableColumns.Contains(this.checkBoxFunction.Text);
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
