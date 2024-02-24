using DotnetXmlProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Schema;

namespace DotnetXmlProject.adminUserControl
{
    public partial class addUser : UserControl
    {
        public string pathUser = "..\\..\\..\\Data\\users.xml";
        public string classPath = "..\\..\\..\\Data\\classes.xml";
        public string sessionPath = "..\\..\\..\\Data\\session.xml";

        public addUser()
        {
            InitializeComponent();
            PopulateDataGridViewStudent();
            PopulateDataGridViewTeacher();
            PopulateComboBoxWithRoles(RoleCombobox);
        }

        //==========================================================================
        //Display
        //==========================================================================
        public void PopulateDataGridViewStudent()
        {
            try
            {
                using (var stream = new FileStream(pathUser, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    var stds = XElement.Load(stream);
                    var sourceStd = stds.Elements("student")
                                        .Where(u => string.Equals(u.Element("role")?.Value, "Student", StringComparison.OrdinalIgnoreCase))
                                        .Select(u => new User
                                        {
                                            id = (int)u.Element("id"),
                                            Email = (string)u.Element("email"),
                                            UserName = (string)u.Element("username"),
                                            password = (string)u.Element("password"),
                                            role = (Role)Enum.Parse(typeof(Role), (string)u.Element("role"))
                                        }).ToList();

                    studentData.DataSource = sourceStd;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student data: {ex.Message}");
            }
        }

        public void PopulateDataGridViewTeacher()
        {
            try
            {
                using (var stream = new FileStream(pathUser, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    var teacher = XElement.Load(stream);
                    var sourceTeacher = teacher.Elements("teacher")
                                              .Select(u => new User
                                              {
                                                  id = (int)u.Element("id"),
                                                  Email = (string)u.Element("email"),
                                                  UserName = (string)u.Element("username"),
                                                  password = (string)u.Element("password"),
                                                  role = (Role)Enum.Parse(typeof(Role), (string)u.Element("role"))

                                              }).ToList();

                    teacherData.DataSource = sourceTeacher;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading teacher data: {ex.Message}");
            }
        }

        private void PopulateComboBoxWithRoles(ComboBox comboBox)
        {
            comboBox.Items.AddRange(new string[] { "teacher", "student" });
        }

        //==========================================================================
        //Add
        //==========================================================================
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string email = EmailText.Text;
                string userName = usernameText.Text;
                string password = passwordText.Text;
                Role role = (Role)Enum.Parse(typeof(Role), RoleCombobox.Text, true); // Convert string to enum

                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password) || role == null)
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                if (!Validation.ValidateUserData(userName, password, email))
                {
                    return;
                }

                AddUserToXml(email, userName, password, role);
                PopulateData.refreshAllData();

                ManageClasses mc = new ManageClasses();
                mc.RefrchData();

                ClassManagement cm = new ClassManagement();
                cm.comboxTeacherData();
                clearInput();

                PopulateDataGridViewStudent();
                PopulateDataGridViewTeacher();

                MessageBox.Show("User added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}");
            }

        }
        private void AddUserToXml(string email, string userName, string password, Role role)
        {
            try
            {
                using (var stream = new FileStream(pathUser, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    var xmlDoc = XDocument.Load(stream);

                    bool emailExists = xmlDoc.Descendants()
                                .Any(u => (string)u.Element("email") == email);

                    if (emailExists)
                    {
                        MessageBox.Show("Email already exists. Please use a different email address.");
                        return;
                    }


                    int lastId = xmlDoc.Descendants()
                                        .Where(e => e.Name == "user" || e.Name == "student" || e.Name == "teacher")
                                        .Select(u => (int)u.Element("id"))
                                        .DefaultIfEmpty(0)
                                        .Max();

                    XElement newUserElement;

                    if (role == Role.Admin)
                    {
                        newUserElement = new XElement("user",
                            new XElement("id", lastId + 1),
                            new XElement("email", email),
                            new XElement("username", userName),
                            new XElement("password", password),
                            new XElement("role", role.ToString()));
                    }
                    else if (role == Role.Student)
                    {
                        newUserElement = new XElement("student",
                            new XElement("id", lastId + 1),
                            new XElement("email", email),
                            new XElement("username", userName),
                            new XElement("password", password),
                            new XElement("role", role.ToString()),
                           new XElement("classes"),
                        new XElement("attendanceIds"));
                    }
                    else if (role == Role.Teacher)
                    {
                        newUserElement = new XElement("teacher",
                            new XElement("id", lastId + 1),
                            new XElement("email", email),
                            new XElement("username", userName),
                            new XElement("password", password),
                            new XElement("role", role.ToString()),
                            new XElement("classes"));
                    }
                    else
                    {
                        MessageBox.Show("Invalid user role.");
                        return;
                    }

                    if (xmlDoc.Root == null)
                    {
                        xmlDoc.Add(new XElement("Users", newUserElement));

                    }
                    else
                    {
                        xmlDoc.Root.Add(newUserElement);


                    }

                    stream.Position = 0;
                    xmlDoc.Save(stream);


                }


            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}. Please make sure the XML file is not open in another program.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}");
            }


