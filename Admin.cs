
﻿using DotnetXmlProject.adminUserControl;
using DotnetXmlProject.Classes;
using Microsoft.VisualBasic.ApplicationServices;

﻿using DotnetXmlProject.Classes;



namespace DotnetXmlProject
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

            addUser2.Visible = false;
            attendanceMangement1.Visible = false;
            classManagement1.Visible = false;








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
            attendanceMangement1.Visible = false;
            classManagement1.Visible = false;


        }

        private void addClassBtn_Click(object sender, EventArgs e)
        {
            addUser2.Visible = false;
            attendanceMangement1.Visible = false;
            classManagement1.Visible = true;
        }

        private void attendanveBtn_Click(object sender, EventArgs e)
        {
            addUser2.Visible = false;
            attendanceMangement1.Visible = true;
            classManagement1.Visible = false;
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            addUser2.Visible = false;
            attendanceMangement1.Visible = false;
            classManagement1.Visible = false;
            Reports r1 = new Reports();
            r1.Show();
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
    }
}
