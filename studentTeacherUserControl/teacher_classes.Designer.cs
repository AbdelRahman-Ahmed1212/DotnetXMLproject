﻿namespace DotnetXmlProject.studentTeacherUserControl
{
    partial class teacher_classesv
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
            toolbtn = new ToolStrip();
            editeStudents = new TabControl();
            tabPage2 = new TabPage();
            addstdbtn = new Button();
            panel4 = new Panel();
            textBoxstatus = new TextBox();
            Statuslabel = new Label();
            panel3 = new Panel();
            textBoxdate = new TextBox();
            stdPasslabel = new Label();
            panel2 = new Panel();
            textBoxclass = new TextBox();
            classlabel = new Label();
            panel1 = new Panel();
            textBoxstdName = new TextBox();
            stdNameLabel = new Label();
            tabcontroleaddstd = new TabPage();
            dataGridView1 = new DataGridView();
            searchpictureBox = new PictureBox();
            panel6 = new Panel();
            label6 = new Label();
            displayClassbtn = new Button();
            panel5 = new Panel();
            classIdtextBox = new TextBox();
            label5 = new Label();
            serchtextBox = new TextBox();
            editeStudents.SuspendLayout();
            tabPage2.SuspendLayout();
            tabcontroleaddstd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchpictureBox).BeginInit();
            SuspendLayout();
            // 
            // toolbtn
            // 
            toolbtn.ImageScalingSize = new Size(20, 20);
            toolbtn.Location = new Point(0, 0);
            toolbtn.Name = "toolbtn";
            toolbtn.Size = new Size(942, 25);
            toolbtn.TabIndex = 0;
            toolbtn.Text = "toolStrip1";
            // 
            // editeStudents
            // 
            editeStudents.AccessibleName = "";
            editeStudents.Alignment = TabAlignment.Bottom;
            editeStudents.Controls.Add(tabPage2);
            editeStudents.Controls.Add(tabcontroleaddstd);
            editeStudents.Location = new Point(0, 0);
            editeStudents.Name = "editeStudents";
            editeStudents.SelectedIndex = 0;
            editeStudents.ShowToolTips = true;
            editeStudents.Size = new Size(942, 501);
            editeStudents.TabIndex = 1;
            editeStudents.Tag = "";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.BackgroundImageLayout = ImageLayout.None;
            tabPage2.Controls.Add(addstdbtn);
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(textBoxstatus);
            tabPage2.Controls.Add(Statuslabel);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(textBoxdate);
            tabPage2.Controls.Add(stdPasslabel);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(textBoxclass);
            tabPage2.Controls.Add(classlabel);
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(textBoxstdName);
            tabPage2.Controls.Add(stdNameLabel);
            tabPage2.Location = new Point(4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(934, 468);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add Student";
            // 
            // addstdbtn
            // 
            addstdbtn.BackColor = Color.MediumBlue;
            addstdbtn.FlatAppearance.BorderColor = Color.White;
            addstdbtn.FlatAppearance.BorderSize = 0;
            addstdbtn.FlatStyle = FlatStyle.Flat;
            addstdbtn.Location = new Point(178, 328);
            addstdbtn.Name = "addstdbtn";
            addstdbtn.Size = new Size(94, 29);
            addstdbtn.TabIndex = 15;
            addstdbtn.Text = "Add";
            addstdbtn.UseVisualStyleBackColor = false;
            addstdbtn.Click += addstdbtn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gray;
            panel4.Location = new Point(547, 256);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 2);
            panel4.TabIndex = 14;
            // 
            // textBoxstatus
            // 
            textBoxstatus.BorderStyle = BorderStyle.None;
            textBoxstatus.Location = new Point(547, 231);
            textBoxstatus.Name = "textBoxstatus";
            textBoxstatus.Size = new Size(270, 20);
            textBoxstatus.TabIndex = 13;
            // 
            // Statuslabel
            // 
            Statuslabel.AutoSize = true;
            Statuslabel.Location = new Point(548, 208);
            Statuslabel.Name = "Statuslabel";
            Statuslabel.Size = new Size(49, 20);
            Statuslabel.TabIndex = 12;
            Statuslabel.Text = "Status";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Location = new Point(114, 256);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 2);
            panel3.TabIndex = 11;
            // 
            // textBoxdate
            // 
            textBoxdate.BorderStyle = BorderStyle.None;
            textBoxdate.Location = new Point(114, 231);
            textBoxdate.Name = "textBoxdate";
            textBoxdate.Size = new Size(270, 20);
            textBoxdate.TabIndex = 10;
            // 
            // stdPasslabel
            // 
            stdPasslabel.AutoSize = true;
            stdPasslabel.Location = new Point(115, 208);
            stdPasslabel.Name = "stdPasslabel";
            stdPasslabel.Size = new Size(39, 20);
            stdPasslabel.TabIndex = 9;
            stdPasslabel.Text = "date";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Location = new Point(547, 166);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 2);
            panel2.TabIndex = 8;
            // 
            // textBoxclass
            // 
            textBoxclass.BackColor = Color.White;
            textBoxclass.BorderStyle = BorderStyle.None;
            textBoxclass.Location = new Point(547, 141);
            textBoxclass.Name = "textBoxclass";
            textBoxclass.Size = new Size(270, 20);
            textBoxclass.TabIndex = 7;
            // 
            // classlabel
            // 
            classlabel.AutoSize = true;
            classlabel.Location = new Point(547, 118);
            classlabel.Name = "classlabel";
            classlabel.Size = new Size(40, 20);
            classlabel.TabIndex = 6;
            classlabel.Text = "class";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Location = new Point(114, 166);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 2);
            panel1.TabIndex = 5;
            // 
            // textBoxstdName
            // 
            textBoxstdName.BackColor = Color.White;
            textBoxstdName.BorderStyle = BorderStyle.None;
            textBoxstdName.Location = new Point(114, 141);
            textBoxstdName.Name = "textBoxstdName";
            textBoxstdName.Size = new Size(270, 20);
            textBoxstdName.TabIndex = 4;
            // 
            // stdNameLabel
            // 
            stdNameLabel.AutoSize = true;
            stdNameLabel.Location = new Point(114, 118);
            stdNameLabel.Name = "stdNameLabel";
            stdNameLabel.Size = new Size(49, 20);
            stdNameLabel.TabIndex = 3;
            stdNameLabel.Text = "Name";
            // 
            // tabcontroleaddstd
            // 
            tabcontroleaddstd.BackColor = Color.White;
            tabcontroleaddstd.Controls.Add(dataGridView1);
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
            tabcontroleaddstd.Click += tabcontroleaddstd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(872, 318);
            dataGridView1.TabIndex = 11;
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
            searchpictureBox.Click += searchpictureBox_Click;
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
            label6.Location = new Point(587, 43);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 7;
            label6.Text = "Student Id";
            // 
            // displayClassbtn
            // 
            displayClassbtn.Location = new Point(382, 66);
            displayClassbtn.Name = "displayClassbtn";
            displayClassbtn.Size = new Size(74, 29);
            displayClassbtn.TabIndex = 6;
            displayClassbtn.Text = "Display";
            displayClassbtn.UseVisualStyleBackColor = true;
            displayClassbtn.Click += displayClassbtn_Click;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 43);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 3;
            label5.Text = "class Id";
            // 
            // serchtextBox
            // 
            serchtextBox.BorderStyle = BorderStyle.None;
            serchtextBox.Location = new Point(587, 66);
            serchtextBox.Name = "serchtextBox";
            serchtextBox.Size = new Size(270, 20);
            serchtextBox.TabIndex = 8;
            // 
            // teacher_classesv
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(toolbtn);
            Controls.Add(editeStudents);
            Location = new Point(122, 125);
            Name = "teacher_classesv";
            Size = new Size(942, 501);
            editeStudents.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabcontroleaddstd.ResumeLayout(false);
            tabcontroleaddstd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchpictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolbtn;
        private TabPage tabcontroleaddstd;
        private TabPage tabPage2;
        private Panel panel3;
        private TextBox textBoxdate;
        private Label stdPasslabel;
        private Panel panel2;
        private TextBox textBoxclass;
        private Label classlabel;
        private Panel panel1;
        private TextBox textBoxstdName;
        private Label stdNameLabel;
        private Button addstdbtn;
        private Panel panel4;
        private TextBox textBoxstatus;
        private Label Statuslabel;
        private Panel panel5;
        private TextBox classIdtextBox;
        private Label label5;
        private Button displayClassbtn;
        private Panel panel6;
        private TextBox serchtextBox;
        private Label label6;
        private DataGridView dataGridView1;
        private PictureBox searchpictureBox;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        public TabControl editeStudents;
    }
}
