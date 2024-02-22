namespace DotnetXmlProject
{
    partial class Reports
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            Export = new Button();
            attendeceGrid = new DataGridView();
            classList = new ComboBox();
            label3 = new Label();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)attendeceGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 27);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "from";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(509, 27);
            label2.Name = "label2";
            label2.Size = new Size(23, 20);
            label2.TabIndex = 1;
            label2.Text = "to";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(253, 27);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += datePickerChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(538, 27);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 3;
            dateTimePicker2.ValueChanged += datePickerChanged;
            // 
            // Export
            // 
            Export.Location = new Point(694, 399);
            Export.Name = "Export";
            Export.Size = new Size(94, 29);
            Export.TabIndex = 4;
            Export.Text = "Export";
            Export.UseVisualStyleBackColor = true;
            Export.Click += Export_Click;
            // 
            // attendeceGrid
            // 
            attendeceGrid.AllowUserToAddRows = false;
            attendeceGrid.AllowUserToDeleteRows = false;
            attendeceGrid.AllowUserToResizeColumns = false;
            attendeceGrid.AllowUserToResizeRows = false;
            attendeceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            attendeceGrid.Location = new Point(12, 72);
            attendeceGrid.Name = "attendeceGrid";
            attendeceGrid.RowHeadersWidth = 51;
            attendeceGrid.Size = new Size(776, 321);
            attendeceGrid.TabIndex = 5;
            // 
            // classList
            // 
            classList.FormattingEnabled = true;
            classList.Location = new Point(49, 24);
            classList.Name = "classList";
            classList.Size = new Size(151, 28);
            classList.TabIndex = 6;
            classList.SelectedValueChanged += datePickerChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 27);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 7;
            label3.Text = "for";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 404);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(145, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "individual Report";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(classList);
            Controls.Add(attendeceGrid);
            Controls.Add(Export);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Reports";
            Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)attendeceGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button Export;
        private DataGridView attendeceGrid;
        private ComboBox classList;
        private Label label3;
        private CheckBox checkBox1;
    }
}