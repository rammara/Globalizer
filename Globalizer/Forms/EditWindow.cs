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
    public partial class EditWindow : Form
    {
        private readonly Project m_project;
        public EditWindow(Project project)
        {
            InitializeComponent();
            this.m_project = project;
        } // public constructor
    } // EditWindow constructor
} // namespace
