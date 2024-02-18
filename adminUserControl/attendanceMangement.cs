using DotnetXmlProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace DotnetXmlProject.adminUserControl
{
    public partial class attendanceMangement : UserControl
    {
        string recordPath = "..\\..\\..\\Data\\attendanceRecord.xml";
        string userPath = "..\\..\\..\\Data\\users.xml";
        public attendanceMangement()
        {
            InitializeComponent();
            PopulateDataGridViewRecord();
            comboxStdData();
            PopulateComboBoxWithStatus(Statuscb);
            PopulateComboBoxWithStatus(statuscombox);


        }


        //==========================================================================
        //Display
        //==========================================================================
        public void comboxStdData()
        {
            using (var reader = XmlReader.Create(userPath))
            {
                var Users = XElement.Load(reader);
                var teacherIds = Users.Elements("user")
                                      .Where(u => string.Equals(u.Element("role")?.Value, "Student", StringComparison.OrdinalIgnoreCase))
                                      .Select(u => (int)u.Element("id"))
                                      .ToList();

                stdCombobox.Items.AddRange(teacherIds.Select(id => id.ToString()).ToArray());
            }
        }

        public void PopulateDataGridViewRecord()
        {
            using (var readerRecord = XmlReader.Create(recordPath))
            {
                var records = XElement.Load(readerRecord);
                var sourceRecord = records.Elements("attendanceRecord")
                                          .Select(u => new attendanceRecord
                                          {
                                              ID = (int)u.Element("id"),
                                              studentID = (int)u.Element("stdId"),
                                              date = (DateTime)u.Element("date"),
                                              studentStatus = (Status)Enum.Parse(typeof(Status), (string)u.Element("status"))
                                          }).ToList();

                recordData.DataSource = sourceRecord;
            }
        }


        public void PopulateComboBoxWithStatus(ComboBox comboBox)
        {
            // Add role values to the ComboBox
            comboBox.Items.AddRange(new string[] { "present", "absent" });
        }




        //==========================================================================
        //Add
        //==========================================================================
        private void AddRecordToXml(int stdID, Status status)
        {

            try
            {
                using (var stream = new FileStream(recordPath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    var xmlDoc = XDocument.Load(stream);
                    int lastId = xmlDoc.Descendants("attendanceRecord").Select(u => (int)u.Element("id")).DefaultIfEmpty(0).Max();

                    XElement newRecordElement = new XElement("attendanceRecord",
                                            new XElement("id", lastId + 1),
                                            new XElement("stdId", stdID),
                                            new XElement("date", DateTime.Now),
                                            new XElement("status", status.ToString()));

                    if (xmlDoc.Root == null)
                    {
                        xmlDoc.Add(new XElement("attendanceRecords", newRecordElement));
                    }
                    else
                    {
                        xmlDoc.Root.Add(newRecordElement);
                    }

                    stream.Position = 0;
                    xmlDoc.Save(stream);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error adding record: {ex.Message}. Please make sure the XML file is not open in another program.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding record: {ex.Message}");
            }
        }

        private void addRecordBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int stdID = Convert.ToInt32(stdCombobox.Text);
                Status statuss = (Status)Enum.Parse(typeof(Status), Statuscb.Text, true); // Convert string to enum


                if (statuss == null || stdID == null)
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                AddRecordToXml(stdID, statuss);


                stdCombobox.SelectedIndex = -1;
                Statuscb.SelectedIndex = -1;

                PopulateDataGridViewRecord();



                MessageBox.Show("Recourd added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding record: {ex.Message}");
            }
        }

        //==========================================================================
        //Edit
        //==========================================================================

        private void UpdateRecourdInXml(int recordId, int stdID, string status)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(recordPath);
                XElement recordToUpdate = xmlDoc.Descendants("attendanceRecord").FirstOrDefault(u => (int)u.Element("id") == recordId);

                if (recordToUpdate != null)
                {
                    recordToUpdate.Element("stdId").Value = stdID.ToString();
                    recordToUpdate.Element("status").Value = status;

                    xmlDoc.Save(recordPath);
                }
                else
                {
                    MessageBox.Show("record with the specified ID not found.");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error updating record: {ex.Message}. Please make sure the XML file is not open in another program.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating record: {ex.Message}");
            }
        }

        private void EditRecordBtn_Click(object sender, EventArgs e)
        {
            if (recordData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to edit.");
                return;
            }

            int recordID = Convert.ToInt32(recordData.SelectedRows[0].Cells["id"].Value);
            int stdId = Convert.ToInt32(recordData.SelectedRows[0].Cells["studentID"].Value);
            string status = recordData.SelectedRows[0].Cells["studentStatus"].Value.ToString();

            UpdateRecourdInXml(recordID, stdId, status);

            PopulateDataGridViewRecord();


            MessageBox.Show("recourd updated successfully.");
        }
        //==========================================================================
        //Delete
        //==========================================================================

        private void DeleteRecordFromXml(int userId)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(recordPath);
                XElement recordToDelete = xmlDoc.Descendants("attendanceRecord").FirstOrDefault(u => (int)u.Element("id") == userId);

                if (recordToDelete != null)
                {
                    recordToDelete.Remove();
                    xmlDoc.Save(recordPath);
                }
                else
                {
                    MessageBox.Show("record with the specified ID not found.");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error deleting record: {ex.Message}. Please make sure the XML file is not open in another program.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting record: {ex.Message}");
            }
        }


        private void DeleteRecordBtn_Click(object sender, EventArgs e)
        {
            if (recordData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            int recordId = Convert.ToInt32(recordData.SelectedRows[0].Cells["id"].Value);
            DeleteRecordFromXml(recordId);

            PopulateDataGridViewRecord();
            MessageBox.Show("Record deleted successfully.");
        }

        //==========================================================================
        //Search
        //==========================================================================
        private void SearchAndPopulateGridView(string searchText)
        {
            using (var stream = new FileStream(recordPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                XDocument xmlDoc = XDocument.Load(stream);
                var searchResults = xmlDoc.Root.Elements("attendanceRecord")
                    .Where(u =>  u.Element("stdId")?.Value.Contains(searchText, StringComparison.OrdinalIgnoreCase) == true)
                    .Select(u => new attendanceRecord
                    {
                        ID = (int)u.Element("id"),
                        studentID = (int)u.Element("stdId"),
                        date = (DateTime)u.Element("date"),
                        studentStatus = (Status)Enum.Parse(typeof(Status), (string)u.Element("status"))
                    }).ToList();
                recordData.DataSource = searchResults;

            }
        }

        private void stdNameTxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = stdNameTxtSearch.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                SearchAndPopulateGridView(searchText);
            }
            else
            {
                PopulateDataGridViewRecord();
            }
        }
    }
}
