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
            toolTip1 = new ToolTip(components);
            tabPage3 = new TabPage();
            recordData = new DataGridView();
            panel1 = new Panel();
            statuscombox = new ComboBox();
            DeleteRecordBtn = new Button();
            EditRecordBtn = new Button();
            label1 = new Label();
            label4 = new Label();
            IDRecordText = new TextBox();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            stdNameTxtSearch = new TextBox();
            label8 = new Label();
            tabPage2 = new TabPage();
            Statuscb = new ComboBox();
            panel3 = new Panel();
            label7 = new Label();
            label5 = new Label();
            addRecordBtn = new Button();
            stdCombobox = new ComboBox();
            panel4 = new Panel();
            StudentIDcb = new Label();
            tabControl1 = new TabControl();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recordData).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage2.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.Controls.Add(recordData);
            tabPage3.Controls.Add(panel1);
            tabPage3.Location = new Point(4, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(618, 292);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Records";
            // 
            // recordData
            // 
            recordData.BackgroundColor = Color.White;
            recordData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recordData.Location = new Point(6, 130);
            recordData.Name = "recordData";
            recordData.Size = new Size(586, 156);
            recordData.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(statuscombox);
            panel1.Controls.Add(DeleteRecordBtn);
            panel1.Controls.Add(EditRecordBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(IDRecordText);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(stdNameTxtSearch);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(592, 106);
            panel1.TabIndex = 6;
            // 
            // statuscombox
            // 
            statuscombox.FormattingEnabled = true;
            statuscombox.Location = new Point(427, 64);
            statuscombox.Name = "statuscombox";
            statuscombox.Size = new Size(132, 23);
            statuscombox.TabIndex = 20;
            // 
            // DeleteRecordBtn
            // 
            DeleteRecordBtn.BackColor = Color.Indigo;
            DeleteRecordBtn.ForeColor = Color.White;
            DeleteRecordBtn.Location = new Point(473, 7);
            DeleteRecordBtn.Name = "DeleteRecordBtn";
            DeleteRecordBtn.Size = new Size(86, 31);
            DeleteRecordBtn.TabIndex = 7;
            DeleteRecordBtn.Text = "Delete";
            DeleteRecordBtn.UseVisualStyleBackColor = false;
            DeleteRecordBtn.Click += DeleteRecordBtn_Click;
            // 
            // EditRecordBtn
            // 
            EditRecordBtn.BackColor = Color.Indigo;
            EditRecordBtn.ForeColor = Color.White;
            EditRecordBtn.Location = new Point(381, 7);
            EditRecordBtn.Name = "EditRecordBtn";
            EditRecordBtn.Size = new Size(86, 31);
            EditRecordBtn.TabIndex = 8;
            EditRecordBtn.Text = "Edit";
            EditRecordBtn.UseVisualStyleBackColor = false;
            EditRecordBtn.Click += EditRecordBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(322, 67);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 11;
            label1.Text = "Status  :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Indigo;
            label4.Location = new Point(32, 67);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 3;
            label4.Text = "ID :";
            // 
            // IDRecordText
            // 
            IDRecordText.Location = new Point(143, 64);
            IDRecordText.Name = "IDRecordText";
            IDRecordText.Size = new Size(132, 23);
            IDRecordText.TabIndex = 6;
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
            // panel5
            // 
            panel5.BackColor = Color.Indigo;
            panel5.Location = new Point(124, 29);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 2);
            panel5.TabIndex = 2;
            // 
            // stdNameTxtSearch
            // 
            stdNameTxtSearch.BorderStyle = BorderStyle.None;
            stdNameTxtSearch.Location = new Point(124, 10);
            stdNameTxtSearch.Name = "stdNameTxtSearch";
            stdNameTxtSearch.Size = new Size(170, 16);
            stdNameTxtSearch.TabIndex = 4;
            stdNameTxtSearch.TextChanged += stdNameTxtSearch_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.Indigo;
            label8.Location = new Point(3, 10);
            label8.Name = "label8";
            label8.Size = new Size(116, 21);
            label8.TabIndex = 3;
            label8.Text = "Student Name :";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(Statuscb);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(addRecordBtn);
            tabPage2.Controls.Add(stdCombobox);
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(StudentIDcb);
            tabPage2.Location = new Point(4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(618, 292);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add";
            // 
            // Statuscb
            // 
            Statuscb.FlatStyle = FlatStyle.Flat;
            Statuscb.FormattingEnabled = true;
            Statuscb.Location = new Point(314, 143);
            Statuscb.Name = "Statuscb";
            Statuscb.Size = new Size(200, 23);
            Statuscb.TabIndex = 35;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Indigo;
            panel3.Location = new Point(314, 175);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 2);
            panel3.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.Indigo;
            label7.Location = new Point(314, 104);
            label7.Name = "label7";
            label7.Size = new Size(59, 21);
            label7.TabIndex = 34;
            label7.Text = "Status :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.ForeColor = Color.Indigo;
            label5.Location = new Point(226, 16);
            label5.Name = "label5";
            label5.Size = new Size(122, 28);
            label5.TabIndex = 29;
            label5.Text = "Add Record";
            // 
            // addRecordBtn
            // 
            addRecordBtn.BackColor = Color.Indigo;
            addRecordBtn.ForeColor = Color.White;
            addRecordBtn.Location = new Point(215, 233);
            addRecordBtn.Name = "addRecordBtn";
            addRecordBtn.Size = new Size(133, 42);
            addRecordBtn.TabIndex = 28;
            addRecordBtn.Text = "Add";
            addRecordBtn.UseVisualStyleBackColor = false;
            addRecordBtn.Click += addRecordBtn_Click;
            // 
            // stdCombobox
            // 
            stdCombobox.FlatStyle = FlatStyle.Flat;
            stdCombobox.FormattingEnabled = true;
            stdCombobox.Location = new Point(37, 143);
            stdCombobox.Name = "stdCombobox";
            stdCombobox.Size = new Size(200, 23);
            stdCombobox.TabIndex = 27;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Indigo;
            panel4.Location = new Point(37, 175);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 2);
            panel4.TabIndex = 21;
            // 
            // StudentIDcb
            // 
            StudentIDcb.AutoSize = true;
            StudentIDcb.Font = new Font("Segoe UI", 12F);
            StudentIDcb.ForeColor = Color.Indigo;
            StudentIDcb.Location = new Point(37, 111);
            StudentIDcb.Name = "StudentIDcb";
            StudentIDcb.Size = new Size(85, 21);
            StudentIDcb.TabIndex = 23;
            StudentIDcb.Text = "Student ID:";
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(626, 320);
            tabControl1.TabIndex = 0;
            // 
            // attendanceMangement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "attendanceMangement";
            Size = new Size(637, 323);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)recordData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip1;
        private TabPage tabPage3;
        private DataGridView recordData;
        private Panel panel1;
        private Button DeleteRecordBtn;
        private Button EditRecordBtn;
        private Label label1;
        private Label label4;
        private TextBox IDRecordText;
        private PictureBox pictureBox2;
        private Panel panel5;
        private TextBox stdNameTxtSearch;
        private Label label8;
        private TabPage tabPage2;
        private ComboBox Statuscb;
        private Panel panel3;
        private Label label7;
        private Label label5;
        private Button addRecordBtn;
        private ComboBox stdCombobox;
        private Panel panel4;
        private Label StudentIDcb;
        private TabControl tabControl1;
        private ComboBox statuscombox;
    }
}
