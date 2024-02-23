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
            displayClassbtn = new Button();
            editAttendancedataGridView = new DataGridView();
            tabPage2 = new TabPage();
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
            displayClassbtn.BackColor = Color.Aqua;
            displayClassbtn.Location = new Point(31, 62);
            displayClassbtn.Name = "displayClassbtn";
            displayClassbtn.Size = new Size(74, 29);
            displayClassbtn.TabIndex = 6;
            displayClassbtn.Text = "Display";
            displayClassbtn.UseVisualStyleBackColor = false;
            displayClassbtn.Click += displayClassbtn_Click_1;
            // 
            // editAttendancedataGridView
            // 
            editAttendancedataGridView.AllowUserToAddRows = false;
            editAttendancedataGridView.AllowUserToDeleteRows = false;
            editAttendancedataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            editAttendancedataGridView.BackgroundColor = Color.White;
            editAttendancedataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            editAttendancedataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            editAttendancedataGridView.Location = new Point(31, 131);
            editAttendancedataGridView.Name = "editAttendancedataGridView";
            editAttendancedataGridView.ReadOnly = true;
            editAttendancedataGridView.RowHeadersWidth = 51;
            editAttendancedataGridView.ShowCellErrors = false;
            editAttendancedataGridView.ShowEditingIcon = false;
            editAttendancedataGridView.ShowRowErrors = false;
            editAttendancedataGridView.Size = new Size(872, 318);
            editAttendancedataGridView.TabIndex = 11;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.BackgroundImageLayout = ImageLayout.None;
            tabPage2.Controls.Add(EditeAttendencebtn);
            tabPage2.Controls.Add(displaytoeditbtn);
            tabPage2.Controls.Add(editeAttendencdataGridView);
            tabPage2.Location = new Point(4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(934, 468);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Edit Attendence";
            // 
            // EditeAttendencebtn
            // 
            EditeAttendencebtn.BackColor = Color.DeepSkyBlue;
            EditeAttendencebtn.Location = new Point(395, 386);
            EditeAttendencebtn.Name = "EditeAttendencebtn";
            EditeAttendencebtn.Size = new Size(94, 29);
            EditeAttendencebtn.TabIndex = 2;
            EditeAttendencebtn.Text = "Save";
            EditeAttendencebtn.UseVisualStyleBackColor = false;
            EditeAttendencebtn.Click += EditeAttendencebtn_Click;
            // 
            // displaytoeditbtn
            // 
            displaytoeditbtn.BackColor = Color.DeepSkyBlue;
            displaytoeditbtn.Location = new Point(395, 26);
            displaytoeditbtn.Name = "displaytoeditbtn";
            displaytoeditbtn.Size = new Size(94, 29);
            displaytoeditbtn.TabIndex = 1;
            displaytoeditbtn.Text = "Display";
            displaytoeditbtn.UseVisualStyleBackColor = false;
            displaytoeditbtn.Click += displaytoeditbtn_Click;
            // 
            // editeAttendencdataGridView
            // 
            editeAttendencdataGridView.BackgroundColor = Color.White;
            editeAttendencdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            editeAttendencdataGridView.Location = new Point(87, 61);
            editeAttendencdataGridView.Name = "editeAttendencdataGridView";
            editeAttendencdataGridView.RowHeadersWidth = 51;
            editeAttendencdataGridView.Size = new Size(777, 304);
            editeAttendencdataGridView.TabIndex = 0;
            // 
            // toolbtn
            // 
            toolbtn.ImageScalingSize = new Size(20, 20);
            toolbtn.Location = new Point(0, 0);
            toolbtn.Name = "toolbtn";
            toolbtn.Size = new Size(1001, 25);
            toolbtn.TabIndex = 2;
            toolbtn.Text = "toolStrip1";
            // 
            // editStudents
            // 
            editStudents.AccessibleName = "";
            editStudents.Alignment = TabAlignment.Bottom;
            editStudents.Controls.Add(tabPage2);
            editStudents.Controls.Add(tabcontroleaddstd);
            editStudents.Location = new Point(0, 96);
            editStudents.Name = "editStudents";
            editStudents.SelectedIndex = 0;
            editStudents.ShowToolTips = true;
            editStudents.Size = new Size(942, 501);
            editStudents.TabIndex = 3;
            editStudents.Tag = "";
            // 
            // tabcontroleaddstd
            // 
            tabcontroleaddstd.BackColor = Color.White;
            tabcontroleaddstd.Controls.Add(editAttendancedataGridView);
            tabcontroleaddstd.Controls.Add(displayClassbtn);
            tabcontroleaddstd.Location = new Point(4, 4);
            tabcontroleaddstd.Name = "tabcontroleaddstd";
            tabcontroleaddstd.Padding = new Padding(3);
            tabcontroleaddstd.Size = new Size(934, 468);
            tabcontroleaddstd.TabIndex = 0;
            tabcontroleaddstd.Text = "show students";
            // 
            // editAttendence
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(toolbtn);
            Controls.Add(editStudents);
            Name = "editAttendence";
            Size = new Size(1001, 693);
            ((System.ComponentModel.ISupportInitialize)editAttendancedataGridView).EndInit();
            tabPage2.ResumeLayout(false);
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
    }
}
