
﻿using DotnetXmlProject.adminUserControl;
using DotnetXmlProject.Classes;
using Microsoft.VisualBasic.ApplicationServices;

﻿using DotnetXmlProject.Classes;

using User = DotnetXmlProject.Classes.User;


namespace DotnetXmlProject
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

            addUser2.Visible = false;
            attendanceMangement2.Visible = false;
            classManagement2.Visible = false;
            manageClasses1.Visible = false;








        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void addUserBtn_Click(object sender, EventArgs e)
        {
            addUser2.Visible = true;
            attendanceMangement2.Visible = false;
            classManagement2.Visible = false;
            manageClasses1.Visible = false;

        }

        private void addClassBtn_Click(object sender, EventArgs e)
        {
            addUser2.Visible = false;
            attendanceMangement2.Visible = false;
            classManagement2.Visible = true;
            manageClasses1.Visible = false;
        }

        private void attendanveBtn_Click(object sender, EventArgs e)
        {
            addUser2.Visible = false;
            attendanceMangement2.Visible = true;
            classManagement2.Visible = false;
            manageClasses1.Visible = false;
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            addUser2.Visible = false;
            attendanceMangement2.Visible = false;
            classManagement2.Visible = false;
            manageClasses1.Visible = false;
        }

        private void addUser1_Load(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void attendanceMangement2_Load(object sender, EventArgs e)
        {

        }

        private void addUser2_Load(object sender, EventArgs e)
        {

        }

        private void attendanceMangement1_Load(object sender, EventArgs e)
        {


        }

        private void manageBtn_Click(object sender, EventArgs e)
        {
            manageClasses1.Visible = true;
            addUser2.Visible = false;
            attendanceMangement2.Visible = false;
            classManagement2.Visible = false;
        }
    }
}
