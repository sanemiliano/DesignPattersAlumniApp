using Alumni.App.Db.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumniAppEmiliano.Classes.Adapters
{
    class DataBaseToViewAdapter
    {
        public DataTable adapt(List<UserSubjectDto> gradesList)
        {
            DataTable grades = new DataTable();
            grades.Columns.Add(new DataColumn("Average Subject", typeof(decimal)));
            grades.Columns.Add(new DataColumn("Grade 1", typeof(decimal)));
            grades.Columns.Add(new DataColumn("Grade 2", typeof(decimal)));
            grades.Columns.Add(new DataColumn("Grade 3", typeof(decimal)));
            grades.Columns.Add(new DataColumn("IdSubject", typeof(int)));
            grades.Columns.Add(new DataColumn("IdUser", typeof(int)));
            grades.Columns.Add(new DataColumn("Subjectname", typeof(string)));
            grades.Columns.Add(new DataColumn("Username", typeof(string)));
            foreach(UserSubjectDto element in gradesList)
            {
                DataRow row = grades.NewRow();
                row[0] = element.AverageSubject;
                row[1] = element.Grade1;
                row[2] = element.Grade2;
                row[3] = element.Grade3;
                row[4] = element.IdSubject;
                row[5] = element.IdUser;
                row[6] = element.SubjectName;
                row[7] = element.UserName;
                grades.Rows.Add(row);
            }
            return grades;
        }
    }
}
