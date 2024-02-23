namespace DotnetXmlProject
{
    partial class GenerateReport
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            Generate = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(118, 33);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(56, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "PDF";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += changeMode;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(189, 31);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(71, 24);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "EXCEL";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 33);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 2;
            label1.Text = "format :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(109, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 28);
            comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 66);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 4;
            label2.Text = "date format :";
            // 
            // Generate
            // 
            Generate.Location = new Point(123, 148);
            Generate.Name = "Generate";
            Generate.Size = new Size(137, 39);
            Generate.TabIndex = 5;
            Generate.Text = "Generate";
            Generate.UseVisualStyleBackColor = true;
            Generate.Click += Generate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 6;
            label3.Text = "filename";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 27);
            textBox1.TabIndex = 7;
            // 
            // GenerateReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 199);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(Generate);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "GenerateReport";
            Text = "GenerateReport";
            Load += GenerateReport_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Button Generate;
        private Label label3;
        private TextBox textBox1;
    }
}