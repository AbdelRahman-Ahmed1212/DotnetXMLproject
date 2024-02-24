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
using System.Xml;
using static System.Collections.Specialized.BitVector32;
using System.Globalization;
using System.Reflection;

namespace DotnetXmlProject.adminUserControl
{
    public partial class attendanceMangement : UserControl
    {
        public string recordPath = "..\\..\\..\\Data\\attendence.xml";
        public string userPath = "..\\..\\..\\Data\\users.xml";
        public string classPath = "..\\..\\..\\Data\\classes.xml";
        public string sessionPath = "..\\..\\..\\Data\\session.xml";
        public attendanceMangement()
        {
            InitializeComponent();

            comboxSubjectData();
            PopulateDataGridViewSession();
            PopulateSessionIds();

        }


        //==========================================================================
        //Display
        //==========================================================================
        public void comboxSubjectData()
        {
            subjectCombobox.Items.Clear();

            using (var reader = XmlReader.Create(classPath))
            {
                var Users = XElement.Load(reader);
                var subjectIds = Users.Elements("stdClass")
                                      .Select(u => (int)u.Element("id"))
                                      .ToList();

                subjectCombobox.Items.AddRange(subjectIds.Select(id => id.ToString()).ToArray());
            }
        }
        public void PopulateSessionIds()
        {
            try
            {
                using (var reader = XmlReader.Create(sessionPath))
                {
                    var sessions = XElement.Load(reader);
                    var sessionIds = sessions.Elements("Session")
                                            .Select(s => (int)s.Attribute("id"))
                                            .ToList();

                    sessionIDText.Items.AddRange(sessionIds.Select(id => id.ToString()).ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading session IDs: {ex.Message}");
            }
        }

        public void PopulateDataGridViewSession()
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(sessionPath);

                var sessions = xmlDoc.Descendants("Session")
                                     .Select(s => new session
                                     {
                                         id = (int)s.Attribute("id"),
                                         className = (string)s.Attribute("class"),
                                         Date = DateTime.ParseExact((string)s.Attribute("date"), "dd/MM/yyyy", CultureInfo.InvariantCulture),
                                         teacherID = (int)s.Attribute("teacherId"),
                                        
                                     }).ToList();

                sessionData.DataSource = sessions;
                sessionData.Columns["className"].HeaderText = "Class Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading session data: {ex.Message}");
            }
        }


        public void PopulateDataGridViewattendanceRecourd(int sessionID)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(sessionPath);

                var attendanceRecords = xmlDoc.Descendants("Session")
                                              .Where(s => (int)s.Attribute("id") == sessionID)
                                              .Elements("AttendenceRecord")
                                              .Select(r => new attendanceRecord
                                              {
                                                  ID = (int)r.Element("stdid"),
                                                  studentName = (string)r.Element("stdName"),
                                                  studentStatus = (Status)Enum.Parse(typeof(Status), (string)r.Element("status"))
                                              }).ToList();
                if (attendanceRecords.Any())
                {
                    stdSessionData.DataSource = attendanceRecords;


                }
                else
                {
                    stdSessionData.DataSource = null;
                    MessageBox.Show($"session with ID {sessionID} not found or has no associated students.");
                }
                stdSessionData.DataSource = attendanceRecords;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading session data: {ex.Message}");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int sessionID = Convert.ToInt32(sessionIDText.Text);

