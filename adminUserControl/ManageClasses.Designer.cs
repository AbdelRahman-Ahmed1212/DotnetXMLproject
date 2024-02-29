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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageClasses));
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
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            toolTip1.SetToolTip(tabControl1, resources.GetString("tabControl1.ToolTip"));
            // 
            // tabPage1
            // 
            resources.ApplyResources(tabPage1, "tabPage1");
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
            tabPage1.Name = "tabPage1";
            toolTip1.SetToolTip(tabPage1, resources.GetString("tabPage1.ToolTip"));
            tabPage1.Click += tabPage1_Click;
            // 
            // stdClassID
            // 
            resources.ApplyResources(stdClassID, "stdClassID");
            stdClassID.BorderStyle = BorderStyle.None;
            stdClassID.ForeColor = Color.DarkCyan;
            stdClassID.FormattingEnabled = true;
            stdClassID.MultiColumn = true;
            stdClassID.Name = "stdClassID";
            stdClassID.SelectionMode = SelectionMode.MultiExtended;
            toolTip1.SetToolTip(stdClassID, resources.GetString("stdClassID.ToolTip"));
            // 
            // addClassTeacher
            // 
            resources.ApplyResources(addClassTeacher, "addClassTeacher");
            addClassTeacher.BackColor = Color.DarkCyan;
            addClassTeacher.ForeColor = Color.White;
            addClassTeacher.Name = "addClassTeacher";
            toolTip1.SetToolTip(addClassTeacher, resources.GetString("addClassTeacher.ToolTip"));
            addClassTeacher.UseVisualStyleBackColor = false;
            addClassTeacher.Click += addClassTeacher_Click;
            // 
            // addClassStd
            // 
            resources.ApplyResources(addClassStd, "addClassStd");
            addClassStd.BackColor = Color.DarkCyan;
            addClassStd.ForeColor = Color.White;
            addClassStd.Name = "addClassStd";
            toolTip1.SetToolTip(addClassStd, resources.GetString("addClassStd.ToolTip"));
            addClassStd.UseVisualStyleBackColor = false;
            addClassStd.Click += addClassStd_Click;
            // 
            // teacherClassID
            // 
            resources.ApplyResources(teacherClassID, "teacherClassID");
            teacherClassID.FormattingEnabled = true;
            teacherClassID.Name = "teacherClassID";
            toolTip1.SetToolTip(teacherClassID, resources.GetString("teacherClassID.ToolTip"));
            // 
            // classTeacherID
            // 
            resources.ApplyResources(classTeacherID, "classTeacherID");
            classTeacherID.FormattingEnabled = true;
            classTeacherID.Name = "classTeacherID";
            toolTip1.SetToolTip(classTeacherID, resources.GetString("classTeacherID.ToolTip"));
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.DarkCyan;
            panel1.Name = "panel1";
            toolTip1.SetToolTip(panel1, resources.GetString("panel1.ToolTip"));
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.BackColor = Color.DarkCyan;
            panel2.Name = "panel2";
            toolTip1.SetToolTip(panel2, resources.GetString("panel2.ToolTip"));
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.DarkCyan;
            label1.Name = "label1";
            toolTip1.SetToolTip(label1, resources.GetString("label1.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.DarkCyan;
            label2.Name = "label2";
            toolTip1.SetToolTip(label2, resources.GetString("label2.ToolTip"));
            // 
            // classStdID
            // 
            resources.ApplyResources(classStdID, "classStdID");
            classStdID.FormattingEnabled = true;
            classStdID.Name = "classStdID";
            toolTip1.SetToolTip(classStdID, resources.GetString("classStdID.ToolTip"));
            // 
            // panel4
            // 
            resources.ApplyResources(panel4, "panel4");
            panel4.BackColor = Color.DarkCyan;
            panel4.Name = "panel4";
            toolTip1.SetToolTip(panel4, resources.GetString("panel4.ToolTip"));
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.BackColor = Color.DarkCyan;
            panel3.Name = "panel3";
            toolTip1.SetToolTip(panel3, resources.GetString("panel3.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.DarkCyan;
            label4.Name = "label4";
            toolTip1.SetToolTip(label4, resources.GetString("label4.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.DarkCyan;
            label3.Name = "label3";
            toolTip1.SetToolTip(label3, resources.GetString("label3.ToolTip"));
            // 
            // tabPage2
            // 
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.BackColor = Color.Azure;
            tabPage2.Controls.Add(classesData);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(userID);
            tabPage2.Controls.Add(panel5);
            tabPage2.Controls.Add(label5);
            tabPage2.ForeColor = Color.DarkCyan;
            tabPage2.Name = "tabPage2";
            toolTip1.SetToolTip(tabPage2, resources.GetString("tabPage2.ToolTip"));
            // 
            // classesData
            // 
            resources.ApplyResources(classesData, "classesData");
            classesData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            classesData.BackgroundColor = Color.Azure;
            classesData.BorderStyle = BorderStyle.None;
            classesData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            classesData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            classesData.EditMode = DataGridViewEditMode.EditProgrammatically;
            classesData.Name = "classesData";
            toolTip1.SetToolTip(classesData, resources.GetString("classesData.ToolTip"));
            // 
            // button4
            // 
            resources.ApplyResources(button4, "button4");
            button4.BackColor = Color.DarkCyan;
            button4.ForeColor = Color.White;
            button4.Name = "button4";
            toolTip1.SetToolTip(button4, resources.GetString("button4.ToolTip"));
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.BackColor = Color.DarkCyan;
            button3.ForeColor = Color.White;
            button3.Name = "button3";
            toolTip1.SetToolTip(button3, resources.GetString("button3.ToolTip"));
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // userID
            // 
            resources.ApplyResources(userID, "userID");
            userID.FormattingEnabled = true;
            userID.Name = "userID";
            toolTip1.SetToolTip(userID, resources.GetString("userID.ToolTip"));
            // 
            // panel5
            // 
            resources.ApplyResources(panel5, "panel5");
            panel5.BackColor = Color.DarkCyan;
            panel5.Name = "panel5";
            toolTip1.SetToolTip(panel5, resources.GetString("panel5.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.DarkCyan;
            label5.Name = "label5";
            toolTip1.SetToolTip(label5, resources.GetString("label5.ToolTip"));
            // 
            // ManageClasses
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(tabControl1);
            ForeColor = Color.DarkCyan;
            Name = "ManageClasses";
            toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
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
