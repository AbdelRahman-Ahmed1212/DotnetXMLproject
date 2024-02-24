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
        string sessionPath = "..\\..\\..\\Data\\Session.xml";
        string usersPath = "..\\..\\..\\Data\\users.xml";
        public string userName;

        public editAttendence(string userName)
        {
            InitializeComponent();
            //getTeacherId(userName);
            this.userName = userName;
            var sreader = XmlReader.Create(sessionPath);
            var sdoc = XElement.Load(sreader);
            comboBox1.DataSource = sdoc.Elements().Where(x => x.Attribute("teacherId").Value == getTeacherId(userName))
                                    .Select(x=>x.Attribute("date").Value).ToList();
            sreader.Close();
        }
        

        public string getTeacherId(string passedTeacher)
        {
            string xmlFilePath = usersPath;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);

            XmlNodeList nodes = xmlDoc.GetElementsByTagName("teacher");
            foreach (XmlNode node in nodes)
            {
                XmlNode usernameNode = node.SelectSingleNode("email");
                if (usernameNode != null && usernameNode.InnerText == passedTeacher)
                {
                    XmlNode idNode = node.SelectSingleNode("id");
                    if (idNode != null)
                    {
                        string userId = idNode.InnerText;
                        return userId;
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
                var attendanceRecords = xmlDoc.Root.Elements("Session").Where(
                        x=>x.Attribute("date").Value == comboBox1.SelectedValue)
                    .SelectMany(session => session.Elements("AttendenceRecord")
                        .Select(record => new
                        {
                            StudentId = (int)record.Element("stdid"),
                            StudentName = (string)record.Element("stdName"),
                            SessionId = (int)session.Attribute("id"),
                            SessionDate = (string)session.Attribute("date"),
                            Status = (string)record.Element("status"),
                            TeacherId = (string)session.Attribute("teacherId")
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

        /////
        ///

        private void DisplayStudentStatustoEdit(string TeacherId)
        {
            using (var sessionReader = new FileStream(sessionPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                XDocument xmlDoc = XDocument.Load(sessionReader);

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("StudentId", typeof(int));
                dataTable.Columns.Add("StudentName", typeof(string));
                dataTable.Columns.Add("SessionId", typeof(int));
                dataTable.Columns.Add("SessionDate", typeof(string));
                dataTable.Columns.Add("Attended", typeof(bool)); 

                var attendanceRecords = xmlDoc.Root.Elements("Session").Where(
                        x => x.Attribute("date").Value == comboBox1.SelectedValue.ToString())
                    .SelectMany(session => session.Elements("AttendenceRecord")
                        .Select(record => new
                        {
                            StudentId = (int)record.Element("stdid"),
                            StudentName = (string)record.Element("stdName"),
                            SessionId = (int)session.Attribute("id"),
                            SessionDate = (string)session.Attribute("date"),
                            Status = (string)record.Element("status"), 
                            TeacherId = (string)session.Attribute("teacherId")
                        })).Where(record => record.TeacherId == TeacherId);

                foreach (var record in attendanceRecords)
                {
                    bool attended = record.Status == "Present"; 
                    dataTable.Rows.Add(record.StudentId, record.StudentName, record.SessionId, record.SessionDate, attended);
                }

                editeAttendencdataGridView.DataSource = dataTable;

                editeAttendencdataGridView.Columns["Attended"].HeaderText = "Attended";
                editeAttendencdataGridView.Columns["Attended"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                editeAttendencdataGridView.Columns["Attended"].DefaultCellStyle.NullValue = false;
                editeAttendencdataGridView.Columns["Attended"].ValueType = typeof(bool);
                editeAttendencdataGridView.Columns["Attended"].Width = 80;
            }
        }

        private void EditeAttendencebtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in editeAttendencdataGridView.Rows)
            {
                if (row.Cells["studentId"].Value == null) { 
                break;
                }
                int studentId = (int)row.Cells["StudentId"].Value;
                int sessionId = (int)row.Cells["SessionId"].Value;
                bool attended = (bool)row.Cells["Attended"].Value;

                UpdateAttendanceInXml(studentId, sessionId, attended);
            }

            MessageBox.Show("Attendance records updated successfully.");
        }

        private void UpdateAttendanceInXml(int studentId, int sessionId, bool attended)
        {
            XDocument xmlDoc = XDocument.Load(sessionPath);

            XElement sessionElement = xmlDoc.Root.Elements("Session").FirstOrDefault(s => (int)s.Attribute("id") == sessionId);
            if (sessionElement != null)
            {
                XElement attendanceRecordElement = sessionElement.Elements("AttendenceRecord")
                    .FirstOrDefault(record => (int)record.Element("stdid") == studentId);
                if (attendanceRecordElement != null)
                {
                    attendanceRecordElement.Element("status").Value = attended ? "Present" : "Absent";
                }
            }

            // Save the changes to the XML file
            xmlDoc.Save(sessionPath);
        }

        private void displaytoeditbtn_Click(object sender, EventArgs e)
        {
            string passedId = getTeacherId(userName);
            DisplayStudentStatustoEdit(passedId);
        }

       
    }
}

