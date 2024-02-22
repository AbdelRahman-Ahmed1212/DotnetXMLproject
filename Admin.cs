
﻿using DotnetXmlProject.adminUserControl;
using DotnetXmlProject.Classes;
using Microsoft.VisualBasic.ApplicationServices;

﻿using DotnetXmlProject.Classes;

using User = DotnetXmlProject.Classes.User;


namespace DotnetXmlProject
{
    public partial class Admin : Form
    {
        public static string username;
        public Admin()
        {
            InitializeComponent();

            addUser1.Visible = false;
            attendanceMangement1.Visible = false;
            classManagement2.Visible = false;
            manageClasses1.Visible = false;
            test1.Visible = true;
            labelWelcome.Text = username;

            timerDate.Start();


        }

        private void MovePanel(Control button)
        {
            panelSide.Location = new Point(button.Location.X - button.Location.X, button.Location.Y);
        }

      
        private void addUserBtn_Click(object sender, EventArgs e)
        {
            addUser1.Visible = true;
            attendanceMangement1.Visible = false;
            classManagement2.Visible = false;
            manageClasses1.Visible = false;
            test1.Visible = false;

            MovePanel(addUserBtn);

        }

        private void addClassBtn_Click(object sender, EventArgs e)
        {
            addUser1.Visible = false;
            attendanceMangement1.Visible = false;
            classManagement2.Visible = true;
            manageClasses1.Visible = false;
            test1.Visible = false;

            MovePanel(addClassBtn);
        }

        private void attendanveBtn_Click(object sender, EventArgs e)
        {
            addUser1.Visible = false;
            attendanceMangement1.Visible = true;
            classManagement2.Visible = false;
            manageClasses1.Visible = false;
            test1.Visible = false;

            MovePanel(attendanveBtn);
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            addUser1.Visible = false;
            attendanceMangement1.Visible = false;
            classManagement2.Visible = false;
            manageClasses1.Visible = false;
            test1.Visible = false;

            MovePanel(reportBtn);
        }

       

        private void manageBtn_Click(object sender, EventArgs e)
        {
            manageClasses1.Visible = true;
            addUser1.Visible = false;
            attendanceMangement1.Visible = false;
            classManagement2.Visible = false;
            test1.Visible = false;

            MovePanel(manageBtn);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString("F");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dbox = MessageBox.Show("Are You Want To Log Out ? ", "Log out ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dbox == DialogResult.Yes)
            {
                timerDate.Stop();
                Close();
            }
            else
            {

            }
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            MovePanel(dashboardBtn);

            addUser1.Visible = false;
            attendanceMangement1.Visible = false;
            classManagement2.Visible = false;
            manageClasses1.Visible = false;
            test1.Visible = true;
        }

       
    }
}
