using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetXmlProject.Classes
{
    enum Role {
        Admin,
        Student,
        Teacher
        }
    internal class User
    {
       public string id {  get; set; }
       public string UserName { get; set; }
        
      public string password { set; get; }
      
      public Role role { get; set;}
    
    }
}
