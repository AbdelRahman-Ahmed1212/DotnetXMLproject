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

namespace DotnetXmlProject.adminUserControl
{
    public partial class test : UserControl
    {
        public string userPath = "D:\\c#xmlv4\\Data\\users.xml";
        public string classPath = "D:\\c#xmlv4\\Data\\classes.xml";
        public string sessionPath = "D:\\c#xmlv4\\Data\\session.xml";

        public test()
        {
            InitializeComponent();
            getCount();
        }

        public void getCount()
        {
            sessionNum.Text = CountNum(sessionPath, "Session").ToString();
            stdNum.Text = CountNum(userPath, "student").ToString();
            classesNum.Text = CountNum(classPath, "stdClass").ToString();
            techerNum.Text = CountNum(userPath, "teacher").ToString();
        }

        public static int CountNum(string xmlFilePath, string type)
        {
            try
            {
                XDocument doc = XDocument.Load(xmlFilePath);
                int userCount = doc.Descendants(type).Count();

                return userCount;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return 0;
            }
        }

        private void stdNumLabel_Click(object sender, EventArgs e)
        {

        }

        private void classesNumLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
