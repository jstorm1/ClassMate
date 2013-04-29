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
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void textBoxSaveLocation_DoubleClick(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = textBoxSaveLocation.Text;
            folderBrowserDialog1.ShowDialog();
            textBoxSaveLocation.Text = folderBrowserDialog1.SelectedPath;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
