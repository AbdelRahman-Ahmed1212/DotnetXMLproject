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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test));
            stdNumLabel = new Label();
            classesNumLabel = new Label();
            SessionsNumLabel = new Label();
            teachersNumLabel = new Label();
            classesNum = new Label();
            sessionNum = new Label();
            techerNum = new Label();
            stdNum = new Label();
            restore = new Button();
            language = new Button();
            SuspendLayout();
            // 
            // stdNumLabel
            // 
            resources.ApplyResources(stdNumLabel, "stdNumLabel");
            stdNumLabel.ForeColor = Color.DarkCyan;
            stdNumLabel.Name = "stdNumLabel";
            stdNumLabel.Click += stdNumLabel_Click;
            // 
            // classesNumLabel
            // 
            resources.ApplyResources(classesNumLabel, "classesNumLabel");
            classesNumLabel.ForeColor = Color.DarkCyan;
            classesNumLabel.Name = "classesNumLabel";
            // 
            // SessionsNumLabel
            // 
            resources.ApplyResources(SessionsNumLabel, "SessionsNumLabel");
            SessionsNumLabel.ForeColor = Color.DarkCyan;
            SessionsNumLabel.Name = "SessionsNumLabel";
            // 
            // teachersNumLabel
            // 
            resources.ApplyResources(teachersNumLabel, "teachersNumLabel");
            teachersNumLabel.ForeColor = Color.DarkCyan;
            teachersNumLabel.Name = "teachersNumLabel";
            // 
            // classesNum
            // 
            resources.ApplyResources(classesNum, "classesNum");
            classesNum.ForeColor = Color.DarkCyan;
            classesNum.Name = "classesNum";
            // 
            // sessionNum
            // 
            resources.ApplyResources(sessionNum, "sessionNum");
            sessionNum.ForeColor = Color.DarkCyan;
            sessionNum.Name = "sessionNum";
            // 
            // techerNum
            // 
            resources.ApplyResources(techerNum, "techerNum");
            techerNum.ForeColor = Color.DarkCyan;
            techerNum.Name = "techerNum";
            // 
            // stdNum
            // 
            resources.ApplyResources(stdNum, "stdNum");
            stdNum.ForeColor = Color.DarkCyan;
            stdNum.Name = "stdNum";
            // 
            // restore
            // 
            resources.ApplyResources(restore, "restore");
            restore.Name = "restore";
            restore.UseVisualStyleBackColor = true;
            restore.Click += restore_Click;
            // 
            // language
            // 
            resources.ApplyResources(language, "language");
            language.Name = "language";
            language.UseVisualStyleBackColor = true;
            // 
            // test
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(language);
            Controls.Add(restore);
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
        private Button restore;
        private Button language;
    }
}
