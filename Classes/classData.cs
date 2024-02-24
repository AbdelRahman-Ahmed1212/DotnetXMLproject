using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetXmlProject.Classes
{
    internal class classData
    {
        public int id { set; get; }
        public int TeacherId { set; get; }
        public string name { set; get; }
        public string? status { get; internal set; }
        public int SessionId { get; internal set; }
        public string? SessionDate { get; internal set; }
        public string Session { get; internal set; }
    }
}

