using DotnetXmlProject.Classes;
using DotnetXmlProject.studentTeacherUserControl;
using System.Globalization;
using System.Xml;
using System.Xml.Linq;
using static DotnetXmlProject.Teacher;
namespace DotnetXmlProject
{
    public partial class Form1 : Form
    {


        public Form1()
        {

            InitializeComponent();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var username = textBox1.Text;
            var password = textBox2.Text;
            var currentLanguage = "";
            Admin.username = username;

            using (var reader = XmlReader.Create("..\\..\\..\\Data\\users.xml"))
            {
                var Doc = XElement.Load(reader);

                var user = Doc.Elements()
                              .Where(item => (string)item.Element("email") == username)

                              .FirstOrDefault();

                if (user != null)
                {
                    // User found, check the password
                    string storedPassword = (string)user.Element("password");

                    if (storedPassword == password)
                    {
                        MessageBox.Show("Login successful");
                        if (radioButton1.Checked)
                        {
                            currentLanguage = "ar";
                        }
                        if(radioButton2.Checked)
                        {
                            currentLanguage = "en";
                        }
                        switch (user.Element("role")?.Value)
                        {
                            case "Admin":
                                Admin admin = new Admin(currentLanguage);
                                admin.Show();
                                break;
                            case "Student":
                                Student student = new Student(textBox1.Text, "Student");
                                student.Show();
                                //amr edited here
                                student.userName = textBox1.Text;
                                student.role = "Student";
                                break;
                            case "Teacher":
                                Teacher teacher = new Teacher(textBox1.Text, "Teacher",currentLanguage);
                                teacher.Show();
                                teacher.userName = textBox1.Text; // Assign username to Teacher instance
                                teacher.role = "Teacher";
                                editAttendence editAttendence = new editAttendence(textBox1.Text); // Create instance of editAttendence
                                editAttendence.userName = textBox1.Text; // Assign username to editAttendence instance
                                break;

                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password");
                    }
                }
                else
                {
                    MessageBox.Show("User does not exist");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
