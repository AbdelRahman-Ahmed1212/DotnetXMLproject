using DotnetXmlProject.Classes;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace DotnetXmlProject.studentTeacherUserControl
{
    public partial class teacher_classesv : UserControl
    {
        public string classesPath = "C:\\Users\\20115\\OneDrive\\Desktop\\x\\DotnetXMLproject\\Data\\Session.xml";
        public string usersPath = "C:\\Users\\20115\\OneDrive\\Desktop\\x\\DotnetXMLproject\\Data\\users.xml";

        public teacher_classesv()
        {
            InitializeComponent();
        }


        ////display class by class id//////

        private void displayClassGridViewById(string sessionId)
        {
            using (var stream = new FileStream(classesPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                XDocument xmlDoc = XDocument.Load(stream);
                var searchResults = xmlDoc.Root.Elements("Session")
                    .Where(session => (string)session.Attribute("id") == sessionId)
                    .SelectMany(session => session.Elements("AttendenceRecord")
                        .Select(record => new classData
                        {
                            SessionId = (int)session.Attribute("id"),
                            Session = (string)session.Attribute("class"),
                            id = (int)record.Element("stdid"),
                            name = (string)record.Element("stdName"),
                            SessionDate = (string)session.Attribute("date"),
                            status = (string)record.Element("status")
                        })).ToList();

                dataGridView1.DataSource = searchResults;
            }
        }
        ////display students by student id//////
        private void SearchAndDisplayByStudentId(string studentId)
        {
            using (var stream = new FileStream(classesPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                XDocument xmlDoc = XDocument.Load(stream);
                var searchResults = xmlDoc.Root.Elements("Session")
                    .SelectMany(session => session.Elements("AttendenceRecord")
                        .Where(record => (string)record.Element("stdid") == studentId)
                        .Select(record => new classData
                        {
                            SessionId = (int)session.Attribute("id"),
                            Session = (string)session.Attribute("class"),
                            id = (int)record.Element("stdid"),
                            name = (string)record.Element("stdName"),
                            SessionDate = (string)session.Attribute("date"),
                            status = (string)record.Element("status")
                        })).ToList();

                dataGridView1.DataSource = searchResults;
            }
        }

        /////function to check user existence in users data////

        private bool IsStudentAlreadyAdded(int studentId, string sessionId)
        {
            XDocument xmlDoc = XDocument.Load(classesPath);

            XElement sessionElement = xmlDoc.Root.Elements("Session")
                .FirstOrDefault(s => (string)s.Attribute("id") == sessionId);

            if (sessionElement != null)
            {
                bool isStudentAlreadyAdded = sessionElement.Elements("AttendenceRecord")
                    .Any(record => (int)record.Element("stdid") == studentId);

                return isStudentAlreadyAdded;
            }
            else
            {
                MessageBox.Show("Session not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void addStudent()
        {
            string name = textBoxstdName.Text;
            string stdClass = textBoxclass.Text;
            string date = textBoxdate.Text;
            string status = textBoxstatus.Text;

            // Check if the student exists in the users.xml file
            int studentId = GetStudentIdFromName(name);
            if (studentId == -1)
            {
                MessageBox.Show("Student does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool isexist = IsStudentAlreadyAdded(studentId,stdClass);
            if (isexist)
            {
                MessageBox.Show("student already exists");
                return;
            }
            XDocument xmlDoc = XDocument.Load(classesPath);
            XElement sessionElement = xmlDoc.Root.Elements("Session")
                .FirstOrDefault(s => (string)s.Attribute("id") == stdClass);

            if (sessionElement != null)
            {
                sessionElement.Add(
                    new XElement("AttendenceRecord",
                        new XElement("stdid", studentId),
                        new XElement("stdName", name),
                        new XElement("status", status),
                        new XAttribute("date", date)
                    )
                );

                // Save the changes to the XML document
                xmlDoc.Save(classesPath);
                MessageBox.Show("Student added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Session not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int GetStudentIdFromName(string name)
        {
            XDocument usersXml = XDocument.Load(usersPath);
            XElement userElement = usersXml.Root.Elements("user")
                                  .FirstOrDefault(u => (string)u.Element("name") == name);

            if (userElement != null)
            {
                // Retrieve the student ID from the user element
                return (int)userElement.Element("id");
            }
            else
            {
                return -1; 
                // Return -1 if the student does not exist
            }
        }
        
        
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void displayClassbtn_Click(object sender, EventArgs e)
        {
            displayClassGridViewById(classIdtextBox.Text);
        }

        private void tabcontroleaddstd_Click(object sender, EventArgs e)
        {

        }

        private void searchpictureBox_Click(object sender, EventArgs e)
        {
            SearchAndDisplayByStudentId(serchtextBox.Text);
        }

        private void dataGridView1_Load(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addstdbtn_Click(object sender, EventArgs e)
        {
            addStudent();
        }
    }
}
