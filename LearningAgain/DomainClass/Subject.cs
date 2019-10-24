using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAgain.DomainClass
{
    public class Subject
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string SubjectID { get; set; }
        public string SubjectName { get; set; }
        public ICollection<DomainClass.Class> Classes { get; set; }
    }
}
