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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mnuProjectNew_Click(object sender, EventArgs e)
        {
            using (SettingsWindow frm = new SettingsWindow())
            {
                frm.ShowDialog();
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
    }
}
