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
using System.Xml.Linq;
using static DotnetXmlProject.Form1;
namespace DotnetXmlProject.studentTeacherUserControl
{

    public partial class editAttendence : UserControl
    {
        string sessionPath = "C:\\Users\\20115\\OneDrive\\Desktop\\x\\DotnetXMLproject\\Data\\Session.xml";
        string usersPath = "C:\\Users\\20115\\OneDrive\\Desktop\\x\\DotnetXMLproject\\Data\\users.xml";
        public string userName;

        public editAttendence()
        {
            InitializeComponent();
            // DisplayStudentStatus()
        }

        private void editeAttendence_Load(object sender, EventArgs e)
        {
            ////
            string passedTeacherId = getTeacherId(userName);
            MessageBox.Show("Passed Teacher ID: " + passedTeacherId, "Debug Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisplayStudentStatus(passedTeacherId);
            ///
        }

        public string getTeacherId(string passedTeacher)
        {
            string passedTeacherId = "";
            XDocument usersXml = XDocument.Load(usersPath);
            XElement userElement = usersXml.Root.Elements("user")
                .FirstOrDefault(u => (string)u.Element("username") == passedTeacher);

            if (userElement != null)
            {
                passedTeacherId = (string)userElement.Attribute("teacherId");
            }
            else
            {
                MessageBox.Show("User not found in XML file: " + passedTeacher, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return passedTeacherId;
        }

        private void DisplayStudentStatus(string TeacherId)
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
                            SessionDate = (string)session.Attribute("date"), 
                            Status = (string)record.Element("status"),
                            TeacherId = (string)session.Attribute("teacherID")
                        })).Where(record => record.TeacherId == TeacherId)
                    .ToList();

                editAttendancedataGridView.DataSource = attendanceRecords;
            }
        }

        private void displayClassbtn_Click(object sender, EventArgs e)
        {
            string passedTeacherId = getTeacherId(userName);
            DisplayStudentStatus(passedTeacherId);


          

        }
    }

}

