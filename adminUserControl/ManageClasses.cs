using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Xml;
using DotnetXmlProject.Classes;
using Microsoft.VisualBasic.ApplicationServices;

namespace DotnetXmlProject.adminUserControl
{
    public partial class ManageClasses : UserControl
    {
        public ManageClasses()
        {
            InitializeComponent();
            comboxClassData();
            comboxStdData();
            comboxTeacherData();
            comboxUserData();
        }
        public string classPath = "..\\..\\..\\Data\\classes.xml";
        public string userPath = "..\\..\\..\\Data\\users.xml";

        public void RefrchData()
        {
            comboxClassData();
            comboxStdData();
            comboxTeacherData();
            comboxUserData();

        }
        //==========================================================================
        //Display
        //==========================================================================

        public void comboxStdData()
        {
            stdClassID.Items.Clear();
            using (var reader = XmlReader.Create(userPath))
            {
                var Users = XElement.Load(reader);
                var studentIds = Users.Elements("student")
                                      .Where(u => string.Equals(u.Element("role")?.Value, "Student", StringComparison.OrdinalIgnoreCase))
                                      .Select(u => (int)u.Element("id"))
                                      .ToList();

                stdClassID.Items.AddRange(studentIds.Select(id => id.ToString()).ToArray());
            }
        }

        public void comboxTeacherData()
        {
            teacherClassID.Items.Clear();
            using (var reader = XmlReader.Create(userPath))
            {
                var Users = XElement.Load(reader);
                var teacherIds = Users.Elements("teacher")
                                      .Where(u => string.Equals(u.Element("role")?.Value, "Teacher", StringComparison.OrdinalIgnoreCase))
                                      .Select(u => (int)u.Element("id"))
                                      .ToList();

                teacherClassID.Items.AddRange(teacherIds.Select(id => id.ToString()).ToArray());
            }
        }

