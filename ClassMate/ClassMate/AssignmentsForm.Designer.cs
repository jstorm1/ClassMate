namespace ClassMate
{
    partial class AssignmentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAssignTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAssignType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAssignDescription = new System.Windows.Forms.TextBox();
            this.dateTimePickerAssignDue = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxAssignCompleted = new System.Windows.Forms.CheckBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxAssignNotes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // textBoxAssignTitle
            // 
            this.textBoxAssignTitle.Location = new System.Drawing.Point(79, 42);
            this.textBoxAssignTitle.Name = "textBoxAssignTitle";
            this.textBoxAssignTitle.Size = new System.Drawing.Size(156, 20);
            this.textBoxAssignTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type:";
            // 
            // comboBoxAssignType
            // 
            this.comboBoxAssignType.FormattingEnabled = true;
            this.comboBoxAssignType.Location = new System.Drawing.Point(79, 73);
            this.comboBoxAssignType.Name = "comboBoxAssignType";
            this.comboBoxAssignType.Size = new System.Drawing.Size(156, 21);
            this.comboBoxAssignType.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description:";
            // 
            // textBoxAssignDescription
            // 
            this.textBoxAssignDescription.Location = new System.Drawing.Point(79, 104);
            this.textBoxAssignDescription.Name = "textBoxAssignDescription";
            this.textBoxAssignDescription.Size = new System.Drawing.Size(215, 20);
            this.textBoxAssignDescription.TabIndex = 3;
            // 
            // dateTimePickerAssignDue
            // 
            this.dateTimePickerAssignDue.Location = new System.Drawing.Point(79, 131);
            this.dateTimePickerAssignDue.Name = "dateTimePickerAssignDue";
            this.dateTimePickerAssignDue.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAssignDue.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Due:";
            // 
            // checkBoxAssignCompleted
            // 
            this.checkBoxAssignCompleted.AutoSize = true;
            this.checkBoxAssignCompleted.Location = new System.Drawing.Point(79, 216);
            this.checkBoxAssignCompleted.Name = "checkBoxAssignCompleted";
            this.checkBoxAssignCompleted.Size = new System.Drawing.Size(76, 17);
            this.checkBoxAssignCompleted.TabIndex = 6;
            this.checkBoxAssignCompleted.Text = "Completed";
            this.checkBoxAssignCompleted.UseVisualStyleBackColor = true;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(34, 13);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(38, 13);
            this.labelClass.TabIndex = 9;
            this.labelClass.Text = "Class: ";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(62, 239);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "&Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(163, 239);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Notes:";
            // 
            // richTextBoxAssignNotes
            // 
            this.richTextBoxAssignNotes.Location = new System.Drawing.Point(79, 163);
            this.richTextBoxAssignNotes.Name = "richTextBoxAssignNotes";
            this.richTextBoxAssignNotes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxAssignNotes.Size = new System.Drawing.Size(200, 47);
            this.richTextBoxAssignNotes.TabIndex = 5;
            this.richTextBoxAssignNotes.Text = "";
            // 
            // AssignmentsForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(315, 274);
            this.Controls.Add(this.richTextBoxAssignNotes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.checkBoxAssignCompleted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerAssignDue);
            this.Controls.Add(this.textBoxAssignDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxAssignType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAssignTitle);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssignmentsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Assignment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAssignTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxAssignType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAssignDescription;
        private System.Windows.Forms.DateTimePicker dateTimePickerAssignDue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxAssignCompleted;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxAssignNotes;
    }
}