using DotnetXmlProject.Classes;
using DotnetXmlProject.UtilClasses;
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
            var Attendence = XmlReader.Create("..\\..\\..\\Data\\attendence.xml");
            var UsersDoc = XElement.Load(usersReader);
            var classesDoc = XElement.Load(classesReader);
            var AttendenceDoc = XElement.Load(Attendence);
            classList.DataSource = classesDoc.Elements().Select(
             x => x.Element("name").Value
                ).ToList();
            attendeceGrid.DataSource = AttendenceDoc.Elements().Select(
                x => new
                {
                    id = x.Element("id").Value,
                    status = x.Element("status").Value,
                    classId = x.Element("classId").Value
                }
                );
        }

        private void Export_Click(object sender, EventArgs e)
        {
            GenerateReport gr1 = new GenerateReport();
            gr1.Show();

        }

        private void datePickerChanged(object sender, EventArgs e)
        {
            var Date1 = dateTimePicker1.Value;
            var Date2 = dateTimePicker2.Value;
            
        }
    }
}
