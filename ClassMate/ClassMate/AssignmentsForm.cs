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
    public partial class AssignmentsForm : Form
    {
        public ClassTree assignmentClass { get; set; }

        bool newAssignment;
        string originalAssignmentTitle;

        public AssignmentsForm(object passObject)
        {
            newAssignment = true;
            InitializeComponent();
            ClassTree passClass = (ClassTree)passObject;

            labelClass.Text = "Class: " + passClass.ClassTitle;
            assignmentClass = passClass;
        }

        public AssignmentsForm(string assignTitle, object passObject)
        {
            newAssignment = false;
            originalAssignmentTitle = assignTitle;

            ClassTree passClass = (ClassTree)passObject;

            labelClass.Text = "Class: " + passClass.ClassTitle;

            foreach (ClassAssignment assignment in passClass.ClassTreeAssignments)
            {
                if (assignment.assignmentTitle == assignTitle)
                {
                    textBoxAssignTitle.Text = assignment.assignmentTitle;
                    comboBoxAssignType.Text = assignment.assignmentType;
                    textBoxAssignDescription.Text = assignment.assignmentDescription;
                    dateTimePickerAssignDue.Value = assignment.assignmentDue;
                    checkBoxAssignCompleted.Checked = assignment.assignmentComplete;
                    richTextBoxAssignNotes.Text = assignment.assignmentNote;
                }
            }

            assignmentClass = passClass;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (newAssignment)
            {
                ClassAssignment newAssign = new ClassAssignment(textBoxAssignTitle.Text,
                                                             comboBoxAssignType.Text,
                                                             textBoxAssignDescription.Text,
                                                             richTextBoxAssignNotes.Text,
                                                             assignmentClass.ClassTitle,
                                                             dateTimePickerAssignDue.Value,
                                                             checkBoxAssignCompleted.Checked);
                
                assignmentClass.ClassTreeAssignments.Add(newAssign);

            }
            else
            {
                foreach (ClassAssignment cAss in assignmentClass.ClassTreeAssignments)
                {
                    if (cAss.assignmentTitle == originalAssignmentTitle)
                    {
                        assignmentClass.ClassTreeAssignments.Remove(cAss);

                        cAss.assignmentTitle = textBoxAssignTitle.Text;
                        cAss.assignmentType = comboBoxAssignType.Text;
                        cAss.assignmentDescription = textBoxAssignDescription.Text;
                        cAss.assignmentNote = richTextBoxAssignNotes.Text;
                        cAss.assignmentDue = dateTimePickerAssignDue.Value;
                        cAss.assignmentClass = assignmentClass.ClassTitle;
                        cAss.assignmentComplete = checkBoxAssignCompleted.Checked;
                        
                        assignmentClass.ClassTreeAssignments.Add(cAss);
                    }
                }
            }
            this.Close();
        }
    }
}
