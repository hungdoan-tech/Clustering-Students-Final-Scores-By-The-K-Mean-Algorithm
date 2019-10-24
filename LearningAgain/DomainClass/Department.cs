using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAgain.DomainClass
{
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepartmentID { get; set; }
        public string DeparmentName { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
