namespace ClassMate
{
    partial class ClassForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.buttonRemovetime = new System.Windows.Forms.Button();
            this.buttonAddTime = new System.Windows.Forms.Button();
            this.textBoxCreditHours = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxWebSite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxClassTimes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxClassTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageTeacher = new System.Windows.Forms.TabPage();
            this.textBoxTeacherPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxOfficeHours = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTeacherOffice = new System.Windows.Forms.TextBox();
            this.labelOffice = new System.Windows.Forms.Label();
            this.textBoxTeacher = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageNotes = new System.Windows.Forms.TabPage();
            this.richTextBoxClassNotes = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.errorProviderClass = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            this.tabPageTeacher.SuspendLayout();
            this.tabPageNotes.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderClass)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 4);
            this.tabControl1.Controls.Add(this.tabPageInfo);
            this.tabControl1.Controls.Add(this.tabPageTeacher);
            this.tabControl1.Controls.Add(this.tabPageNotes);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(364, 276);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.AutoScroll = true;
            this.tabPageInfo.Controls.Add(this.buttonRemovetime);
            this.tabPageInfo.Controls.Add(this.buttonAddTime);
            this.tabPageInfo.Controls.Add(this.textBoxCreditHours);
            this.tabPageInfo.Controls.Add(this.label5);
            this.tabPageInfo.Controls.Add(this.textBoxWebSite);
            this.tabPageInfo.Controls.Add(this.label4);
            this.tabPageInfo.Controls.Add(this.textBoxLocation);
            this.tabPageInfo.Controls.Add(this.label3);
            this.tabPageInfo.Controls.Add(this.listBoxClassTimes);
            this.tabPageInfo.Controls.Add(this.label2);
            this.tabPageInfo.Controls.Add(this.textBoxClassTitle);
            this.tabPageInfo.Controls.Add(this.label1);
            this.tabPageInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfo.Size = new System.Drawing.Size(356, 250);
            this.tabPageInfo.TabIndex = 0;
            this.tabPageInfo.Text = "Info";
            this.tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // buttonRemovetime
            // 
            this.buttonRemovetime.AutoSize = true;
            this.buttonRemovetime.Image = global::ClassMate.Properties.Resources.minus_16x16;
            this.buttonRemovetime.Location = new System.Drawing.Point(288, 113);
            this.buttonRemovetime.Name = "buttonRemovetime";
            this.buttonRemovetime.Size = new System.Drawing.Size(22, 22);
            this.buttonRemovetime.TabIndex = 11;
            this.buttonRemovetime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRemovetime.UseVisualStyleBackColor = true;
            this.buttonRemovetime.Click += new System.EventHandler(this.buttonRemovetime_Click);
            // 
            // buttonAddTime
            // 
            this.buttonAddTime.AutoSize = true;
            this.buttonAddTime.Image = global::ClassMate.Properties.Resources.plus_16x16;
            this.buttonAddTime.Location = new System.Drawing.Point(288, 92);
            this.buttonAddTime.Name = "buttonAddTime";
            this.buttonAddTime.Size = new System.Drawing.Size(22, 22);
            this.buttonAddTime.TabIndex = 10;
            this.buttonAddTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAddTime.UseVisualStyleBackColor = true;
            this.buttonAddTime.Click += new System.EventHandler(this.buttonAddTime_Click);
            // 
            // textBoxCreditHours
            // 
            this.textBoxCreditHours.Location = new System.Drawing.Point(118, 225);
            this.textBoxCreditHours.Name = "textBoxCreditHours";
            this.textBoxCreditHours.Size = new System.Drawing.Size(100, 20);
            this.textBoxCreditHours.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Credit Hours:";
            // 
            // textBoxWebSite
            // 
            this.textBoxWebSite.Location = new System.Drawing.Point(118, 187);
            this.textBoxWebSite.Name = "textBoxWebSite";
            this.textBoxWebSite.Size = new System.Drawing.Size(217, 20);
            this.textBoxWebSite.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Web Site:";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(118, 149);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(167, 20);
            this.textBoxLocation.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Location:";
            // 
            // listBoxClassTimes
            // 
            this.listBoxClassTimes.FormattingEnabled = true;
            this.listBoxClassTimes.Location = new System.Drawing.Point(118, 92);
            this.listBoxClassTimes.Name = "listBoxClassTimes";
            this.listBoxClassTimes.Size = new System.Drawing.Size(167, 43);
            this.listBoxClassTimes.TabIndex = 3;
            this.toolTip1.SetToolTip(this.listBoxClassTimes, "Double click a time to edit it");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class Time(s):";
            // 
            // textBoxClassTitle
            // 
            this.textBoxClassTitle.Location = new System.Drawing.Point(118, 57);
            this.textBoxClassTitle.Name = "textBoxClassTitle";
            this.textBoxClassTitle.Size = new System.Drawing.Size(167, 20);
            this.textBoxClassTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class Title:";
            // 
            // tabPageTeacher
            // 
            this.tabPageTeacher.Controls.Add(this.textBoxTeacherPhone);
            this.tabPageTeacher.Controls.Add(this.label9);
            this.tabPageTeacher.Controls.Add(this.textBoxEmail);
            this.tabPageTeacher.Controls.Add(this.label8);
            this.tabPageTeacher.Controls.Add(this.textBoxOfficeHours);
            this.tabPageTeacher.Controls.Add(this.label7);
            this.tabPageTeacher.Controls.Add(this.textBoxTeacherOffice);
            this.tabPageTeacher.Controls.Add(this.labelOffice);
            this.tabPageTeacher.Controls.Add(this.textBoxTeacher);
            this.tabPageTeacher.Controls.Add(this.label6);
            this.tabPageTeacher.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeacher.Name = "tabPageTeacher";
            this.tabPageTeacher.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeacher.Size = new System.Drawing.Size(356, 250);
            this.tabPageTeacher.TabIndex = 1;
            this.tabPageTeacher.Text = "Teacher";
            this.tabPageTeacher.UseVisualStyleBackColor = true;
            // 
            // textBoxTeacherPhone
            // 
            this.textBoxTeacherPhone.Location = new System.Drawing.Point(125, 144);
            this.textBoxTeacherPhone.Name = "textBoxTeacherPhone";
            this.textBoxTeacherPhone.Size = new System.Drawing.Size(130, 20);
            this.textBoxTeacherPhone.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Phone:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(125, 111);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(130, 20);
            this.textBoxEmail.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Email:";
            // 
            // textBoxOfficeHours
            // 
            this.textBoxOfficeHours.Location = new System.Drawing.Point(125, 80);
            this.textBoxOfficeHours.Name = "textBoxOfficeHours";
            this.textBoxOfficeHours.Size = new System.Drawing.Size(130, 20);
            this.textBoxOfficeHours.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Office Hours:";
            // 
            // textBoxTeacherOffice
            // 
            this.textBoxTeacherOffice.Location = new System.Drawing.Point(125, 53);
            this.textBoxTeacherOffice.Name = "textBoxTeacherOffice";
            this.textBoxTeacherOffice.Size = new System.Drawing.Size(130, 20);
            this.textBoxTeacherOffice.TabIndex = 3;
            // 
            // labelOffice
            // 
            this.labelOffice.AutoSize = true;
            this.labelOffice.Location = new System.Drawing.Point(42, 56);
            this.labelOffice.Name = "labelOffice";
            this.labelOffice.Size = new System.Drawing.Size(38, 13);
            this.labelOffice.TabIndex = 2;
            this.labelOffice.Text = "Office:";
            // 
            // textBoxTeacher
            // 
            this.textBoxTeacher.Location = new System.Drawing.Point(125, 23);
            this.textBoxTeacher.Name = "textBoxTeacher";
            this.textBoxTeacher.Size = new System.Drawing.Size(130, 20);
            this.textBoxTeacher.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Teacher:";
            // 
            // tabPageNotes
            // 
            this.tabPageNotes.Controls.Add(this.richTextBoxClassNotes);
            this.tabPageNotes.Location = new System.Drawing.Point(4, 22);
            this.tabPageNotes.Name = "tabPageNotes";
            this.tabPageNotes.Size = new System.Drawing.Size(356, 250);
            this.tabPageNotes.TabIndex = 2;
            this.tabPageNotes.Text = "Notes";
            this.tabPageNotes.UseVisualStyleBackColor = true;
            // 
            // richTextBoxClassNotes
            // 
            this.richTextBoxClassNotes.AcceptsTab = true;
            this.richTextBoxClassNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxClassNotes.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxClassNotes.Name = "richTextBoxClassNotes";
            this.richTextBoxClassNotes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxClassNotes.Size = new System.Drawing.Size(356, 250);
            this.richTextBoxClassNotes.TabIndex = 0;
            this.richTextBoxClassNotes.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.97337F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.76029F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.78208F));
            this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSave, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(370, 315);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(261, 285);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(177, 285);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // errorProviderClass
            // 
            this.errorProviderClass.BlinkRate = 2000;
            this.errorProviderClass.ContainerControl = this;
            // 
            // ClassForm
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(370, 315);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClassForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Class Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClassForm_FormClosing);
            this.Load += new System.EventHandler(this.ClassForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageInfo.ResumeLayout(false);
            this.tabPageInfo.PerformLayout();
            this.tabPageTeacher.ResumeLayout(false);
            this.tabPageTeacher.PerformLayout();
            this.tabPageNotes.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.TabPage tabPageTeacher;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxCreditHours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxWebSite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxClassTimes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxClassTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageNotes;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxTeacherPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxOfficeHours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTeacherOffice;
        private System.Windows.Forms.Label labelOffice;
        private System.Windows.Forms.TextBox textBoxTeacher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBoxClassNotes;
        private System.Windows.Forms.Button buttonAddTime;
        private System.Windows.Forms.ErrorProvider errorProviderClass;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonRemovetime;
        //private System.Windows.Forms.BindingSource classesBindingSource;
        //private classmateDataSetTableAdapters.classesTableAdapter classesTableAdapter;
    }
}