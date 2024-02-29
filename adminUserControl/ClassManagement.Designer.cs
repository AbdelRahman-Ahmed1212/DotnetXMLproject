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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassManagement));
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
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            toolTip1.SetToolTip(tabControl1, resources.GetString("tabControl1.ToolTip"));
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            resources.ApplyResources(tabPage1, "tabPage1");
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
            tabPage1.Name = "tabPage1";
            toolTip1.SetToolTip(tabPage1, resources.GetString("tabPage1.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.DarkCyan;
            label5.Name = "label5";
            toolTip1.SetToolTip(label5, resources.GetString("label5.ToolTip"));
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.DarkCyan;
            button1.ForeColor = Color.White;
            button1.Name = "button1";
            toolTip1.SetToolTip(button1, resources.GetString("button1.ToolTip"));
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // techercb
            // 
            resources.ApplyResources(techercb, "techercb");
            techercb.FormattingEnabled = true;
            techercb.Name = "techercb";
            toolTip1.SetToolTip(techercb, resources.GetString("techercb.ToolTip"));
            // 
            // panel4
            // 
            resources.ApplyResources(panel4, "panel4");
            panel4.BackColor = Color.DarkCyan;
            panel4.Name = "panel4";
            toolTip1.SetToolTip(panel4, resources.GetString("panel4.ToolTip"));
            // 
            // NameText
            // 
            resources.ApplyResources(NameText, "NameText");
            NameText.BorderStyle = BorderStyle.None;
            NameText.Name = "NameText";
            toolTip1.SetToolTip(NameText, resources.GetString("NameText.ToolTip"));
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.DarkCyan;
            panel1.Name = "panel1";
            toolTip1.SetToolTip(panel1, resources.GetString("panel1.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.DarkCyan;
            label4.Name = "label4";
            toolTip1.SetToolTip(label4, resources.GetString("label4.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.Indigo;
            label2.Name = "label2";
            toolTip1.SetToolTip(label2, resources.GetString("label2.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.DarkCyan;
            label1.Name = "label1";
            toolTip1.SetToolTip(label1, resources.GetString("label1.ToolTip"));
            // 
            // tabPage2
            // 
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.BackColor = Color.Azure;
            tabPage2.Controls.Add(panel6);
            tabPage2.Controls.Add(classData);
            tabPage2.ForeColor = Color.DarkCyan;
            tabPage2.Name = "tabPage2";
            toolTip1.SetToolTip(tabPage2, resources.GetString("tabPage2.ToolTip"));
            // 
            // panel6
            // 
            resources.ApplyResources(panel6, "panel6");
            panel6.Controls.Add(classDeleteBtn);
            panel6.Controls.Add(classEditBtn);
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(classSearchText);
            panel6.Controls.Add(label6);
            panel6.Name = "panel6";
            toolTip1.SetToolTip(panel6, resources.GetString("panel6.ToolTip"));
            // 
            // classDeleteBtn
            // 
            resources.ApplyResources(classDeleteBtn, "classDeleteBtn");
            classDeleteBtn.BackColor = Color.DarkCyan;
            classDeleteBtn.ForeColor = Color.White;
            classDeleteBtn.Name = "classDeleteBtn";
            toolTip1.SetToolTip(classDeleteBtn, resources.GetString("classDeleteBtn.ToolTip"));
            classDeleteBtn.UseVisualStyleBackColor = false;
            classDeleteBtn.Click += classDeleteBtn_Click_1;
            // 
            // classEditBtn
            // 
            resources.ApplyResources(classEditBtn, "classEditBtn");
            classEditBtn.BackColor = Color.DarkCyan;
            classEditBtn.ForeColor = Color.White;
            classEditBtn.Name = "classEditBtn";
            toolTip1.SetToolTip(classEditBtn, resources.GetString("classEditBtn.ToolTip"));
            classEditBtn.UseVisualStyleBackColor = false;
            classEditBtn.Click += classEditBtn_Click_1;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            toolTip1.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            // 
            // panel7
            // 
            resources.ApplyResources(panel7, "panel7");
            panel7.BackColor = Color.DarkCyan;
            panel7.Name = "panel7";
            toolTip1.SetToolTip(panel7, resources.GetString("panel7.ToolTip"));
            // 
            // classSearchText
            // 
            resources.ApplyResources(classSearchText, "classSearchText");
            classSearchText.BorderStyle = BorderStyle.None;
            classSearchText.Name = "classSearchText";
            toolTip1.SetToolTip(classSearchText, resources.GetString("classSearchText.ToolTip"));
            classSearchText.TextChanged += classSearchText_TextChanged_1;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.ForeColor = Color.DarkCyan;
            label6.Name = "label6";
            toolTip1.SetToolTip(label6, resources.GetString("label6.ToolTip"));
            // 
            // classData
            // 
            resources.ApplyResources(classData, "classData");
            classData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            classData.BackgroundColor = Color.Azure;
            classData.BorderStyle = BorderStyle.None;
            classData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            classData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            classData.Name = "classData";
            toolTip1.SetToolTip(classData, resources.GetString("classData.ToolTip"));
            classData.CellBeginEdit += classData_CellBeginEdit;
            // 
            // ClassManagement
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(tabControl1);
            ForeColor = Color.DarkCyan;
            Name = "ClassManagement";
            toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
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
