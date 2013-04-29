using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassMate
{
    public partial class frmCurriculum : Form
    {
        public frmCurriculum()
        {
            InitializeComponent();
        }

        //private void curriculumBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.curriculumBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.classmateDataSet);

        //}

        private void frmCurriculum_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'classmateDataSet.classes' table. You can move, or remove it, as needed.
            //this.classesTableAdapter.Fill(this.classmateDataSet.classes);
            //// TODO: This line of code loads data into the 'classmateDataSet.curriculumclasses' table. You can move, or remove it, as needed.
            //this.curriculumclassesTableAdapter.Fill(this.classmateDataSet.curriculumclasses);
            //// TODO: This line of code loads data into the 'classmateDataSet.curriculum' table. You can move, or remove it, as needed.
            //this.curriculumTableAdapter.Fill(this.classmateDataSet.curriculum);

        }
    }
}
