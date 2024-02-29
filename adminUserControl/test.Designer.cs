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
            teachersNumLabel = new Label();
            classesNum = new Label();
            sessionNum = new Label();
            techerNum = new Label();
            stdNum = new Label();
            restore = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // stdNumLabel
            // 
            resources.ApplyResources(stdNumLabel, "stdNumLabel");
            stdNumLabel.ForeColor = Color.DarkCyan;
            stdNumLabel.Name = "stdNumLabel";
            stdNumLabel.Click += stdNumLabel_Click;
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.students;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.teacherrrr;
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.presentationnn;
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.text_books;
            resources.ApplyResources(pictureBox4, "pictureBox4");
            pictureBox4.Name = "pictureBox4";
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label2
            // 
            label2.ForeColor = Color.DarkCyan;
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.DarkCyan;
            label3.Name = "label3";
            // 
            // test
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(restore);
            Controls.Add(stdNum);
            Controls.Add(techerNum);
            Controls.Add(sessionNum);
            Controls.Add(classesNum);
            Controls.Add(teachersNumLabel);
            Controls.Add(stdNumLabel);
            ForeColor = Color.DarkCyan;
            Name = "test";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label stdNumLabel;
        private Label teachersNumLabel;
        private Label classesNum;
        private Label sessionNum;
        private Label techerNum;
        private Label stdNum;
        private Button restore;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label2;
        private Label label3;
    }
}
