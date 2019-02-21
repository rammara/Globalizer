namespace Globalizer.Forms
{
    partial class SettingsWindow
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
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabProject = new System.Windows.Forms.TabPage();
            this.TextEncodingCP = new System.Windows.Forms.TextBox();
            this.LabelEncoding = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextProjectName = new System.Windows.Forms.TextBox();
            this.LabelFileMask = new System.Windows.Forms.Label();
            this.TextFileMask = new System.Windows.Forms.TextBox();
            this.TextRegExp = new System.Windows.Forms.TextBox();
            this.LabelSearchPattern = new System.Windows.Forms.Label();
            this.BtnBrowsePath = new System.Windows.Forms.Button();
            this.TextProjectRoot = new System.Windows.Forms.TextBox();
            this.LabelProjectRoot = new System.Windows.Forms.Label();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.tabSettings.SuspendLayout();
            this.tabProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSettings
            // 
            this.tabSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSettings.Controls.Add(this.tabProject);
            this.tabSettings.Controls.Add(this.tabGeneral);
            this.tabSettings.Location = new System.Drawing.Point(12, 29);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(459, 341);
            this.tabSettings.TabIndex = 0;
            // 
            // tabProject
            // 
            this.tabProject.Controls.Add(this.TextEncodingCP);
            this.tabProject.Controls.Add(this.LabelEncoding);
            this.tabProject.Controls.Add(this.label1);
            this.tabProject.Controls.Add(this.TextProjectName);
            this.tabProject.Controls.Add(this.LabelFileMask);
            this.tabProject.Controls.Add(this.TextFileMask);
            this.tabProject.Controls.Add(this.TextRegExp);
            this.tabProject.Controls.Add(this.LabelSearchPattern);
            this.tabProject.Controls.Add(this.BtnBrowsePath);
            this.tabProject.Controls.Add(this.TextProjectRoot);
            this.tabProject.Controls.Add(this.LabelProjectRoot);
            this.tabProject.Location = new System.Drawing.Point(4, 22);
            this.tabProject.Name = "tabProject";
            this.tabProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabProject.Size = new System.Drawing.Size(451, 315);
            this.tabProject.TabIndex = 1;
            this.tabProject.Text = "Project";
            this.tabProject.UseVisualStyleBackColor = true;
            // 
            // TextEncodingCP
            // 
            this.TextEncodingCP.Location = new System.Drawing.Point(22, 271);
            this.TextEncodingCP.Name = "TextEncodingCP";
            this.TextEncodingCP.Size = new System.Drawing.Size(100, 20);
            this.TextEncodingCP.TabIndex = 10;
            // 
            // LabelEncoding
            // 
            this.LabelEncoding.AutoSize = true;
            this.LabelEncoding.Location = new System.Drawing.Point(20, 248);
            this.LabelEncoding.Name = "LabelEncoding";
            this.LabelEncoding.Size = new System.Drawing.Size(221, 13);
            this.LabelEncoding.TabIndex = 9;
            this.LabelEncoding.Text = "Encoding code page (leave blank for UTF-8):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Poject name:";
            // 
            // TextProjectName
            // 
            this.TextProjectName.Location = new System.Drawing.Point(22, 31);
            this.TextProjectName.Name = "TextProjectName";
            this.TextProjectName.Size = new System.Drawing.Size(325, 20);
            this.TextProjectName.TabIndex = 1;
            this.TextProjectName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // LabelFileMask
            // 
            this.LabelFileMask.AutoSize = true;
            this.LabelFileMask.Location = new System.Drawing.Point(17, 189);
            this.LabelFileMask.Name = "LabelFileMask";
            this.LabelFileMask.Size = new System.Drawing.Size(72, 13);
            this.LabelFileMask.TabIndex = 6;
            this.LabelFileMask.Text = "Search mask:";
            // 
            // TextFileMask
            // 
            this.TextFileMask.Location = new System.Drawing.Point(20, 205);
            this.TextFileMask.Name = "TextFileMask";
            this.TextFileMask.Size = new System.Drawing.Size(325, 20);
            this.TextFileMask.TabIndex = 5;
            this.TextFileMask.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // TextRegExp
            // 
            this.TextRegExp.Location = new System.Drawing.Point(20, 146);
            this.TextRegExp.Name = "TextRegExp";
            this.TextRegExp.Size = new System.Drawing.Size(325, 20);
            this.TextRegExp.TabIndex = 4;
            this.TextRegExp.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // LabelSearchPattern
            // 
            this.LabelSearchPattern.AutoSize = true;
            this.LabelSearchPattern.Location = new System.Drawing.Point(17, 130);
            this.LabelSearchPattern.Name = "LabelSearchPattern";
            this.LabelSearchPattern.Size = new System.Drawing.Size(138, 13);
            this.LabelSearchPattern.TabIndex = 3;
            this.LabelSearchPattern.Text = "Quotes Regualr Expression:";
            // 
            // BtnBrowsePath
            // 
            this.BtnBrowsePath.Location = new System.Drawing.Point(351, 81);
            this.BtnBrowsePath.Name = "BtnBrowsePath";
            this.BtnBrowsePath.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowsePath.TabIndex = 3;
            this.BtnBrowsePath.Text = "Browse...";
            this.BtnBrowsePath.UseVisualStyleBackColor = true;
            this.BtnBrowsePath.Click += new System.EventHandler(this.BtnBrowseProject_Click);
            // 
            // TextProjectRoot
            // 
            this.TextProjectRoot.Location = new System.Drawing.Point(20, 83);
            this.TextProjectRoot.Name = "TextProjectRoot";
            this.TextProjectRoot.ReadOnly = true;
            this.TextProjectRoot.Size = new System.Drawing.Size(325, 20);
            this.TextProjectRoot.TabIndex = 2;
            this.TextProjectRoot.Text = "<Not set>";
            this.TextProjectRoot.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // LabelProjectRoot
            // 
            this.LabelProjectRoot.AutoSize = true;
            this.LabelProjectRoot.Location = new System.Drawing.Point(17, 66);
            this.LabelProjectRoot.Name = "LabelProjectRoot";
            this.LabelProjectRoot.Size = new System.Drawing.Size(88, 13);
            this.LabelProjectRoot.TabIndex = 0;
            this.LabelProjectRoot.Text = "Project root path:";
            // 
            // tabGeneral
            // 
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(451, 315);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // BtnOK
            // 
            this.BtnOK.Enabled = false;
            this.BtnOK.Location = new System.Drawing.Point(252, 375);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(109, 34);
            this.BtnOK.TabIndex = 7;
            this.BtnOK.Text = "&OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(367, 375);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(104, 34);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "&Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // SettingsWindow
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(483, 416);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.tabSettings);
            this.Controls.Add(this.BtnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.tabSettings.ResumeLayout(false);
            this.tabProject.ResumeLayout(false);
            this.tabProject.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabProject;
        private System.Windows.Forms.Button BtnBrowsePath;
        private System.Windows.Forms.TextBox TextProjectRoot;
        private System.Windows.Forms.Label LabelProjectRoot;
        private System.Windows.Forms.Label LabelFileMask;
        private System.Windows.Forms.TextBox TextFileMask;
        private System.Windows.Forms.TextBox TextRegExp;
        private System.Windows.Forms.Label LabelSearchPattern;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextProjectName;
        private System.Windows.Forms.TextBox TextEncodingCP;
        private System.Windows.Forms.Label LabelEncoding;
    }
}