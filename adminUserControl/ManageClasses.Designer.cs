namespace DotnetXmlProject.adminUserControl
{
    partial class ManageClasses
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
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            stdClassID = new ListBox();
            addClassTeacher = new Button();
            addClassStd = new Button();
            teacherClassID = new ComboBox();
            classTeacherID = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            classStdID = new ComboBox();
            panel4 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            tabPage2 = new TabPage();
            classesData = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            userID = new ComboBox();
            panel5 = new Panel();
            label5 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)classesData).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(942, 488);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Azure;
            tabPage1.Controls.Add(stdClassID);
            tabPage1.Controls.Add(addClassTeacher);
            tabPage1.Controls.Add(addClassStd);
            tabPage1.Controls.Add(teacherClassID);
            tabPage1.Controls.Add(classTeacherID);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(classStdID);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.ForeColor = Color.DarkCyan;
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(934, 460);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add Subjects";
            tabPage1.Click += tabPage1_Click;
            // 
            // stdClassID
            // 
            stdClassID.BorderStyle = BorderStyle.None;
            stdClassID.ForeColor = Color.DarkCyan;
            stdClassID.FormattingEnabled = true;
            stdClassID.ItemHeight = 15;
            stdClassID.Location = new Point(107, 71);
            stdClassID.MultiColumn = true;
            stdClassID.Name = "stdClassID";
            stdClassID.SelectionMode = SelectionMode.MultiExtended;
            stdClassID.Size = new Size(197, 90);
            stdClassID.TabIndex = 33;
            // 
            // addClassTeacher
            // 
            addClassTeacher.BackColor = Color.DarkCyan;
            addClassTeacher.ForeColor = Color.White;
            addClassTeacher.Location = new Point(752, 324);
            addClassTeacher.Name = "addClassTeacher";
            addClassTeacher.Size = new Size(133, 42);
            addClassTeacher.TabIndex = 32;
            addClassTeacher.Text = "Add ";
            addClassTeacher.UseVisualStyleBackColor = false;
            addClassTeacher.Click += addClassTeacher_Click;
            // 
            // addClassStd
            // 
            addClassStd.BackColor = Color.DarkCyan;
            addClassStd.ForeColor = Color.White;
            addClassStd.Location = new Point(761, 133);
            addClassStd.Name = "addClassStd";
            addClassStd.Size = new Size(133, 42);
            addClassStd.TabIndex = 31;
            addClassStd.Text = "Add ";
            addClassStd.UseVisualStyleBackColor = false;
            addClassStd.Click += addClassStd_Click;
            // 
            // teacherClassID
            // 
            teacherClassID.FlatStyle = FlatStyle.Flat;
            teacherClassID.FormattingEnabled = true;
            teacherClassID.Location = new Point(107, 339);
            teacherClassID.Name = "teacherClassID";
            teacherClassID.Size = new Size(200, 23);
            teacherClassID.TabIndex = 30;
            // 
            // classTeacherID
            // 
            classTeacherID.FlatStyle = FlatStyle.Flat;
            classTeacherID.FormattingEnabled = true;
            classTeacherID.Location = new Point(495, 339);
            classTeacherID.Name = "classTeacherID";
            classTeacherID.Size = new Size(200, 23);
            classTeacherID.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Location = new Point(495, 368);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 2);
            panel1.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Location = new Point(107, 370);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 2);
            panel2.TabIndex = 26;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(418, 341);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 27;
            label1.Text = "Subject ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(13, 337);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 28;
            label2.Text = "Teacher ID :";
            // 
            // classStdID
            // 
            classStdID.FlatStyle = FlatStyle.Flat;
            classStdID.FormattingEnabled = true;
            classStdID.Location = new Point(504, 138);
            classStdID.Name = "classStdID";
            classStdID.Size = new Size(200, 23);
            classStdID.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkCyan;
            panel4.Location = new Point(504, 167);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 2);
            panel4.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkCyan;
            panel3.Location = new Point(107, 173);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 2);
            panel3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(411, 140);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 6;
            label4.Text = "Subject ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(12, 142);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 1;
            label3.Text = "Student ID :";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Azure;
            tabPage2.Controls.Add(classesData);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(userID);
            tabPage2.Controls.Add(panel5);
            tabPage2.Controls.Add(label5);
            tabPage2.ForeColor = Color.DarkCyan;
            tabPage2.Location = new Point(4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(934, 460);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Manage Subjects";
            // 
            // classesData
            // 
            classesData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            classesData.BackgroundColor = Color.Azure;
            classesData.BorderStyle = BorderStyle.None;
            classesData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            classesData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            classesData.EditMode = DataGridViewEditMode.EditProgrammatically;
            classesData.Location = new Point(70, 144);
            classesData.Name = "classesData";
            classesData.Size = new Size(786, 255);
            classesData.TabIndex = 30;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkCyan;
            button4.ForeColor = Color.White;
            button4.Location = new Point(490, 52);
            button4.Name = "button4";
            button4.Size = new Size(133, 42);
            button4.TabIndex = 29;
            button4.Text = "Show";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkCyan;
            button3.ForeColor = Color.White;
            button3.Location = new Point(647, 52);
            button3.Name = "button3";
            button3.Size = new Size(133, 42);
            button3.TabIndex = 28;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // userID
            // 
            userID.FlatStyle = FlatStyle.Flat;
            userID.FormattingEnabled = true;
            userID.Location = new Point(254, 52);
            userID.Name = "userID";
            userID.Size = new Size(200, 23);
            userID.TabIndex = 27;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkCyan;
            panel5.Location = new Point(254, 83);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 2);
            panel5.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(169, 50);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 26;
            label5.Text = "User ID :";
            // 
            // ManageClasses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(tabControl1);
            ForeColor = Color.DarkCyan;
            Name = "ManageClasses";
            Size = new Size(942, 501);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)classesData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button addClassStd;
        private ComboBox teacherClassID;
        private ComboBox classTeacherID;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private ComboBox classStdID;
        private Panel panel4;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private TabPage tabPage2;
        private Button addClassTeacher;
        private ComboBox userID;
        private Panel panel5;
        private Label label5;
        private Button button4;
        private Button button3;
        private DataGridView classesData;
        private ListBox stdClassID;
    }
}
