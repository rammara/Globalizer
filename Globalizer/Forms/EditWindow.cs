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
using System.IO;

namespace Globalizer.Forms
{
    public partial class EditWindow : Form
    {
        public readonly Project Project;
        private Dictionary<Literal.WorkStates, DataGridViewCellStyle> m_cellStyles;
        public EditWindow(Project project)
        {
            InitializeComponent();
            this.Project = project;
            this.CreateCellStyles();
            this.Project.ReScan();
            this.BuildObjTree();
            this.treeFileView.ExpandAll();
        } // public constructor

        #region "Create cell styles"
        private void CreateCellStyles()
        {
            this.m_cellStyles = new Dictionary<Literal.WorkStates, DataGridViewCellStyle>()
            {
                { Literal.WorkStates.Completed, new DataGridViewCellStyle()
                    {
                        BackColor = Color.LightGreen,
                        ForeColor = Color.DarkGreen
                    }
                },
                { Literal.WorkStates.Ignored, new DataGridViewCellStyle()
                    {
                        BackColor = Color.LightGray,
                        ForeColor = Color.DarkGray
                    }
                },
                { Literal.WorkStates.Unchanged, new DataGridViewCellStyle()
                    {
                        BackColor = SystemColors.Window,
                        ForeColor = SystemColors.ControlText
                    }
                },
                { Literal.WorkStates.WorkInProgress, new DataGridViewCellStyle()
                    {
                        BackColor = Color.LightYellow,
                        ForeColor = Color.Brown
                    }
                }
            };
        } // CreateCellStyles
        #endregion "Create cell styles"

        protected void BuildObjTree()
        {
            this.treeFileView.Nodes.Clear();
            TreeNode root = this.treeFileView.Nodes.Add(this.Project.Name);
            foreach(CodeFile file in this.Project)
            {
                string FileName = Path.GetFileName(file.FullPath);
                string[] relativePath = Path.GetDirectoryName(file.FullPath).Substring(this.Project.Path.Length)
                        .Split(new char[] { Path.DirectorySeparatorChar }, StringSplitOptions.RemoveEmptyEntries);

                TreeNode parentNode = FindNode(relativePath, root);
                parentNode.Nodes.Add(new TreeNode() { Name = FileName, Tag = file, Text = $"{FileName} [{file.Count()}]" });
            } // foreach
        } // BuildObjTree

        protected TreeNode FindNode(string[] pathelements, TreeNode startfrom)
        {
            if (pathelements.Length == 0) return startfrom; // root

            string topelement = pathelements[0];
            TreeNode foundNode = null;
            foreach(TreeNode tn in startfrom.Nodes)
            {
                if (null == tn.Tag && tn.Name == topelement)
                {
                    foundNode = tn;
                    break;
                }
            } // element
            if (null == foundNode) // create
            {
                foundNode = new TreeNode(topelement) { Name = topelement };
                startfrom.Nodes.Add(foundNode);
            }

            if (pathelements.Length > 1)
            {
                foundNode = FindNode(pathelements.Where((string elem, int i) => i >= 1).ToArray(), foundNode);
            }
            return foundNode;
        } // FindNode

        private void treeFileView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Populate(e.Node);
        } // treeFileView_AfterSelect

        private void Populate(TreeNode n)
        {
            this.dgvEdit.Rows.Clear();
            if (null != n.Tag) // folder
            {
                CodeFile file = (CodeFile)n.Tag;
                foreach(var lit in file)
                {
                    DataGridViewRow row = new DataGridViewRow() { Tag = lit };
                    BindingList<string> ds = new BindingList<string>(Enum.GetNames(typeof(Literal.WorkStates)));

                    var cellId = new DataGridViewTextBoxCell() { Value = lit.Id };
                    var cellPos = new DataGridViewTextBoxCell() { Value = $"{lit.LineNumber}:{lit.LinePosition}" };
                    var cellLen = new DataGridViewTextBoxCell() { Value = lit.Length };
                    var cellVal = new DataGridViewTextBoxCell() { Value = lit.Value };
                    var cellState = new DataGridViewComboBoxCell() {
                        DataSource = ds,
                        Value = Enum.GetName(typeof(Literal.WorkStates), lit.WorkState),
                        DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
                    };

                    DataGridViewCell[] cells = new DataGridViewCell[] {
                        cellPos,
                        cellLen,
                        cellVal,
                        cellId,
                        cellState
                    };
                    row.Cells.AddRange(cells);
                    row.DefaultCellStyle = this.m_cellStyles[lit.WorkState];
                    cellPos.ReadOnly = true;
                    cellLen.ReadOnly = true;
                    cellVal.ReadOnly = true;
                    this.dgvEdit.Rows.Add(row);
                } // foreach literal
            }
        } // Populate

        private void dgvEdit_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvEdit.Rows[e.RowIndex];
            Literal lit = (Literal)row.Tag;

            if (e.ColumnIndex == this.clnState.Index)
            {
                lit.WorkState = (Literal.WorkStates)Enum.Parse(typeof(Literal.WorkStates), row.Cells[e.ColumnIndex].Value.ToString());
            }
            else
            {
                lit.WorkState = Literal.WorkStates.WorkInProgress;
                row.Cells[this.clnState.Index].Value = Enum.GetName(typeof(Literal.WorkStates), lit.WorkState);
            }
            row.DefaultCellStyle = this.m_cellStyles[lit.WorkState];
        } // dgvEdit_CellEndEdit
    } // EditWindow constructor
} // namespace
