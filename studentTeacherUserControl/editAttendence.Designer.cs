namespace DotnetXmlProject.studentTeacherUserControl
{
    partial class editAttendence
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            displayClassbtn = new Button();
            panel5 = new Panel();
            classIdtextBox = new TextBox();
            serchtextBox = new TextBox();
            editAttendancedataGridView = new DataGridView();
            searchpictureBox = new PictureBox();
            panel6 = new Panel();
            label6 = new Label();
            label5 = new Label();
            tabPage2 = new TabPage();
            toolbtn = new ToolStrip();
            editStudents = new TabControl();
            tabcontroleaddstd = new TabPage();
            ((System.ComponentModel.ISupportInitialize)editAttendancedataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchpictureBox).BeginInit();
            editStudents.SuspendLayout();
            tabcontroleaddstd.SuspendLayout();
            SuspendLayout();
            // 
            // displayClassbtn
            // 
            displayClassbtn.Location = new Point(382, 66);
            displayClassbtn.Name = "displayClassbtn";
            displayClassbtn.Size = new Size(74, 29);
            displayClassbtn.TabIndex = 6;
            displayClassbtn.Text = "Display";
            displayClassbtn.UseVisualStyleBackColor = true;
            displayClassbtn.Click += displayClassbtn_Click_1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gray;
            panel5.Location = new Point(94, 91);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 2);
            panel5.TabIndex = 5;
            // 
            // classIdtextBox
            // 
            classIdtextBox.BorderStyle = BorderStyle.None;
            classIdtextBox.Location = new Point(94, 66);
            classIdtextBox.Name = "classIdtextBox";
            classIdtextBox.Size = new Size(270, 20);
            classIdtextBox.TabIndex = 4;
            // 
            // serchtextBox
            // 
            serchtextBox.BorderStyle = BorderStyle.None;
            serchtextBox.Location = new Point(587, 66);
            serchtextBox.Name = "serchtextBox";
            serchtextBox.Size = new Size(270, 20);
            serchtextBox.TabIndex = 8;
            // 
            // editAttendancedataGridView
            // 
            editAttendancedataGridView.AllowUserToAddRows = false;
            editAttendancedataGridView.AllowUserToDeleteRows = false;
            editAttendancedataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            editAttendancedataGridView.BackgroundColor = Color.White;
            editAttendancedataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            editAttendancedataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            editAttendancedataGridView.Location = new Point(31, 131);
            editAttendancedataGridView.Name = "editAttendancedataGridView";
            editAttendancedataGridView.ReadOnly = true;
            editAttendancedataGridView.RowHeadersWidth = 51;
            editAttendancedataGridView.ShowCellErrors = false;
            editAttendancedataGridView.ShowEditingIcon = false;
            editAttendancedataGridView.ShowRowErrors = false;
            editAttendancedataGridView.Size = new Size(872, 318);
            editAttendancedataGridView.TabIndex = 11;
            // 
            // searchpictureBox
            // 
            searchpictureBox.Image = Properties.Resources.search_removebg_preview;
            searchpictureBox.Location = new Point(835, 66);
            searchpictureBox.Name = "searchpictureBox";
            searchpictureBox.Size = new Size(19, 26);
            searchpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            searchpictureBox.TabIndex = 10;
            searchpictureBox.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gray;
            panel6.Location = new Point(587, 91);
            panel6.Name = "panel6";
            panel6.Size = new Size(270, 2);
            panel6.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(590, 46);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 7;
            label6.Text = "Student Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 46);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 3;
            label5.Text = "class Id";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.BackgroundImageLayout = ImageLayout.None;
            tabPage2.Location = new Point(4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(934, 468);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Edit Attendence";
            // 
            // toolbtn
            // 
            toolbtn.ImageScalingSize = new Size(20, 20);
            toolbtn.Location = new Point(0, 0);
            toolbtn.Name = "toolbtn";
            toolbtn.Size = new Size(1001, 25);
            toolbtn.TabIndex = 2;
            toolbtn.Text = "toolStrip1";
            // 
            // editStudents
            // 
            editStudents.AccessibleName = "";
            editStudents.Alignment = TabAlignment.Bottom;
            editStudents.Controls.Add(tabPage2);
            editStudents.Controls.Add(tabcontroleaddstd);
            editStudents.Location = new Point(0, 96);
            editStudents.Name = "editStudents";
            editStudents.SelectedIndex = 0;
            editStudents.ShowToolTips = true;
            editStudents.Size = new Size(942, 501);
            editStudents.TabIndex = 3;
            editStudents.Tag = "";
            // 
            // tabcontroleaddstd
            // 
            tabcontroleaddstd.BackColor = Color.White;
            tabcontroleaddstd.Controls.Add(editAttendancedataGridView);
            tabcontroleaddstd.Controls.Add(searchpictureBox);
            tabcontroleaddstd.Controls.Add(panel6);
            tabcontroleaddstd.Controls.Add(label6);
            tabcontroleaddstd.Controls.Add(displayClassbtn);
            tabcontroleaddstd.Controls.Add(panel5);
            tabcontroleaddstd.Controls.Add(classIdtextBox);
            tabcontroleaddstd.Controls.Add(label5);
            tabcontroleaddstd.Controls.Add(serchtextBox);
            tabcontroleaddstd.Location = new Point(4, 4);
            tabcontroleaddstd.Name = "tabcontroleaddstd";
            tabcontroleaddstd.Padding = new Padding(3);
            tabcontroleaddstd.Size = new Size(934, 468);
            tabcontroleaddstd.TabIndex = 0;
            tabcontroleaddstd.Text = "show students";
            // 
            // editAttendence
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(toolbtn);
            Controls.Add(editStudents);
            Name = "editAttendence";
            Size = new Size(1001, 693);
            ((System.ComponentModel.ISupportInitialize)editAttendancedataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchpictureBox).EndInit();
            editStudents.ResumeLayout(false);
            tabcontroleaddstd.ResumeLayout(false);
            tabcontroleaddstd.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button displayClassbtn;
        private Panel panel5;
        private TextBox classIdtextBox;
        private TextBox serchtextBox;
        private DataGridView editAttendancedataGridView;
        private PictureBox searchpictureBox;
        private Panel panel6;
        private Label label6;
        private Label label5;
        private TabPage tabPage2;
        private ToolStrip toolbtn;
        public TabControl editStudents;
        private TabPage tabcontroleaddstd;
    }
}
