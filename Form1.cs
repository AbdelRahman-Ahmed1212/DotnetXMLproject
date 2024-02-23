using DotnetXmlProject.Classes;
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
            
            Admin.username = username;

            using (var reader = XmlReader.Create("..\\..\\..\\Data\\users.xml"))
            {
                var Doc = XElement.Load(reader);

                var user = Doc.Elements()
                              .Where(item => (string)item.Element("username") == username)

                              .FirstOrDefault();

                if (user != null)
                {
                    // User found, check the password
                    string storedPassword = (string)user.Element("password");

                    if (storedPassword == password)
                    {
                        MessageBox.Show("Login successful");
                        switch (user.Element("role")?.Value)
                        {
                            case "Admin":
                                Admin admin = new Admin();
                                admin.Show();
                                break;
                            case "Student":
                                Student student = new Student();
                                student.Show();
                                //amr edited here
                                student.userName = textBox1.Text;
                                student.role = "Student";
                                break;
                            case "Teacher":
                                Teacher teacher = new Teacher();
                                teacher.Show();
                                //amr edited here
                                teacher.userName = textBox1.Text;
                                teacher.role = "Teacher";
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
            /*
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("Ar-eg");

            this.Controls.Clear();
            this.InitializeComponent();
            */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
