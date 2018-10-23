using Spire.DataExport.RTF;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumniAppEmiliano.Classes.Services
{
    class FileGeneratorService
    {
        public void generateTxtFile(string path,DataTable grades)
        {
            StreamWriter swExtLogFile = new StreamWriter(path + "Grades.txt", true);

            int i;
            swExtLogFile.Write(Environment.NewLine);
            foreach (DataRow row in grades.Rows)
            {
                object[] array = row.ItemArray;
                for (i = 0; i < array.Length - 1; i++)
                {
                    swExtLogFile.Write(array[i].ToString() + " | ");
                }
                swExtLogFile.WriteLine(array[i].ToString());
            }
            swExtLogFile.Write("*****END OF DATA****" + DateTime.Now.ToString());
            swExtLogFile.Flush();
            swExtLogFile.Close();
        }

        public void generateDocxFile(string text, DataTable grades)
        {
            RTFExport rtfExport = new Spire.DataExport.RTF.RTFExport();
            rtfExport.DataSource = Spire.DataExport.Common.ExportSource.DataTable;
            rtfExport.DataTable = grades;
            rtfExport.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
            RTFStyle rtfStyle = new RTFStyle();
            rtfExport.RTFOptions.DataStyle = rtfStyle;

            rtfExport.FileName = "Grades.doc";
            rtfExport.SaveToFile();
        }
    
    }
}
