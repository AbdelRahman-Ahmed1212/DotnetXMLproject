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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
            var reader = XmlReader.Create("..\\..\\..\\Data\\users.xml");
            var XE = XElement.Load(reader);

        }
    }
}
