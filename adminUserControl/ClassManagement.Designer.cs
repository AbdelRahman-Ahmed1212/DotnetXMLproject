namespace DotnetXmlProject.adminUserControl
{
    partial class ClassManagement
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
            label5 = new Label();
            button1 = new Button();
            techercb = new ComboBox();
            panel4 = new Panel();
            NameText = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel6 = new Panel();
            classDeleteBtn = new Button();
            classEditBtn = new Button();
            pictureBox1 = new PictureBox();
            panel7 = new Panel();
            classSearchText = new TextBox();
            label6 = new Label();
            classData = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)classData).BeginInit();
            SuspendLayout();
            // 
            // toolTip1
            // 
            toolTip1.BackColor = Color.Azure;
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(942, 501);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Azure;
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(techercb);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(NameText);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.ForeColor = Color.DarkCyan;
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(934, 473);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add Class";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(430, 127);
            label5.Name = "label5";
            label5.Size = new Size(126, 28);
            label5.TabIndex = 20;
            label5.Text = "Add Subject";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.ForeColor = Color.White;
            button1.Location = new Point(430, 355);
            button1.Name = "button1";
            button1.Size = new Size(133, 42);
            button1.TabIndex = 19;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // techercb
            // 
            techercb.FlatStyle = FlatStyle.Flat;
            techercb.FormattingEnabled = true;
            techercb.Location = new Point(609, 252);
            techercb.Name = "techercb";
            techercb.Size = new Size(200, 23);
            techercb.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkCyan;
            panel4.Location = new Point(609, 284);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 2);
            panel4.TabIndex = 7;
            // 
            // NameText
            // 
            NameText.BorderStyle = BorderStyle.None;
            NameText.Location = new Point(148, 259);
            NameText.Name = "NameText";
            NameText.Size = new Size(200, 16);
            NameText.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Location = new Point(148, 281);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 2);
            panel1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(609, 220);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 11;
            label4.Text = "Teacher ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(332, 314);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(148, 222);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 14;
            label1.Text = "Name :";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Azure;
            tabPage2.Controls.Add(panel6);
            tabPage2.Controls.Add(classData);
            tabPage2.ForeColor = Color.DarkCyan;
            tabPage2.Location = new Point(4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(934, 473);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Classes";
            // 
            // panel6
            // 
            panel6.Controls.Add(classDeleteBtn);
            panel6.Controls.Add(classEditBtn);
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(classSearchText);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(181, 49);
            panel6.Name = "panel6";
            panel6.Size = new Size(598, 68);
            panel6.TabIndex = 4;
            // 
            // classDeleteBtn
            // 
            classDeleteBtn.BackColor = Color.DarkCyan;
            classDeleteBtn.ForeColor = Color.White;
            classDeleteBtn.Location = new Point(473, 7);
            classDeleteBtn.Name = "classDeleteBtn";
            classDeleteBtn.Size = new Size(86, 31);
            classDeleteBtn.TabIndex = 7;
            classDeleteBtn.Text = "Delete";
            classDeleteBtn.UseVisualStyleBackColor = false;
            classDeleteBtn.Click += classDeleteBtn_Click_1;
            // 
            // classEditBtn
            // 
            classEditBtn.BackColor = Color.DarkCyan;
            classEditBtn.ForeColor = Color.White;
            classEditBtn.Location = new Point(381, 7);
            classEditBtn.Name = "classEditBtn";
            classEditBtn.Size = new Size(86, 31);
            classEditBtn.TabIndex = 8;
            classEditBtn.Text = "Edit";
            classEditBtn.UseVisualStyleBackColor = false;
            classEditBtn.Click += classEditBtn_Click_1;
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
            panel7.Location = new Point(124, 29);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 2);
            panel7.TabIndex = 2;
            // 
            // classSearchText
            // 
            classSearchText.BorderStyle = BorderStyle.None;
            classSearchText.Location = new Point(124, 10);
            classSearchText.Name = "classSearchText";
            classSearchText.Size = new Size(170, 16);
            classSearchText.TabIndex = 4;
            classSearchText.TextChanged += classSearchText_TextChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(3, 10);
            label6.Name = "label6";
            label6.Size = new Size(99, 21);
            label6.TabIndex = 3;
            label6.Text = "Class Name :";
            // 
            // classData
            // 
            classData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            classData.BackgroundColor = Color.Azure;
            classData.BorderStyle = BorderStyle.None;
            classData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            classData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            classData.Location = new Point(70, 144);
            classData.Name = "classData";
            classData.Size = new Size(786, 255);
            classData.TabIndex = 3;
            classData.CellBeginEdit += classData_CellBeginEdit;
            // 
            // ClassManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(tabControl1);
            ForeColor = Color.DarkCyan;
            Name = "ClassManagement";
            Size = new Size(942, 501);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)classData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label5;
        private Button button1;
        private ComboBox techercb;
        private Panel panel4;
        private TextBox NameText;
        private Panel panel1;
        private Label label4;
        private Label label2;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel6;
        private Button classDeleteBtn;
        private Button classEditBtn;
        private Label label9;
        private TextBox usernameTeacherText;
        private PictureBox pictureBox1;
        private Panel panel7;
        private TextBox classSearchText;
        private Label label6;
        private DataGridView classData;
    }
}
