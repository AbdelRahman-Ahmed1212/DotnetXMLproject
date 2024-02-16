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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            var reader = XmlReader.Create("..\\..\\..\\Data\\users.xml");
            var Users = XElement.Load(reader);
            var source = Users.Elements().Select(
                x => new User
                {
                    id = x.Element("id").Value,
                    UserName = x.Element("username").Value,
                    password = x.Element("password").Value,
                }
                ).ToList();
            dataGridView1.DataSource = source;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
