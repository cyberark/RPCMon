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
        public ColumnSelection()
        {
            InitializeComponent();
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
