using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetXmlProject.Classes
{
    internal class Student:User
    {
        public int ClassID { get; set; }
        public List<int> AttendenceIDS { get; set; }
    }
}
