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
    public partial class ClassTimeSelect : Form
    {
        Days classDays = new Days();

        // Property for the calling form to receive the class time value.
        public string ClassTimeReturn { get; set; }

        public ClassTimeSelect()
        {
            InitializeComponent();
        }

        public ClassTimeSelect(string currentClassTime)
        {
            BreakApartTime(currentClassTime);
        }

        private void BreakApartTime(string classTime)
        {
            // Insert code to break apart the days and times of the class time
        }
        
        private string GetDays()
        {
            string days = "";
            if (classDays.monday)
                days += "M,";
            if (classDays.tuesday)
                days += "T,";
            if (classDays.wednesday)
                days += "W,";
            if (classDays.thursday)
                days += "Th,";
            if (classDays.friday)
                days = "F,";
            if (classDays.saturday)
                days += "Sa";
            
            // string days = "";

            //foreach (Control ctrl in groupBox1.Controls)
            //{
            //    if (ctrl is CheckBox)
            //    {
            //        CheckBox ckBox = (CheckBox)ctrl;
            //        if (ckBox.Checked)
            //        {
            //            days += ckBox.Text + ", ";
            //        }
            //    }
            //}
            return days;
        }
       
        private string GetTimes()
        {
            string times = "";
            // DateTime dt = new DateTime();
            // dt = dateTimePickerFrom.Value;
            //dateTimePickerFrom.CustomFormat = "h:mm";
            times = dateTimePickerFrom.Value.ToString("h:mm") + "-";
            // times = dt.Hour.ToString() + ":" + dt.Minute.ToString() + "-";
            // dt = dateTimePickerTo.Value;
            //times += dt.ToShortTimeString();
            times += dateTimePickerTo.Value.ToString("h:mm tt");
            
            //times = String.Format("h:mm", dateTimePickerFrom.Value) + "-";
            //times += String.Format("h:mm tt", dateTimePickerTo.Value);
            return times;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            ClassTimeReturn = GetDays() + GetTimes();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxMonday_CheckedChanged(object sender, EventArgs e)
        {
            classDays.monday = checkBoxMonday.Checked;
        }

        private void checkBoxTuesday_CheckedChanged(object sender, EventArgs e)
        {
            classDays.tuesday = checkBoxTuesday.Checked;
        }

        private void checkBoxWednesday_CheckedChanged(object sender, EventArgs e)
        {
            classDays.wednesday = checkBoxWednesday.Checked;
        }

        private void checkBoxThursday_CheckedChanged(object sender, EventArgs e)
        {
            classDays.thursday = checkBoxThursday.Checked;
        }

        private void checkBoxFriday_CheckedChanged(object sender, EventArgs e)
        {
            classDays.friday = checkBoxFriday.Checked;
        }

        private void checkBoxSaturday_CheckedChanged(object sender, EventArgs e)
        {
            classDays.saturday = checkBoxSaturday.Checked;
        }


    
    }
}
