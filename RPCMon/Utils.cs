using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPCMon
{
    public class Utils
    {
        public const int MAIN_GRID_MAX_COLUMNS = 16;

        public enum eColumnNames
        {
            PID = 0,
            TID,
            ProcessName,
            UUID,
            Module,
            ModulePath,
            ProceduresCount,
            Service,
            Function,
            NetworkAddress,
            Protocol,
            Endpoint,
            Options,
            AuthenticationLevel,
            AuthenticationService,
            ImpersonationLevel,
            TimeStamp,
            Task,

        }

        public enum eEvents
        {
            ClientStart = 0,
            ServerStart,
            ClientStop,
            ServerStop,
        }

        public enum eFilterNames
        {
            Column, Relation, Value, Action, MatchCase
        }

        public enum eFormNames
        {
            FormColumnFilter,
            FormHighlighFilter
        }

        //public static readonly Dictionary<string, int> m_ColumnMapToIndex = new Dictionary<string, int>()
        //{
        //        { eColumnNames.PID.ToString(), (int)eColumnNames.PID },
        //        { eColumnNames.TID.ToString(), (int)eColumnNames.TID },
        //        { eColumnNames.ProcessName.ToString(), (int)eColumnNames.ProcessName },
        //        { eColumnNames.UUID.ToString(), (int)eColumnNames.UUID },
        //        { eColumnNames.Module.ToString(), (int)eColumnNames.Module },
        //        { eColumnNames.ModulePath.ToString() , (int)eColumnNames.ModulePath },
        //        //{ eColumnNames.UUID.ToString(), (int)eColumnNames.UUID },
        //        //{ eColumnNames.UUID.ToString(), (int)eColumnNames.UUID },
        //        { eColumnNames.Function.ToString(), (int)eColumnNames.Function },
        //        { eColumnNames.NetworkAddress.ToString(), (int)eColumnNames.NetworkAddress },
        //        { eColumnNames.Protocol.ToString(), (int)eColumnNames.Protocol},
        //        { eColumnNames.Endpoint.ToString(), (int)eColumnNames.Endpoint},
        //        { eColumnNames.Options.ToString(), (int)eColumnNames.Options},
        //        { eColumnNames.AuthenticationLevel.ToString(), (int)eColumnNames.AuthenticationLevel},
        //        { eColumnNames.AuthenticationService.ToString(), (int)eColumnNames.AuthenticationService},
        //        { eColumnNames.ImpersonationLevel.ToString(), (int)eColumnNames.ImpersonationLevel}
        //};

        public static ListView CopyListView(ListView originalListView)
        {
            ListView copiedListView = new ListView();

            // Copy properties from the original ListView
            copiedListView.View = originalListView.View;
            copiedListView.FullRowSelect = originalListView.FullRowSelect;

            // Copy columns
            foreach (ColumnHeader column in originalListView.Columns)
            {
                copiedListView.Columns.Add((ColumnHeader)column.Clone());
            }

            // Copy items
            foreach (ListViewItem item in originalListView.Items)
            {
                ListViewItem copiedItem = (ListViewItem)item.Clone();
                copiedListView.Items.Add(copiedItem);
            }

            return copiedListView;
        }

    }
}
