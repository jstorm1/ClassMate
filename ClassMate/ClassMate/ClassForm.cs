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
    public partial class ClassForm : Form
    {
        // Form property to pass the class back to the main UI.
        public object ClassPass { get; set; }
        public bool saveClose { get; set; }

        public ClassForm()
        {
            InitializeComponent();
        }

        public ClassForm(object passObject)
        {
            InitializeComponent();
            ClassTree passClass = (ClassTree)passObject;

            textBoxClassTitle.Text = passClass.ClassTitle;

            if (passClass.ClassTreeTimes.m_TimeList.Count != 0)
            {
                foreach (ClassTime time in passClass.ClassTreeTimes)
                {
                    listBoxClassTimes.Items.Add(time.classTimeTime);
                }
            }
            
            // Populate the rest of the class information.
            textBoxLocation.Text = passClass.ClassLocation;
            textBoxWebSite.Text = passClass.ClassWebSite;
            textBoxCreditHours.Text = passClass.ClassCreditHours;

            // Populate the teacher information into the new class.
            textBoxTeacher.Text = passClass.ClassTeacher;
            textBoxTeacherOffice.Text = passClass.ClassTeacherOffice;
            textBoxOfficeHours.Text = passClass.ClassTeacherOfficeHours;
            textBoxEmail.Text = passClass.ClassTeacherEmail;
            textBoxTeacherPhone.Text = passClass.ClassTeacherPhone;
            richTextBoxClassNotes.Text = passClass.ClassNote;

        }

        private void buttonAddTime_Click(object sender, EventArgs e)
        {
            ClassTimeSelect timeForm = new ClassTimeSelect();

            if (timeForm.ShowDialog() == DialogResult.OK)
            {
                listBoxClassTimes.Items.Add(timeForm.ClassTimeReturn);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            saveClose = false;
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            // Instantiate a new class object.
            ClassTree newClass = new ClassTree();

            // Validate necessary fields (Class Title & Class Time(s)). If so add to new class.
            if (FieldValidator())
            {
                newClass.ClassTitle = textBoxClassTitle.Text;

                // Enumerate the class times and add to the new class object.
                newClass.ClassTreeTimes = new ClassTimes();
                foreach (string time in listBoxClassTimes.Items)
                {
                    ClassTime classTime = new ClassTime(textBoxClassTitle.Text, time);

                    newClass.ClassTreeTimes.Add(classTime);
                }
            }
            else
            {
                return;
            }

            // Populate the rest of the class information.
            newClass.ClassLocation = textBoxLocation.Text;
            newClass.ClassWebSite = textBoxWebSite.Text;
            newClass.ClassCreditHours = textBoxCreditHours.Text;

            // Populate the teacher information into the new class.
            newClass.ClassTeacher = textBoxTeacher.Text;
            newClass.ClassTeacherOffice = textBoxTeacherOffice.Text;
            newClass.ClassTeacherOfficeHours = textBoxOfficeHours.Text;
            newClass.ClassTeacherEmail = textBoxEmail.Text;
            newClass.ClassTeacherPhone = textBoxTeacherPhone.Text;
            newClass.ClassNote = richTextBoxClassNotes.Text;

            // newClass.ClassTreeAssignments.Add(new ClassAssignment("Assignment01", "", "", "", newClass.ClassTitle, DateTime.Now, false));
            
            // populate this forms property for reference from calling form.
            ClassPass = newClass;

            // Write Class file to disk.
            DatabaseClass.CreateClass(newClass, newClass.ClassTitle);

            // Set the saveClose variable to true for calling form.
            saveClose = true;

            this.Close();
        }

        private void buttonRemovetime_Click(object sender, EventArgs e)
        {
            if (listBoxClassTimes.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a class from the list.", "No Class Time Selected",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                listBoxClassTimes.Items.RemoveAt(listBoxClassTimes.SelectedIndex);
            }
        }

        #region Control Validation
            private bool FieldValidator()
            {
                bool success = true;
                // Validate this control only if it is not empty nor null.
                if (textBoxClassTitle.Text.Length == 0)
                {
                    success = false;
                    errorProviderClass.SetError(textBoxClassTitle, "Please enter a valid class title");
                }
                else
                {
                    errorProviderClass.SetError(textBoxClassTitle, "");
                }

                // Validate this control only if there are items in the list.
                if (listBoxClassTimes.Items.Count == 0)
                {
                    success = false;
                    errorProviderClass.SetError(listBoxClassTimes, "Please enter at least one class time.");
                }
                else
                {
                    errorProviderClass.SetError(listBoxClassTimes, "");
                }

                return success;
            }
        #endregion

            private void ClassForm_FormClosing(object sender, FormClosingEventArgs e)
            {
                if (!saveClose)
                {
                    string msgText = "Are you sure you want to lose all of your changes?";
                    if (MessageBox.Show(msgText, "Exit Without Saving", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
                
                
            }

            private void ClassForm_Load(object sender, EventArgs e)
            {
                // TODO: This line of code loads data into the 'classmateDataSet.classes' table. You can move, or remove it, as needed.
                //this.classesTableAdapter.Fill(this.classmateDataSet.classes);

            }
    }
}
                