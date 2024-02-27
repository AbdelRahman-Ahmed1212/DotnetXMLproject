//*using Microsoft.Office.Interop.Excel;
using System;
//using Excel = Microsoft.Office.Interop.Excel;

namespace DotnetXmlProject
{
    public partial class GenerateReport : Form
    {
        private DataGridView attendeceGrid;
       /* Microsoft.Office.Interop.Excel.Application oXL;
        Microsoft.Office.Interop.Excel._Workbook oWB;
        Microsoft.Office.Interop.Excel._Worksheet oSheet;*/
        private string exportMode { get; set; }
        public GenerateReport(DataGridView attendeceGrid)
        {
            InitializeComponent();
            this.attendeceGrid = attendeceGrid;
            this.exportMode = "pdf";


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GenerateReport_Load(object sender, EventArgs e)
        {

        }
        private void Generate_Click(object sender, EventArgs e)
        {

            string fileName = textBox1.Text;
            Generate.Enabled = false;
            // Check if the file exists
            if (File.Exists(fileName))
            {
                MessageBox.Show("this file exists please choose another name");
            }
            else if (Path.GetInvalidFileNameChars().Any(x => fileName.Contains(x)))
            {
                MessageBox.Show("Invalid file Name");
 
            }else if(fileName.Trim().Length == 0)
            {
                MessageBox.Show("Invalid file Name");
            }
            /* else
            {
                // Create a new Excel application
               Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false; // Optional: Make Excel visible

                // Add a new workbook
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.ActiveSheet;
                worksheet.Cells[1, 0] = "Session Date";
                worksheet.Cells[1, 5] = "class";
                // Add column headers to the worksheet
                for (int i = 0; i < attendeceGrid.Columns.Count; i++)
                {
                    worksheet.Cells[3, i + 1] = attendeceGrid.Columns[i].HeaderText;
                
                }
                worksheet.Columns.ColumnWidth = 20;
                // Add data rows to the worksheet
                for (int i = 0; i < attendeceGrid.Rows.Count; i++)
                {
                    for (int j = 0; j < attendeceGrid.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = attendeceGrid.Rows[i].Cells[j].Value;
                    }
                }
                string filepath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "reports", $"{fileName}");
                // Save the workbook to the specified file path
                if (exportMode == "pdf")
                {
                    workbook.ExportAsFixedFormat2(Excel.XlFixedFormatType.xlTypePDF, filepath + ".pdf");
                    workbook.Close(false);

                }
                else
                {
                    workbook.SaveAs(filepath + ".xlsx");
                    workbook.Close();

                }
                excelApp.Quit();
                MessageBox.Show("file saved successfully in your reports folder");

                // Clean up Excel objects

                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            }

            Generate.Enabled = true;*/

        }

        private void changeMode(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                exportMode = "pdf";
            }
            else
            {
                exportMode = "Excel";
            }
        }
    }
}
