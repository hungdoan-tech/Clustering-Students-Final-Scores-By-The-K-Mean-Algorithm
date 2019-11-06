using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_1.DomainClass
{
    public class Class
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ClassID { get; set; }
        public string SubjectID { get; set; }
        public int ProfessorID { get; set; }
        public ICollection<Grade> Grades { get; set; }
        public DomainClass.Subject Subject { get; set; }
        public Professor Professor { get; set; }
    }
}
