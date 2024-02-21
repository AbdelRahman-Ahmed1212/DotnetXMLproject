using DotnetXmlProject.Classes;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DotnetXmlProject.studentTeacherUserControl
{
    public partial class teacher_classesv : UserControl
    {
        public string classesPath = "C:\\Users\\20115\\OneDrive\\Desktop\\x\\DotnetXMLproject\\Data\\classes.xml";
        public string usersPath = "C:\\Users\\20115\\OneDrive\\Desktop\\x\\DotnetXMLproject\\Data\\users.xml";

        public teacher_classesv()
        {
            InitializeComponent();
        }

        private void populateClassGridView()
        {
            using (var classreader = new FileStream(classesPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                XDocument xmlDoc = XDocument.Load(classreader);
                var classSource = xmlDoc.Root.Elements("stdClass").Select(u => new classData
                {
                    id = (int)u.Element("id"),
                    TeacherId = (int)u.Element("teacherId"),
                    name = (string)u.Element("name")
                }).ToList();

                dataGridView1.DataSource = classSource;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle label click event if needed
        }

        private void displayClassbtn_Click(object sender, EventArgs e)
        {
            populateClassGridView();
        }

        private void SearchAndPopulateGridView(string searchText)
        {
            using (var stream = new FileStream(classesPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                XDocument xmlDoc = XDocument.Load(stream);
                var searchResults = xmlDoc.Root.Elements("stdClass")
                    .Where(u => u.Element("name")?.Value.Contains(searchText, StringComparison.OrdinalIgnoreCase) == true)
                    .Select(u => new classData
                    {
                        id = (int)u.Element("id"),
                        TeacherId = (int)u.Element("teacherId"),
                        name = (string)u.Element("name"),
                    }).ToList();

                dataGridView1.DataSource = searchResults;
            }
        }

        private void tabcontroleaddstd_Click(object sender, EventArgs e)
        {

        }
    }
}
