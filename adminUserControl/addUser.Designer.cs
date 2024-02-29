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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addUser));
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
            resources.ApplyResources(studentPage, "studentPage");
            studentPage.BackColor = Color.Azure;
            studentPage.Controls.Add(studentData);
            studentPage.Controls.Add(panel8);
            studentPage.ForeColor = Color.DarkCyan;
            studentPage.Name = "studentPage";
            Users.SetToolTip(studentPage, resources.GetString("studentPage.ToolTip"));
            // 
            // studentData
            // 
            resources.ApplyResources(studentData, "studentData");
            studentData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentData.BackgroundColor = Color.Azure;
            studentData.BorderStyle = BorderStyle.None;
            studentData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            studentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentData.Name = "studentData";
            Users.SetToolTip(studentData, resources.GetString("studentData.ToolTip"));
            studentData.CellBeginEdit += studentData_CellBeginEdit;
            // 
            // panel8
            // 
            resources.ApplyResources(panel8, "panel8");
            panel8.Controls.Add(deleteStdBtn);
            panel8.Controls.Add(stdEditBtn);
            panel8.Controls.Add(pictureBox2);
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(stdSearchText);
            panel8.Controls.Add(label14);
            panel8.Name = "panel8";
            Users.SetToolTip(panel8, resources.GetString("panel8.ToolTip"));
            // 
            // deleteStdBtn
            // 
            resources.ApplyResources(deleteStdBtn, "deleteStdBtn");
            deleteStdBtn.BackColor = Color.DarkCyan;
            deleteStdBtn.ForeColor = Color.White;
            deleteStdBtn.Name = "deleteStdBtn";
            Users.SetToolTip(deleteStdBtn, resources.GetString("deleteStdBtn.ToolTip"));
            deleteStdBtn.UseVisualStyleBackColor = false;
            deleteStdBtn.Click += deleteStdBtn_Click;
            // 
            // stdEditBtn
            // 
            resources.ApplyResources(stdEditBtn, "stdEditBtn");
            stdEditBtn.BackColor = Color.DarkCyan;
            stdEditBtn.ForeColor = Color.White;
            stdEditBtn.Name = "stdEditBtn";
            Users.SetToolTip(stdEditBtn, resources.GetString("stdEditBtn.ToolTip"));
            stdEditBtn.UseVisualStyleBackColor = false;
            stdEditBtn.Click += stdEditBtn_Click;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            Users.SetToolTip(pictureBox2, resources.GetString("pictureBox2.ToolTip"));
            // 
            // panel9
            // 
            resources.ApplyResources(panel9, "panel9");
            panel9.BackColor = Color.DarkCyan;
            panel9.Name = "panel9";
            Users.SetToolTip(panel9, resources.GetString("panel9.ToolTip"));
            // 
            // stdSearchText
            // 
            resources.ApplyResources(stdSearchText, "stdSearchText");
            stdSearchText.BorderStyle = BorderStyle.None;
            stdSearchText.Name = "stdSearchText";
            Users.SetToolTip(stdSearchText, resources.GetString("stdSearchText.ToolTip"));
            stdSearchText.TextChanged += stdSearchText_TextChanged;
            // 
            // label14
            // 
            resources.ApplyResources(label14, "label14");
            label14.Name = "label14";
            Users.SetToolTip(label14, resources.GetString("label14.ToolTip"));
            // 
            // tabPage2
            // 
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.BackColor = Color.Azure;
            tabPage2.Controls.Add(panel6);
            tabPage2.Controls.Add(panel5);
            tabPage2.Controls.Add(teacherData);
            tabPage2.ForeColor = Color.DarkCyan;
            tabPage2.Name = "tabPage2";
            Users.SetToolTip(tabPage2, resources.GetString("tabPage2.ToolTip"));
            // 
            // panel6
            // 
            resources.ApplyResources(panel6, "panel6");
            panel6.Controls.Add(teacherDeleteBtn);
            panel6.Controls.Add(teacherEditBtn);
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(teacherSearchText);
            panel6.Controls.Add(label6);
            panel6.Name = "panel6";
            Users.SetToolTip(panel6, resources.GetString("panel6.ToolTip"));
            // 
            // teacherDeleteBtn
            // 
            resources.ApplyResources(teacherDeleteBtn, "teacherDeleteBtn");
            teacherDeleteBtn.BackColor = Color.DarkCyan;
            teacherDeleteBtn.ForeColor = Color.White;
            teacherDeleteBtn.Name = "teacherDeleteBtn";
            Users.SetToolTip(teacherDeleteBtn, resources.GetString("teacherDeleteBtn.ToolTip"));
            teacherDeleteBtn.UseVisualStyleBackColor = false;
            teacherDeleteBtn.Click += teacherDeleteBtn_Click;
            // 
            // teacherEditBtn
            // 
            resources.ApplyResources(teacherEditBtn, "teacherEditBtn");
            teacherEditBtn.BackColor = Color.DarkCyan;
            teacherEditBtn.ForeColor = Color.White;
            teacherEditBtn.Name = "teacherEditBtn";
            Users.SetToolTip(teacherEditBtn, resources.GetString("teacherEditBtn.ToolTip"));
            teacherEditBtn.UseVisualStyleBackColor = false;
            teacherEditBtn.Click += teacherEditBtn_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            Users.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            // 
            // panel7
            // 
            resources.ApplyResources(panel7, "panel7");
            panel7.BackColor = Color.DarkCyan;
            panel7.Name = "panel7";
            Users.SetToolTip(panel7, resources.GetString("panel7.ToolTip"));
            // 
            // teacherSearchText
            // 
            resources.ApplyResources(teacherSearchText, "teacherSearchText");
            teacherSearchText.BorderStyle = BorderStyle.None;
            teacherSearchText.Name = "teacherSearchText";
            Users.SetToolTip(teacherSearchText, resources.GetString("teacherSearchText.ToolTip"));
            teacherSearchText.TextChanged += teacherSearchText_TextChanged;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            Users.SetToolTip(label6, resources.GetString("label6.ToolTip"));
            // 
            // panel5
            // 
            resources.ApplyResources(panel5, "panel5");
            panel5.Name = "panel5";
            Users.SetToolTip(panel5, resources.GetString("panel5.ToolTip"));
            // 
            // teacherData
            // 
            resources.ApplyResources(teacherData, "teacherData");
            teacherData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            teacherData.BackgroundColor = Color.Azure;
            teacherData.BorderStyle = BorderStyle.None;
            teacherData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            teacherData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teacherData.Name = "teacherData";
            Users.SetToolTip(teacherData, resources.GetString("teacherData.ToolTip"));
            teacherData.CellBeginEdit += teacherData_CellBeginEdit;
            // 
            // tabPage1
            // 
            resources.ApplyResources(tabPage1, "tabPage1");
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
            tabPage1.Name = "tabPage1";
            Users.SetToolTip(tabPage1, resources.GetString("tabPage1.ToolTip"));
            tabPage1.Click += tabPage1_Click;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.DarkCyan;
            panel1.Name = "panel1";
            Users.SetToolTip(panel1, resources.GetString("panel1.ToolTip"));
            // 
            // EmailText
            // 
            resources.ApplyResources(EmailText, "EmailText");
            EmailText.BorderStyle = BorderStyle.None;
            EmailText.Name = "EmailText";
            Users.SetToolTip(EmailText, resources.GetString("EmailText.ToolTip"));
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.ForeColor = Color.DarkCyan;
            label11.Name = "label11";
            Users.SetToolTip(label11, resources.GetString("label11.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.DarkCyan;
            label5.Name = "label5";
            Users.SetToolTip(label5, resources.GetString("label5.ToolTip"));
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.DarkCyan;
            button1.ForeColor = Color.White;
            button1.Name = "button1";
            Users.SetToolTip(button1, resources.GetString("button1.ToolTip"));
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // RoleCombobox
            // 
            resources.ApplyResources(RoleCombobox, "RoleCombobox");
            RoleCombobox.FormattingEnabled = true;
            RoleCombobox.Name = "RoleCombobox";
            Users.SetToolTip(RoleCombobox, resources.GetString("RoleCombobox.ToolTip"));
            // 
            // panel4
            // 
            resources.ApplyResources(panel4, "panel4");
            panel4.BackColor = Color.DarkCyan;
            panel4.Name = "panel4";
            Users.SetToolTip(panel4, resources.GetString("panel4.ToolTip"));
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.BackColor = Color.DarkCyan;
            panel3.Name = "panel3";
            Users.SetToolTip(panel3, resources.GetString("panel3.ToolTip"));
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.BackColor = Color.DarkCyan;
            panel2.Name = "panel2";
            Users.SetToolTip(panel2, resources.GetString("panel2.ToolTip"));
            // 
            // usernameText
            // 
            resources.ApplyResources(usernameText, "usernameText");
            usernameText.BorderStyle = BorderStyle.None;
            usernameText.Name = "usernameText";
            Users.SetToolTip(usernameText, resources.GetString("usernameText.ToolTip"));
            // 
            // passwordText
            // 
            resources.ApplyResources(passwordText, "passwordText");
            passwordText.BorderStyle = BorderStyle.None;
            passwordText.Name = "passwordText";
            Users.SetToolTip(passwordText, resources.GetString("passwordText.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.DarkCyan;
            label4.Name = "label4";
            Users.SetToolTip(label4, resources.GetString("label4.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.DarkCyan;
            label3.Name = "label3";
            Users.SetToolTip(label3, resources.GetString("label3.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.DarkCyan;
            label2.Name = "label2";
            Users.SetToolTip(label2, resources.GetString("label2.ToolTip"));
            // 
            // tabControl1
            // 
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(studentPage);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            Users.SetToolTip(tabControl1, resources.GetString("tabControl1.ToolTip"));
            // 
            // addUser
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(tabControl1);
            ForeColor = Color.DarkCyan;
            Name = "addUser";
            Users.SetToolTip(this, resources.GetString("$this.ToolTip"));
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
