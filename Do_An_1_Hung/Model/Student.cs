using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_1.DomainClass
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string Sex { get; set; }
        public DateTime? DateOFBirth { get; set; }
        public int DepartmentID { get; set; }
        public Department Department { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}
