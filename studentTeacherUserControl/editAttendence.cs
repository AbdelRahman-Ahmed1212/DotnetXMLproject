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
using static DotnetXmlProject.Form1;
namespace DotnetXmlProject.studentTeacherUserControl
{

    public partial class editAttendence : UserControl
    {
        string sessionPath = "C:\\Users\\20115\\OneDrive\\Desktop\\x\\DotnetXMLproject\\Data\\Session.xml";
        string usersPath = "C:\\Users\\20115\\OneDrive\\Desktop\\x\\DotnetXMLproject\\Data\\users.xml";
        public string userName;

        public editAttendence(string userName)
        {
            InitializeComponent();
            //getTeacherId(userName);
            this.userName = userName;
        }


        public string getTeacherId(string passedTeacher)
        {
            string xmlFilePath = usersPath;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);

            XmlNodeList nodes = xmlDoc.GetElementsByTagName("user");
            foreach (XmlNode node in nodes)
            {
                XmlNode usernameNode = node.SelectSingleNode("userName");
                if (usernameNode != null && usernameNode.InnerText == passedTeacher)
                {
                    XmlNode idNode = node.SelectSingleNode("id");
                    if (idNode != null)
                    {
                        string userId = idNode.InnerText;
                        return userId;
                        //Console.WriteLine("User ID: " + userId);
                        break;
                    }
                }
            }

            return null;
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




        }

        private void displayClassbtn_Click_1(object sender, EventArgs e)
        {
            string passedTeacherId = getTeacherId(userName);
            DisplayStudentStatus(passedTeacherId);

        }
    }

}

