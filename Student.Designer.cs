﻿namespace DotnetXmlProject
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            panel4 = new Panel();
            stdSmallSidePanel = new Panel();
            stdAttendencebtn = new Button();
            panel5 = new Panel();
            StdReportbtn = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            applabel = new Label();
            pictureBox1 = new PictureBox();
            panel8 = new Panel();
            pictureBox2 = new PictureBox();
            panel9 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            stdwelcomlabel = new Label();
            stdusernamelabel = new Label();
            rolelabel = new Label();
            stdroleNamelabel = new Label();
            button1 = new Button();
            panel3 = new Panel();
            panel6 = new Panel();
            stddataGridView = new DataGridView();
            searchbtn = new PictureBox();
            panel7 = new Panel();
            label6 = new Label();
            searchBox = new TextBox();
            reserbtn = new Button();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stddataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchbtn).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            resources.ApplyResources(panel4, "panel4");
            panel4.Controls.Add(stdSmallSidePanel);
            panel4.Controls.Add(stdAttendencebtn);
            panel4.Name = "panel4";
            // 
            // stdSmallSidePanel
            // 
            resources.ApplyResources(stdSmallSidePanel, "stdSmallSidePanel");
            stdSmallSidePanel.BackColor = Color.White;
            stdSmallSidePanel.Name = "stdSmallSidePanel";
            // 
            // stdAttendencebtn
            // 
            resources.ApplyResources(stdAttendencebtn, "stdAttendencebtn");
            stdAttendencebtn.Cursor = Cursors.Hand;
            stdAttendencebtn.FlatAppearance.BorderSize = 0;
            stdAttendencebtn.Name = "stdAttendencebtn";
            stdAttendencebtn.UseVisualStyleBackColor = true;
            stdAttendencebtn.Click += stdAttendencebtn_Click;
            // 
            // panel5
            // 
            resources.ApplyResources(panel5, "panel5");
            panel5.Controls.Add(StdReportbtn);
            panel5.Name = "panel5";
            // 
            // StdReportbtn
            // 
            resources.ApplyResources(StdReportbtn, "StdReportbtn");
            StdReportbtn.Cursor = Cursors.Hand;
            StdReportbtn.FlatAppearance.BorderSize = 0;
            StdReportbtn.Name = "StdReportbtn";
            StdReportbtn.UseVisualStyleBackColor = true;
            StdReportbtn.Click += StdReportbtn_Click;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Name = "panel1";
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.BackColor = Color.DarkCyan;
            panel2.Controls.Add(applabel);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel8);
            panel2.Name = "panel2";
            // 
            // applabel
            // 
            resources.ApplyResources(applabel, "applabel");
            applabel.ForeColor = Color.White;
            applabel.Name = "applabel";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // panel8
            // 
            resources.ApplyResources(panel8, "panel8");
            panel8.Controls.Add(pictureBox2);
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(label1);
            panel8.Controls.Add(dataGridView1);
            panel8.Controls.Add(textBox1);
            panel8.Name = "panel8";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Image = Properties.Resources.search_removebg_preview;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // panel9
            // 
            resources.ApplyResources(panel9, "panel9");
            panel9.BackColor = Color.Gray;
            panel9.Name = "panel9";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // dataGridView1
            // 
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Name = "dataGridView1";
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Name = "textBox1";
            // 
            // stdwelcomlabel
            // 
            resources.ApplyResources(stdwelcomlabel, "stdwelcomlabel");
            stdwelcomlabel.Name = "stdwelcomlabel";
            // 
            // stdusernamelabel
            // 
            resources.ApplyResources(stdusernamelabel, "stdusernamelabel");
            stdusernamelabel.Name = "stdusernamelabel";
            // 
            // rolelabel
            // 
            resources.ApplyResources(rolelabel, "rolelabel");
            rolelabel.Name = "rolelabel";
            // 
            // stdroleNamelabel
            // 
            resources.ApplyResources(stdroleNamelabel, "stdroleNamelabel");
            stdroleNamelabel.Name = "stdroleNamelabel";
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Cursor = Cursors.Hand;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.BackColor = Color.DarkCyan;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(stdroleNamelabel);
            panel3.Controls.Add(rolelabel);
            panel3.Controls.Add(stdusernamelabel);
            panel3.Controls.Add(stdwelcomlabel);
            panel3.Name = "panel3";
            // 
            // panel6
            // 
            resources.ApplyResources(panel6, "panel6");
            panel6.Name = "panel6";
            // 
            // stddataGridView
            // 
            resources.ApplyResources(stddataGridView, "stddataGridView");
            stddataGridView.BackgroundColor = Color.White;
            stddataGridView.BorderStyle = BorderStyle.None;
            stddataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stddataGridView.Name = "stddataGridView";
            // 
            // searchbtn
            // 
            resources.ApplyResources(searchbtn, "searchbtn");
            searchbtn.Image = Properties.Resources.search_removebg_preview;
            searchbtn.Name = "searchbtn";
            searchbtn.TabStop = false;
            searchbtn.Click += searchBox_Click;
            // 
            // panel7
            // 
            resources.ApplyResources(panel7, "panel7");
            panel7.BackColor = Color.Gray;
            panel7.Name = "panel7";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // searchBox
            // 
            resources.ApplyResources(searchBox, "searchBox");
            searchBox.BorderStyle = BorderStyle.None;
            searchBox.Name = "searchBox";
            // 
            // reserbtn
            // 
            resources.ApplyResources(reserbtn, "reserbtn");
            reserbtn.BackColor = Color.White;
            reserbtn.Cursor = Cursors.Hand;
            reserbtn.Name = "reserbtn";
            reserbtn.UseVisualStyleBackColor = false;
            reserbtn.Click += reserbtn_Click;
            // 
            // Student
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(reserbtn);
            Controls.Add(searchbtn);
            Controls.Add(panel7);
            Controls.Add(label6);
            Controls.Add(searchBox);
            Controls.Add(stddataGridView);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Name = "Student";
            WindowState = FormWindowState.Maximized;
            Load += Student_Load;
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stddataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchbtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel4;
        private Panel stdSmallSidePanel;
        private Button stdAttendencebtn;
        private Panel panel5;
        private Button StdReportbtn;
        private Panel panel1;
        private Panel panel2;
        private Label applabel;
        private PictureBox pictureBox1;
        private Panel panel8;
        private PictureBox pictureBox2;
        private Panel panel9;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label stdwelcomlabel;
        private Label stdusernamelabel;
        private Label rolelabel;
        private Label stdroleNamelabel;
        private Button button1;
        private Panel panel3;
        private Panel panel6;
        private DataGridView stddataGridView;
        private PictureBox searchbtn;
        private Panel panel7;
        private Label label6;
        private TextBox searchBox;
        private Button reserbtn;
    }
}