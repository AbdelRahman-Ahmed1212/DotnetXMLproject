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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DotnetXmlProject
{
    public partial class Student : Form
    {
        public int flag;
        public string userName;
        public string role;
        public string sessionPath = "C:\\Users\\20115\\OneDrive\\Desktop\\x\\DotnetXMLproject\\Data\\Session.xml";
        public Student(string _userName, string _role,int _flag=0)
        {
            InitializeComponent();
            this.userName = _userName;
            this.role = _role;
            this.flag = _flag;
        }

        private void Student_Load(object sender, EventArgs e)
        {
            stdusernamelabel.Text = userName;
            stdroleNamelabel.Text = role;

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
            // Calculate the new location relative to the parent control
            int newX = button.Location.X - button.Parent.Location.X;
            int newY = button.Location.Y - button.Parent.Location.Y;

            // Adjust the Y coordinate based on your requirements (-180 in this case)
            newY -= 180;

            // Set the new location for the panel
            stdSmallSidePanel.Location = new Point(newX, newY);
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
            flag++; 
        }



        private void searchBox_Click(object sender, EventArgs e)
        {
            if (searchBox.Text.Trim() != "")
                DisplayStudentStatusByDate(userName, searchBox.Text.Trim());
            else
                MessageBox.Show("please enter date");

        }

        private void reserbtn_Click(object sender, EventArgs e)
        {
            if (flag != 0)
            {
                searchBox.Text = "";
                DisplayStudentStatus(userName);
            }
            else
            {
                searchBox.Text = "";
                return;
            }   
        }
    }
}
