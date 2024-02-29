using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotnetXmlProject
{
    public partial class backup : Form
    {
        public backup()
        {
            InitializeComponent();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Title = "Select Files",
                Filter = "XML Files (*.xml)|*.xml|XSD Files (*.xsd)|*.xsd|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    // Assuming "destinationPath" is the destination directory path
                    string destinationPath = "..//..//..//Data";

                    // Combine destination path with just the file name, not the full path
                    string destinationFile = Path.Combine(destinationPath, Path.GetFileName(fileName));

                    // Perform the copy
                    File.Copy(fileName, destinationFile, true);
                }

                MessageBox.Show("Files copied successfully!");
            }
        }
    }
}