        public void comboxUserData()
        {
            userID.Items.Clear();
            try
            {
                using (var reader = XmlReader.Create(userPath))
                {
                    var users = XElement.Load(reader);
                    var allUserIds = users.Descendants()
                                          .Where(e => e.Name == "student" || e.Name == "teacher")
                                          .Select(u => (int)u.Element("id"))
                                          .ToList();

                    userID.Items.AddRange(allUserIds.Select(id => id.ToString()).ToArray());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user data: {ex.Message}");
            }
        }
        public void comboxClassData()
        {
            classStdID.Items.Clear();
            classTeacherID.Items.Clear();
            using (var reader = XmlReader.Create(classPath))
            {
                var Users = XElement.Load(reader);
                var classIds = Users.Elements("stdClass")
                                      .Select(u => (int)u.Element("id"))
                                      .ToList();

                classTeacherID.Items.AddRange(classIds.Select(id => id.ToString()).ToArray());
                classStdID.Items.AddRange(classIds.Select(id => id.ToString()).ToArray());

            }
        }
        private void PopulateDataGridViewUserById(int id)
        {
            try
            {
                using (var stream = new FileStream(userPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    var users = XElement.Load(stream);
                    var userData = users.Descendants()
                                        .Where(e => (string)e.Element("id") == id.ToString())
                                        .SelectMany(u => u.Descendants("class")
                                            .Select(c => new classData
                                            {
                                                id = (int)c.Element("classID"),
                                                TeacherId = id,
                                                name = (string)c.Element("className")
                                            })).ToList();

                    if (userData.Any())
                    {
                        classesData.DataSource = userData;
                        classesData.Columns["TeacherId"].HeaderText = "UserId";

                    }
                    else
                    {
                        classesData.DataSource = null;
                        MessageBox.Show($"User with ID {id} not found or has no associated classes.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student data: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(userID.Text);
            PopulateDataGridViewUserById(id);
        }

        //==========================================================================
        //Add
        //==========================================================================


        private void AddClassDataToUser(int userID, int classID)
        {
            try
            {
                if (!Validation.CheckIfIdExists(classPath, "stdClass", "id", classID))
                {
                    MessageBox.Show("Class with the specified ID not found.");
                    return;
                }
                else
                {
                    XDocument xmlDoc = XDocument.Load(userPath);


                    var userElement = xmlDoc.Descendants()
                        .Where(e => e.Name == "student" || e.Name == "teacher")
                        .FirstOrDefault(u => (int)u.Element("id") == userID);

                    if (userElement != null)
                    {
                        var classNameElement = userElement.Element("classes");
                        if (classNameElement == null)
                        {
                            classNameElement = new XElement("classes");
                            userElement.Add(classNameElement);
                        }

                        classNameElement.Add(new XElement("class",
                                        new XElement("classID", classID),
                                        new XElement("className", GetClassNameById(classID))));

                        xmlDoc.Save(userPath);

                        MessageBox.Show("Class add successfully.");
                    }
                    else
                    {
                        MessageBox.Show("User with the specified ID not found.");
                    }

                }
               
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error adding class name: {ex.Message}. Please make sure the XML file is not open in another program.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding class name: {ex.Message}");
            }
        }

        public string GetClassNameById(int id)
        {
            try
            {
                using (var stream = new FileStream(classPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    var xmlData = XElement.Load(stream);
                    var className = xmlData.Descendants("stdClass")
                                           .Where(e => (int)e.Element("id") == id)
                                           .Select(e => (string)e.Element("name"))
                                           .FirstOrDefault();


                    return className;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving class name: {ex.Message}");
                return null;
            }
        }

        private void addClassStd_Click(object sender, EventArgs e)
        {
            int classID = Convert.ToInt32(classStdID.Text);
            int userID = Convert.ToInt32(stdClassID.Text);
            AddClassDataToUser(userID, classID);
            clearInput();
        }

        private void addClassTeacher_Click(object sender, EventArgs e)
        {
            int classID = Convert.ToInt32(classTeacherID.Text);
            int userID = Convert.ToInt32(teacherClassID.Text);
            AddClassDataToUser(userID, classID);
            clearInput();
        }

        //==========================================================================
        //Delete
        //==========================================================================

        private void DeleteUserClassFromXml(int classId, int userID)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(userPath);
                var a = xmlDoc.Descendants();

                var userElement = xmlDoc.Descendants()
                    .Where(e => e.Name == "student" || e.Name == "teacher")
                    .FirstOrDefault(u => (int)u.Element("id") == userID);


                if (userElement != null)
                {
                    XElement classesElement = userElement.Element("classes");
                    if (classesElement != null)
                    {
                        XElement classElementToRemove = classesElement.Elements("class").FirstOrDefault(c => (int)c.Element("classID") == classId);
                        if (classElementToRemove != null)
                        {
                            classElementToRemove.Remove();
                        }
                        else
                        {
                            MessageBox.Show("Class with the specified ID not found in teacher's classes.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Classes element not found in teacher's data.");
                    }
                }
                else
                {
                    MessageBox.Show("Teacher with the specified ID not found in users XML.");
                }



                xmlDoc.Save(userPath);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error deleting class: {ex.Message}. Please make sure the XML file is not open in another program.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting class: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (classesData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a class to delete.");
                return;
            }
            int classId = Convert.ToInt32(classesData.SelectedRows[0].Cells["id"].Value);
            int teacherId = Convert.ToInt32(classesData.SelectedRows[0].Cells["TeacherId"].Value);

            DeleteUserClassFromXml(classId, teacherId);

            PopulateDataGridViewUserById(teacherId);
            MessageBox.Show("Class deleted successfully.");
        }

        //==========================================================================
        //Additional Methods
        //==========================================================================

        private void clearInput()
        {
            classStdID.SelectedIndex = -1;
            classTeacherID.SelectedIndex = -1;
            teacherClassID.SelectedIndex = -1;
            stdClassID.SelectedIndex = -1;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
