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

namespace DotnetXmlProject.adminUserControl
{
    public partial class ClassManagement : UserControl
    {
        public ClassManagement()
        {
            InitializeComponent();
            PopulateDataGridViewClass();
            comboxTeacherData(teachercombox);
            comboxTeacherData(techercb);

        }

        public void PopulateDataGridViewClass()
        {
            using (var readerClass = XmlReader.Create("..\\..\\..\\Data\\users.xml"))
            {
                var classes = XElement.Load(readerClass);
                var sourceClass = classes.Elements("user")
                                        .Select(u => new User
                                        {
                                            id = (int)u.Element("id"),
                                            UserName = (string)u.Element("userName"),
                                            password = (string)u.Element("password"),
                                            role = (Role)Enum.Parse(typeof(Role), (string)u.Element("role"))
                                        }).ToList();

                classData.DataSource = sourceClass;
            }
        }

        public void comboxTeacherData(ComboBox cb)
        {
            using (var reader = XmlReader.Create("..\\..\\..\\Data\\users.xml"))
            {
                var Users = XElement.Load(reader);
                var teacherIds = Users.Elements("user")
                                      .Where(u => string.Equals(u.Element("role")?.Value, "Teacher", StringComparison.OrdinalIgnoreCase))
                                      .Select(u => (int)u.Element("id"))
                                      .ToList();

                cb.Items.AddRange(teacherIds.Select(id => id.ToString()).ToArray());
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void teacherData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
