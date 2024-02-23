using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetXmlProject.Classes
{
    internal class AttendceReportRecord
    {
        public int id {  get; set; }
        public string studentID { get; set; }
        List<string> status { get; set; }
        public int absentCount { get; set; }
    }
}
