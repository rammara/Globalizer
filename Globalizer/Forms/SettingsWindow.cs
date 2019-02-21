using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Globalizer.Code;

namespace Globalizer.Forms
{
    public partial class SettingsWindow : Form
    {
        public Project Project { get; set; }
        public SettingsWindow(Project project = null)
        {
            InitializeComponent();
            if (null != project)
            {
                this.TextProjectName.Text = project.Name;
                this.TextProjectRoot.Text = project.Path;
                this.TextRegExp.Text = project.RegExp;
                this.TextFileMask.Text = project.FileMask;
                if (project.Encoding != null) this.TextEncodingCP.Text = project.Encoding.CodePage.ToString();
            }
            this.Project = project;
        } // SettingsWindow constructor

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            this.TextRegExp.Text = Globals.StringRegExp;
            this.TextFileMask.Text = Globals.FileSearchMask;
        } // SettingsWindow_Load

        private void BtnBrowseProject_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog() { Description = "Select a root project folder." })
            {
                DialogResult ret = dlg.ShowDialog();
                if (DialogResult.OK == ret)
                {
                    this.TextProjectRoot.Text = dlg.SelectedPath;
                }
                else
                {
                    this.TextProjectRoot.Text = string.Empty;
                }
            } // using
        } // BtnBrowseProject_Click

        private void BtnOK_Click(object sender, EventArgs e)
        {
            SetProjectProperties();
            this.DialogResult = DialogResult.OK;
        } // BtnOK_Click

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Project = null;
            this.DialogResult = DialogResult.Cancel;
        } // BtnCancel_Click

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            this.BtnOK.Enabled = this.TextProjectName.Text.Length > 0 && System.IO.Directory.Exists(this.TextProjectRoot.Text) &&
                                 this.TextRegExp.Text.Trim() != string.Empty && this.TextFileMask.Text != string.Empty;

            if (null == this.Project)
            {
                if (this.BtnOK.Enabled)
                {
                    SetProjectProperties();
                }
            }
        } // TextProjectName_TextChanged

        private void SetProjectProperties()
        {
            this.Project = new Project(this.TextProjectName.Text, this.TextProjectRoot.Text)
            { FileMask = this.TextFileMask.Text, RegExp = this.TextRegExp.Text };
            if (!string.IsNullOrEmpty(this.TextEncodingCP.Text) && int.TryParse(this.TextEncodingCP.Text, out int cp))
                this.Project.Encoding = Encoding.GetEncoding(cp);
        } // SetProjectProperties
    } // class SettingsWindow
} // namespace
