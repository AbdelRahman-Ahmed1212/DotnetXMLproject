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
            addClassTeacher = new Button();
            addClassStd = new Button();
            teacherClassID = new ComboBox();
            classTeacherID = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            stdClassID = new ComboBox();
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
            tabControl1.Size = new Size(703, 311);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(addClassTeacher);
            tabPage1.Controls.Add(addClassStd);
            tabPage1.Controls.Add(teacherClassID);
            tabPage1.Controls.Add(classTeacherID);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(stdClassID);
            tabPage1.Controls.Add(classStdID);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(695, 283);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add Classes";
            // 
            // addClassTeacher
            // 
            addClassTeacher.BackColor = Color.Indigo;
            addClassTeacher.ForeColor = Color.White;
            addClassTeacher.Location = new Point(278, 224);
            addClassTeacher.Name = "addClassTeacher";
            addClassTeacher.Size = new Size(133, 42);
            addClassTeacher.TabIndex = 32;
            addClassTeacher.Text = "Add ";
            addClassTeacher.UseVisualStyleBackColor = false;
            addClassTeacher.Click += addClassTeacher_Click;
            // 
            // addClassStd
            // 
            addClassStd.BackColor = Color.Indigo;
            addClassStd.ForeColor = Color.White;
            addClassStd.Location = new Point(278, 94);
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
            teacherClassID.Location = new Point(91, 168);
            teacherClassID.Name = "teacherClassID";
            teacherClassID.Size = new Size(200, 23);
            teacherClassID.TabIndex = 30;
            // 
            // classTeacherID
            // 
            classTeacherID.FlatStyle = FlatStyle.Flat;
            classTeacherID.FormattingEnabled = true;
            classTeacherID.Location = new Point(434, 164);
            classTeacherID.Name = "classTeacherID";
            classTeacherID.Size = new Size(200, 23);
            classTeacherID.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Location = new Point(434, 193);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 2);
            panel1.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Indigo;
            panel2.Location = new Point(91, 199);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 2);
            panel2.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(357, 166);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 27;
            label1.Text = "Class ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(6, 166);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 28;
            label2.Text = "Teacher ID :";
            // 
            // stdClassID
            // 
            stdClassID.FlatStyle = FlatStyle.Flat;
            stdClassID.FormattingEnabled = true;
            stdClassID.Location = new Point(91, 43);
            stdClassID.Name = "stdClassID";
            stdClassID.Size = new Size(200, 23);
            stdClassID.TabIndex = 24;
            // 
            // classStdID
            // 
            classStdID.FlatStyle = FlatStyle.Flat;
            classStdID.FormattingEnabled = true;
            classStdID.Location = new Point(434, 39);
            classStdID.Name = "classStdID";
            classStdID.Size = new Size(200, 23);
            classStdID.TabIndex = 23;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Indigo;
            panel4.Location = new Point(434, 68);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 2);
            panel4.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Indigo;
            panel3.Location = new Point(91, 74);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 2);
            panel3.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(357, 41);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 21;
            label4.Text = "Class ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 41);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 22;
            label3.Text = "Student ID :";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(classesData);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(userID);
            tabPage2.Controls.Add(panel5);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(695, 283);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Manage Classes";
            // 
            // classesData
            // 
            classesData.BackgroundColor = Color.White;
            classesData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            classesData.EditMode = DataGridViewEditMode.EditProgrammatically;
            classesData.Location = new Point(21, 102);
            classesData.Name = "classesData";
            classesData.Size = new Size(658, 175);
            classesData.TabIndex = 30;
            // 
            // button4
            // 
            button4.BackColor = Color.Indigo;
            button4.ForeColor = Color.White;
            button4.Location = new Point(342, 43);
            button4.Name = "button4";
            button4.Size = new Size(133, 42);
            button4.TabIndex = 29;
            button4.Text = "Show";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Indigo;
            button3.ForeColor = Color.White;
            button3.Location = new Point(499, 43);
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
            userID.Location = new Point(106, 43);
            userID.Name = "userID";
            userID.Size = new Size(200, 23);
            userID.TabIndex = 27;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Indigo;
            panel5.Location = new Point(106, 74);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 2);
            panel5.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(21, 41);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 26;
            label5.Text = "User ID :";
            // 
            // ManageClasses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControl1);
            Name = "ManageClasses";
            Size = new Size(706, 382);
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
        private ComboBox stdClassID;
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
    }
}
