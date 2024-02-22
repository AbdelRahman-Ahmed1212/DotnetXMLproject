﻿using DotnetXmlProject.adminUserControl;
using DotnetXmlProject.Classes;
using DotnetXmlProject.studentTeacherUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace DotnetXmlProject
{
    public partial class Teacher : Form
    {
        public string userName;
        public string role;
        public Teacher()
        {
            InitializeComponent();

        }


        private void Teacher_Load(object sender, EventArgs e)
        {
            teacher_classesv1.Visible = false;
            usernamelabel.Text = userName;
            rolelabel.Text = role;
        }
       
        private void MoveSidePanel(Control button)
        {
            TchSidepanel.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 180);
        }

        private void TchClassesbutton_Click(object sender, EventArgs e)
        {
            teacher_classesv1.BringToFront();
            teacher_classesv1.Visible=true;
            MoveSidePanel(TchClassesbutton);

        }

        private void TchAttendencebutton_Click(object sender, EventArgs e)
        {
            editAttendence editAttendence = new editAttendence();
            editAttendence.Dock = DockStyle.Fill;
            this.Controls.Add(editAttendence);
            editAttendence.BringToFront();
            MoveSidePanel(TchAttendencebutton);
        }

        private void TchReportbutton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(TchReportbutton);
        }
        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else
                return;
        }

    }
}
