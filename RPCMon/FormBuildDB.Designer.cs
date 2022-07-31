using System.Drawing;
using System.Windows.Forms;

namespace RPCMon
{
    partial class FormBuildDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuildDB));
            this.buttonBuild = new System.Windows.Forms.Button();
            this.labelRPCFolder = new System.Windows.Forms.Label();
            this.textBoxFolderForRPC = new System.Windows.Forms.TextBox();
            this.checkBoxRecursive = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listViewRPCFiles = new System.Windows.Forms.ListView();
            this.columnHeaderFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHasRpc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonStop = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTotalFiles = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelRPCFiles = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSaveFile = new System.Windows.Forms.TextBox();
            this.buttonJumpFolder = new System.Windows.Forms.Button();
            this.toolTipJumpButton = new System.Windows.Forms.ToolTip(this.components);
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxExcludedFolders = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBuild
            // 
            this.buttonBuild.Location = new System.Drawing.Point(12, 100);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(75, 23);
            this.buttonBuild.TabIndex = 0;
            this.buttonBuild.Text = "Build";
            this.buttonBuild.UseVisualStyleBackColor = true;
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // labelRPCFolder
            // 
            this.labelRPCFolder.AutoSize = true;
            this.labelRPCFolder.Location = new System.Drawing.Point(12, 23);
            this.labelRPCFolder.Name = "labelRPCFolder";
            this.labelRPCFolder.Size = new System.Drawing.Size(82, 13);
            this.labelRPCFolder.TabIndex = 1;
            this.labelRPCFolder.Text = "Folder for RPC: ";
            // 
            // textBoxFolderForRPC
            // 
            this.textBoxFolderForRPC.Location = new System.Drawing.Point(100, 20);
            this.textBoxFolderForRPC.Name = "textBoxFolderForRPC";
            this.textBoxFolderForRPC.Size = new System.Drawing.Size(244, 20);
            this.textBoxFolderForRPC.TabIndex = 2;
            this.textBoxFolderForRPC.Text = "C:\\Windows";
            // 
            // checkBoxRecursive
            // 
            this.checkBoxRecursive.AutoSize = true;
            this.checkBoxRecursive.Location = new System.Drawing.Point(100, 46);
            this.checkBoxRecursive.Name = "checkBoxRecursive";
            this.checkBoxRecursive.Size = new System.Drawing.Size(74, 17);
            this.checkBoxRecursive.TabIndex = 3;
            this.checkBoxRecursive.Text = "Recursive";
            this.checkBoxRecursive.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "*.exe",
            "*.dll",
            "*.com"});
            this.comboBox1.Location = new System.Drawing.Point(359, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // listViewRPCFiles
            // 
            this.listViewRPCFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewRPCFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFileName,
            this.columnHeaderHasRpc});
            this.listViewRPCFiles.HideSelection = false;
            this.listViewRPCFiles.Location = new System.Drawing.Point(2, 178);
            this.listViewRPCFiles.Name = "listViewRPCFiles";
            this.listViewRPCFiles.Size = new System.Drawing.Size(555, 314);
            this.listViewRPCFiles.TabIndex = 8;
            this.listViewRPCFiles.UseCompatibleStateImageBehavior = false;
            this.listViewRPCFiles.View = System.Windows.Forms.View.Details;
            this.listViewRPCFiles.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewRPCFiles_ColumnClick);
            // 
            // columnHeaderFileName
            // 
            this.columnHeaderFileName.Text = "File Name";
            this.columnHeaderFileName.Width = 125;
            // 
            // columnHeaderHasRpc
            // 
            this.columnHeaderHasRpc.Text = "Has RPC?";
            this.columnHeaderHasRpc.Width = 83;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(100, 100);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 9;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTotalFiles,
            this.toolStripStatusLabelRPCFiles});
            this.statusStrip1.Location = new System.Drawing.Point(0, 498);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(555, 24);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTotalFiles
            // 
            this.toolStripStatusLabelTotalFiles.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabelTotalFiles.Name = "toolStripStatusLabelTotalFiles";
            this.toolStripStatusLabelTotalFiles.Size = new System.Drawing.Size(125, 19);
            this.toolStripStatusLabelTotalFiles.Text = "Total Searched Files: 0";
            // 
            // toolStripStatusLabelRPCFiles
            // 
            this.toolStripStatusLabelRPCFiles.Name = "toolStripStatusLabelRPCFiles";
            this.toolStripStatusLabelRPCFiles.Size = new System.Drawing.Size(67, 19);
            this.toolStripStatusLabelRPCFiles.Text = "RPC Files: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Saved File Path: ";
            // 
            // textBoxSaveFile
            // 
            this.textBoxSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSaveFile.Location = new System.Drawing.Point(100, 138);
            this.textBoxSaveFile.Name = "textBoxSaveFile";
            this.textBoxSaveFile.Size = new System.Drawing.Size(400, 20);
            this.textBoxSaveFile.TabIndex = 12;
            // 
            // buttonJumpFolder
            // 
            this.buttonJumpFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonJumpFolder.BackColor = System.Drawing.Color.Transparent;
            this.buttonJumpFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonJumpFolder.FlatAppearance.BorderSize = 0;
            this.buttonJumpFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJumpFolder.Image = ((System.Drawing.Image)(resources.GetObject("buttonJumpFolder.Image")));
            this.buttonJumpFolder.Location = new System.Drawing.Point(506, 136);
            this.buttonJumpFolder.Name = "buttonJumpFolder";
            this.buttonJumpFolder.Size = new System.Drawing.Size(25, 22);
            this.buttonJumpFolder.TabIndex = 13;
            this.buttonJumpFolder.TabStop = false;
            this.buttonJumpFolder.UseVisualStyleBackColor = false;
            this.buttonJumpFolder.Click += new System.EventHandler(this.button1_Click);
            this.buttonJumpFolder.MouseLeave += new System.EventHandler(this.buttonJumpFolder_MouseLeave);
            this.buttonJumpFolder.MouseHover += new System.EventHandler(this.buttonJumpFolder_MouseHover);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(191, 100);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxExcludedFolders
            // 
            this.textBoxExcludedFolders.Location = new System.Drawing.Point(100, 69);
            this.textBoxExcludedFolders.Name = "textBoxExcludedFolders";
            this.textBoxExcludedFolders.Size = new System.Drawing.Size(244, 20);
            this.textBoxExcludedFolders.TabIndex = 16;
            this.textBoxExcludedFolders.Text = "C:\\Windows\\WinSxS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Exclude Folders: ";
            // 
            // FormBuildDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 522);
            this.Controls.Add(this.textBoxExcludedFolders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonJumpFolder);
            this.Controls.Add(this.textBoxSaveFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.listViewRPCFiles);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBoxRecursive);
            this.Controls.Add(this.textBoxFolderForRPC);
            this.Controls.Add(this.labelRPCFolder);
            this.Controls.Add(this.buttonBuild);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuildDB";
            this.ShowIcon = false;
            this.Text = "Build DB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBuildDB_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuild;
        private System.Windows.Forms.Label labelRPCFolder;
        private System.Windows.Forms.TextBox textBoxFolderForRPC;
        private System.Windows.Forms.CheckBox checkBoxRecursive;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listViewRPCFiles;
        private System.Windows.Forms.ColumnHeader columnHeaderFileName;
        private System.Windows.Forms.ColumnHeader columnHeaderHasRpc;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTotalFiles;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRPCFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSaveFile;
        private System.Windows.Forms.Button buttonJumpFolder;
        private ToolTip toolTipJumpButton;
        private Button buttonClear;
        private TextBox textBoxExcludedFolders;
        private Label label2;
    }
}