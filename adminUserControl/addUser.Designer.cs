namespace DotnetXmlProject.adminUserControl
{
    partial class addUser
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
            Users = new ToolTip(components);
            studentPage = new TabPage();
            studentData = new DataGridView();
            panel8 = new Panel();
            label1 = new Label();
            UsernameStudentText = new TextBox();
            deleteStdBtn = new Button();
            stdEditBtn = new Button();
            label8 = new Label();
            label12 = new Label();
            label13 = new Label();
            PassStudentText = new TextBox();
            nameStudentText = new TextBox();
            IDStudentText = new TextBox();
            pictureBox2 = new PictureBox();
            panel9 = new Panel();
            stdSearchText = new TextBox();
            label14 = new Label();
            tabPage2 = new TabPage();
            panel6 = new Panel();
            label7 = new Label();
            teacherDeleteBtn = new Button();
            teacherEditBtn = new Button();
            nameTecherText = new TextBox();
            label10 = new Label();
            label9 = new Label();
            ID = new Label();
            PassTeacherText = new TextBox();
            usernameTeacherText = new TextBox();
            IDTeacherText = new TextBox();
            pictureBox1 = new PictureBox();
            panel7 = new Panel();
            teacherSearchText = new TextBox();
            label6 = new Label();
            panel5 = new Panel();
            teacherData = new DataGridView();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            NameText = new TextBox();
            label11 = new Label();
            label5 = new Label();
            button1 = new Button();
            RoleCombobox = new ComboBox();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            usernameText = new TextBox();
            passwordText = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabControl1 = new TabControl();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            studentPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentData).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teacherData).BeginInit();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // studentPage
            // 
            studentPage.BackColor = Color.White;
            studentPage.Controls.Add(studentData);
            studentPage.Controls.Add(panel8);
            studentPage.Location = new Point(4, 4);
            studentPage.Name = "studentPage";
            studentPage.Padding = new Padding(3);
            studentPage.Size = new Size(613, 298);
            studentPage.TabIndex = 2;
            studentPage.Text = "Students";
            // 
            // studentData
            // 
            studentData.BackgroundColor = Color.White;
            studentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentData.Location = new Point(0, 156);
            studentData.Name = "studentData";
            studentData.Size = new Size(598, 136);
            studentData.TabIndex = 4;
            // 
            // panel8
            // 
            panel8.Controls.Add(label1);
            panel8.Controls.Add(UsernameStudentText);
            panel8.Controls.Add(deleteStdBtn);
            panel8.Controls.Add(stdEditBtn);
            panel8.Controls.Add(label8);
            panel8.Controls.Add(label12);
            panel8.Controls.Add(label13);
            panel8.Controls.Add(PassStudentText);
            panel8.Controls.Add(nameStudentText);
            panel8.Controls.Add(IDStudentText);
            panel8.Controls.Add(pictureBox2);
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(stdSearchText);
            panel8.Controls.Add(label14);
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(595, 137);
            panel8.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 111);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 13;
            label1.Text = "Username :";
            // 
            // UsernameStudentText
            // 
            UsernameStudentText.Location = new Point(427, 111);
            UsernameStudentText.Name = "UsernameStudentText";
            UsernameStudentText.Size = new Size(131, 23);
            UsernameStudentText.TabIndex = 12;
            // 
            // deleteStdBtn
            // 
            deleteStdBtn.BackColor = Color.Indigo;
            deleteStdBtn.ForeColor = Color.White;
            deleteStdBtn.Location = new Point(472, 7);
            deleteStdBtn.Name = "deleteStdBtn";
            deleteStdBtn.Size = new Size(86, 31);
            deleteStdBtn.TabIndex = 9;
            deleteStdBtn.Text = "Delete";
            deleteStdBtn.UseVisualStyleBackColor = false;
            deleteStdBtn.Click += deleteStdBtn_Click;
            // 
            // stdEditBtn
            // 
            stdEditBtn.BackColor = Color.Indigo;
            stdEditBtn.ForeColor = Color.White;
            stdEditBtn.Location = new Point(380, 7);
            stdEditBtn.Name = "stdEditBtn";
            stdEditBtn.Size = new Size(86, 31);
            stdEditBtn.TabIndex = 10;
            stdEditBtn.Text = "Edit";
            stdEditBtn.UseVisualStyleBackColor = false;
            stdEditBtn.Click += stdEditBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(322, 67);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 11;
            label8.Text = "Password :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(32, 111);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 10;
            label12.Text = "Name :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(32, 67);
            label13.Name = "label13";
            label13.Size = new Size(24, 15);
            label13.TabIndex = 3;
            label13.Text = "ID :";
            // 
            // PassStudentText
            // 
            PassStudentText.Location = new Point(427, 64);
            PassStudentText.Name = "PassStudentText";
            PassStudentText.Size = new Size(131, 23);
            PassStudentText.TabIndex = 7;
            // 
            // nameStudentText
            // 
            nameStudentText.Location = new Point(143, 111);
            nameStudentText.Name = "nameStudentText";
            nameStudentText.Size = new Size(131, 23);
            nameStudentText.TabIndex = 8;
            // 
            // IDStudentText
            // 
            IDStudentText.Location = new Point(143, 64);
            IDStudentText.Name = "IDStudentText";
            IDStudentText.Size = new Size(138, 23);
            IDStudentText.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.ImageLocation = "D:\\C#XML\\Images\\Screenshot 2024-02-16 221054.png";
            pictureBox2.Location = new Point(300, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Indigo;
            panel9.Location = new Point(124, 29);
            panel9.Name = "panel9";
            panel9.Size = new Size(200, 2);
            panel9.TabIndex = 2;
            // 
            // stdSearchText
            // 
            stdSearchText.BorderStyle = BorderStyle.None;
            stdSearchText.Location = new Point(124, 10);
            stdSearchText.Name = "stdSearchText";
            stdSearchText.Size = new Size(170, 16);
            stdSearchText.TabIndex = 4;
            stdSearchText.TextChanged += stdSearchText_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(3, 10);
            label14.Name = "label14";
            label14.Size = new Size(116, 21);
            label14.TabIndex = 3;
            label14.Text = "Student Name :";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(panel6);
            tabPage2.Controls.Add(panel5);
            tabPage2.Controls.Add(teacherData);
            tabPage2.Location = new Point(4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(613, 298);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Teachers";
            // 
            // panel6
            // 
            panel6.Controls.Add(label7);
            panel6.Controls.Add(teacherDeleteBtn);
            panel6.Controls.Add(teacherEditBtn);
            panel6.Controls.Add(nameTecherText);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(ID);
            panel6.Controls.Add(PassTeacherText);
            panel6.Controls.Add(usernameTeacherText);
            panel6.Controls.Add(IDTeacherText);
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(teacherSearchText);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(1, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(595, 137);
            panel6.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 106);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 13;
            label7.Text = "Name :";
            // 
            // teacherDeleteBtn
            // 
            teacherDeleteBtn.BackColor = Color.Indigo;
            teacherDeleteBtn.ForeColor = Color.White;
            teacherDeleteBtn.Location = new Point(473, 7);
            teacherDeleteBtn.Name = "teacherDeleteBtn";
            teacherDeleteBtn.Size = new Size(86, 31);
            teacherDeleteBtn.TabIndex = 7;
            teacherDeleteBtn.Text = "Delete";
            teacherDeleteBtn.UseVisualStyleBackColor = false;
            teacherDeleteBtn.Click += teacherDeleteBtn_Click;
            // 
            // teacherEditBtn
            // 
            teacherEditBtn.BackColor = Color.Indigo;
            teacherEditBtn.ForeColor = Color.White;
            teacherEditBtn.Location = new Point(381, 7);
            teacherEditBtn.Name = "teacherEditBtn";
            teacherEditBtn.Size = new Size(86, 31);
            teacherEditBtn.TabIndex = 8;
            teacherEditBtn.Text = "Edit";
            teacherEditBtn.UseVisualStyleBackColor = false;
            teacherEditBtn.Click += teacherEditBtn_Click;
            // 
            // nameTecherText
            // 
            nameTecherText.Location = new Point(143, 103);
            nameTecherText.Name = "nameTecherText";
            nameTecherText.Size = new Size(131, 23);
            nameTecherText.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(322, 67);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 11;
            label10.Text = "Password :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(316, 111);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 10;
            label9.Text = "Username :";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(32, 67);
            ID.Name = "ID";
            ID.Size = new Size(24, 15);
            ID.TabIndex = 3;
            ID.Text = "ID :";
            // 
            // PassTeacherText
            // 
            PassTeacherText.Location = new Point(427, 64);
            PassTeacherText.Name = "PassTeacherText";
            PassTeacherText.Size = new Size(132, 23);
            PassTeacherText.TabIndex = 7;
            // 
            // usernameTeacherText
            // 
            usernameTeacherText.Location = new Point(427, 106);
            usernameTeacherText.Name = "usernameTeacherText";
            usernameTeacherText.Size = new Size(132, 23);
            usernameTeacherText.TabIndex = 8;
            // 
            // IDTeacherText
            // 
            IDTeacherText.Location = new Point(143, 64);
            IDTeacherText.Name = "IDTeacherText";
            IDTeacherText.Size = new Size(132, 23);
            IDTeacherText.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "D:\\C#XML\\Images\\Screenshot 2024-02-16 221054.png";
            pictureBox1.Location = new Point(300, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Indigo;
            panel7.Location = new Point(124, 29);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 2);
            panel7.TabIndex = 2;
            // 
            // teacherSearchText
            // 
            teacherSearchText.BorderStyle = BorderStyle.None;
            teacherSearchText.Location = new Point(124, 10);
            teacherSearchText.Name = "teacherSearchText";
            teacherSearchText.Size = new Size(170, 16);
            teacherSearchText.TabIndex = 4;
            teacherSearchText.TextChanged += teacherSearchText_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(3, 10);
            label6.Name = "label6";
            label6.Size = new Size(115, 21);
            label6.TabIndex = 3;
            label6.Text = "Teacher Name :";
            // 
            // panel5
            // 
            panel5.Location = new Point(1227, 289);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 100);
            panel5.TabIndex = 1;
            // 
            // teacherData
            // 
            teacherData.BackgroundColor = Color.White;
            teacherData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teacherData.Location = new Point(3, 157);
            teacherData.Name = "teacherData";
            teacherData.Size = new Size(593, 141);
            teacherData.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(NameText);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(RoleCombobox);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(usernameText);
            tabPage1.Controls.Add(passwordText);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(613, 298);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add User";
            tabPage1.Click += tabPage1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Location = new Point(54, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 2);
            panel1.TabIndex = 7;
            // 
            // NameText
            // 
            NameText.BorderStyle = BorderStyle.None;
            NameText.Location = new Point(54, 118);
            NameText.Name = "NameText";
            NameText.Size = new Size(200, 16);
            NameText.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(54, 83);
            label11.Name = "label11";
            label11.Size = new Size(59, 21);
            label11.TabIndex = 8;
            label11.Text = "Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.Location = new Point(235, 19);
            label5.Name = "label5";
            label5.Size = new Size(98, 28);
            label5.TabIndex = 6;
            label5.Text = "Add User";
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.ForeColor = Color.White;
            button1.Location = new Point(235, 253);
            button1.Name = "button1";
            button1.Size = new Size(133, 42);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // RoleCombobox
            // 
            RoleCombobox.FlatStyle = FlatStyle.Flat;
            RoleCombobox.FormattingEnabled = true;
            RoleCombobox.Location = new Point(351, 200);
            RoleCombobox.Name = "RoleCombobox";
            RoleCombobox.Size = new Size(200, 23);
            RoleCombobox.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Indigo;
            panel4.Location = new Point(351, 232);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 2);
            panel4.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Indigo;
            panel3.Location = new Point(351, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 2);
            panel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Indigo;
            panel2.Location = new Point(54, 232);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 2);
            panel2.TabIndex = 0;
            // 
            // usernameText
            // 
            usernameText.BorderStyle = BorderStyle.None;
            usernameText.Location = new Point(351, 118);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(200, 16);
            usernameText.TabIndex = 2;
            // 
            // passwordText
            // 
            passwordText.BorderStyle = BorderStyle.None;
            passwordText.Location = new Point(54, 207);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(200, 16);
            passwordText.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(351, 168);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 0;
            label4.Text = "Role :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(351, 83);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 0;
            label3.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(54, 168);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 0;
            label2.Text = "Password :";
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(studentPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(621, 326);
            tabControl1.TabIndex = 0;
            // 
            // addUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControl1);
            ForeColor = Color.Indigo;
            Name = "addUser";
            Size = new Size(621, 326);
            studentPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)studentData).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)teacherData).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ToolTip Users;
        private TabPage studentPage;
        private DataGridView studentData;
        private Panel panel8;
        private Button deleteStdBtn;
        private Button stdEditBtn;
        private Label label8;
        private Label label12;
        private Label label13;
        private TextBox PassStudentText;
        private TextBox nameStudentText;
        private TextBox IDStudentText;
        private PictureBox pictureBox2;
        private Panel panel9;
        private TextBox stdSearchText;
        private Label label14;
        private TabPage tabPage2;
        private Panel panel6;
        private Button teacherDeleteBtn;
        private Button teacherEditBtn;
        private Label label10;
        private Label label9;
        private Label ID;
        private TextBox PassTeacherText;
        private TextBox usernameTeacherText;
        private TextBox IDTeacherText;
        private PictureBox pictureBox1;
        private Panel panel7;
        private TextBox teacherSearchText;
        private Label label6;
        private Panel panel5;
        private DataGridView teacherData;
        private TabPage tabPage1;
        private Label label5;
        private Button button1;
        private ComboBox RoleCombobox;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private TextBox usernameText;
        private TextBox passwordText;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabControl tabControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private TextBox UsernameStudentText;
        private Label label7;
        private TextBox nameTecherText;
        private Panel panel1;
        private TextBox NameText;
        private Label label11;
    }
}
