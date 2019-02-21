namespace Globalizer.Forms
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mnuStripMain = new System.Windows.Forms.MenuStrip();
            this.mnuProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectDelim1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuProjectExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStripMain
            // 
            resources.ApplyResources(this.mnuStripMain, "mnuStripMain");
            this.mnuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProject,
            this.mnuTools});
            this.mnuStripMain.Name = "mnuStripMain";
            // 
            // mnuProject
            // 
            resources.ApplyResources(this.mnuProject, "mnuProject");
            this.mnuProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProjectNew,
            this.mnuProjectOpen,
            this.mnuProjectSave,
            this.mnuProjectSaveAs,
            this.mnuProjectDelim1,
            this.mnuProjectExit});
            this.mnuProject.Name = "mnuProject";
            // 
            // mnuProjectNew
            // 
            resources.ApplyResources(this.mnuProjectNew, "mnuProjectNew");
            this.mnuProjectNew.Name = "mnuProjectNew";
            this.mnuProjectNew.Click += new System.EventHandler(this.mnuProjectNew_Click);
            // 
            // mnuProjectOpen
            // 
            resources.ApplyResources(this.mnuProjectOpen, "mnuProjectOpen");
            this.mnuProjectOpen.Name = "mnuProjectOpen";
            this.mnuProjectOpen.Click += new System.EventHandler(this.mnuProjectOpen_Click);
            // 
            // mnuProjectSave
            // 
            resources.ApplyResources(this.mnuProjectSave, "mnuProjectSave");
            this.mnuProjectSave.Name = "mnuProjectSave";
            this.mnuProjectSave.Click += new System.EventHandler(this.mnuProjectSave_Click);
            // 
            // mnuProjectSaveAs
            // 
            resources.ApplyResources(this.mnuProjectSaveAs, "mnuProjectSaveAs");
            this.mnuProjectSaveAs.Name = "mnuProjectSaveAs";
            this.mnuProjectSaveAs.Click += new System.EventHandler(this.mnuProjectSaveAs_Click);
            // 
            // mnuProjectDelim1
            // 
            resources.ApplyResources(this.mnuProjectDelim1, "mnuProjectDelim1");
            this.mnuProjectDelim1.Name = "mnuProjectDelim1";
            // 
            // mnuProjectExit
            // 
            resources.ApplyResources(this.mnuProjectExit, "mnuProjectExit");
            this.mnuProjectExit.Name = "mnuProjectExit";
            this.mnuProjectExit.Click += new System.EventHandler(this.mnuProjectExit_Click);
            // 
            // mnuTools
            // 
            resources.ApplyResources(this.mnuTools, "mnuTools");
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolsSettings});
            this.mnuTools.Name = "mnuTools";
            // 
            // mnuToolsSettings
            // 
            resources.ApplyResources(this.mnuToolsSettings, "mnuToolsSettings");
            this.mnuToolsSettings.Name = "mnuToolsSettings";
            this.mnuToolsSettings.Click += new System.EventHandler(this.mnuToolsSettings_Click);
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mnuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuStripMain;
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.mnuStripMain.ResumeLayout(false);
            this.mnuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuProject;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectNew;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectSave;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectSaveAs;
        private System.Windows.Forms.ToolStripSeparator mnuProjectDelim1;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectExit;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuToolsSettings;
        private System.Windows.Forms.MenuStrip mnuStripMain;
    }
}

