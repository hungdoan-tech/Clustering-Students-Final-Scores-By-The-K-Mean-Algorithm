using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_1.Business
{
    class BLStudent
    {
        public List<dynamic> DetailStudentInfo_cbb_Subjects(string ID)
        {
            using (var ctx = new UniversityContext())
            {
                    var detailStudentInfo = (from t in ctx.Students
                                             join p in ctx.Departments on t.DepartmentID equals p.DepartmentID
                                             join s in ctx.Grades on t.StudentID equals s.StudentID
                                             join r in ctx.Classes on s.ClassID equals r.ClassID
                                             join q in ctx.Subjects on r.SubjectID equals q.SubjectID
                                             where r.SubjectID.ToString() == ID 
                                             select new
                                             {
                                                 t.StudentID,
                                                 t.StudentName,
                                                 t.DateOFBirth,
                                                 t.Sex,
                                                 p.DepartmentID,
                                                 p.DeparmentName,
                                                 r.ClassID,
                                                 q.SubjectID,
                                                 q.SubjectName,
                                             }).Distinct();
                    return detailStudentInfo.ToList<dynamic>();
            }
        }
        public List<dynamic> DetailStudentInfo_cbb_Classes(string ID)
        {
            using (var ctx = new UniversityContext())
            {
                    var detailStudentInfo = (from t in ctx.Students
                                             join p in ctx.Departments on t.DepartmentID equals p.DepartmentID
                                             join s in ctx.Grades on t.StudentID equals s.StudentID
                                             join r in ctx.Classes on s.ClassID equals r.ClassID
                                             join q in ctx.Subjects on r.SubjectID equals q.SubjectID
                                             where r.ClassID.ToString() == ID 
                                             select new
                                             {
                                                 t.StudentID,
                                                 t.StudentName,
                                                 t.DateOFBirth,
                                                 t.Sex,
                                                 p.DepartmentID,
                                                 p.DeparmentName,
                                                 r.ClassID,
                                                 q.SubjectID,
                                                 q.SubjectName,
                                             }).Distinct();
                    return detailStudentInfo.ToList<dynamic>();
            }
        }
        public List<dynamic> Search(string studentIdentity,string classID, string subjectID)
        {
            using (var ctx = new UniversityContext())
            {
                var search = (from t in ctx.Students
                                  join p in ctx.Departments on t.DepartmentID equals p.DepartmentID
                                  join s in ctx.Grades on t.StudentID equals s.StudentID
                                  join r in ctx.Classes on s.ClassID equals r.ClassID
                                  join q in ctx.Subjects on r.SubjectID equals q.SubjectID
                                  where (t.StudentID.ToString().Contains(studentIdentity) || t.StudentName.ToString().Contains(studentIdentity))
                                    && r.ClassID.Contains(classID) && q.SubjectID.Contains(subjectID)
                                  select new
                                  {
                                      t.StudentID,
                                      t.StudentName,
                                      t.DateOFBirth,
                                      t.Sex,
                                      p.DepartmentID,
                                      p.DeparmentName,
                                      r.ClassID,
                                      q.SubjectID,
                                      q.SubjectName,
                                  }).Distinct();
                return search.ToList<dynamic>();
            }
        }
    }
}
