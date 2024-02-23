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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DotnetXmlProject.adminUserControl
{
    public partial class ClassManagement : UserControl
    {
        public string classPath = "D:\\c#xmlv2\\Data\\classes.xml";
        public string userPath = "D:\\c#xmlv2\\Data\\users.xml";
        public string sessionPath = "D:\\c#xmlv2\\Data\\session.xml";
        public ClassManagement()
        {
            InitializeComponent();
            PopulateDataGridViewClass();
            //comboxTeacherData(teachercombox);
            comboxTeacherData();

        }

        //==========================================================================
        //Display
        //==========================================================================

        public void PopulateDataGridViewClass()
        {
            using (var readerClass = XmlReader.Create(classPath))
            {
                var classes = XElement.Load(readerClass);
                var sourceClass = classes.Elements("stdClass")
                                        .Select(u => new classData
                                        {
                                            id = (int)u.Element("id"),
                                            name = (string)u.Element("name"),
                                            TeacherId = (int)u.Element("teacherId"),
                                        }).ToList();

                classData.DataSource = sourceClass;
            }
        }

        public void comboxTeacherData()
        {
            using (var reader = XmlReader.Create(userPath))
            {
                techercb.Items.Clear();
                var Users = XElement.Load(reader);
                var teacherIds = Users.Elements("teacher")
                                      .Select(u => (int)u.Element("id"))
                                      .ToList();

                techercb.Items.AddRange(teacherIds.Select(id => id.ToString()).ToArray());
            }
        }

        //==========================================================================
        //Add
        //==========================================================================

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string name = NameText.Text;
                int teacherID = Convert.ToInt32(techercb.Text);

                if (string.IsNullOrEmpty(name) || teacherID == 0)
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                AddClassToXml(name, teacherID);

                NameText.Text = "";
                techercb.SelectedIndex = -1;

                PopulateDataGridViewClass();

                comboxTeacherData();


                MessageBox.Show("Class added successfully.");

                attendanceMangement am = new attendanceMangement();
                am.comboxSubjectData();

                ManageClasses mc = new ManageClasses();
                mc.comboxClassData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding class: {ex.Message}");
            }
        }


        private void AddClassToXml(string name, int teacherID)
        {
            try
            {
                if (!Validation.CheckIfIdExists(userPath, "teacher","id", teacherID))
                {
                    MessageBox.Show("Teacher with the specified ID not found.");
                    return;
                }
                else
                {
                    using (var stream = new FileStream(classPath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    {
                        var xmlDoc = XDocument.Load(stream);
                        int lastId = xmlDoc.Descendants("stdClass").Select(u => (int)u.Element("id")).DefaultIfEmpty(0).Max();

                        XElement newClassElement = new XElement("stdClass",
                                                new XElement("id", lastId + 1),
                                                new XElement("name", name),
                                                new XElement("teacherId", teacherID));

                        if (xmlDoc.Root == null)
                        {
                            xmlDoc.Add(new XElement("stdClass", newClassElement));
                        }
                        else
                        {
                            xmlDoc.Root.Add(newClassElement);
                        }
                        AddClassNameToTeacher(teacherID, name, lastId + 1);

                        stream.Position = 0;
                        xmlDoc.Save(stream);
                    }
                }
            }

               
            catch (IOException ex)
            {
                MessageBox.Show($"Error adding class: {ex.Message}. Please make sure the XML file is not open in another program.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding class: {ex.Message}");
            }
        }

        private void AddClassNameToTeacher(int teacherId, string className, int classID)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(userPath);


                var teacherElement = xmlDoc.Descendants()
                    .Where(e => e.Name.LocalName == "teacher")
                    .FirstOrDefault(u => (int)u.Element("id") == teacherId);

                if (teacherElement != null)
                {
                    var classNameElement = teacherElement.Element("classes");
                    if (classNameElement == null)
                    {
                        classNameElement = new XElement("classes");
                        teacherElement.Add(classNameElement);
                    }

                    classNameElement.Add(new XElement("class",
                                    new XElement("classID", classID),
                                    new XElement("className", className)));

                    xmlDoc.Save(userPath);
                }
                else
                {
                    MessageBox.Show("User with the specified ID not found.");
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


        //==========================================================================
        //Edit
        //==========================================================================

        private void classEditBtn_Click_1(object sender, EventArgs e)
        {
            if (classData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a class to edit.");
                return;
            }

            int id = Convert.ToInt32(classData.SelectedRows[0].Cells["id"].Value);
            string name = classData.SelectedRows[0].Cells["name"].Value.ToString();
            int teacherId = Convert.ToInt32(classData.SelectedRows[0].Cells["TeacherId"].Value);

            UpdateClassInXml(id, name, teacherId);
            UpdateSessionRecordsForClass(id, name);

            PopulateDataGridViewClass();


            MessageBox.Show("Class updated successfully.");
        }



        private void UpdateClassInXml(int id, string name, int teacherId)
        {
            try
            {
                XDocument classXmlDoc = XDocument.Load(classPath);
                XElement classToUpdate = classXmlDoc.Descendants("stdClass").FirstOrDefault(u => (int)u.Element("id") == id);

                if (classToUpdate != null)
                {
                    classToUpdate.Element("name").Value = name;
                    classXmlDoc.Save(classPath);
                }
                else
                {
                    MessageBox.Show("Class with the specified ID not found.");
                    return;
                }

                XDocument userXmlDoc = XDocument.Load(userPath);

                // Update class name in teacher's classes
                XElement teacherElement = userXmlDoc.Descendants("teacher").FirstOrDefault(t => (int)t.Element("id") == teacherId);
                if (teacherElement != null)
                {
                    XElement classesElement = teacherElement.Element("classes");
                    if (classesElement != null)
                    {
                        XElement classElement = classesElement.Elements("class").FirstOrDefault(c => (int)c.Element("classID") == id);
                        if (classElement != null)
                        {
                            classElement.Element("className").Value = name;
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

                // Update class name in student's classes
                var studentElements = userXmlDoc.Descendants("student");
                foreach (var studentElement in studentElements)
                {
                    var classesElement = studentElement.Element("classes");
                    if (classesElement != null)
                    {
                        var classElement = classesElement.Elements("class").FirstOrDefault(c => (int)c.Element("classID") == id);
                        if (classElement != null)
                        {
                            classElement.Element("className").Value = name;
                        }
                    }
                }

                userXmlDoc.Save(userPath);
               

            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error updating class: {ex.Message}. Please make sure the XML file is not open in another program.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating class: {ex.Message}");
            }
        }

        private void UpdateSessionRecordsForClass(int classId, string newName)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(sessionPath);

                var sessionsToUpdate = xmlDoc.Descendants("Session")
                              .Where(s => (int?)s.Attribute("subjectId") == classId).ToList();

                foreach (var session in sessionsToUpdate)
                {
                    session.Attribute("class").Value = newName;
                }

                xmlDoc.Save(sessionPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating session records for class: {ex.Message}");
            }
        }
        //==========================================================================
        //Delete
        //==========================================================================

        private void classDeleteBtn_Click_1(object sender, EventArgs e)
        {
            if (classData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a class to delete.");
                return;
            }
            int classId = Convert.ToInt32(classData.SelectedRows[0].Cells["id"].Value);
            int teacherId = Convert.ToInt32(classData.SelectedRows[0].Cells["TeacherId"].Value);
            string classname = classData.SelectedRows[0].Cells["name"].Value.ToString();

            DeleteClassFromXml(classId, teacherId);
            DeleteSessionsForClass(classId);

            PopulateDataGridViewClass();
            MessageBox.Show("Class deleted successfully.");
        }



        private void DeleteClassFromXml(int classId, int teacherId)
        {
            try
            {
                XDocument classXmlDoc = XDocument.Load(classPath);
                XElement classToDelete = classXmlDoc.Descendants("stdClass").FirstOrDefault(u => (int)u.Element("id") == classId);

                if (classToDelete != null)
                {
                    classToDelete.Remove();
                    classXmlDoc.Save(classPath);
                }
                else
                {
                    MessageBox.Show("Class with the specified ID not found.");
                    return;
                }

                XDocument usersXmlDoc = XDocument.Load(userPath);

                // delete class  from teacher
                XElement teacherElement = usersXmlDoc.Descendants("teacher").FirstOrDefault(t => (int)t.Element("id") == teacherId);
                if (teacherElement != null)
                {
                    XElement classesElement = teacherElement.Element("classes");
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

                // delete class  from student
                var studentElements = usersXmlDoc.Descendants("student");
                foreach (var studentElement in studentElements)
                {
                    var classesElement = studentElement.Element("classes");
                    if (classesElement != null)
                    {
                        var classElementToRemove = classesElement.Elements("class").FirstOrDefault(c => (int)c.Element("classID") == classId);
                        if (classElementToRemove != null)
                        {
                            classElementToRemove.Remove();
                        }
                    }
                }

                usersXmlDoc.Save(userPath);
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

        private void DeleteSessionsForClass(int classId)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(sessionPath);

                // Delete sessions associated with the class
                var sessionsToDelete = xmlDoc.Descendants("Session")
                              .Where(s => (int?)s.Attribute("subjectId") == classId).ToList();


                foreach (var session in sessionsToDelete)
                {
                    session.Remove();
                }

                xmlDoc.Save(sessionPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting sessions for class: {ex.Message}");
            }
        }
        //==========================================================================
        //Search
        //==========================================================================
        private void SearchAndPopulateGridView(string searchText)
        {
            using (var stream = new FileStream(classPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                XDocument xmlDoc = XDocument.Load(stream);
                var searchResults = xmlDoc.Root.Elements("stdClass")
                    .Where(u => u.Element("name")?.Value.Contains(searchText, StringComparison.OrdinalIgnoreCase) == true)
                    .Select(u => new stdClass
                    {
                        id = (int)u.Element("id"),
                        TeacherId = (int)u.Element("teacherId"),
                        name = (string)u.Element("name"),
                    }).ToList();

                classData.DataSource = searchResults;


            }
        }
        private void classSearchText_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = classSearchText.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                SearchAndPopulateGridView(searchText);
            }
            else
            {
                PopulateDataGridViewClass();
            }
        }


        //==========================================================================
        //Additional Methods
        //==========================================================================


        private void classData_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            List<string> columnsToPreventEditing = new List<string> { "id", "TeacherId" };
            if (columnsToPreventEditing.Contains(classData.Columns[e.ColumnIndex].Name))
            {
                e.Cancel = true;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
