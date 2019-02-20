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
            this.outerContainer = new System.Windows.Forms.ToolStripContainer();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectDelim1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuProjectExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.outerContainer.BottomToolStripPanel.SuspendLayout();
            this.outerContainer.TopToolStripPanel.SuspendLayout();
            this.outerContainer.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // outerContainer
            // 
            // 
            // outerContainer.BottomToolStripPanel
            // 
            this.outerContainer.BottomToolStripPanel.Controls.Add(this.statusBar);
            // 
            // outerContainer.ContentPanel
            // 
            this.outerContainer.ContentPanel.Size = new System.Drawing.Size(742, 561);
            this.outerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outerContainer.Location = new System.Drawing.Point(0, 0);
            this.outerContainer.Name = "outerContainer";
            this.outerContainer.Size = new System.Drawing.Size(742, 607);
            this.outerContainer.TabIndex = 0;
            this.outerContainer.Text = "toolStripContainer1";
            // 
            // outerContainer.TopToolStripPanel
            // 
            this.outerContainer.TopToolStripPanel.Controls.Add(this.mnuMain);
            // 
            // statusBar
            // 
            this.statusBar.Dock = System.Windows.Forms.DockStyle.None;
            this.statusBar.Location = new System.Drawing.Point(0, 0);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(742, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // menuMain
            // 
            this.mnuMain.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProject,
            this.mnuTools});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "menuMain";
            this.mnuMain.Size = new System.Drawing.Size(742, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            this.mnuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuMain_ItemClicked);
            // 
            // mnuProject
            // 
            this.mnuProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProjectNew,
            this.mnuProjectOpen,
            this.mnuProjectSave,
            this.mnuProjectSaveAs,
            this.mnuProjectDelim1,
            this.mnuProjectExit});
            this.mnuProject.Name = "mnuProject";
            this.mnuProject.Size = new System.Drawing.Size(56, 20);
            this.mnuProject.Text = "&Project";
            // 
            // mnuProjectNew
            // 
            this.mnuProjectNew.Name = "mnuProjectNew";
            this.mnuProjectNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuProjectNew.Size = new System.Drawing.Size(155, 22);
            this.mnuProjectNew.Text = "&New...";
            // 
            // mnuProjectOpen
            // 
            this.mnuProjectOpen.Name = "mnuProjectOpen";
            this.mnuProjectOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuProjectOpen.Size = new System.Drawing.Size(155, 22);
            this.mnuProjectOpen.Text = "&Open...";
            // 
            // mnuProjectSave
            // 
            this.mnuProjectSave.Name = "mnuProjectSave";
            this.mnuProjectSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuProjectSave.Size = new System.Drawing.Size(155, 22);
            this.mnuProjectSave.Text = "&Save";
            // 
            // mnuProjectSaveAs
            // 
            this.mnuProjectSaveAs.Name = "mnuProjectSaveAs";
            this.mnuProjectSaveAs.Size = new System.Drawing.Size(155, 22);
            this.mnuProjectSaveAs.Text = "Save &As...";
            // 
            // mnuProjectDelim1
            // 
            this.mnuProjectDelim1.Name = "mnuProjectDelim1";
            this.mnuProjectDelim1.Size = new System.Drawing.Size(152, 6);
            // 
            // mnuProjectExit
            // 
            this.mnuProjectExit.Name = "mnuProjectExit";
            this.mnuProjectExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuProjectExit.Size = new System.Drawing.Size(155, 22);
            this.mnuProjectExit.Text = "E&xit";
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolsSettings});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(48, 20);
            this.mnuTools.Text = "&Tools";
            // 
            // mnuToolsSettings
            // 
            this.mnuToolsSettings.Name = "mnuToolsSettings";
            this.mnuToolsSettings.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.mnuToolsSettings.Size = new System.Drawing.Size(150, 22);
            this.mnuToolsSettings.Text = "&Settings...";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 607);
            this.Controls.Add(this.outerContainer);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "MainWindow";
            this.Text = "String Refactoring";
            this.outerContainer.BottomToolStripPanel.ResumeLayout(false);
            this.outerContainer.BottomToolStripPanel.PerformLayout();
            this.outerContainer.TopToolStripPanel.ResumeLayout(false);
            this.outerContainer.TopToolStripPanel.PerformLayout();
            this.outerContainer.ResumeLayout(false);
            this.outerContainer.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.ToolStripContainer outerContainer;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuProject;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectNew;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectSave;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectSaveAs;
        private System.Windows.Forms.ToolStripSeparator mnuProjectDelim1;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectExit;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuToolsSettings;
    }
}

