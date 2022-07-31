namespace RPCMon
{
    partial class ColumnSelection
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
            this.groupBoxProcessManagement = new System.Windows.Forms.GroupBox();
            this.checkBoxProcessName = new System.Windows.Forms.CheckBox();
            this.checkBoxTID = new System.Windows.Forms.CheckBox();
            this.checkBoxPID = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxRPC = new System.Windows.Forms.GroupBox();
            this.checkBoxImpersonationLevel = new System.Windows.Forms.CheckBox();
            this.checkBoxAuthenticationLevel = new System.Windows.Forms.CheckBox();
            this.checkBoxAuthenticationService = new System.Windows.Forms.CheckBox();
            this.checkBoxOptions = new System.Windows.Forms.CheckBox();
            this.checkBoxEndpoint = new System.Windows.Forms.CheckBox();
            this.checkBoxProtocol = new System.Windows.Forms.CheckBox();
            this.checkBoxNetworkAddress = new System.Windows.Forms.CheckBox();
            this.checkBoxService = new System.Windows.Forms.CheckBox();
            this.checkBoxUUID = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxRPCServer = new System.Windows.Forms.GroupBox();
            this.checkBoxModulePath = new System.Windows.Forms.CheckBox();
            this.checkBoxModule = new System.Windows.Forms.CheckBox();
            this.checkBoxProceduresCount = new System.Windows.Forms.CheckBox();
            this.checkBoxFunction = new System.Windows.Forms.CheckBox();
            this.groupBoxProcessManagement.SuspendLayout();
            this.groupBoxRPC.SuspendLayout();
            this.groupBoxRPCServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxProcessManagement
            // 
            this.groupBoxProcessManagement.Controls.Add(this.checkBoxProcessName);
            this.groupBoxProcessManagement.Controls.Add(this.checkBoxTID);
            this.groupBoxProcessManagement.Controls.Add(this.checkBoxPID);
            this.groupBoxProcessManagement.Location = new System.Drawing.Point(12, 47);
            this.groupBoxProcessManagement.Name = "groupBoxProcessManagement";
            this.groupBoxProcessManagement.Size = new System.Drawing.Size(272, 77);
            this.groupBoxProcessManagement.TabIndex = 0;
            this.groupBoxProcessManagement.TabStop = false;
            this.groupBoxProcessManagement.Text = "RPC Client";
            // 
            // checkBoxProcessName
            // 
            this.checkBoxProcessName.AutoSize = true;
            this.checkBoxProcessName.Checked = true;
            this.checkBoxProcessName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxProcessName.Location = new System.Drawing.Point(6, 53);
            this.checkBoxProcessName.Name = "checkBoxProcessName";
            this.checkBoxProcessName.Size = new System.Drawing.Size(92, 17);
            this.checkBoxProcessName.TabIndex = 2;
            this.checkBoxProcessName.Text = "ProcessName";
            this.checkBoxProcessName.UseVisualStyleBackColor = true;
            // 
            // checkBoxTID
            // 
            this.checkBoxTID.AutoSize = true;
            this.checkBoxTID.Checked = true;
            this.checkBoxTID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTID.Location = new System.Drawing.Point(132, 30);
            this.checkBoxTID.Name = "checkBoxTID";
            this.checkBoxTID.Size = new System.Drawing.Size(44, 17);
            this.checkBoxTID.TabIndex = 1;
            this.checkBoxTID.Text = "TID";
            this.checkBoxTID.UseVisualStyleBackColor = true;
            // 
            // checkBoxPID
            // 
            this.checkBoxPID.AutoSize = true;
            this.checkBoxPID.Checked = true;
            this.checkBoxPID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPID.Location = new System.Drawing.Point(7, 30);
            this.checkBoxPID.Name = "checkBoxPID";
            this.checkBoxPID.Size = new System.Drawing.Size(44, 17);
            this.checkBoxPID.TabIndex = 0;
            this.checkBoxPID.Text = "PID";
            this.checkBoxPID.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select columns to appear in the Procnoid window:";
            // 
            // groupBoxRPC
            // 
            this.groupBoxRPC.Controls.Add(this.checkBoxImpersonationLevel);
            this.groupBoxRPC.Controls.Add(this.checkBoxAuthenticationLevel);
            this.groupBoxRPC.Controls.Add(this.checkBoxAuthenticationService);
            this.groupBoxRPC.Controls.Add(this.checkBoxOptions);
            this.groupBoxRPC.Controls.Add(this.checkBoxEndpoint);
            this.groupBoxRPC.Controls.Add(this.checkBoxProtocol);
            this.groupBoxRPC.Controls.Add(this.checkBoxNetworkAddress);
            this.groupBoxRPC.Location = new System.Drawing.Point(12, 253);
            this.groupBoxRPC.Name = "groupBoxRPC";
            this.groupBoxRPC.Size = new System.Drawing.Size(272, 122);
            this.groupBoxRPC.TabIndex = 3;
            this.groupBoxRPC.TabStop = false;
            this.groupBoxRPC.Text = "RPC Misc";
            // 
            // checkBoxImpersonationLevel
            // 
            this.checkBoxImpersonationLevel.AutoSize = true;
            this.checkBoxImpersonationLevel.Checked = true;
            this.checkBoxImpersonationLevel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxImpersonationLevel.Location = new System.Drawing.Point(8, 97);
            this.checkBoxImpersonationLevel.Name = "checkBoxImpersonationLevel";
            this.checkBoxImpersonationLevel.Size = new System.Drawing.Size(118, 17);
            this.checkBoxImpersonationLevel.TabIndex = 8;
            this.checkBoxImpersonationLevel.Text = "ImpersonationLevel";
            this.checkBoxImpersonationLevel.UseVisualStyleBackColor = true;
            // 
            // checkBoxAuthenticationLevel
            // 
            this.checkBoxAuthenticationLevel.AutoSize = true;
            this.checkBoxAuthenticationLevel.Location = new System.Drawing.Point(7, 74);
            this.checkBoxAuthenticationLevel.Name = "checkBoxAuthenticationLevel";
            this.checkBoxAuthenticationLevel.Size = new System.Drawing.Size(120, 17);
            this.checkBoxAuthenticationLevel.TabIndex = 7;
            this.checkBoxAuthenticationLevel.Text = "AuthenticationLevel";
            this.checkBoxAuthenticationLevel.UseVisualStyleBackColor = true;
            // 
            // checkBoxAuthenticationService
            // 
            this.checkBoxAuthenticationService.AutoSize = true;
            this.checkBoxAuthenticationService.Location = new System.Drawing.Point(133, 74);
            this.checkBoxAuthenticationService.Name = "checkBoxAuthenticationService";
            this.checkBoxAuthenticationService.Size = new System.Drawing.Size(130, 17);
            this.checkBoxAuthenticationService.TabIndex = 6;
            this.checkBoxAuthenticationService.Text = "AuthenticationService";
            this.checkBoxAuthenticationService.UseVisualStyleBackColor = true;
            // 
            // checkBoxOptions
            // 
            this.checkBoxOptions.AutoSize = true;
            this.checkBoxOptions.Location = new System.Drawing.Point(133, 51);
            this.checkBoxOptions.Name = "checkBoxOptions";
            this.checkBoxOptions.Size = new System.Drawing.Size(62, 17);
            this.checkBoxOptions.TabIndex = 5;
            this.checkBoxOptions.Text = "Options";
            this.checkBoxOptions.UseVisualStyleBackColor = true;
            // 
            // checkBoxEndpoint
            // 
            this.checkBoxEndpoint.AutoSize = true;
            this.checkBoxEndpoint.Checked = true;
            this.checkBoxEndpoint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEndpoint.Location = new System.Drawing.Point(7, 51);
            this.checkBoxEndpoint.Name = "checkBoxEndpoint";
            this.checkBoxEndpoint.Size = new System.Drawing.Size(68, 17);
            this.checkBoxEndpoint.TabIndex = 4;
            this.checkBoxEndpoint.Text = "Endpoint";
            this.checkBoxEndpoint.UseVisualStyleBackColor = true;
            // 
            // checkBoxProtocol
            // 
            this.checkBoxProtocol.AutoSize = true;
            this.checkBoxProtocol.Checked = true;
            this.checkBoxProtocol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxProtocol.Location = new System.Drawing.Point(133, 28);
            this.checkBoxProtocol.Name = "checkBoxProtocol";
            this.checkBoxProtocol.Size = new System.Drawing.Size(65, 17);
            this.checkBoxProtocol.TabIndex = 3;
            this.checkBoxProtocol.Text = "Protocol";
            this.checkBoxProtocol.UseVisualStyleBackColor = true;
            // 
            // checkBoxNetworkAddress
            // 
            this.checkBoxNetworkAddress.AutoSize = true;
            this.checkBoxNetworkAddress.Location = new System.Drawing.Point(7, 28);
            this.checkBoxNetworkAddress.Name = "checkBoxNetworkAddress";
            this.checkBoxNetworkAddress.Size = new System.Drawing.Size(104, 17);
            this.checkBoxNetworkAddress.TabIndex = 2;
            this.checkBoxNetworkAddress.Text = "NetworkAddress";
            this.checkBoxNetworkAddress.UseVisualStyleBackColor = true;
            // 
            // checkBoxService
            // 
            this.checkBoxService.AutoSize = true;
            this.checkBoxService.Checked = true;
            this.checkBoxService.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxService.Location = new System.Drawing.Point(132, 76);
            this.checkBoxService.Name = "checkBoxService";
            this.checkBoxService.Size = new System.Drawing.Size(62, 17);
            this.checkBoxService.TabIndex = 1;
            this.checkBoxService.Text = "Service";
            this.checkBoxService.UseVisualStyleBackColor = true;
            // 
            // checkBoxUUID
            // 
            this.checkBoxUUID.AutoSize = true;
            this.checkBoxUUID.Checked = true;
            this.checkBoxUUID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUUID.Location = new System.Drawing.Point(6, 30);
            this.checkBoxUUID.Name = "checkBoxUUID";
            this.checkBoxUUID.Size = new System.Drawing.Size(53, 17);
            this.checkBoxUUID.TabIndex = 0;
            this.checkBoxUUID.Text = "UUID";
            this.checkBoxUUID.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(113, 391);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(209, 391);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxRPCServer
            // 
            this.groupBoxRPCServer.Controls.Add(this.checkBoxFunction);
            this.groupBoxRPCServer.Controls.Add(this.checkBoxModulePath);
            this.groupBoxRPCServer.Controls.Add(this.checkBoxModule);
            this.groupBoxRPCServer.Controls.Add(this.checkBoxProceduresCount);
            this.groupBoxRPCServer.Controls.Add(this.checkBoxUUID);
            this.groupBoxRPCServer.Controls.Add(this.checkBoxService);
            this.groupBoxRPCServer.Location = new System.Drawing.Point(12, 139);
            this.groupBoxRPCServer.Name = "groupBoxRPCServer";
            this.groupBoxRPCServer.Size = new System.Drawing.Size(272, 108);
            this.groupBoxRPCServer.TabIndex = 3;
            this.groupBoxRPCServer.TabStop = false;
            this.groupBoxRPCServer.Text = "RPC Server";
            // 
            // checkBoxModulePath
            // 
            this.checkBoxModulePath.AutoSize = true;
            this.checkBoxModulePath.Location = new System.Drawing.Point(6, 53);
            this.checkBoxModulePath.Name = "checkBoxModulePath";
            this.checkBoxModulePath.Size = new System.Drawing.Size(83, 17);
            this.checkBoxModulePath.TabIndex = 2;
            this.checkBoxModulePath.Text = "ModulePath";
            this.checkBoxModulePath.UseVisualStyleBackColor = true;
            // 
            // checkBoxModule
            // 
            this.checkBoxModule.AutoSize = true;
            this.checkBoxModule.Checked = true;
            this.checkBoxModule.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxModule.Location = new System.Drawing.Point(132, 30);
            this.checkBoxModule.Name = "checkBoxModule";
            this.checkBoxModule.Size = new System.Drawing.Size(61, 17);
            this.checkBoxModule.TabIndex = 1;
            this.checkBoxModule.Text = "Module";
            this.checkBoxModule.UseVisualStyleBackColor = true;
            // 
            // checkBoxProceduresCount
            // 
            this.checkBoxProceduresCount.AutoSize = true;
            this.checkBoxProceduresCount.Location = new System.Drawing.Point(132, 53);
            this.checkBoxProceduresCount.Name = "checkBoxProceduresCount";
            this.checkBoxProceduresCount.Size = new System.Drawing.Size(108, 17);
            this.checkBoxProceduresCount.TabIndex = 0;
            this.checkBoxProceduresCount.Text = "ProceduresCount";
            this.checkBoxProceduresCount.UseVisualStyleBackColor = true;
            // 
            // checkBoxFunction
            // 
            this.checkBoxFunction.AutoSize = true;
            this.checkBoxFunction.Checked = true;
            this.checkBoxFunction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFunction.Location = new System.Drawing.Point(7, 76);
            this.checkBoxFunction.Name = "checkBoxFunction";
            this.checkBoxFunction.Size = new System.Drawing.Size(67, 17);
            this.checkBoxFunction.TabIndex = 3;
            this.checkBoxFunction.Text = "Function";
            this.checkBoxFunction.UseVisualStyleBackColor = true;
            // 
            // ColumnSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 425);
            this.Controls.Add(this.groupBoxRPCServer);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxRPC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxProcessManagement);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColumnSelection";
            this.ShowIcon = false;
            this.Text = "RPC Monitor Column Selection";
            this.groupBoxProcessManagement.ResumeLayout(false);
            this.groupBoxProcessManagement.PerformLayout();
            this.groupBoxRPC.ResumeLayout(false);
            this.groupBoxRPC.PerformLayout();
            this.groupBoxRPCServer.ResumeLayout(false);
            this.groupBoxRPCServer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProcessManagement;
        private System.Windows.Forms.CheckBox checkBoxProcessName;
        private System.Windows.Forms.CheckBox checkBoxTID;
        private System.Windows.Forms.CheckBox checkBoxPID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxRPC;
        private System.Windows.Forms.CheckBox checkBoxImpersonationLevel;
        private System.Windows.Forms.CheckBox checkBoxAuthenticationLevel;
        private System.Windows.Forms.CheckBox checkBoxAuthenticationService;
        private System.Windows.Forms.CheckBox checkBoxOptions;
        private System.Windows.Forms.CheckBox checkBoxEndpoint;
        private System.Windows.Forms.CheckBox checkBoxProtocol;
        private System.Windows.Forms.CheckBox checkBoxNetworkAddress;
        private System.Windows.Forms.CheckBox checkBoxService;
        private System.Windows.Forms.CheckBox checkBoxUUID;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxRPCServer;
        private System.Windows.Forms.CheckBox checkBoxFunction;
        private System.Windows.Forms.CheckBox checkBoxModulePath;
        private System.Windows.Forms.CheckBox checkBoxModule;
        private System.Windows.Forms.CheckBox checkBoxProceduresCount;
    }
}