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
        public string sessionPath = "C:\\Users\\20115\\OneDrive\\Desktop\\x\\DotnetXMLproject\\Data\\Session.xml";
        public Student()
        {
            InitializeComponent();


        }

        private void Student_Load(object sender, EventArgs e)
        {
            stduserlabel.Text = userName;
            stdrolelabel.Text = role;

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
        private void DisplayStudentStatus(string passedUser)
        {
            using (var sessionReader = new FileStream(sessionPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                XDocument xmlDoc = XDocument.Load(sessionReader);
                var attendanceRecords = xmlDoc.Root.Elements("Session")
                    .SelectMany(session => session.Elements("AttendenceRecord")
                        .Select(record => new
                        {
                            StudentId = (int)record.Element("stdid"),
                            StudentName = (string)record.Element("stdName"),
                            SessionId = (int)session.Attribute("id"),
                            SessionDate = (string)session.Attribute("date"), // Parse SessionDate to string
                            Status = (string)record.Element("status")
                        }))
                    .Where(record => record.StudentName == passedUser)
                    .ToList();

                stddataGridView.DataSource = attendanceRecords;
            }
        }

        private void DisplayStudentStatusByDate(string passedUser, string searchDate)
        {
            using (var sessionReader = new FileStream(sessionPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                XDocument xmlDoc = XDocument.Load(sessionReader);
                var attendanceRecords = xmlDoc.Root.Elements("Session")
                    .SelectMany(session => session.Elements("AttendenceRecord")
                        .Select(record => new
                        {
                            StudentId = (int)record.Element("stdid"),
                            StudentName = (string)record.Element("stdName"),
                            SessionId = (int)session.Attribute("id"),
                            SessionDate = (string)session.Attribute("date"), // Parse SessionDate to string
                            Status = (string)record.Element("status")
                        }))
                    .Where(record => record.StudentName == passedUser && record.SessionDate == searchDate)
                    .ToList();

                stddataGridView.DataSource = attendanceRecords;
            }
        }



        private void stdAttendencebtn_Click(object sender, EventArgs e)
        {
            // Call DisplayStudentStatus without a search date
            DisplayStudentStatus(userName);
            MoveSidePanel(stdAttendencebtn);
        }



        private void searchBox_Click(object sender, EventArgs e)
        {
            DisplayStudentStatusByDate(userName, searchBox.Text.Trim());

        }

        private void reserbtn_Click(object sender, EventArgs e)
        {
            DisplayStudentStatus(userName);
        }
    }
}
