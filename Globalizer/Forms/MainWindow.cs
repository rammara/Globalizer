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
        private Dictionary<Guid, EditWindow> m_windows;

        public MainWindow()
        {
            InitializeComponent();
            m_windows = new Dictionary<Guid, EditWindow>();
        } // constructor


        private void mnuProjectNew_Click(object sender, EventArgs e)
        {
            Project prj = new Project("esc", @"D:\Vs Projects\ESClient") { FileMask = Globals.CSHARP_DEFAULT_FILEMASK, RegExp = Globals.CSHARP_DEFAULT_REGEX };
            EditWindow newWindow = new EditWindow(prj) { MdiParent = this };
            this.m_windows.Add(prj.Identity, newWindow);
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

        }

        private void mnuProjectSave_Click(object sender, EventArgs e)
        {

        }

        private void mnuProjectSaveAs_Click(object sender, EventArgs e)
        {

        }

        private void mnuProjectExit_Click(object sender, EventArgs e)
        {

        }

        private void mnuToolsSettings_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