            RefrchAllData();


        }

        //==========================================================================
        //Edit
        //==========================================================================
        private void teacherEditBtn_Click(object sender, EventArgs e)
        {
            if (teacherData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to edit.");
                return;
            }

            int userId = Convert.ToInt32(teacherData.SelectedRows[0].Cells["id"].Value);
            string userName = teacherData.SelectedRows[0].Cells["username"].Value.ToString();
            string password = teacherData.SelectedRows[0].Cells["password"].Value.ToString();
            string email = teacherData.SelectedRows[0].Cells["email"].Value.ToString();

            if (!Validation.ValidateUserData(userName, password, email))
            {
                return;
            }

            UpdateUserInXml(userId, userName, password, email);

            PopulateDataGridViewTeacher();

            MessageBox.Show("User updated successfully.");
        }

        private void stdEditBtn_Click(object sender, EventArgs e)
        {
            if (studentData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to edit.");
                return;
            }

            int userId = Convert.ToInt32(studentData.SelectedRows[0].Cells["id"].Value);
            string userName = studentData.SelectedRows[0].Cells["username"].Value.ToString();
            string password = studentData.SelectedRows[0].Cells["password"].Value.ToString();
            string email = studentData.SelectedRows[0].Cells["email"].Value.ToString();

            if (!Validation.ValidateUserData(userName, password, email))
            {
                return;
            }

            UpdateUserInXml(userId, userName, password, email);

            PopulateDataGridViewStudent();

            MessageBox.Show("User updated successfully.");
        }

        private void UpdateUserInXml(int userId, string userName, string password, string email)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(pathUser);
                XElement userToUpdate = xmlDoc.Descendants()
                                              .Where(e => e.Name == "user" || e.Name == "student" || e.Name == "teacher")
                                              .FirstOrDefault(u => (int)u.Element("id") == userId);


