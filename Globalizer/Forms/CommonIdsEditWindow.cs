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
    public partial class CommonIdsEditWindow : Form
    {
        private readonly Project m_project;
        public CommonIdsEditWindow(Project project)
        {
            InitializeComponent();
            this.m_project = project;
            this.dgvEdit.Columns.AddRange(new DataGridViewColumn[]
            {
               
                new DataGridViewTextBoxColumn()
                {
                    Name = "clnValue",
                    DataPropertyName = "Value",
                    ReadOnly = true,
                    HeaderText = "Value",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    FillWeight = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "clnName",
                    DataPropertyName = "Key",
                    ReadOnly = true,
                    HeaderText = "Current Key",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    FillWeight = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "clnNewValue",
                    HeaderText = "New value",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    FillWeight = 100
                }
            });
        } // CommonIdsEditWindow

        private void CommonIdsEditWindow_Load(object sender, EventArgs e)
        {
            this.dgvEdit.AutoGenerateColumns = false;
            foreach (string key in this.m_project.CommonIDs.Keys)
            {
                this.dgvEdit.Rows.Add(new object[] { key, this.m_project.CommonIDs[key], null });
            } // foreach            
        } // CommonIdsEditWindow_Load
    } // class CommonIdsEditWindow
} // namespace
