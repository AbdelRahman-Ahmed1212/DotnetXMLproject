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
using System.Xml;
using System.Xml.Linq;

namespace DotnetXmlProject
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            var usersReader = XmlReader.Create("..\\..\\..\\Data\\users.xml");
            var classesReader = XmlReader.Create("..\\..\\..\\Data\\classes.xml");
            var UsersDoc = XElement.Load(usersReader);
            var classesDoc = XElement.Load(classesReader);
            classes.DataSource = classesDoc.Elements().Select(
             x => x.Element("name").Value
                ).ToList(); ;
        }

        private void Export_Click(object sender, EventArgs e)
        {
            GenerateReport gr1 = new GenerateReport();
            gr1.Show();

        }
    }
}
