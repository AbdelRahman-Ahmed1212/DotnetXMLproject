using DotnetXmlProject.Classes;
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

namespace DotnetXmlProject
{
    public partial class Student : Form
    {
        public string userName;
        public string role;
        public Student()
        {
            InitializeComponent();
            var reader = XmlReader.Create("..\\..\\..\\Data\\users.xml");
            var XE = XElement.Load(reader);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else
                return;

        }
        private void MoveSidePanel(Control button)
        {
            stdSmallSidePanel.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 180);
        }

        private void StdReportbtn_Click(object sender, EventArgs e)
        {
            MoveSidePanel(StdReportbtn);
        }

        private void stdAttendencebtn_Click(object sender, EventArgs e)
        {
            MoveSidePanel(stdAttendencebtn);
        }
    }
}
