namespace DotnetXmlProject.adminUserControl
{
    partial class attendanceMangement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(attendanceMangement));
            toolTip1 = new ToolTip(components);
            tabPage3 = new TabPage();
            sessionData = new DataGridView();
            panel1 = new Panel();
            DeleteRecordBtn = new Button();
            EditRecordBtn = new Button();
            tabPage2 = new TabPage();
            dateSession = new DateTimePicker();
            panel3 = new Panel();
            Date = new Label();
            label5 = new Label();
            addRecordBtn = new Button();
            subjectCombobox = new ComboBox();
            panel4 = new Panel();
            ClassIDcb = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            stdSessionData = new DataGridView();
            button1 = new Button();
            sessionIDText = new ComboBox();
            panel2 = new Panel();
            label1 = new Label();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sessionData).BeginInit();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stdSessionData).BeginInit();
            SuspendLayout();
            // 
            // tabPage3
            // 
            resources.ApplyResources(tabPage3, "tabPage3");
            tabPage3.BackColor = Color.Azure;
            tabPage3.Controls.Add(sessionData);
            tabPage3.Controls.Add(panel1);
            tabPage3.ForeColor = Color.DarkCyan;
            tabPage3.Name = "tabPage3";
            toolTip1.SetToolTip(tabPage3, resources.GetString("tabPage3.ToolTip"));
            // 
            // sessionData
            // 
            resources.ApplyResources(sessionData, "sessionData");
            sessionData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sessionData.BackgroundColor = Color.Azure;
            sessionData.BorderStyle = BorderStyle.None;
            sessionData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            sessionData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sessionData.Name = "sessionData";
            toolTip1.SetToolTip(sessionData, resources.GetString("sessionData.ToolTip"));
            sessionData.CellBeginEdit += sessionData_CellBeginEdit;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(DeleteRecordBtn);
            panel1.Controls.Add(EditRecordBtn);
            panel1.Name = "panel1";
            toolTip1.SetToolTip(panel1, resources.GetString("panel1.ToolTip"));
            // 
            // DeleteRecordBtn
            // 
            resources.ApplyResources(DeleteRecordBtn, "DeleteRecordBtn");
            DeleteRecordBtn.BackColor = Color.DarkCyan;
            DeleteRecordBtn.ForeColor = Color.White;
            DeleteRecordBtn.Name = "DeleteRecordBtn";
            toolTip1.SetToolTip(DeleteRecordBtn, resources.GetString("DeleteRecordBtn.ToolTip"));
            DeleteRecordBtn.UseVisualStyleBackColor = false;
            DeleteRecordBtn.Click += DeleteRecordBtn_Click;
            // 
            // EditRecordBtn
            // 
            resources.ApplyResources(EditRecordBtn, "EditRecordBtn");
            EditRecordBtn.BackColor = Color.DarkCyan;
            EditRecordBtn.ForeColor = Color.White;
            EditRecordBtn.Name = "EditRecordBtn";
            toolTip1.SetToolTip(EditRecordBtn, resources.GetString("EditRecordBtn.ToolTip"));
            EditRecordBtn.UseVisualStyleBackColor = false;
            EditRecordBtn.Click += EditRecordBtn_Click;
            // 
            // tabPage2
            // 
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.BackColor = Color.Azure;
            tabPage2.Controls.Add(dateSession);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(Date);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(addRecordBtn);
            tabPage2.Controls.Add(subjectCombobox);
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(ClassIDcb);
            tabPage2.Name = "tabPage2";
            toolTip1.SetToolTip(tabPage2, resources.GetString("tabPage2.ToolTip"));
            // 
            // dateSession
            // 
            resources.ApplyResources(dateSession, "dateSession");
            dateSession.Name = "dateSession";
            toolTip1.SetToolTip(dateSession, resources.GetString("dateSession.ToolTip"));
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.BackColor = Color.DarkCyan;
            panel3.Name = "panel3";
            toolTip1.SetToolTip(panel3, resources.GetString("panel3.ToolTip"));
            // 
            // Date
            // 
            resources.ApplyResources(Date, "Date");
            Date.ForeColor = Color.DarkCyan;
            Date.Name = "Date";
            toolTip1.SetToolTip(Date, resources.GetString("Date.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.BackColor = Color.Azure;
            label5.ForeColor = Color.DarkCyan;
            label5.Name = "label5";
            toolTip1.SetToolTip(label5, resources.GetString("label5.ToolTip"));
            // 
            // addRecordBtn
            // 
            resources.ApplyResources(addRecordBtn, "addRecordBtn");
            addRecordBtn.BackColor = Color.DarkCyan;
            addRecordBtn.ForeColor = Color.White;
            addRecordBtn.Name = "addRecordBtn";
            toolTip1.SetToolTip(addRecordBtn, resources.GetString("addRecordBtn.ToolTip"));
            addRecordBtn.UseVisualStyleBackColor = false;
            addRecordBtn.Click += addRecordBtn_Click;
            // 
            // subjectCombobox
            // 
            resources.ApplyResources(subjectCombobox, "subjectCombobox");
            subjectCombobox.FormattingEnabled = true;
            subjectCombobox.Name = "subjectCombobox";
            toolTip1.SetToolTip(subjectCombobox, resources.GetString("subjectCombobox.ToolTip"));
            // 
            // panel4
            // 
            resources.ApplyResources(panel4, "panel4");
            panel4.BackColor = Color.DarkCyan;
            panel4.Name = "panel4";
            toolTip1.SetToolTip(panel4, resources.GetString("panel4.ToolTip"));
            // 
            // ClassIDcb
            // 
            resources.ApplyResources(ClassIDcb, "ClassIDcb");
            ClassIDcb.ForeColor = Color.DarkCyan;
            ClassIDcb.Name = "ClassIDcb";
            toolTip1.SetToolTip(ClassIDcb, resources.GetString("ClassIDcb.ToolTip"));
            // 
            // tabControl1
            // 
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            toolTip1.SetToolTip(tabControl1, resources.GetString("tabControl1.ToolTip"));
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            resources.ApplyResources(tabPage1, "tabPage1");
            tabPage1.BackColor = Color.Azure;
            tabPage1.Controls.Add(stdSessionData);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(sessionIDText);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(label1);
            tabPage1.ForeColor = Color.DarkCyan;
            tabPage1.Name = "tabPage1";
            toolTip1.SetToolTip(tabPage1, resources.GetString("tabPage1.ToolTip"));
            // 
            // stdSessionData
            // 
            resources.ApplyResources(stdSessionData, "stdSessionData");
            stdSessionData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            stdSessionData.BackgroundColor = Color.Azure;
            stdSessionData.BorderStyle = BorderStyle.None;
            stdSessionData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            stdSessionData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stdSessionData.EditMode = DataGridViewEditMode.EditProgrammatically;
            stdSessionData.Name = "stdSessionData";
            toolTip1.SetToolTip(stdSessionData, resources.GetString("stdSessionData.ToolTip"));
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.DarkCyan;
            button1.ForeColor = Color.White;
            button1.Name = "button1";
            toolTip1.SetToolTip(button1, resources.GetString("button1.ToolTip"));
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // sessionIDText
            // 
            resources.ApplyResources(sessionIDText, "sessionIDText");
            sessionIDText.FormattingEnabled = true;
            sessionIDText.Name = "sessionIDText";
            toolTip1.SetToolTip(sessionIDText, resources.GetString("sessionIDText.ToolTip"));
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.BackColor = Color.DarkCyan;
            panel2.Name = "panel2";
            toolTip1.SetToolTip(panel2, resources.GetString("panel2.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.DarkCyan;
            label1.Name = "label1";
            toolTip1.SetToolTip(label1, resources.GetString("label1.ToolTip"));
            // 
            // attendanceMangement
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(tabControl1);
            ForeColor = Color.DarkCyan;
            Name = "attendanceMangement";
            toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sessionData).EndInit();
            panel1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stdSessionData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip1;
        private TabPage tabPage3;
        private DataGridView sessionData;
        private Panel panel1;
        private Button DeleteRecordBtn;
        private Button EditRecordBtn;
        private TabPage tabPage2;
        private ComboBox Statuscb;
        private Panel panel3;
        private Label Date;
        private Label label5;
        private Button addRecordBtn;
        private ComboBox subjectCombobox;
        private Panel panel4;
        private Label ClassIDcb;
        private TabControl tabControl1;
        private DateTimePicker dateSession;
        private TabPage tabPage1;
        private Button button1;
        private ComboBox sessionIDText;
        private Panel panel2;
        private Label label1;
        private DataGridView stdSessionData;
    }
}
