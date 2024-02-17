using DotnetXmlProject.adminUserControl;
using DotnetXmlProject.Classes;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using User = DotnetXmlProject.Classes.User;

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





            //==========================================================================



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
