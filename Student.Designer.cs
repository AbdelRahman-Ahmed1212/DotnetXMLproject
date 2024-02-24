namespace DotnetXmlProject
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
            panel1 = new Panel();
            panel5 = new Panel();
            StdReportbtn = new Button();
            panel4 = new Panel();
            stdSmallSidePanel = new Panel();
            stdAttendencebtn = new Button();
            panel2 = new Panel();
            stduserlabel = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            button1 = new Button();
            stdroleNamelabel = new Label();
            stdrolelabel = new Label();
            stdusernamelabel = new Label();
            stdwelcomlabel = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            panel1.Paint += panel1_Paint;
            // 
            // panel5
            // 
            panel5.Controls.Add(StdReportbtn);
            resources.ApplyResources(panel5, "panel5");
            panel5.Name = "panel5";
            // 
            // StdReportbtn
            // 
            StdReportbtn.Cursor = Cursors.Hand;
            StdReportbtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(StdReportbtn, "StdReportbtn");
       //     StdReportbtn.Image = Properties.Resources.Report;
            StdReportbtn.Name = "StdReportbtn";
            StdReportbtn.UseVisualStyleBackColor = true;
            StdReportbtn.Click += StdReportbtn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(stdSmallSidePanel);
            panel4.Controls.Add(stdAttendencebtn);
            resources.ApplyResources(panel4, "panel4");
            panel4.Name = "panel4";
            // 
            // stdSmallSidePanel
            // 
            stdSmallSidePanel.BackColor = Color.White;
            resources.ApplyResources(stdSmallSidePanel, "stdSmallSidePanel");
            stdSmallSidePanel.Name = "stdSmallSidePanel";
            // 
            // stdAttendencebtn
            // 
            stdAttendencebtn.Cursor = Cursors.Hand;
            stdAttendencebtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(stdAttendencebtn, "stdAttendencebtn");
          //  stdAttendencebtn.Image = Properties.Resources.attendenceIcon_;
            stdAttendencebtn.Name = "stdAttendencebtn";
            stdAttendencebtn.UseVisualStyleBackColor = true;
            stdAttendencebtn.Click += stdAttendencebtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Controls.Add(stduserlabel);
            panel2.Controls.Add(pictureBox1);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // stduserlabel
            // 
            resources.ApplyResources(stduserlabel, "stduserlabel");
            stduserlabel.ForeColor = Color.White;
            stduserlabel.Name = "stduserlabel";
            // 
            // pictureBox1
            // 
          //  pictureBox1.Image = Properties.Resources.vector_male_student_icon_removebg_preview;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkCyan;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(stdroleNamelabel);
            panel3.Controls.Add(stdrolelabel);
            panel3.Controls.Add(stdusernamelabel);
            panel3.Controls.Add(stdwelcomlabel);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // stdroleNamelabel
            // 
            resources.ApplyResources(stdroleNamelabel, "stdroleNamelabel");
            stdroleNamelabel.Name = "stdroleNamelabel";
            // 
            // stdrolelabel
            // 
            resources.ApplyResources(stdrolelabel, "stdrolelabel");
            stdrolelabel.Name = "stdrolelabel";
            // 
            // stdusernamelabel
            // 
            resources.ApplyResources(stdusernamelabel, "stdusernamelabel");
            stdusernamelabel.Name = "stdusernamelabel";
            // 
            // stdwelcomlabel
            // 
            resources.ApplyResources(stdwelcomlabel, "stdwelcomlabel");
            stdwelcomlabel.Name = "stdwelcomlabel";
            // 
            // Student
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Student";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label stduserlabel;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label stdusernamelabel;
        private Label stdwelcomlabel;
        private Panel panel4;
        private Button stdAttendencebtn;
        private Button button1;
        private Label stdroleNamelabel;
        private Label stdrolelabel;
        private Panel panel5;
        private Button StdReportbtn;
        private Panel stdSmallSidePanel;
    }
}