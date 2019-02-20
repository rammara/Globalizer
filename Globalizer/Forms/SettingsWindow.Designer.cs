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
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.LabelProjectRoot = new System.Windows.Forms.Label();
            this.TxtProjectRoot = new System.Windows.Forms.TextBox();
            this.BtnBrowseProject = new System.Windows.Forms.Button();
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
            this.tabSettings.Size = new System.Drawing.Size(736, 345);
            this.tabSettings.TabIndex = 0;
            // 
            // tabProject
            // 
            this.tabProject.Controls.Add(this.BtnBrowseProject);
            this.tabProject.Controls.Add(this.TxtProjectRoot);
            this.tabProject.Controls.Add(this.LabelProjectRoot);
            this.tabProject.Location = new System.Drawing.Point(4, 22);
            this.tabProject.Name = "tabProject";
            this.tabProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabProject.Size = new System.Drawing.Size(728, 319);
            this.tabProject.TabIndex = 1;
            this.tabProject.Text = "Project";
            this.tabProject.UseVisualStyleBackColor = true;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(728, 319);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // LabelProjectRoot
            // 
            this.LabelProjectRoot.AutoSize = true;
            this.LabelProjectRoot.Location = new System.Drawing.Point(18, 23);
            this.LabelProjectRoot.Name = "LabelProjectRoot";
            this.LabelProjectRoot.Size = new System.Drawing.Size(88, 13);
            this.LabelProjectRoot.TabIndex = 0;
            this.LabelProjectRoot.Text = "Project root path:";
            // 
            // TxtProjectRoot
            // 
            this.TxtProjectRoot.Location = new System.Drawing.Point(21, 40);
            this.TxtProjectRoot.Name = "TxtProjectRoot";
            this.TxtProjectRoot.ReadOnly = true;
            this.TxtProjectRoot.Size = new System.Drawing.Size(325, 20);
            this.TxtProjectRoot.TabIndex = 1;
            this.TxtProjectRoot.Text = "<Not set>";
            // 
            // BtnBrowseProject
            // 
            this.BtnBrowseProject.Location = new System.Drawing.Point(352, 38);
            this.BtnBrowseProject.Name = "BtnBrowseProject";
            this.BtnBrowseProject.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowseProject.TabIndex = 2;
            this.BtnBrowseProject.Text = "Browse...";
            this.BtnBrowseProject.UseVisualStyleBackColor = true;
            this.BtnBrowseProject.Click += new System.EventHandler(this.BtnBrowseProject_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 386);
            this.Controls.Add(this.tabSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsWindow";
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
        private System.Windows.Forms.Button BtnBrowseProject;
        private System.Windows.Forms.TextBox TxtProjectRoot;
        private System.Windows.Forms.Label LabelProjectRoot;
    }
}