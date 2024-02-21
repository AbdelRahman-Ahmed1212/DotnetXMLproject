using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetXmlProject.Classes
{
    static public class Validation
    {
        static public bool IsDateInCorrectFormat(string date)
        {
            DateTime parsedDate;
            return DateTime.TryParse(date, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out parsedDate);
        }

    }
}
