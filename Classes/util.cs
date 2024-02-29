using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetXmlProject.Classes
{
    internal class util
    {
        public static void CopyFilesPeriodically(object sender, EventArgs e)
        {
            try
            {
                // Source directory path
                string sourceDirectory = "..\\..\\..\\Data";

                // Destination directory path
                string destinationDirectory = "..\\..\\..\\backup";

                // Get all XML and XSD files in the source directory
                string[] files = Directory.GetFiles(sourceDirectory, "*.*", SearchOption.AllDirectories)
                    .Where(file => file.ToLower().EndsWith(".xml") || file.ToLower().EndsWith(".xsd"))
                    .ToArray();

                // Copy each file to the destination directory
                foreach (string file in files)
                {
                    string destinationFile = Path.Combine(destinationDirectory, Path.GetFileName(file));
                    File.Copy(file, destinationFile, true);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static string getDatapath(string file) {
            if(file == "")
            {
                return "..\\..\\..\\Data\\";
            }
            string filePath = "..\\..\\..\\Data\\" + file;
            return filePath;
        }
    }
}
