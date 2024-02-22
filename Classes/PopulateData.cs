using DotnetXmlProject.adminUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetXmlProject.Classes
{
    public static class PopulateData
    {
        public static void refreshAllData()
        {
            test t = new test();
            t.getCount();

            addUser addUser = new addUser();
            addUser.PopulateDataGridViewStudent();
            addUser.PopulateDataGridViewTeacher();

            attendanceMangement attendanceMangement = new attendanceMangement();
            attendanceMangement.comboxSubjectData();
            attendanceMangement.PopulateSessionIds();
            attendanceMangement.PopulateDataGridViewSession();

            ClassManagement classManagement = new ClassManagement();
            classManagement.PopulateDataGridViewClass();
            classManagement.comboxTeacherData();

            ManageClasses manageClasses = new ManageClasses();
            manageClasses.comboxClassData();
            manageClasses.comboxStdData();
            manageClasses.comboxTeacherData();
            manageClasses.comboxUserData();

        }
    }
}
