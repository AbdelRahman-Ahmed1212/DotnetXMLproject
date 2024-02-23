namespace DotnetXmlProject.adminUserControl
{
    partial class test
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
            stdNumLabel = new Label();
            classesNumLabel = new Label();
            SessionsNumLabel = new Label();
            teachersNumLabel = new Label();
            classesNum = new Label();
            sessionNum = new Label();
            techerNum = new Label();
            stdNum = new Label();
            SuspendLayout();
            // 
            // stdNumLabel
            // 
            stdNumLabel.AutoSize = true;
            stdNumLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            stdNumLabel.ForeColor = Color.DarkCyan;
            stdNumLabel.Location = new Point(226, 97);
            stdNumLabel.Name = "stdNumLabel";
            stdNumLabel.Size = new Size(95, 28);
            stdNumLabel.TabIndex = 1;
            stdNumLabel.Text = "Students";
            // 
            // classesNumLabel
            // 
            classesNumLabel.AutoSize = true;
            classesNumLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            classesNumLabel.ForeColor = Color.DarkCyan;
            classesNumLabel.Location = new Point(634, 295);
            classesNumLabel.Name = "classesNumLabel";
            classesNumLabel.Size = new Size(79, 28);
            classesNumLabel.TabIndex = 2;
            classesNumLabel.Text = "Classes";
            // 
            // SessionsNumLabel
            // 
            SessionsNumLabel.AutoSize = true;
            SessionsNumLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            SessionsNumLabel.ForeColor = Color.DarkCyan;
            SessionsNumLabel.Location = new Point(226, 295);
            SessionsNumLabel.Name = "SessionsNumLabel";
            SessionsNumLabel.Size = new Size(91, 28);
            SessionsNumLabel.TabIndex = 3;
            SessionsNumLabel.Text = "Sessions";
            // 
            // teachersNumLabel
            // 
            teachersNumLabel.AutoSize = true;
            teachersNumLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            teachersNumLabel.ForeColor = Color.DarkCyan;
            teachersNumLabel.Location = new Point(634, 97);
            teachersNumLabel.Name = "teachersNumLabel";
            teachersNumLabel.Size = new Size(94, 28);
            teachersNumLabel.TabIndex = 4;
            teachersNumLabel.Text = "Teachers";
            // 
            // classesNum
            // 
            classesNum.AutoSize = true;
            classesNum.Font = new Font("Segoe UI", 12F);
            classesNum.ForeColor = Color.DarkCyan;
            classesNum.Location = new Point(654, 323);
            classesNum.Name = "classesNum";
            classesNum.Size = new Size(59, 21);
            classesNum.TabIndex = 15;
            classesNum.Text = "Name :";
            // 
            // sessionNum
            // 
            sessionNum.AutoSize = true;
            sessionNum.Font = new Font("Segoe UI", 12F);
            sessionNum.ForeColor = Color.DarkCyan;
            sessionNum.Location = new Point(241, 323);
            sessionNum.Name = "sessionNum";
            sessionNum.Size = new Size(59, 21);
            sessionNum.TabIndex = 16;
            sessionNum.Text = "Name :";
            // 
            // techerNum
            // 
            techerNum.AutoSize = true;
            techerNum.Font = new Font("Segoe UI", 12F);
            techerNum.ForeColor = Color.DarkCyan;
            techerNum.Location = new Point(654, 125);
            techerNum.Name = "techerNum";
            techerNum.Size = new Size(59, 21);
            techerNum.TabIndex = 17;
            techerNum.Text = "Name :";
            // 
            // stdNum
            // 
            stdNum.AutoSize = true;
            stdNum.Font = new Font("Segoe UI", 12F);
            stdNum.ForeColor = Color.DarkCyan;
            stdNum.Location = new Point(241, 125);
            stdNum.Name = "stdNum";
            stdNum.Size = new Size(59, 21);
            stdNum.TabIndex = 18;
            stdNum.Text = "Name :";
            // 
            // test
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(stdNum);
            Controls.Add(techerNum);
            Controls.Add(sessionNum);
            Controls.Add(classesNum);
            Controls.Add(teachersNumLabel);
            Controls.Add(SessionsNumLabel);
            Controls.Add(classesNumLabel);
            Controls.Add(stdNumLabel);
            ForeColor = Color.DarkCyan;
            Name = "test";
            Size = new Size(942, 501);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label stdNumLabel;
        private Label classesNumLabel;
        private Label SessionsNumLabel;
        private Label teachersNumLabel;
        private Label classesNum;
        private Label sessionNum;
        private Label techerNum;
        private Label stdNum;
    }
}
