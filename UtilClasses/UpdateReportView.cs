using DotnetXmlProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.Xsl;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DotnetXmlProject.UtilClasses
{
    internal class UpdateReportView
    {
        public static List<attendanceRecord> resultList = new List<attendanceRecord>();
        public static List<AttendceReportRecord> getAllClassesReports(DateTime date1, DateTime date2) { 
            var reader = XmlReader.Create("..\\..\\..\\Data\\attendence.xml");
            var xAtt = XElement.Load(reader);
            foreach (var item in xAtt.Elements())
            {
                AttendceReportRecord record = new AttendceReportRecord();
                DateTime recordDate;
                if (DateTime.TryParse(item.Element("date").Value, out recordDate) &&
                    recordDate >= date1 && recordDate <= date2)
                {
                    record.studentID = item.Element("stdId").Value;
                    record.id = 0;
                   




                }
            }
            return resultList;
        }
        
    }
}
