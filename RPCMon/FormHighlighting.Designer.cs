namespace RPCMon
{
    partial class FormHighlighting
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
            this.labelHighlight = new System.Windows.Forms.Label();
            this.comboBoxColumn = new System.Windows.Forms.ComboBox();
            this.comboBoxRelation = new System.Windows.Forms.ComboBox();
            this.comboBoxValue = new System.Windows.Forms.ComboBox();
            this.labelThen = new System.Windows.Forms.Label();
            this.comboBoxAction = new System.Windows.Forms.ComboBox();
            this.listViewHighlights = new System.Windows.Forms.ListView();
            this.columnHeaderColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRelation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCaseSensitive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.CaseSensitiveCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelHighlight
            // 
            this.labelHighlight.AutoSize = true;
            this.labelHighlight.Location = new System.Drawing.Point(16, 11);
            this.labelHighlight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHighlight.Name = "labelHighlight";
            this.labelHighlight.Size = new System.Drawing.Size(282, 17);
            this.labelHighlight.TabIndex = 0;
            this.labelHighlight.Text = "Highlight entries matching these conditions:";
            // 
            // comboBoxColumn
            // 
            this.comboBoxColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColumn.FormattingEnabled = true;
            this.comboBoxColumn.Items.AddRange(new object[] {
            "PID",
            "TID",
            "ProcessName",
            "UUID",
            "Module",
            "ModulePath",
            "ProceduresCount",
            "Service",
            "Function",
            "NetworkAddress",
            "Protocol",
            "Endpoint",
            "Options",
            "AuthenticationLevel",
            "AuthenticationService",
            "ImpersonationLevel",
            "TimeStamp",
            "TaskName"});
            this.comboBoxColumn.Location = new System.Drawing.Point(16, 31);
            this.comboBoxColumn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxColumn.Name = "comboBoxColumn";
            this.comboBoxColumn.Size = new System.Drawing.Size(160, 24);
            this.comboBoxColumn.TabIndex = 1;
            // 
            // comboBoxRelation
            // 
            this.comboBoxRelation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRelation.FormattingEnabled = true;
            this.comboBoxRelation.Items.AddRange(new object[] {
            "contains",
            "is",
            "begins with",
            "ends with"});
            this.comboBoxRelation.Location = new System.Drawing.Point(185, 31);
            this.comboBoxRelation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxRelation.Name = "comboBoxRelation";
            this.comboBoxRelation.Size = new System.Drawing.Size(93, 24);
            this.comboBoxRelation.TabIndex = 2;
            // 
            // comboBoxValue
            // 
            this.comboBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxValue.FormattingEnabled = true;
            this.comboBoxValue.Location = new System.Drawing.Point(288, 31);
            this.comboBoxValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxValue.Name = "comboBoxValue";
            this.comboBoxValue.Size = new System.Drawing.Size(395, 24);
            this.comboBoxValue.TabIndex = 3;
            // 
            // labelThen
            // 
            this.labelThen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelThen.AutoSize = true;
            this.labelThen.Location = new System.Drawing.Point(692, 31);
            this.labelThen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelThen.Name = "labelThen";
            this.labelThen.Size = new System.Drawing.Size(36, 17);
            this.labelThen.TabIndex = 4;
            this.labelThen.Text = "then";
            // 
            // comboBoxAction
            // 
            this.comboBoxAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAction.FormattingEnabled = true;
            this.comboBoxAction.Items.AddRange(new object[] {
            "Include",
            "Exclude"});
            this.comboBoxAction.Location = new System.Drawing.Point(743, 27);
            this.comboBoxAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxAction.Name = "comboBoxAction";
            this.comboBoxAction.Size = new System.Drawing.Size(93, 24);
            this.comboBoxAction.TabIndex = 5;
            // 
            // listViewHighlights
            // 
            this.listViewHighlights.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewHighlights.CheckBoxes = true;
            this.listViewHighlights.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderColumn,
            this.columnHeaderRelation,
            this.columnHeaderValue,
            this.columnHeaderAction,
            this.columnCaseSensitive});
            this.listViewHighlights.HideSelection = false;
            this.listViewHighlights.Location = new System.Drawing.Point(16, 105);
            this.listViewHighlights.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewHighlights.Name = "listViewHighlights";
            this.listViewHighlights.Size = new System.Drawing.Size(824, 328);
            this.listViewHighlights.TabIndex = 6;
            this.listViewHighlights.UseCompatibleStateImageBehavior = false;
            this.listViewHighlights.View = System.Windows.Forms.View.Details;
            this.listViewHighlights.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewHighlights_MouseDoubleClick);
            // 
            // columnHeaderColumn
            // 
            this.columnHeaderColumn.Text = "Column";
            // 
            // columnHeaderRelation
            // 
            this.columnHeaderRelation.Text = "Relation";
            // 
            // columnHeaderValue
            // 
            this.columnHeaderValue.Text = "Value";
            // 
            // columnHeaderAction
            // 
            this.columnHeaderAction.Text = "Action";
            // 
            // columnCaseSensitive
            // 
            this.columnCaseSensitive.Text = "Match Case";
            this.columnCaseSensitive.Width = 90;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(521, 441);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(629, 441);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(629, 69);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Location = new System.Drawing.Point(737, 69);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(100, 28);
            this.buttonRemove.TabIndex = 10;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Location = new System.Drawing.Point(16, 69);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 28);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Location = new System.Drawing.Point(737, 441);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(100, 28);
            this.buttonApply.TabIndex = 12;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // CaseSensitiveCheckBox
            // 
            this.CaseSensitiveCheckBox.AutoSize = true;
            this.CaseSensitiveCheckBox.Location = new System.Drawing.Point(288, 65);
            this.CaseSensitiveCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CaseSensitiveCheckBox.Name = "CaseSensitiveCheckBox";
            this.CaseSensitiveCheckBox.Size = new System.Drawing.Size(104, 21);
            this.CaseSensitiveCheckBox.TabIndex = 13;
            this.CaseSensitiveCheckBox.Text = "Match Case";
            this.CaseSensitiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // FormHighlighting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 484);
            this.Controls.Add(this.CaseSensitiveCheckBox);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.listViewHighlights);
            this.Controls.Add(this.comboBoxAction);
            this.Controls.Add(this.labelThen);
            this.Controls.Add(this.comboBoxValue);
            this.Controls.Add(this.comboBoxRelation);
            this.Controls.Add(this.comboBoxColumn);
            this.Controls.Add(this.labelHighlight);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHighlighting";
            this.ShowIcon = false;
            this.Text = "RPC Monitor Highlighting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHighlight;
        private System.Windows.Forms.ComboBox comboBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxRelation;
        private System.Windows.Forms.ComboBox comboBoxValue;
        private System.Windows.Forms.Label labelThen;
        private System.Windows.Forms.ComboBox comboBoxAction;
        private System.Windows.Forms.ListView listViewHighlights;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ColumnHeader columnHeaderColumn;
        private System.Windows.Forms.ColumnHeader columnHeaderRelation;
        private System.Windows.Forms.ColumnHeader columnHeaderValue;
        private System.Windows.Forms.ColumnHeader columnHeaderAction;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.ColumnHeader columnCaseSensitive;
        private System.Windows.Forms.CheckBox CaseSensitiveCheckBox;
    }
}