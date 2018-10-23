using Alumni.App.Db;
using Alumni.App.Db.DTO;
using AlumniAppEmiliano.Classes.Adapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumniAppEmiliano.Classes.Services
{
    class DataBaseService
    {
        AcademicInfoService academicService = new AcademicInfoService();
        public DataTable getGrades(int userId)
        {
            List<UserSubjectDto> gradesList = academicService.GetSubjectsAndGradesByUser(userId);
            //Adapting information donwloaded
            DataBaseToViewAdapter adapter = new DataBaseToViewAdapter();
            DataTable grades = adapter.adapt(gradesList);
            return grades;
        }
    }
}