            if (Validation.CheckIfSessionExists(sessionPath, "Session", "id", sessionID)) 
            {
                PopulateDataGridViewattendanceRecourd(sessionID);
            }
            else
            {
                MessageBox.Show("Invalid session ID. Please enter a valid session ID.");
            }
            
        }

        //==========================================================================
        //Add
        //==========================================================================
        public void AddNewSession(DateTime date, int subjectId)
        {
            try
            {
                
                if (Validation.CheckIfIdExists(classPath, "stdClass", "id", subjectId))
                {
                    
                    XDocument xmlDoc = XDocument.Load(sessionPath);

                    int newSessionId = xmlDoc.Descendants("Session").Max(s => (int)s.Attribute("id")) + 1;
                    string className = GetClassNameFromId(subjectId);
                    int teacherID = GetteacherIDFromId(subjectId);

                   
                    XElement newSession = new XElement("Session",
                        new XAttribute("id", newSessionId),
                        new XAttribute("date", date.ToString("dd/MM/yyyy")),
                        new XAttribute("subjectId", subjectId),
                        new XAttribute("class", className),
                        new XAttribute("teacherId", teacherID)
                    );

                    // Add attendance records for associated students
                    XDocument userDoc = XDocument.Load(userPath);
                    var students = userDoc.Descendants("student")
                                          .Where(u => u.Element("classes")?.Elements("class")
                                                       .Any(c => (string)c.Element("className") == className) ?? false)
                                          .Select(u => new
                                          {
                                              ID = (int)u.Element("id"),
                                              Name = (string)u.Element("userName")
                                          });

                    foreach (var student in students)
                    {
                        XElement attendanceRecord = new XElement("AttendenceRecord",
                            new XElement("stdid", student.ID),
                            new XElement("stdName", student.Name),
                            new XElement("status", "notAsssigned")
                        );

                        newSession.Add(attendanceRecord);
                    }

                    xmlDoc.Root.Add(newSession);
                    xmlDoc.Save(sessionPath);

                    PopulateDataGridViewSession();
                    MessageBox.Show("New session added successfully.");
                    PopulateSessionIds();
                    clearInput();
                }
                else
                {
                    MessageBox.Show("Session with the specified subject ID not exists.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding new session: {ex.Message}");
            }
        }

        private string GetClassNameFromId(int subjectId)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(classPath);

                XElement stdClass = xmlDoc.Descendants("stdClass")
                                          .FirstOrDefault(s => (int)s.Element("id") == subjectId);
                return (string)stdClass.Element("name");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving class name: {ex.Message}");
                return "DefaultClass";
            }
        }
        private int GetteacherIDFromId(int subjectId)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(classPath);

                XElement stdClass = xmlDoc.Descendants("stdClass")
                                          .FirstOrDefault(s => (int)s.Element("id") == subjectId);
                return (int)stdClass.Element("teacherId");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving teacher : {ex.Message}");
                return 0;
            }
        }

        private void addRecordBtn_Click(object sender, EventArgs e)
        {
            int subjectID = Convert.ToInt32(subjectCombobox.Text);
            DateTime date = Convert.ToDateTime(dateSession.Text);

            AddNewSession(date, subjectID);

            ManageClasses cm = new ManageClasses();
            cm.comboxClassData();
        }

        //==========================================================================
        //Edit
        //==========================================================================
        private void EditRecordBtn_Click(object sender, EventArgs e)
        {
            if (sessionData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a session to edit.");
                return;
            }

            int sessionId = Convert.ToInt32(sessionData.SelectedRows[0].Cells["id"].Value);
            DateTime sessionDate = (DateTime)sessionData.SelectedRows[0].Cells["Date"].Value;
            string formattedDate = sessionDate.ToString("dd/MM/yyyy");

            if (Validation.IsDateInCorrectFormat(formattedDate))
            {
                UpdateSessionDateInXml(sessionId, formattedDate);
                PopulateDataGridViewSession();
                
                MessageBox.Show("Session updated successfully.");
            }
            else
            {
                MessageBox.Show("Invalid date format. Please enter the date in the format: dd/MM/yyyy");
            }
        }

        private void UpdateSessionDateInXml(int sessionId, string newDate)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(sessionPath);
                XElement sessionToUpdate = xmlDoc.Descendants("Session")
                                                  .FirstOrDefault(s => (int)s.Attribute("id") == sessionId);

                if (sessionToUpdate != null)
                {
                    sessionToUpdate.Attribute("date").Value = newDate;
                    xmlDoc.Save(sessionPath);
                }
                else
                {
                    MessageBox.Show("Session with the specified ID not found.");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error updating session date: {ex.Message}. Please make sure the XML file is not open in another program.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating session date: {ex.Message}");
            }
        }

       


        //==========================================================================
        //Delete
        //==========================================================================

        private void DeleteRecordBtn_Click(object sender, EventArgs e)
        {
            if (sessionData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a session to delete.");
                return;
            }

            int sessionId = Convert.ToInt32(sessionData.SelectedRows[0].Cells["id"].Value);
            DeleteSessionFromXml(sessionId);

            PopulateDataGridViewSession();
            ManageClasses cm = new ManageClasses();
            cm.comboxClassData();
        }

        private void DeleteSessionFromXml(int sessionId)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(sessionPath);

                // Find the session to delete
                XElement sessionToDelete = xmlDoc.Root.Elements("Session")
                                                     .FirstOrDefault(s => (int)s.Attribute("id") == sessionId);

                if (sessionToDelete != null)
                {
                    sessionToDelete.Remove();
                    xmlDoc.Save(sessionPath);
                    MessageBox.Show("Session deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Session with the specified ID not found.");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error deleting session: {ex.Message}. Please make sure the XML file is not open in another program.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting session: {ex.Message}");
            }
        }


        //==========================================================================
        //Additional Methods
        //==========================================================================

        private void sessionData_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            List<string> columnsToPreventEditing = new List<string> { "id", "className", "teacherID" };

            if (columnsToPreventEditing.Contains(sessionData.Columns[e.ColumnIndex].Name))
            {
                e.Cancel = true;
            }
        }

        private void clearInput()
        {
            subjectCombobox.SelectedIndex = -1;


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
