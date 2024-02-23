using DotnetXmlProject.Classes;
using DotnetXmlProject.UtilClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace DotnetXmlProject
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();

        }

        private void Export_Click(object sender, EventArgs e)
        {
            GenerateReport gr1 = new GenerateReport(attendeceGrid);
            gr1.Show();

        }

        private void datePickerChanged(object sender, EventArgs e)
        {
            var Date1 = dateTimePicker1.Value;
            var Date2 = dateTimePicker2.Value;

            var reader = XmlReader.Create("..\\..\\..\\Data\\Session.xml");
            var classReader = XmlReader.Create("..\\..\\..\\Data\\classes.xml");
            var sessions = XElement.Load(reader);
            var classes = XElement.Load(classReader);
            // Clear existing columns and rows
            attendeceGrid.Columns.Clear();
            attendeceGrid.Rows.Clear();
            classList.DataSource = classes.Elements().Select(c => c.Element("name")?.Value.ToString()).ToList();
            
            // Add columns to the DataGridView based on session dates
            attendeceGrid.Columns.Add("StudentName", "StudentName");

            Dictionary<DateTime, int> columnIndexes = new Dictionary<DateTime, int>();

            foreach (var session in sessions.Elements("Session"))
            {
                var sessionDate = DateTime.ParseExact(session.Attribute("date").Value, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                // Check if the session date is within the specified range
                if (sessionDate >= Date1 && sessionDate <= Date2)
                {
                    var columnHeaderText = sessionDate.ToString("yyyy-MM-dd");
                    attendeceGrid.Columns.Add(columnHeaderText, columnHeaderText);
                    columnIndexes[sessionDate] = attendeceGrid.Columns.Count - 1;
                }
            }

            attendeceGrid.Columns.Add("AttendanceCount", "Attendance Count"); // New column for attendance count

            // Add rows to the DataGridView based on student attendance records
            foreach (var session in sessions.Elements("Session"))
            {
                var sessionDate = DateTime.ParseExact(session.Attribute("date").Value, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                // Check if the session date is within the specified range
                if (sessionDate >= Date1 && sessionDate <= Date2)
                {
                    foreach (var attendanceRecord in session.Elements("AttendenceRecord"))
                    {
                        var stdName = attendanceRecord.Element("stdName").Value;
                        var status = attendanceRecord.Element("status").Value;

                        int columnIndex = columnIndexes[sessionDate];

                        // Find the row index based on the student name
                        int rowIndex = -1;
                        foreach (DataGridViewRow row in attendeceGrid.Rows)
                        {
                            if (row.Cells["StudentName"].Value?.ToString() == stdName)
                            {
                                rowIndex = row.Index;
                                break;
                            }
                        }

                        if (rowIndex == -1)
                        {
                            // Add a new row for the student if not found
                            rowIndex = attendeceGrid.Rows.Add();
                            attendeceGrid.Rows[rowIndex].Cells["StudentName"].Value = stdName;
                        }

                        // Set the status in the corresponding cell
                        attendeceGrid.Rows[rowIndex].Cells[columnIndex].Value = status;

                        // Set or increment the attendance count for the current session
                        if (attendeceGrid.Rows[rowIndex].Cells["AttendanceCount"].Value != null &&
                            !DBNull.Value.Equals(attendeceGrid.Rows[rowIndex].Cells["AttendanceCount"].Value))
                        {
                            int currentCount = Convert.ToInt32(attendeceGrid.Rows[rowIndex].Cells["AttendanceCount"].Value);
                            attendeceGrid.Rows[rowIndex].Cells["AttendanceCount"].Value = currentCount + 1;
                        }
                        else
                        {
                            attendeceGrid.Rows[rowIndex].Cells["AttendanceCount"].Value = 1;
                        }
                    }
                }
            }
           int lastRow = attendeceGrid.Rows.Add(); // Add a new row at the end
            for (int j = 2; j <= attendeceGrid.Columns.Count; j++)
            {
                int totalCount = 0;

                // Calculate the total count of absences for each session
                for (int i = 0; i < attendeceGrid.Rows.Count - 1; i++) // Exclude the last row
                {
                    if (attendeceGrid.Rows[i].Cells[j - 1].Value?.ToString() == "not Asssigned")
                    {
                        totalCount++;
                    }
                }

                attendeceGrid.Rows[lastRow].Cells[j - 1].Value = totalCount;
            }

        }



    }
}