                if (userToUpdate != null)
                {
                    userToUpdate.Element("username").Value = userName;
                    userToUpdate.Element("password").Value = password;
                    userToUpdate.Element("email").Value = email;

                    xmlDoc.Save(pathUser);
                }
                else
                {
                    MessageBox.Show("User with the specified ID not found.");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error updating user: {ex.Message}. Please make sure the XML file is not open in another program.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user: {ex.Message}");
            }
        }

        //==========================================================================
        //Delete
        //==========================================================================
        private void teacherDeleteBtn_Click(object sender, EventArgs e)
        {
            if (teacherData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            int userId = Convert.ToInt32(teacherData.SelectedRows[0].Cells["id"].Value);
            DeleteUserFromXml(userId);

            ManageClasses mc = new ManageClasses();
            mc.RefrchData();

            ClassManagement cm = new ClassManagement();
            cm.comboxTeacherData();

            PopulateDataGridViewTeacher();

        }

        private void deleteStdBtn_Click(object sender, EventArgs e)
        {
            if (studentData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            int userId = Convert.ToInt32(studentData.SelectedRows[0].Cells["id"].Value);
            DeleteUserFromXml(userId);

            PopulateDataGridViewStudent();
            MessageBox.Show("User deleted successfully.");

            RefrchAllData();
        }

        private void DeleteUserFromXml(int userId)
        {
            try
            {
                XDocument userXmlDoc = XDocument.Load(pathUser);
                XDocument classesXmlDoc = XDocument.Load(classPath);
                XDocument sessionsXmlDoc = XDocument.Load(sessionPath);

                XElement userToDelete = GetUserById(userXmlDoc, userId);

                if (userToDelete != null)
                {
                    string role = userToDelete.Element("role").Value;

                    if (role == "Teacher")
                    {
                        int teacherId = (int)userToDelete.Element("id");

                        GetTeacherClasses(classesXmlDoc, userXmlDoc, teacherId);
                        RemoveTeacherFromClasses(classesXmlDoc, teacherId);
                        RemoveSessionsByTeacherId(sessionsXmlDoc, teacherId);
                        
                    }
                    else if (role == "Student")
                    {
                        int studentId = (int)userToDelete.Element("id");

                        // Remove student attendance from sessions
                        RemoveStudentAttendanceFromSessions(sessionsXmlDoc, studentId);
                    }

                    // Remove the user from the user XML
                    userToDelete.Remove();
                    userXmlDoc.Save(pathUser);

                    MessageBox.Show("User deleted successfully.");
                }
                else
                {
                    MessageBox.Show("User with the specified ID not found.");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error deleting user: {ex.Message}. Please make sure the XML file is not open in another program.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting user: {ex.Message}");
            }
        }
        private XElement GetUserById(XDocument userXmlDoc, int userId)
        {
            return userXmlDoc.Descendants()
                             .Where(e => e.Name == "user" || e.Name == "student" || e.Name == "teacher")
                             .FirstOrDefault(u => (int)u.Element("id") == userId);
        }

       

        private void RemoveTeacherFromClasses(XDocument classesXmlDoc, int teacherId)
        {
            
                classesXmlDoc.Root.Elements("stdClass")
                                                  .Where(c => (int)c.Element("teacherId") == teacherId)
                                                  .ToList()
                                                   .ForEach(a => a.Remove());

            classesXmlDoc.Save(classPath);


           
        }

        private void RemoveSessionsByTeacherId(XDocument sessionsXmlDoc, int teacherId)
        {
           
            sessionsXmlDoc.Root.Elements("Session")
                                                .Where(s => (int)s.Attribute("teacherId") == teacherId).ToList()
                                               .ForEach(a => a.Remove());

            sessionsXmlDoc.Save(sessionPath);

        }

        private void RemoveClassFromStudents(XDocument userXmlDoc, int classID)
        {
            foreach (var student in userXmlDoc.Root.Elements("student"))
            {
                var studentClasses = student.Element("classes").Elements("class").ToList();

                foreach (var classElement in studentClasses)
                {
                    int currentClassID = (int)classElement.Element("classID");
                    if (currentClassID == classID)
                    {
                        classElement.Remove();
                    }
                }
            }
            userXmlDoc.Save(pathUser);
        }

        private void GetTeacherClasses(XDocument classesXmlDoc,XDocument userXmlDoc, int teacherId)
        {
            List<int> classIDs = classesXmlDoc.Root.Elements("stdClass")
                           .Where(c => (int)c.Element("teacherId") == teacherId)
                           .Select(c => (int)c.Element("id"))
                           .ToList();

            foreach (int classID in classIDs)
            {
                
                RemoveClassFromStudents(userXmlDoc, classID);
            }
        }





        private void RemoveStudentAttendanceFromSessions(XDocument sessionsXmlDoc, int studentId)
        {

            sessionsXmlDoc.Root.Elements("Session")
                              .Elements("AttendenceRecord")
                              .Where(a => (int)a.Element("stdid") == studentId)
                              .ToList() 
                              .ForEach(a => a.Remove()); 

            sessionsXmlDoc.Save(sessionPath); 


        }


        //==========================================================================
        //Search
        //==========================================================================
        private void SearchAndPopulateGridView(string searchText, string role)
        {
            using (var stream = new FileStream(pathUser, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                XDocument xmlDoc = XDocument.Load(stream);
                var searchResults = xmlDoc.Root.Elements(role)
                    .Where(u => string.Equals(u.Element("role")?.Value, role, StringComparison.OrdinalIgnoreCase) &&
                                u.Element("username")?.Value.Contains(searchText, StringComparison.OrdinalIgnoreCase) == true)
                    .Select(u => new User
                    {
                        id = (int)u.Element("id"),
                        UserName = (string)u.Element("username"),
                        password = (string)u.Element("password"),
                        Email = (string)u.Element("email"),
                        role = (Role)Enum.Parse(typeof(Role), (string)u.Element("role"))
                    }).ToList();
                if (role == "teacher")
                {
                    teacherData.DataSource = searchResults;
                }
                else if (role == "student")
                {
                    studentData.DataSource = searchResults;
                }

            }
        }

        private void teacherSearchText_TextChanged(object sender, EventArgs e)
        {
            string searchText = teacherSearchText.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                SearchAndPopulateGridView(searchText, "teacher");
            }
            else
            {
                PopulateDataGridViewTeacher();
            }
        }

        private void stdSearchText_TextChanged(object sender, EventArgs e)
        {
            string searchText = stdSearchText.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                SearchAndPopulateGridView(searchText, "student");
            }
            else
            {
                PopulateDataGridViewStudent();
            }
        }

        //==========================================================================
        //Additional Methods
        //==========================================================================

        public void clearInput()
        {
            EmailText.Text = "";
            usernameText.Text = "";
            passwordText.Text = "";
            RoleCombobox.SelectedIndex = -1;
        }


        private void teacherData_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            List<string> columnsToPreventEditing = new List<string> { "id", "role" };
            if (columnsToPreventEditing.Contains(teacherData.Columns[e.ColumnIndex].Name))
            {
                e.Cancel = true;
            }
        }

        private void studentData_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            List<string> columnsToPreventEditing = new List<string> { "id", "role","email" };

            if (columnsToPreventEditing.Contains(studentData.Columns[e.ColumnIndex].Name))
            {
                e.Cancel = true;
            }
        }
        public void RefrchAllData()
        {
            ManageClasses mc = new ManageClasses();
            mc.RefrchData();

            ClassManagement cm = new ClassManagement();
            cm.comboxTeacherData();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}





