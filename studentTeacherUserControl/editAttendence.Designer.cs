namespace DotnetXmlProject.studentTeacherUserControl
{
    partial class editAttendence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editAttendence));
            displayClassbtn = new Button();
            editAttendancedataGridView = new DataGridView();
            tabPage2 = new TabPage();
            label1 = new Label();
            comboBox1 = new ComboBox();
            EditeAttendencebtn = new Button();
            displaytoeditbtn = new Button();
            editeAttendencdataGridView = new DataGridView();
            toolbtn = new ToolStrip();
            editStudents = new TabControl();
            tabcontroleaddstd = new TabPage();
            ((System.ComponentModel.ISupportInitialize)editAttendancedataGridView).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)editeAttendencdataGridView).BeginInit();
            editStudents.SuspendLayout();
            tabcontroleaddstd.SuspendLayout();
            SuspendLayout();
            // 
            // displayClassbtn
            // 
            resources.ApplyResources(displayClassbtn, "displayClassbtn");
            displayClassbtn.BackColor = Color.Aqua;
            displayClassbtn.Name = "displayClassbtn";
            displayClassbtn.UseVisualStyleBackColor = false;
            displayClassbtn.Click += displayClassbtn_Click_1;
            // 
            // editAttendancedataGridView
            // 
            resources.ApplyResources(editAttendancedataGridView, "editAttendancedataGridView");
            editAttendancedataGridView.AllowUserToAddRows = false;
            editAttendancedataGridView.AllowUserToDeleteRows = false;
            editAttendancedataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            editAttendancedataGridView.BackgroundColor = Color.White;
            editAttendancedataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            editAttendancedataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            editAttendancedataGridView.Name = "editAttendancedataGridView";
            editAttendancedataGridView.ReadOnly = true;
            editAttendancedataGridView.ShowCellErrors = false;
            editAttendancedataGridView.ShowEditingIcon = false;
            editAttendancedataGridView.ShowRowErrors = false;
            // 
            // tabPage2
            // 
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(EditeAttendencebtn);
            tabPage2.Controls.Add(displaytoeditbtn);
            tabPage2.Controls.Add(editeAttendencdataGridView);
            tabPage2.Name = "tabPage2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // comboBox1
            // 
            resources.ApplyResources(comboBox1, "comboBox1");
            comboBox1.FormattingEnabled = true;
            comboBox1.Name = "comboBox1";
            // 
            // EditeAttendencebtn
            // 
            resources.ApplyResources(EditeAttendencebtn, "EditeAttendencebtn");
            EditeAttendencebtn.BackColor = Color.DeepSkyBlue;
            EditeAttendencebtn.Name = "EditeAttendencebtn";
            EditeAttendencebtn.UseVisualStyleBackColor = false;
            EditeAttendencebtn.Click += EditeAttendencebtn_Click;
            // 
            // displaytoeditbtn
            // 
            resources.ApplyResources(displaytoeditbtn, "displaytoeditbtn");
            displaytoeditbtn.BackColor = Color.DeepSkyBlue;
            displaytoeditbtn.Name = "displaytoeditbtn";
            displaytoeditbtn.UseVisualStyleBackColor = false;
            displaytoeditbtn.Click += displaytoeditbtn_Click;
            // 
            // editeAttendencdataGridView
            // 
            resources.ApplyResources(editeAttendencdataGridView, "editeAttendencdataGridView");
            editeAttendencdataGridView.BackgroundColor = Color.White;
            editeAttendencdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            editeAttendencdataGridView.Name = "editeAttendencdataGridView";
            // 
            // toolbtn
            // 
            resources.ApplyResources(toolbtn, "toolbtn");
            toolbtn.ImageScalingSize = new Size(20, 20);
            toolbtn.Name = "toolbtn";
            // 
            // editStudents
            // 
            resources.ApplyResources(editStudents, "editStudents");
            editStudents.Controls.Add(tabPage2);
            editStudents.Controls.Add(tabcontroleaddstd);
            editStudents.Name = "editStudents";
            editStudents.SelectedIndex = 0;
            editStudents.Tag = "";
            // 
            // tabcontroleaddstd
            // 
            resources.ApplyResources(tabcontroleaddstd, "tabcontroleaddstd");
            tabcontroleaddstd.BackColor = Color.White;
            tabcontroleaddstd.Controls.Add(editAttendancedataGridView);
            tabcontroleaddstd.Controls.Add(displayClassbtn);
            tabcontroleaddstd.Name = "tabcontroleaddstd";
            // 
            // editAttendence
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(toolbtn);
            Controls.Add(editStudents);
            Name = "editAttendence";
            ((System.ComponentModel.ISupportInitialize)editAttendancedataGridView).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)editeAttendencdataGridView).EndInit();
            editStudents.ResumeLayout(false);
            tabcontroleaddstd.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button displayClassbtn;
        private DataGridView editAttendancedataGridView;
        private TabPage tabPage2;
        private ToolStrip toolbtn;
        public TabControl editStudents;
        private TabPage tabcontroleaddstd;
        private Button EditeAttendencebtn;
        private Button displaytoeditbtn;
        private DataGridView editeAttendencdataGridView;
        private Label label1;
        private ComboBox comboBox1;
    }
}
