namespace RPCMon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importAllDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importAsIsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDBToolStripMenuItemLoadDB = new System.Windows.Forms.ToolStripMenuItem();
            this.buildDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDbgHelpFilePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showClientStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showServerStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showClientStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showServerStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHighlight = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGrid = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemoveDuplicate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAutoScroll = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModulePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProceduresCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFunction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNetworkAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProtocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndpoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAuthenticationLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAuthenticationService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImpersonationLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTotalEvents = new System.Windows.Forms.ToolStripStatusLabel();
            this.selectedEventsToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDBPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTipDBPath = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStripRightClickGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStripRightClickGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dBToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.importToolStripMenuItem,
            this.importToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importAllDataToolStripMenuItem,
            this.importAsIsToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.importToolStripMenuItem.Text = "Export";
            // 
            // importAllDataToolStripMenuItem
            // 
            this.importAllDataToolStripMenuItem.Name = "importAllDataToolStripMenuItem";
            this.importAllDataToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.importAllDataToolStripMenuItem.Text = "Export All Data...";
            this.importAllDataToolStripMenuItem.Click += new System.EventHandler(this.exportAllDataToolStripMenuItem_Click);
            // 
            // importAsIsToolStripMenuItem
            // 
            this.importAsIsToolStripMenuItem.Name = "importAsIsToolStripMenuItem";
            this.importAsIsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.importAsIsToolStripMenuItem.Text = "Export As Is...";
            this.importAsIsToolStripMenuItem.Click += new System.EventHandler(this.exportAsIsToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem1
            // 
            this.importToolStripMenuItem1.Name = "importToolStripMenuItem1";
            this.importToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.importToolStripMenuItem1.Text = "Import...";
            this.importToolStripMenuItem1.Click += new System.EventHandler(this.importToolStripMenuItem1_Click);
            // 
            // dBToolStripMenuItem
            // 
            this.dBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDBToolStripMenuItemLoadDB,
            this.buildDBToolStripMenuItem});
            this.dBToolStripMenuItem.Name = "dBToolStripMenuItem";
            this.dBToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.dBToolStripMenuItem.Text = "DB";
            // 
            // loadDBToolStripMenuItemLoadDB
            // 
            this.loadDBToolStripMenuItemLoadDB.Name = "loadDBToolStripMenuItemLoadDB";
            this.loadDBToolStripMenuItemLoadDB.Size = new System.Drawing.Size(128, 22);
            this.loadDBToolStripMenuItemLoadDB.Text = "Load DB...";
            this.loadDBToolStripMenuItemLoadDB.Click += new System.EventHandler(this.loadDBToolStripMenuItemLoadDB_Click);
            // 
            // buildDBToolStripMenuItem
            // 
            this.buildDBToolStripMenuItem.Name = "buildDBToolStripMenuItem";
            this.buildDBToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.buildDBToolStripMenuItem.Text = "Build DB...";
            this.buildDBToolStripMenuItem.Click += new System.EventHandler(this.buildDBToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setDbgHelpFilePathToolStripMenuItem,
            this.showClientStartToolStripMenuItem,
            this.showServerStartToolStripMenuItem,
            this.showClientStopToolStripMenuItem,
            this.showServerStopToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // setDbgHelpFilePathToolStripMenuItem
            // 
            this.setDbgHelpFilePathToolStripMenuItem.Name = "setDbgHelpFilePathToolStripMenuItem";
            this.setDbgHelpFilePathToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.setDbgHelpFilePathToolStripMenuItem.Text = "Set DbgHelp File Path...";
            this.setDbgHelpFilePathToolStripMenuItem.Click += new System.EventHandler(this.setDbgHelpFilePathToolStripMenuItem_Click);
            // 
            // showClientStartToolStripMenuItem
            // 
            this.showClientStartToolStripMenuItem.Checked = true;
            this.showClientStartToolStripMenuItem.CheckOnClick = true;
            this.showClientStartToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showClientStartToolStripMenuItem.Name = "showClientStartToolStripMenuItem";
            this.showClientStartToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.showClientStartToolStripMenuItem.Text = "Show ClientStart";
            this.showClientStartToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showClientStartToolStripMenuItem_CheckedChanged);
            // 
            // showServerStartToolStripMenuItem
            // 
            this.showServerStartToolStripMenuItem.Checked = true;
            this.showServerStartToolStripMenuItem.CheckOnClick = true;
            this.showServerStartToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showServerStartToolStripMenuItem.Name = "showServerStartToolStripMenuItem";
            this.showServerStartToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.showServerStartToolStripMenuItem.Text = "Show ServerStart";
            this.showServerStartToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showServerStartToolStripMenuItem_CheckedChanged);
            // 
            // showClientStopToolStripMenuItem
            // 
            this.showClientStopToolStripMenuItem.CheckOnClick = true;
            this.showClientStopToolStripMenuItem.Name = "showClientStopToolStripMenuItem";
            this.showClientStopToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.showClientStopToolStripMenuItem.Text = "Show ClientStop";
            this.showClientStopToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showClientStopToolStripMenuItem_CheckedChanged);
            // 
            // showServerStopToolStripMenuItem
            // 
            this.showServerStopToolStripMenuItem.CheckOnClick = true;
            this.showServerStopToolStripMenuItem.Name = "showServerStopToolStripMenuItem";
            this.showServerStopToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.showServerStopToolStripMenuItem.Text = "Show ServerStop";
            this.showServerStopToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showServerStopToolStripMenuItem_CheckedChanged);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonStart,
            this.toolStripButtonClear,
            this.toolStripButtonFilter,
            this.toolStripButtonFind,
            this.toolStripButtonHighlight,
            this.toolStripButtonGrid,
            this.toolStripButtonRemoveDuplicate,
            this.toolStripButtonAutoScroll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(828, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonStart
            // 
            this.toolStripButtonStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStart.Image = global::RPCMon.Properties.Resources.startIcon;
            this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStart.Name = "toolStripButtonStart";
            this.toolStripButtonStart.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonStart.Text = "Capture";
            this.toolStripButtonStart.ToolTipText = "Capture";
            this.toolStripButtonStart.Click += new System.EventHandler(this.toolStripButtonStart_Click);
            // 
            // toolStripButtonClear
            // 
            this.toolStripButtonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClear.Image = global::RPCMon.Properties.Resources.eraser;
            this.toolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonClear.Text = "Clear (Ctrl+X)";
            this.toolStripButtonClear.Click += new System.EventHandler(this.toolStripButtonClear_Click);
            // 
            // toolStripButtonFilter
            // 
            this.toolStripButtonFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFilter.Image = global::RPCMon.Properties.Resources.filter;
            this.toolStripButtonFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFilter.Name = "toolStripButtonFilter";
            this.toolStripButtonFilter.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonFilter.Text = "Filter (Ctrl+L)";
            this.toolStripButtonFilter.ToolTipText = "Filter (Ctrl+L)";
            this.toolStripButtonFilter.Click += new System.EventHandler(this.toolStripButtonFilter_Click);
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFind.Image = global::RPCMon.Properties.Resources.find;
            this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFind.Name = "toolStripButtonFind";
            this.toolStripButtonFind.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonFind.Text = "Find (Ctrl+F)";
            this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
            // 
            // toolStripButtonHighlight
            // 
            this.toolStripButtonHighlight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHighlight.Image = global::RPCMon.Properties.Resources.highlighter;
            this.toolStripButtonHighlight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHighlight.Name = "toolStripButtonHighlight";
            this.toolStripButtonHighlight.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonHighlight.Text = "HighLight (Ctrl+H)";
            this.toolStripButtonHighlight.Click += new System.EventHandler(this.toolStripButtonHighlight_Click);
            // 
            // toolStripButtonGrid
            // 
            this.toolStripButtonGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGrid.Image = global::RPCMon.Properties.Resources.grid_disable;
            this.toolStripButtonGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGrid.Name = "toolStripButtonGrid";
            this.toolStripButtonGrid.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonGrid.Text = "Show Grid";
            this.toolStripButtonGrid.Click += new System.EventHandler(this.toolStripButtonGrid_Click);
            // 
            // toolStripButtonRemoveDuplicate
            // 
            this.toolStripButtonRemoveDuplicate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemoveDuplicate.Image = global::RPCMon.Properties.Resources.duplicate_disable;
            this.toolStripButtonRemoveDuplicate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveDuplicate.Name = "toolStripButtonRemoveDuplicate";
            this.toolStripButtonRemoveDuplicate.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonRemoveDuplicate.Text = "Remove Duplicate Rows";
            this.toolStripButtonRemoveDuplicate.Click += new System.EventHandler(this.toolStripButtonRemoveDuplicate_Click);
            // 
            // toolStripButtonAutoScroll
            // 
            this.toolStripButtonAutoScroll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAutoScroll.Image = global::RPCMon.Properties.Resources.scroll_disable;
            this.toolStripButtonAutoScroll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAutoScroll.Name = "toolStripButtonAutoScroll";
            this.toolStripButtonAutoScroll.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAutoScroll.Text = "Auto Scroll";
            this.toolStripButtonAutoScroll.ToolTipText = "Auto Scroll";
            this.toolStripButtonAutoScroll.Click += new System.EventHandler(this.toolStripButtonAutoScroll_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPID,
            this.ColumnTID,
            this.ColumnProcessName,
            this.ColumnUUID,
            this.ColumnModule,
            this.ColumnModulePath,
            this.ColumnProceduresCount,
            this.ColumnService,
            this.ColumnFunction,
            this.ColumnNetworkAddress,
            this.ColumnProtocol,
            this.ColumnEndpoint,
            this.ColumnOptions,
            this.ColumnAuthenticationLevel,
            this.ColumnAuthenticationService,
            this.ColumnImpersonationLevel,
            this.ColumnTimeStamp,
            this.ColumnTaskName});
            this.dataGridView1.Location = new System.Drawing.Point(0, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(828, 486);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ColumnPID
            // 
            this.ColumnPID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnPID.HeaderText = "PID";
            this.ColumnPID.Name = "ColumnPID";
            this.ColumnPID.ReadOnly = true;
            this.ColumnPID.Width = 79;
            // 
            // ColumnTID
            // 
            this.ColumnTID.HeaderText = "TID";
            this.ColumnTID.Name = "ColumnTID";
            this.ColumnTID.ReadOnly = true;
            // 
            // ColumnProcessName
            // 
            this.ColumnProcessName.HeaderText = "ProcessName";
            this.ColumnProcessName.Name = "ColumnProcessName";
            this.ColumnProcessName.ReadOnly = true;
            // 
            // ColumnUUID
            // 
            this.ColumnUUID.HeaderText = "UUID";
            this.ColumnUUID.Name = "ColumnUUID";
            this.ColumnUUID.ReadOnly = true;
            // 
            // ColumnModule
            // 
            this.ColumnModule.HeaderText = "Module";
            this.ColumnModule.Name = "ColumnModule";
            this.ColumnModule.ReadOnly = true;
            // 
            // ColumnModulePath
            // 
            this.ColumnModulePath.HeaderText = "ModulePath";
            this.ColumnModulePath.Name = "ColumnModulePath";
            this.ColumnModulePath.ReadOnly = true;
            this.ColumnModulePath.Visible = false;
            // 
            // ColumnProceduresCount
            // 
            this.ColumnProceduresCount.HeaderText = "ProceduresCount";
            this.ColumnProceduresCount.Name = "ColumnProceduresCount";
            this.ColumnProceduresCount.ReadOnly = true;
            this.ColumnProceduresCount.Visible = false;
            // 
            // ColumnService
            // 
            this.ColumnService.HeaderText = "Service";
            this.ColumnService.Name = "ColumnService";
            this.ColumnService.ReadOnly = true;
            // 
            // ColumnFunction
            // 
            this.ColumnFunction.HeaderText = "Function";
            this.ColumnFunction.Name = "ColumnFunction";
            this.ColumnFunction.ReadOnly = true;
            // 
            // ColumnNetworkAddress
            // 
            this.ColumnNetworkAddress.HeaderText = "NetworkAddress";
            this.ColumnNetworkAddress.Name = "ColumnNetworkAddress";
            this.ColumnNetworkAddress.ReadOnly = true;
            this.ColumnNetworkAddress.Visible = false;
            // 
            // ColumnProtocol
            // 
            this.ColumnProtocol.HeaderText = "Protocol";
            this.ColumnProtocol.Name = "ColumnProtocol";
            this.ColumnProtocol.ReadOnly = true;
            // 
            // ColumnEndpoint
            // 
            this.ColumnEndpoint.HeaderText = "Endpoint";
            this.ColumnEndpoint.Name = "ColumnEndpoint";
            this.ColumnEndpoint.ReadOnly = true;
            // 
            // ColumnOptions
            // 
            this.ColumnOptions.HeaderText = "Options";
            this.ColumnOptions.Name = "ColumnOptions";
            this.ColumnOptions.ReadOnly = true;
            this.ColumnOptions.Visible = false;
            // 
            // ColumnAuthenticationLevel
            // 
            this.ColumnAuthenticationLevel.HeaderText = "AuthenticationLevel";
            this.ColumnAuthenticationLevel.Name = "ColumnAuthenticationLevel";
            this.ColumnAuthenticationLevel.ReadOnly = true;
            this.ColumnAuthenticationLevel.Visible = false;
            // 
            // ColumnAuthenticationService
            // 
            this.ColumnAuthenticationService.HeaderText = "AuthenticationService";
            this.ColumnAuthenticationService.Name = "ColumnAuthenticationService";
            this.ColumnAuthenticationService.ReadOnly = true;
            this.ColumnAuthenticationService.Visible = false;
            // 
            // ColumnImpersonationLevel
            // 
            this.ColumnImpersonationLevel.HeaderText = "ImpersonationLevel";
            this.ColumnImpersonationLevel.Name = "ColumnImpersonationLevel";
            this.ColumnImpersonationLevel.ReadOnly = true;
            // 
            // ColumnTimeStamp
            // 
            this.ColumnTimeStamp.HeaderText = "TimeStamp";
            this.ColumnTimeStamp.Name = "ColumnTimeStamp";
            this.ColumnTimeStamp.ReadOnly = true;
            this.ColumnTimeStamp.Visible = false;
            // 
            // ColumnTaskName
            // 
            this.ColumnTaskName.HeaderText = "TaskName";
            this.ColumnTaskName.Name = "ColumnTaskName";
            this.ColumnTaskName.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTotalEvents,
            this.selectedEventsToolStrip,
            this.toolStripStatusLabelDBPath});
            this.statusStrip1.Location = new System.Drawing.Point(0, 538);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(828, 24);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTotalEvents
            // 
            this.toolStripStatusLabelTotalEvents.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabelTotalEvents.Name = "toolStripStatusLabelTotalEvents";
            this.toolStripStatusLabelTotalEvents.Size = new System.Drawing.Size(107, 19);
            this.toolStripStatusLabelTotalEvents.Text = "Shown events: 0/0";
            // 
            // selectedEventsToolStrip
            // 
            this.selectedEventsToolStrip.Name = "selectedEventsToolStrip";
            this.selectedEventsToolStrip.Size = new System.Drawing.Size(100, 19);
            this.selectedEventsToolStrip.Text = "Selected events: 0";
            // 
            // toolStripStatusLabelDBPath
            // 
            this.toolStripStatusLabelDBPath.Name = "toolStripStatusLabelDBPath";
            this.toolStripStatusLabelDBPath.Size = new System.Drawing.Size(49, 19);
            this.toolStripStatusLabelDBPath.Text = "DB File: ";
            this.toolStripStatusLabelDBPath.MouseLeave += new System.EventHandler(this.toolStripStatusLabelDBPath_MouseLeave);
            this.toolStripStatusLabelDBPath.MouseHover += new System.EventHandler(this.toolStripStatusLabelDBPath_MouseHover);
            // 
            // contextMenuStripRightClickGridView
            // 
            this.contextMenuStripRightClickGridView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripRightClickGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyRowToolStripMenuItem,
            this.copyCellToolStripMenuItem});
            this.contextMenuStripRightClickGridView.Name = "contextMenuStripRightClickGridView";
            this.contextMenuStripRightClickGridView.Size = new System.Drawing.Size(181, 70);
            this.contextMenuStripRightClickGridView.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.contextMenuStripRightClickGridView_Closing);
            // 
            // copyRowToolStripMenuItem
            // 
            this.copyRowToolStripMenuItem.Name = "copyRowToolStripMenuItem";
            this.copyRowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyRowToolStripMenuItem.Text = "Copy Row";
            this.copyRowToolStripMenuItem.Click += new System.EventHandler(this.copyRowToolStripMenuItem_Click);
            // 
            // copyCellToolStripMenuItem
            // 
            this.copyCellToolStripMenuItem.Name = "copyCellToolStripMenuItem";
            this.copyCellToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyCellToolStripMenuItem.Text = "Copy Cell";
            this.copyCellToolStripMenuItem.Click += new System.EventHandler(this.copyCellToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RPCMon.Properties.Resources.drag_and_drop;
            this.pictureBox1.Location = new System.Drawing.Point(343, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 131);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "RPCMon - RPC Monitor Based Windows Events";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStripRightClickGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonStart;
        private System.Windows.Forms.ToolStripButton toolStripButtonFilter;
        private System.Windows.Forms.ToolStripButton toolStripButtonAutoScroll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonClear;
        private System.Windows.Forms.ToolStripButton toolStripButtonFind;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTotalEvents;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDBPath;
        private System.Windows.Forms.ToolStripButton toolStripButtonHighlight;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTipDBPath;
        private System.Windows.Forms.ToolStripMenuItem dBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDBToolStripMenuItemLoadDB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRightClickGridView;
        private System.Windows.Forms.ToolStripMenuItem copyRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonGrid;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveDuplicate;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDbgHelpFilePathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importAllDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importAsIsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel selectedEventsToolStrip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModule;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModulePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProceduresCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnService;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNetworkAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProtocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEndpoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuthenticationLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuthenticationService;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImpersonationLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTaskName;
        private System.Windows.Forms.ToolStripMenuItem showClientStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showServerStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showClientStopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showServerStopToolStripMenuItem;
    }
}

