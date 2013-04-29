using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassMate
{
    public partial class ClassMateUI : Form
    {
     
        // Base tree node.
        TreeNode tNode = new TreeNode();
        
        public ClassMateUI()
        {
            InitializeComponent();
            // Initialize the save and retrieve path for classes.
            if (ClassMate.Properties.Settings.Default.SavePath == "")
            {
                ClassMate.Properties.Settings.Default.SavePath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\" + Application.ProductName;
            }
            

            // Add base tree node to treeview.
            tNode.Name = "mainNode";
            tNode.Text = "Classes";
            treeViewClasses.Nodes.Add(tNode);
            treeViewClasses.SelectedNode = tNode;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassForm classForm = new ClassForm();
            classForm.ShowDialog();
            if (classForm.saveClose)
            {

                AddToTree(classForm.ClassPass.ToString(), classForm.ClassPass.ToString(), (ClassTree)classForm.ClassPass);
            }
        }

        // Add a class to the tree view control
        private void AddToTree(string nodeName, string nodeText, ClassTree passClass)
        {
            treeViewClasses.SelectedNode = tNode;

            TreeNode nod = new TreeNode();
            nod.Name = nodeName;
            nod.Text = nodeText;
            nod.Tag = passClass;
            TreeNode[] foundNodes = treeViewClasses.Nodes.Find(nodeName, true);
            
            foreach(TreeNode node in foundNodes)
            {
                treeViewClasses.Nodes.Remove(node);
            }
               
            treeViewClasses.SelectedNode.Nodes.Add(nod);
            treeViewClasses.SelectedNode.ExpandAll();
        }

        #region Class Open methods
            private void openClassToolStripMenuItem_Click(object sender, EventArgs e)
            {
                string fileName = ClassOpen();
                if (fileName != null)
                {
                    ClassTree newClass = DatabaseClass.ReadClass(fileName);
                    AddToTree(newClass.ClassTitle,newClass.ClassTitle, newClass);
                }
            }

            private void openToolStripButton_Click(object sender, EventArgs e)
            {
                string fileName = ClassOpen();
                if (fileName != null)
                {
                    ClassTree newClass = DatabaseClass.ReadClass(fileName);
                    AddToTree(newClass.ClassTitle, newClass.ClassTitle, newClass);
                }
            }

            private string ClassOpen()
            {
                openFileDialog1.InitialDirectory = ClassMate.Properties.Settings.Default.SavePath;
                openFileDialog1.ShowDialog();                
                return openFileDialog1.FileName;
            }
        #endregion

            private void treeViewClasses_DoubleClick(object sender, EventArgs e)
            {
                EditClass();
            }

            // Method to edit class
            private void EditClass()
            {
                try
                {
                    if (treeViewClasses.SelectedNode == null)
                    {
                        MessageBox.Show("Please select a class", "No Class Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (treeViewClasses.SelectedNode.Tag == null)   
                        return;

                    ClassForm classForm = new ClassForm(treeViewClasses.SelectedNode.Tag);
                    classForm.ShowDialog();
                    if (classForm.saveClose)
                    {
                        AddToTree(classForm.ClassPass.ToString(), classForm.ClassPass.ToString(), (ClassTree)classForm.ClassPass);
                    }
                }
                catch
                {

                }
            }

            private void classToolStripMenuItem_Click(object sender, EventArgs e)
            {
                EditClass();
            }

            private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
            {
                OptionsForm frm = new OptionsForm();
                frm.ShowDialog();

            }

            private void newAssignmentToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (treeViewClasses.SelectedNode == null)
                {
                    MessageBox.Show("Please select a class", "No Class Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (treeViewClasses.SelectedNode.Tag == null)
                    return;

                AssignmentsForm frm = new AssignmentsForm((ClassTree)treeViewClasses.SelectedNode.Tag);
                frm.ShowDialog();
                
                treeViewClasses.SelectedNode.Tag = frm.assignmentClass;
                PopulateAssignments(frm.assignmentClass);
            }
            
            private void PopulateAssignments(ClassTree passClass)
            {
                foreach (ClassAssignment assignment in passClass.ClassTreeAssignments)
                {
                    ListViewItem lvItem = new ListViewItem();
                    lvItem.Text = assignment.assignmentTitle;
                    lvItem.SubItems.Add(assignment.assignmentDue.ToString());
                    listViewAssignments.Items.Add(lvItem);
                }
            }

            private void saveToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (treeViewClasses.SelectedNode == null)
                {
                    MessageBox.Show("Please select a class", "No Class Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (treeViewClasses.SelectedNode.Tag == null)
                    return;

                DatabaseClass.CreateClass((ClassTree)treeViewClasses.SelectedNode.Tag,treeViewClasses.SelectedNode.Text);
            }

            private void curriculumToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Form frmCurric = new frmCurriculum();
                frmCurric.ShowDialog();
            }
        
    }
}
