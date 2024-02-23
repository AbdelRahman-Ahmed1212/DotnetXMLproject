using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetXmlProject.Classes
{
    internal class Session
    {
        int id { set; get; }
        public string classID { set; get; }
        public DateTime date { set; get; }
        public List<attendanceRecord> Records { set; get;}
    }
}
