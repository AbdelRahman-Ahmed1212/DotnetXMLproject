namespace DotnetXmlProject
{
    partial class Teacher
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
            TchpanelSide = new Panel();
            panel6 = new Panel();
            TchReportbutton = new Button();
            panel4 = new Panel();
            TchAttendencebutton = new Button();
            panel1 = new Panel();
            TchSidepanel = new Panel();
            TchClassesbutton = new Button();
            panel2 = new Panel();
            tchHeadLabel = new Label();
            pictureBox1 = new PictureBox();
            TchPanelTop = new Panel();
            Logoutbutton = new Button();
            rolelabel = new Label();
            usernamelabel = new Label();
            Rlabel1 = new Label();
            Wlabel = new Label();
            TchpanelSide.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            TchPanelTop.SuspendLayout();
            SuspendLayout();
            // 
            // TchpanelSide
            // 
            TchpanelSide.BackColor = Color.PeachPuff;
            TchpanelSide.Controls.Add(panel6);
            TchpanelSide.Controls.Add(panel4);
            TchpanelSide.Controls.Add(panel1);
            TchpanelSide.Controls.Add(panel2);
            TchpanelSide.Dock = DockStyle.Left;
            TchpanelSide.Location = new Point(0, 0);
            TchpanelSide.Name = "TchpanelSide";
            TchpanelSide.Size = new Size(258, 720);
            TchpanelSide.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(TchReportbutton);
            panel6.Location = new Point(4, 331);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 59);
            panel6.TabIndex = 3;
            // 
            // TchReportbutton
            // 
            TchReportbutton.FlatAppearance.BorderSize = 0;
            TchReportbutton.FlatStyle = FlatStyle.Flat;
        //    TchReportbutton.Image = Properties.Resources.Report1;
            TchReportbutton.ImageAlign = ContentAlignment.MiddleLeft;
            TchReportbutton.Location = new Point(36, 14);
            TchReportbutton.Name = "TchReportbutton";
            TchReportbutton.Size = new Size(160, 29);
            TchReportbutton.TabIndex = 0;
            TchReportbutton.Text = "    Report";
            TchReportbutton.UseVisualStyleBackColor = true;
            TchReportbutton.Click += TchReportbutton_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(TchAttendencebutton);
            panel4.Location = new Point(5, 262);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 59);
            panel4.TabIndex = 2;
            // 
            // TchAttendencebutton
            // 
            TchAttendencebutton.FlatAppearance.BorderSize = 0;
            TchAttendencebutton.FlatStyle = FlatStyle.Flat;
        //    TchAttendencebutton.Image = Properties.Resources.attendenceIcon_1;
            TchAttendencebutton.ImageAlign = ContentAlignment.MiddleLeft;
            TchAttendencebutton.Location = new Point(36, 14);
            TchAttendencebutton.Name = "TchAttendencebutton";
            TchAttendencebutton.Size = new Size(160, 29);
            TchAttendencebutton.TabIndex = 0;
            TchAttendencebutton.Text = "    Attendence";
            TchAttendencebutton.UseVisualStyleBackColor = true;
            TchAttendencebutton.Click += TchAttendencebutton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(TchSidepanel);
            panel1.Controls.Add(TchClassesbutton);
            panel1.Location = new Point(5, 197);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 59);
            panel1.TabIndex = 1;
            // 
            // TchSidepanel
            // 
            TchSidepanel.BackColor = Color.White;
            TchSidepanel.Dock = DockStyle.Left;
            TchSidepanel.Location = new Point(0, 0);
            TchSidepanel.Name = "TchSidepanel";
            TchSidepanel.Size = new Size(10, 59);
            TchSidepanel.TabIndex = 1;
            // 
            // TchClassesbutton
            // 
            TchClassesbutton.FlatAppearance.BorderSize = 0;
            TchClassesbutton.FlatStyle = FlatStyle.Flat;
        //    TchClassesbutton.Image = Properties.Resources._class;
            TchClassesbutton.ImageAlign = ContentAlignment.MiddleLeft;
            TchClassesbutton.Location = new Point(36, 14);
            TchClassesbutton.Name = "TchClassesbutton";
            TchClassesbutton.Size = new Size(160, 29);
            TchClassesbutton.TabIndex = 0;
            TchClassesbutton.Text = "   Classes";
            TchClassesbutton.UseVisualStyleBackColor = true;
            TchClassesbutton.Click += TchClassesbutton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tchHeadLabel);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 180);
            panel2.TabIndex = 0;
            // 
            // tchHeadLabel
            // 
            tchHeadLabel.AutoSize = true;
            tchHeadLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tchHeadLabel.ForeColor = Color.White;
            tchHeadLabel.Location = new Point(56, 123);
            tchHeadLabel.Name = "tchHeadLabel";
            tchHeadLabel.Size = new Size(145, 20);
            tchHeadLabel.TabIndex = 1;
            tchHeadLabel.Text = "Attendence System";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
         //   pictureBox1.Image = Properties.Resources.teacherIcon_removebg_preview;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TchPanelTop
            // 
            TchPanelTop.BackColor = Color.DarkSalmon;
            TchPanelTop.Controls.Add(Logoutbutton);
            TchPanelTop.Controls.Add(rolelabel);
            TchPanelTop.Controls.Add(usernamelabel);
            TchPanelTop.Controls.Add(Rlabel1);
            TchPanelTop.Controls.Add(Wlabel);
            TchPanelTop.Dock = DockStyle.Top;
            TchPanelTop.Location = new Point(258, 0);
            TchPanelTop.Name = "TchPanelTop";
            TchPanelTop.Size = new Size(942, 125);
            TchPanelTop.TabIndex = 1;
            // 
            // Logoutbutton
            // 
            Logoutbutton.Location = new Point(845, 48);
            Logoutbutton.Name = "Logoutbutton";
            Logoutbutton.Size = new Size(94, 29);
            Logoutbutton.TabIndex = 4;
            Logoutbutton.Text = "Logout";
            Logoutbutton.UseVisualStyleBackColor = true;
            Logoutbutton.Click += Logoutbutton_Click;
            // 
            // rolelabel
            // 
            rolelabel.AutoSize = true;
            rolelabel.Location = new Point(108, 80);
            rolelabel.Name = "rolelabel";
            rolelabel.Size = new Size(13, 20);
            rolelabel.TabIndex = 3;
            rolelabel.Text = "!";
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.Location = new Point(108, 39);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(13, 20);
            usernamelabel.TabIndex = 2;
            usernamelabel.Text = "!";
            // 
            // Rlabel1
            // 
            Rlabel1.AutoSize = true;
            Rlabel1.Location = new Point(24, 80);
            Rlabel1.Name = "Rlabel1";
            Rlabel1.Size = new Size(50, 20);
            Rlabel1.TabIndex = 1;
            Rlabel1.Text = "Role : ";
            // 
            // Wlabel
            // 
            Wlabel.AutoSize = true;
            Wlabel.Location = new Point(24, 39);
            Wlabel.Name = "Wlabel";
            Wlabel.Size = new Size(78, 20);
            Wlabel.TabIndex = 0;
            Wlabel.Text = "Welcome: ";
            // 
            // Teacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 720);
            Controls.Add(TchPanelTop);
            Controls.Add(TchpanelSide);
            Name = "Teacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teacher";
            WindowState = FormWindowState.Maximized;
            Load += Teacher_Load;
            TchpanelSide.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            TchPanelTop.ResumeLayout(false);
            TchPanelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel TchpanelSide;
        private Panel panel2;
        private Label tchHeadLabel;
        private PictureBox pictureBox1;
        private Panel TchPanelTop;
        private Panel panel1;
        private Button TchClassesbutton;
        private Label rolelabel;
        private Label usernamelabel;
        private Label Rlabel1;
        private Label Wlabel;
        private Panel panel4;
        private Button TchAttendencebutton;
        private Panel TchSidepanel;
        private Panel panel6;
        private Button TchReportbutton;
        private Button Logoutbutton;
    }
}