namespace RPCMon
{
    partial class ColumnFilter
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSearchByColumn = new System.Windows.Forms.ComboBox();
            this.comboBoxRelation = new System.Windows.Forms.ComboBox();
            this.comboBoxValue = new System.Windows.Forms.ComboBox();
            this.listViewColumnFilters = new System.Windows.Forms.ListView();
            this.columnHeaderColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRelation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMatchCase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxAction = new System.Windows.Forms.ComboBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelThen = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.CaseSensitiveCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display entried matching these conditions:";
            // 
            // comboBoxSearchByColumn
            // 
            this.comboBoxSearchByColumn.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxSearchByColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchByColumn.FormattingEnabled = true;
            this.comboBoxSearchByColumn.Items.AddRange(new object[] {
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
            this.comboBoxSearchByColumn.Location = new System.Drawing.Point(16, 31);
            this.comboBoxSearchByColumn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSearchByColumn.Name = "comboBoxSearchByColumn";
            this.comboBoxSearchByColumn.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSearchByColumn.TabIndex = 1;
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
            this.comboBoxRelation.Location = new System.Drawing.Point(187, 32);
            this.comboBoxRelation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxRelation.Name = "comboBoxRelation";
            this.comboBoxRelation.Size = new System.Drawing.Size(115, 24);
            this.comboBoxRelation.TabIndex = 2;
            // 
            // comboBoxValue
            // 
            this.comboBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxValue.FormattingEnabled = true;
            this.comboBoxValue.Location = new System.Drawing.Point(325, 31);
            this.comboBoxValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxValue.Name = "comboBoxValue";
            this.comboBoxValue.Size = new System.Drawing.Size(548, 24);
            this.comboBoxValue.TabIndex = 3;
            // 
            // listViewColumnFilters
            // 
            this.listViewColumnFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewColumnFilters.CheckBoxes = true;
            this.listViewColumnFilters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderColumn,
            this.columnHeaderRelation,
            this.columnHeaderValue,
            this.columnHeaderAction,
            this.columnMatchCase});
            this.listViewColumnFilters.HideSelection = false;
            this.listViewColumnFilters.Location = new System.Drawing.Point(20, 105);
            this.listViewColumnFilters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewColumnFilters.Name = "listViewColumnFilters";
            this.listViewColumnFilters.Size = new System.Drawing.Size(1033, 383);
            this.listViewColumnFilters.TabIndex = 4;
            this.listViewColumnFilters.UseCompatibleStateImageBehavior = false;
            this.listViewColumnFilters.View = System.Windows.Forms.View.Details;
            this.listViewColumnFilters.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewColumnFilters_MouseDoubleClick);
            // 
            // columnHeaderColumn
            // 
            this.columnHeaderColumn.Text = "Column";
            this.columnHeaderColumn.Width = 92;
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
            // columnMatchCase
            // 
            this.columnMatchCase.Text = "Case Sensitive";
            this.columnMatchCase.Width = 87;
            // 
            // comboBoxAction
            // 
            this.comboBoxAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAction.FormattingEnabled = true;
            this.comboBoxAction.Items.AddRange(new object[] {
            "Include",
            "Exclude"});
            this.comboBoxAction.Location = new System.Drawing.Point(939, 31);
            this.comboBoxAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxAction.Name = "comboBoxAction";
            this.comboBoxAction.Size = new System.Drawing.Size(111, 24);
            this.comboBoxAction.TabIndex = 5;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(735, 511);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(843, 511);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(831, 69);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Location = new System.Drawing.Point(951, 69);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(100, 28);
            this.buttonRemove.TabIndex = 9;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // labelThen
            // 
            this.labelThen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelThen.AutoSize = true;
            this.labelThen.Location = new System.Drawing.Point(883, 34);
            this.labelThen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelThen.Name = "labelThen";
            this.labelThen.Size = new System.Drawing.Size(36, 17);
            this.labelThen.TabIndex = 10;
            this.labelThen.Text = "then";
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Location = new System.Drawing.Point(20, 69);
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
            this.buttonApply.Location = new System.Drawing.Point(955, 511);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(100, 28);
            this.buttonApply.TabIndex = 13;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // CaseSensitiveCheckBox
            // 
            this.CaseSensitiveCheckBox.AutoSize = true;
            this.CaseSensitiveCheckBox.Location = new System.Drawing.Point(325, 65);
            this.CaseSensitiveCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CaseSensitiveCheckBox.Name = "CaseSensitiveCheckBox";
            this.CaseSensitiveCheckBox.Size = new System.Drawing.Size(104, 21);
            this.CaseSensitiveCheckBox.TabIndex = 14;
            this.CaseSensitiveCheckBox.Text = "Match Case";
            this.CaseSensitiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // ColumnFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.CaseSensitiveCheckBox);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelThen);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.comboBoxAction);
            this.Controls.Add(this.listViewColumnFilters);
            this.Controls.Add(this.comboBoxValue);
            this.Controls.Add(this.comboBoxRelation);
            this.Controls.Add(this.comboBoxSearchByColumn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ColumnFilter";
            this.ShowIcon = false;
            this.Text = "RPCMon Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSearchByColumn;
        private System.Windows.Forms.ComboBox comboBoxRelation;
        private System.Windows.Forms.ComboBox comboBoxValue;
        private System.Windows.Forms.ListView listViewColumnFilters;
        private System.Windows.Forms.ColumnHeader columnHeaderColumn;
        private System.Windows.Forms.ColumnHeader columnHeaderRelation;
        private System.Windows.Forms.ColumnHeader columnHeaderValue;
        private System.Windows.Forms.ColumnHeader columnHeaderAction;
        private System.Windows.Forms.ComboBox comboBoxAction;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label labelThen;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.ColumnHeader columnMatchCase;
        private System.Windows.Forms.CheckBox CaseSensitiveCheckBox;
    }
}