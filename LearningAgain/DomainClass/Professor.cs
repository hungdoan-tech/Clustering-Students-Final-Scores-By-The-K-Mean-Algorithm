using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAgain.DomainClass
{
    public class Professor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProfessorID { get; set; }
        public string ProfessorName { get; set; }
        public string Password { get; set; }
        public ICollection<DomainClass.Class> Classes { get; set; }
    }
}
