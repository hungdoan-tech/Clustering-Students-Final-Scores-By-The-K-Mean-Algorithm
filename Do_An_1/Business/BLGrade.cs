using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_1.Business
{
    class BLGrade
    {
        public List<dynamic> DetailGradeInfo_cbb_Classes(string ID, string ProID)
        {
            using (var ctx = new UniversityContext())
            {
                if (ctx.Professors.SingleOrDefault(s => s.ProfessorID.ToString() == ProID).IsAdmin != true)
                {
                    var detailGradeInfo = (from s in ctx.Grades
                                           join t in ctx.Students on s.StudentID equals t.StudentID
                                           join p in ctx.Classes on s.ClassID equals p.ClassID
                                           join q in ctx.Subjects on p.SubjectID equals q.SubjectID
                                           where p.ClassID.ToString() == ID && p.ProfessorID.ToString().Contains(ProID)
                                           select new
                                           {
                                               s.ClassID,
                                               p.SubjectID,
                                               q.SubjectName,
                                               t.StudentID,
                                               t.StudentName,
                                               s.Mark,
                                           }).Distinct();
                    return detailGradeInfo.ToList<dynamic>();
                }
                else
                {
                    var detailGradeInfo = (from s in ctx.Grades
                                           join t in ctx.Students on s.StudentID equals t.StudentID
                                           join p in ctx.Classes on s.ClassID equals p.ClassID
                                           join q in ctx.Subjects on p.SubjectID equals q.SubjectID
                                           where p.ClassID.ToString() == ID 
                                           select new
                                           {
                                               s.ClassID,
                                               p.SubjectID,
                                               q.SubjectName,
                                               t.StudentID,
                                               t.StudentName,
                                               s.Mark,
                                           }).Distinct();
                    return detailGradeInfo.ToList<dynamic>();
                }
            }
        }
        public List<dynamic> DetailGradeInfo_cbb_Subjects(string ID, string ProID)
        {
            using (var ctx = new UniversityContext())
            {
                if (ctx.Professors.SingleOrDefault(s => s.ProfessorID.ToString() == ProID).IsAdmin != true)
                {
                    var detailGradeInfo = (from s in ctx.Grades
                                           join t in ctx.Students on s.StudentID equals t.StudentID
                                           join p in ctx.Classes on s.ClassID equals p.ClassID
                                           join q in ctx.Subjects on p.SubjectID equals q.SubjectID
                                           where p.SubjectID.ToString() == ID && p.ProfessorID.ToString().Contains(ProID)
                                           select new
                                           {
                                               s.ClassID,
                                               p.SubjectID,
                                               q.SubjectName,
                                               t.StudentID,
                                               t.StudentName,
                                               s.Mark,
                                           }).Distinct();
                    return detailGradeInfo.ToList<dynamic>();
                }
                else
                {
                    var detailGradeInfo = (from s in ctx.Grades
                                           join t in ctx.Students on s.StudentID equals t.StudentID
                                           join p in ctx.Classes on s.ClassID equals p.ClassID
                                           join q in ctx.Subjects on p.SubjectID equals q.SubjectID
                                           where p.SubjectID.ToString() == ID 
                                           select new
                                           {
                                               s.ClassID,
                                               p.SubjectID,
                                               q.SubjectName,
                                               t.StudentID,
                                               t.StudentName,
                                               s.Mark,
                                           }).Distinct();
                    return detailGradeInfo.ToList<dynamic>();
                }
            }
        }
        public List<dynamic> Search (string studentIdentity, string classID, string subjectID)
        {
            using (var ctx = new UniversityContext())
            {
                var detailGradeInfo = (from s in ctx.Grades
                                       join t in ctx.Students on s.StudentID equals t.StudentID
                                       join p in ctx.Classes on s.ClassID equals p.ClassID
                                       join q in ctx.Subjects on p.SubjectID equals q.SubjectID
                                       where (t.StudentID.ToString().Contains(studentIdentity) || t.StudentName.ToString().Contains(studentIdentity))
                                        && s.ClassID.Contains(classID) && q.SubjectID.Contains(subjectID)
                                       select new
                                       {
                                           s.ClassID,
                                           p.SubjectID,
                                           q.SubjectName,
                                           t.StudentID,
                                           t.StudentName,
                                           s.Mark,
                                       }).Distinct();
                return detailGradeInfo.ToList<dynamic>();
            }
        }
        public bool UpdateMark(int studentID, string classID, double? mark)
        {
            using (var ctx = new UniversityContext())
            {
                try
                {
                    ctx.Grades.SingleOrDefault(b => b.StudentID == studentID && b.ClassID == classID).Mark = mark;
                    ctx.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public int Readfile(string path)
        {
            using (var ctx = new Do_An_1.UniversityContext())
            {
                string filepath = path;
                string[] lines;

                if (System.IO.File.Exists(filepath))
                {
                    lines = System.IO.File.ReadAllLines(filepath);
                    foreach (var line in lines)
                    {
                        string[] element = new string[3];
                        element = line.Split(new char[] { ' ' });
                        int stu = Convert.ToInt32(element[0]);
                        string cla = element[1];
                        try
                        {
                            ctx.Grades.SingleOrDefault(gra => gra.StudentID == stu && gra.ClassID == cla).Mark = Convert.ToDouble(element[2]);
                        }
                        catch 
                        {
                            return 1;
                        }
                    }
                    ctx.SaveChanges();
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
