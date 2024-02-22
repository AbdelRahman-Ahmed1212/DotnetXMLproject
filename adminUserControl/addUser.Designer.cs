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
            deleteStdBtn = new Button();
            stdEditBtn = new Button();
            pictureBox2 = new PictureBox();
            panel9 = new Panel();
            stdSearchText = new TextBox();
            label14 = new Label();
            tabPage2 = new TabPage();
            panel6 = new Panel();
            teacherDeleteBtn = new Button();
            teacherEditBtn = new Button();
            pictureBox1 = new PictureBox();
            panel7 = new Panel();
            teacherSearchText = new TextBox();
            label6 = new Label();
            panel5 = new Panel();
            teacherData = new DataGridView();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            EmailText = new TextBox();
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
            // Users
            // 
            Users.BackColor = Color.Azure;
            // 
            // studentPage
            // 
            studentPage.BackColor = Color.Azure;
            studentPage.Controls.Add(studentData);
            studentPage.Controls.Add(panel8);
            studentPage.ForeColor = Color.DarkCyan;
            studentPage.Location = new Point(4, 4);
            studentPage.Name = "studentPage";
            studentPage.Padding = new Padding(3);
            studentPage.Size = new Size(934, 473);
            studentPage.TabIndex = 2;
            studentPage.Text = "Students";
            // 
            // studentData
            // 
            studentData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentData.BackgroundColor = Color.Azure;
            studentData.BorderStyle = BorderStyle.None;
            studentData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            studentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentData.Location = new Point(70, 144);
            studentData.Name = "studentData";
            studentData.Size = new Size(786, 255);
            studentData.TabIndex = 4;
            studentData.CellBeginEdit += studentData_CellBeginEdit;
            // 
            // panel8
            // 
            panel8.Controls.Add(deleteStdBtn);
            panel8.Controls.Add(stdEditBtn);
            panel8.Controls.Add(pictureBox2);
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(stdSearchText);
            panel8.Controls.Add(label14);
            panel8.Location = new Point(221, 41);
            panel8.Name = "panel8";
            panel8.Size = new Size(595, 64);
            panel8.TabIndex = 3;
            // 
            // deleteStdBtn
            // 
            deleteStdBtn.BackColor = Color.DarkCyan;
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
            stdEditBtn.BackColor = Color.DarkCyan;
            stdEditBtn.ForeColor = Color.White;
            stdEditBtn.Location = new Point(380, 7);
            stdEditBtn.Name = "stdEditBtn";
            stdEditBtn.Size = new Size(86, 31);
            stdEditBtn.TabIndex = 10;
            stdEditBtn.Text = "Edit";
            stdEditBtn.UseVisualStyleBackColor = false;
            stdEditBtn.Click += stdEditBtn_Click;
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
            panel9.BackColor = Color.DarkCyan;
            panel9.Location = new Point(124, 32);
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
            tabPage2.BackColor = Color.Azure;
            tabPage2.Controls.Add(panel6);
            tabPage2.Controls.Add(panel5);
            tabPage2.Controls.Add(teacherData);
            tabPage2.ForeColor = Color.DarkCyan;
            tabPage2.Location = new Point(4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(934, 473);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Teachers";
            // 
            // panel6
            // 
            panel6.Controls.Add(teacherDeleteBtn);
            panel6.Controls.Add(teacherEditBtn);
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(teacherSearchText);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(180, 50);
            panel6.Name = "panel6";
            panel6.Size = new Size(595, 67);
            panel6.TabIndex = 2;
            // 
            // teacherDeleteBtn
            // 
            teacherDeleteBtn.BackColor = Color.DarkCyan;
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
            teacherEditBtn.BackColor = Color.DarkCyan;
            teacherEditBtn.ForeColor = Color.White;
            teacherEditBtn.Location = new Point(381, 7);
            teacherEditBtn.Name = "teacherEditBtn";
            teacherEditBtn.Size = new Size(86, 31);
            teacherEditBtn.TabIndex = 8;
            teacherEditBtn.Text = "Edit";
            teacherEditBtn.UseVisualStyleBackColor = false;
            teacherEditBtn.Click += teacherEditBtn_Click;
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
            panel7.BackColor = Color.DarkCyan;
            panel7.Location = new Point(124, 32);
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
            teacherData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            teacherData.BackgroundColor = Color.Azure;
            teacherData.BorderStyle = BorderStyle.None;
            teacherData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            teacherData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teacherData.Location = new Point(70, 144);
            teacherData.Name = "teacherData";
            teacherData.Size = new Size(786, 255);
            teacherData.TabIndex = 0;
            teacherData.CellBeginEdit += teacherData_CellBeginEdit;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Azure;
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(EmailText);
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
            tabPage1.ForeColor = Color.DarkCyan;
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(934, 473);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add User";
            tabPage1.Click += tabPage1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Location = new Point(204, 229);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 2);
            panel1.TabIndex = 0;
            // 
            // EmailText
            // 
            EmailText.BorderStyle = BorderStyle.None;
            EmailText.Location = new Point(204, 207);
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(200, 16);
            EmailText.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.ForeColor = Color.DarkCyan;
            label11.Location = new Point(204, 172);
            label11.Name = "label11";
            label11.Size = new Size(55, 21);
            label11.TabIndex = 0;
            label11.Text = "Email :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(446, 107);
            label5.Name = "label5";
            label5.Size = new Size(98, 28);
            label5.TabIndex = 0;
            label5.Text = "Add User";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.ForeColor = Color.White;
            button1.Location = new Point(446, 381);
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
            RoleCombobox.Location = new Point(621, 321);
            RoleCombobox.Name = "RoleCombobox";
            RoleCombobox.Size = new Size(200, 23);
            RoleCombobox.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkCyan;
            panel4.Location = new Point(621, 353);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 2);
            panel4.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkCyan;
            panel3.Location = new Point(621, 233);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 2);
            panel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Location = new Point(204, 349);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 2);
            panel2.TabIndex = 0;
            // 
            // usernameText
            // 
            usernameText.BorderStyle = BorderStyle.None;
            usernameText.Location = new Point(621, 211);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(200, 16);
            usernameText.TabIndex = 2;
            // 
            // passwordText
            // 
            passwordText.BorderStyle = BorderStyle.None;
            passwordText.Location = new Point(204, 324);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(200, 16);
            passwordText.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(621, 289);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 0;
            label4.Text = "Role :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(621, 176);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 0;
            label3.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(204, 285);
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
            tabControl1.Size = new Size(942, 501);
            tabControl1.TabIndex = 0;
            // 
            // addUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(tabControl1);
            ForeColor = Color.DarkCyan;
            Name = "addUser";
            Size = new Size(942, 501);
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
        private PictureBox pictureBox2;
        private Panel panel9;
        private TextBox stdSearchText;
        private Label label14;
        private TabPage tabPage2;
        private Panel panel6;
        private Button teacherDeleteBtn;
        private Button teacherEditBtn;
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
        private Panel panel1;
        private TextBox EmailText;
        private Label label11;
    }
}
