namespace ClassMate
{
    partial class OptionsForm
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("General");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControlGeneralSettings = new System.Windows.Forms.TabControl();
            this.tabPageLocations = new System.Windows.Forms.TabPage();
            this.textBoxSaveLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlGeneralSettings.SuspendLayout();
            this.tabPageLocations.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(-1, 1);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControlGeneralSettings);
            this.splitContainer1.Size = new System.Drawing.Size(401, 291);
            this.splitContainer1.SplitterDistance = 133;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode2.Name = "NodeGeneral";
            treeNode2.Text = "General";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(133, 291);
            this.treeView1.TabIndex = 0;
            // 
            // tabControlGeneralSettings
            // 
            this.tabControlGeneralSettings.Controls.Add(this.tabPageLocations);
            this.tabControlGeneralSettings.Controls.Add(this.tabPage2);
            this.tabControlGeneralSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlGeneralSettings.Location = new System.Drawing.Point(0, 0);
            this.tabControlGeneralSettings.Name = "tabControlGeneralSettings";
            this.tabControlGeneralSettings.SelectedIndex = 0;
            this.tabControlGeneralSettings.Size = new System.Drawing.Size(264, 291);
            this.tabControlGeneralSettings.TabIndex = 0;
            // 
            // tabPageLocations
            // 
            this.tabPageLocations.Controls.Add(this.textBoxSaveLocation);
            this.tabPageLocations.Controls.Add(this.label1);
            this.tabPageLocations.Location = new System.Drawing.Point(4, 22);
            this.tabPageLocations.Name = "tabPageLocations";
            this.tabPageLocations.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLocations.Size = new System.Drawing.Size(256, 265);
            this.tabPageLocations.TabIndex = 0;
            this.tabPageLocations.Text = "Locations";
            this.tabPageLocations.UseVisualStyleBackColor = true;
            // 
            // textBoxSaveLocation
            // 
            this.textBoxSaveLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClassMate.Properties.Settings.Default, "SavePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxSaveLocation.Location = new System.Drawing.Point(92, 20);
            this.textBoxSaveLocation.Name = "textBoxSaveLocation";
            this.textBoxSaveLocation.Size = new System.Drawing.Size(157, 20);
            this.textBoxSaveLocation.TabIndex = 1;
            this.textBoxSaveLocation.Text = global::ClassMate.Properties.Settings.Default.SavePath;
            this.toolTip1.SetToolTip(this.textBoxSaveLocation, "Double-click to change.");
            this.textBoxSaveLocation.DoubleClick += new System.EventHandler(this.textBoxSaveLocation_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Save Location:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(256, 265);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(136, 299);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "&OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(218, 299);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Enabled = false;
            this.buttonApply.Location = new System.Drawing.Point(300, 299);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 3;
            this.buttonApply.Text = "&Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(401, 325);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.splitContainer1);
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabControlGeneralSettings.ResumeLayout(false);
            this.tabPageLocations.ResumeLayout(false);
            this.tabPageLocations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabControlGeneralSettings;
        private System.Windows.Forms.TabPage tabPageLocations;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxSaveLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}