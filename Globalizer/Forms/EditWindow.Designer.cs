﻿namespace Globalizer.Forms
{
    partial class EditWindow
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
            this.splitter = new System.Windows.Forms.SplitContainer();
            this.treeFileView = new System.Windows.Forms.TreeView();
            this.tableContents = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFileToolbar = new System.Windows.Forms.Panel();
            this.dgvEdit = new System.Windows.Forms.DataGridView();
            this.clnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnState = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mnuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSetStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetUnchanged = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetIgnored = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWorkInProgress = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetCompleted = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).BeginInit();
            this.splitter.Panel1.SuspendLayout();
            this.splitter.Panel2.SuspendLayout();
            this.splitter.SuspendLayout();
            this.tableContents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdit)).BeginInit();
            this.mnuContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitter.Location = new System.Drawing.Point(0, 0);
            this.splitter.Name = "splitter";
            // 
            // splitter.Panel1
            // 
            this.splitter.Panel1.Controls.Add(this.treeFileView);
            // 
            // splitter.Panel2
            // 
            this.splitter.Panel2.Controls.Add(this.tableContents);
            this.splitter.Size = new System.Drawing.Size(1132, 642);
            this.splitter.SplitterDistance = 322;
            this.splitter.TabIndex = 0;
            // 
            // treeFileView
            // 
            this.treeFileView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeFileView.Location = new System.Drawing.Point(0, 0);
            this.treeFileView.Name = "treeFileView";
            this.treeFileView.Size = new System.Drawing.Size(322, 642);
            this.treeFileView.TabIndex = 0;
            this.treeFileView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeFileView_AfterSelect);
            // 
            // tableContents
            // 
            this.tableContents.ColumnCount = 1;
            this.tableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableContents.Controls.Add(this.pnlFileToolbar, 0, 0);
            this.tableContents.Controls.Add(this.dgvEdit, 0, 1);
            this.tableContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableContents.Location = new System.Drawing.Point(0, 0);
            this.tableContents.Name = "tableContents";
            this.tableContents.RowCount = 2;
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableContents.Size = new System.Drawing.Size(806, 642);
            this.tableContents.TabIndex = 0;
            // 
            // pnlFileToolbar
            // 
            this.pnlFileToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFileToolbar.Location = new System.Drawing.Point(3, 3);
            this.pnlFileToolbar.Name = "pnlFileToolbar";
            this.pnlFileToolbar.Size = new System.Drawing.Size(800, 94);
            this.pnlFileToolbar.TabIndex = 0;
            // 
            // dgvEdit
            // 
            this.dgvEdit.AllowUserToAddRows = false;
            this.dgvEdit.AllowUserToDeleteRows = false;
            this.dgvEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnLocation,
            this.clnLength,
            this.clnString,
            this.clnID,
            this.clnState});
            this.dgvEdit.ContextMenuStrip = this.mnuContext;
            this.dgvEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEdit.Location = new System.Drawing.Point(3, 103);
            this.dgvEdit.Name = "dgvEdit";
            this.dgvEdit.RowHeadersVisible = false;
            this.dgvEdit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEdit.Size = new System.Drawing.Size(800, 536);
            this.dgvEdit.TabIndex = 1;
            this.dgvEdit.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEdit_CellEndEdit);
            // 
            // clnLocation
            // 
            this.clnLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnLocation.HeaderText = "Location";
            this.clnLocation.Name = "clnLocation";
            this.clnLocation.ReadOnly = true;
            // 
            // clnLength
            // 
            this.clnLength.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnLength.HeaderText = "Length";
            this.clnLength.Name = "clnLength";
            this.clnLength.ReadOnly = true;
            // 
            // clnString
            // 
            this.clnString.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnString.FillWeight = 500F;
            this.clnString.HeaderText = "String";
            this.clnString.Name = "clnString";
            this.clnString.ReadOnly = true;
            // 
            // clnID
            // 
            this.clnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnID.FillWeight = 500F;
            this.clnID.HeaderText = "ID";
            this.clnID.Name = "clnID";
            // 
            // clnState
            // 
            this.clnState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnState.FillWeight = 200F;
            this.clnState.HeaderText = "State";
            this.clnState.Name = "clnState";
            // 
            // mnuContext
            // 
            this.mnuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSelectAll,
            this.mnuSeparator1,
            this.mnuSetStatus});
            this.mnuContext.Name = "contextMenuStrip1";
            this.mnuContext.Size = new System.Drawing.Size(165, 54);
            // 
            // mnuSelectAll
            // 
            this.mnuSelectAll.Name = "mnuSelectAll";
            this.mnuSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuSelectAll.Size = new System.Drawing.Size(164, 22);
            this.mnuSelectAll.Text = "Select &All";
            this.mnuSelectAll.Click += new System.EventHandler(this.mnuSelectAll_Click);
            // 
            // mnuSeparator1
            // 
            this.mnuSeparator1.Name = "mnuSeparator1";
            this.mnuSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // mnuSetStatus
            // 
            this.mnuSetStatus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetUnchanged,
            this.mnuSetIgnored,
            this.mnuWorkInProgress,
            this.mnuSetCompleted});
            this.mnuSetStatus.Name = "mnuSetStatus";
            this.mnuSetStatus.Size = new System.Drawing.Size(164, 22);
            this.mnuSetStatus.Text = "Set status";
            // 
            // mnuSetUnchanged
            // 
            this.mnuSetUnchanged.Name = "mnuSetUnchanged";
            this.mnuSetUnchanged.Size = new System.Drawing.Size(163, 22);
            this.mnuSetUnchanged.Text = "Unchanged";
            this.mnuSetUnchanged.Click += new System.EventHandler(this.mnuSetUnchanged_Click);
            // 
            // mnuSetIgnored
            // 
            this.mnuSetIgnored.Name = "mnuSetIgnored";
            this.mnuSetIgnored.Size = new System.Drawing.Size(163, 22);
            this.mnuSetIgnored.Text = "Ignored";
            this.mnuSetIgnored.Click += new System.EventHandler(this.mnuSetIgnored_Click);
            // 
            // mnuWorkInProgress
            // 
            this.mnuWorkInProgress.Name = "mnuWorkInProgress";
            this.mnuWorkInProgress.Size = new System.Drawing.Size(163, 22);
            this.mnuWorkInProgress.Text = "Work in progress";
            this.mnuWorkInProgress.Click += new System.EventHandler(this.mnuWorkInProgress_Click);
            // 
            // mnuSetCompleted
            // 
            this.mnuSetCompleted.Name = "mnuSetCompleted";
            this.mnuSetCompleted.Size = new System.Drawing.Size(163, 22);
            this.mnuSetCompleted.Text = "Completed";
            this.mnuSetCompleted.Click += new System.EventHandler(this.mnuSetCompleted_Click);
            // 
            // EditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 642);
            this.Controls.Add(this.splitter);
            this.Name = "EditWindow";
            this.Text = "EditWindow";
            this.Activated += new System.EventHandler(this.EditWindow_Activated);
            this.splitter.Panel1.ResumeLayout(false);
            this.splitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).EndInit();
            this.splitter.ResumeLayout(false);
            this.tableContents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdit)).EndInit();
            this.mnuContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitter;
        private System.Windows.Forms.TreeView treeFileView;
        private System.Windows.Forms.TableLayoutPanel tableContents;
        private System.Windows.Forms.Panel pnlFileToolbar;
        private System.Windows.Forms.DataGridView dgvEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnString;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnID;
        private System.Windows.Forms.DataGridViewComboBoxColumn clnState;
        private System.Windows.Forms.ContextMenuStrip mnuContext;
        private System.Windows.Forms.ToolStripMenuItem mnuSelectAll;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuSetStatus;
        private System.Windows.Forms.ToolStripMenuItem mnuSetUnchanged;
        private System.Windows.Forms.ToolStripMenuItem mnuSetIgnored;
        private System.Windows.Forms.ToolStripMenuItem mnuWorkInProgress;
        private System.Windows.Forms.ToolStripMenuItem mnuSetCompleted;
    }
}