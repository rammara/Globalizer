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
    public partial class MainWindow : Form
    {
        internal Dictionary<Guid, EditWindow> ChildWindows;

        public MainWindow()
        {
            InitializeComponent();
            ChildWindows = new Dictionary<Guid, EditWindow>();
        } // constructor

        public Project ActiveProject { get; set; }

        public void ActivateChild(Guid identity)
        {
            if (this.ChildWindows.ContainsKey(identity)) this.ChildWindows[identity].Activate();
        } // ActivateChild

        private void mnuProjectNew_Click(object sender, EventArgs e)
        {
            Project prj = new Project("esc", @"D:\Vs Projects\ESClient") { FileMask = Globals.CSHARP_DEFAULT_FILEMASK, RegExp = Globals.CSHARP_DEFAULT_REGEX };
            EditWindow newWindow = new EditWindow(prj) { MdiParent = this };
            this.ChildWindows.Add(prj.Identity, newWindow);
            newWindow.Show();

            using (SettingsWindow frm = new SettingsWindow())
            {
                
                /*
                DialogResult ret = frm.ShowDialog();
                if (DialogResult.OK == ret)
                {
                    Project prj = frm.Project;
                    EditWindow newWindow = new EditWindow(prj) { MdiParent = this };
                    this.m_windows.Add(prj.Identity, newWindow);
                    newWindow.Show();
                }*/
            } // using frm
        } // mnuProjectNew_Click

        private void mnuProjectOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "Globalizer project files|*.glbprj" })
            {
                DialogResult ret = dlg.ShowDialog();
                if (DialogResult.OK == ret)
                {
                    Project prj = Project.Load(dlg.FileName);
                    EditWindow newWindow = new EditWindow(prj) { MdiParent = this };
                    this.ChildWindows.Add(prj.Identity, newWindow);
                    newWindow.Show();
                }
            } // using
        } // mnuProjectOpen_Click

        private void mnuProjectSave_Click(object sender, EventArgs e)
        {
            if (null != this.ActiveProject)
            {
                if (string.IsNullOrEmpty(this.ActiveProject.SavedFilename))
                {
                    using (SaveFileDialog dlg = new SaveFileDialog() { Filter = "Globalizer project files|*.glbprj" })
                    {
                        DialogResult ret = dlg.ShowDialog();
                        if (DialogResult.OK == ret) this.ActiveProject.Save(dlg.FileName);
                    } // using
                }
                else
                {
                    this.ActiveProject.Save(this.ActiveProject.SavedFilename);
                }
            }
        } // mnuProjectSave_Click

        private void mnuProjectSaveAs_Click(object sender, EventArgs e)
        {
            if (null != this.ActiveProject)
            {
                using (SaveFileDialog dlg = new SaveFileDialog() { Filter = "Globalizer project files|*.glbprj" })
                {
                    DialogResult ret = dlg.ShowDialog();
                    if (DialogResult.OK == ret) this.ActiveProject.Save(dlg.FileName);
                } // using
            }
        } // mnuProjectSaveAs_Click

        private void mnuProjectExit_Click(object sender, EventArgs e)
        {

        }

        private void mnuToolsSettings_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void mnuToolsGenerateResx_Click(object sender, EventArgs e)
        {
            if (this.ActiveProject != null)
            {
                using (SaveFileDialog dlg = new SaveFileDialog()
                {
                    Filter = "Resource files|*.resx"
                })
                {
                    DialogResult ret = dlg.ShowDialog();
                    if (DialogResult.OK == ret) this.ActiveProject.GenerateResx(dlg.FileName);
                } // using dlg
            } // if               
        } // mnuToolsGenerateResx_Click

        private void mnuToolsEditCommonIDs_Click(object sender, EventArgs e)
        {
            if (this.ActiveProject != null)
            {
                using (CommonIdsEditWindow wnd = new CommonIdsEditWindow(this.ActiveProject))
                {
                    wnd.ShowDialog();
                } // using
            }
        } // mnuToolsEditCommonIDs_Click
    } // class MainWindow
} // namespace
