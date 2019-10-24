using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAgain.DomainClass
{
    public class Grade
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ClassID { get; set; }
        public double? Mark { get; set; }
        public Student Student { get; set; }
        public DomainClass.Class Class { get; set; }
    }
}
