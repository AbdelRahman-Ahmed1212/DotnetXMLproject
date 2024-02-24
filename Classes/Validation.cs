using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DotnetXmlProject.Classes
{
    static public class Validation
    {
        static public bool IsDateInCorrectFormat(string dateString)
        {
            DateTime date;
            bool isValid = DateTime.TryParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);

            if (isValid)
            {
                // Check if the parsed date is greater than or equal to today's date
                isValid = date.Date >= DateTime.Today.Date;
            }

            return isValid;
        }

            public static bool IsValidName(string name)
        {
            if (name.Length < 3 || name.Length > 40) return false;

            var regex = new Regex(@"^[a-zA-Z]{3,}(?:\s[a-zA-Z]{3,})*$");

            return regex.IsMatch(name);
        }
        public static bool IsValidEmail(string email)
        {

            var regex = new Regex(@"^[a-zA-Z0-9]{1}[a-zA-Z0-9._-]{1,18}[a-zA-Z0-9]{1}@(gmail\.com|yahoo\.com)$");

            return regex.IsMatch(email);
        }
        public static bool IsValidPassword(string password)
        {
            if (password.Length < 8 || password.Length > 20)
            {
                return false;
            }
            else
                return true;

            //var regex = new Regex(@"^(?=.[0-9])(?=.[a-zA-Z]).{8,20}$");

            //return regex.IsMatch(password);
        }

        public static bool ValidateUserData(string userName, string password, string email)
        {
            if (!IsValidName(userName))
            {
                MessageBox.Show("Invalid username format. Username must contain only letters and be between 3 and 40 characters long.");
                return false;
            }

            if (!IsValidPassword(password))
            {
                MessageBox.Show("Invalid password format. Password must be between 8 and 20 characters long and contain at least one letter, one digit.");
                return false;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address.");
                return false;
            }

            return true;
        }

        public static bool CheckIfIdExists(string xmlFilePath, string elementName, string idFieldName, int id)
        {
            XDocument xmlDoc = XDocument.Load(xmlFilePath);

            var query = xmlDoc.Descendants(elementName)
                              .Where(e => (int)e.Element(idFieldName) == id);

            return query.Any();
        }
        public static bool CheckIfSessionExists(string filePath, string elementName, string attributeName, int id)
        {
            XDocument xmlDoc = XDocument.Load(filePath);

            return xmlDoc.Descendants(elementName)
                         .Any(e => (int)e.Attribute(attributeName) == id);
        }


    }
}
