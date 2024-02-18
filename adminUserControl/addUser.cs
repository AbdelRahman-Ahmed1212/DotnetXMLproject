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
        string pathUser = "..\\..\\..\\Data\\users.xml";

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
        private void PopulateDataGridViewStudent()
        {
            try
            {
                using (var stream = new FileStream(pathUser, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    var stds = XElement.Load(stream);
                    var sourceStd = stds.Elements("user")
                                        .Where(u => string.Equals(u.Element("role")?.Value, "Student", StringComparison.OrdinalIgnoreCase))
                                        .Select(u => new User
                                        {
                                            id = (int)u.Element("id"),
                                            UserName = (string)u.Element("userName"),
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

        private void PopulateDataGridViewTeacher()
        {
            try
            {
                using (var stream = new FileStream(pathUser, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    var teacher = XElement.Load(stream);
                    var sourceTeacher = teacher.Elements("user")
                                              .Where(u => string.Equals(u.Element("role")?.Value, "Teacher", StringComparison.OrdinalIgnoreCase))
                                              .Select(u => new User
                                              {
                                                  id = (int)u.Element("id"),
                                                  UserName = (string)u.Element("userName"),
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
            comboBox.Items.AddRange(new string[] { "teacher", "student", "admin" });
        }

        //==========================================================================
        //Add
        //==========================================================================

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string name = NameText.Text;
                string userName = usernameText.Text;
                string passwordd = passwordText.Text;
                Role rolee = (Role)Enum.Parse(typeof(Role), RoleCombobox.Text, true); // Convert string to enum

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passwordd) || rolee == null)
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                AddUserToXml(name, userName, passwordd, rolee);

                NameText.Text = "";
                usernameText.Text = "";
                passwordText.Text = "";
                RoleCombobox.SelectedIndex = -1;

                PopulateDataGridViewStudent();
                PopulateDataGridViewTeacher();

                attendanceMangement attendance = new attendanceMangement();
                attendance.comboxStdData();

                MessageBox.Show("User added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}");
            }
        }

        private void AddUserToXml(string name, string userName, string password, Role role)
        {
            try
            {
                using (var stream = new FileStream(pathUser, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    var xmlDoc = XDocument.Load(stream);
                    int lastId = xmlDoc.Descendants("user").Select(u => (int)u.Element("id")).DefaultIfEmpty(0).Max();

                    XElement newUserElement = new XElement("user",
                                            new XElement("id", lastId + 1),
                                            new XElement("name", name),
                                            new XElement("userName", userName),
                                            new XElement("password", password),
                                            new XElement("role", role.ToString()));
                   // newUserElement.Validate()

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
            string userName = teacherData.SelectedRows[0].Cells["UserName"].Value.ToString();
            string password = teacherData.SelectedRows[0].Cells["password"].Value.ToString();

            UpdateUserInXml(userId, userName, password);

            PopulateDataGridViewTeacher();
            ClearTextBoxes();

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
            string userName = studentData.SelectedRows[0].Cells["UserName"].Value.ToString();
            string password = studentData.SelectedRows[0].Cells["password"].Value.ToString();

            UpdateUserInXml(userId, userName, password);

            PopulateDataGridViewStudent();
            ClearTextBoxes();

            MessageBox.Show("User updated successfully.");
        }

        private void UpdateUserInXml(int userId, string userName, string password)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(pathUser);
                XElement userToUpdate = xmlDoc.Descendants("user").FirstOrDefault(u => (int)u.Element("id") == userId);

                if (userToUpdate != null)
                {
                    userToUpdate.Element("userName").Value = userName;
                    userToUpdate.Element("password").Value = password;

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

            PopulateDataGridViewTeacher();
            MessageBox.Show("User deleted successfully.");
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
        }

        private void DeleteUserFromXml(int userId)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(pathUser);
                XElement userToDelete = xmlDoc.Descendants("user").FirstOrDefault(u => (int)u.Element("id") == userId);

                if (userToDelete != null)
                {
                    userToDelete.Remove();
                    xmlDoc.Save(pathUser);
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

        //==========================================================================
        //Search
        //==========================================================================
        private void SearchAndPopulateGridView(string searchText, string role)
        {
            using (var stream = new FileStream(pathUser, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                XDocument xmlDoc = XDocument.Load(stream);
                var searchResults = xmlDoc.Root.Elements("user")
                    .Where(u => string.Equals(u.Element("role")?.Value, role, StringComparison.OrdinalIgnoreCase) &&
                                u.Element("name")?.Value.Contains(searchText, StringComparison.OrdinalIgnoreCase) == true)
                    .Select(u => new User
                    {
                        id = (int)u.Element("id"),
                        UserName = (string)u.Element("userName"),
                        password = (string)u.Element("password"),
                        role = (Role)Enum.Parse(typeof(Role), (string)u.Element("role"))
                    }).ToList();
                if (role == "Teacher")
                {
                    teacherData.DataSource = searchResults;
                }
                else if (role == "Student")
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
                SearchAndPopulateGridView(searchText, "Teacher");
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
                SearchAndPopulateGridView(searchText, "Student");
            }
            else
            {
                PopulateDataGridViewStudent();
            }
        }

        //==========================================================================
        //Additional Methods
        //==========================================================================
        private void ClearTextBoxes()
        {
            nameTecherText.Text = "";
            usernameTeacherText.Text = "";
            PassTeacherText.Text = "";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
