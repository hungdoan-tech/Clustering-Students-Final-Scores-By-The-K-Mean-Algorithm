using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_1.DomainClass
{
    public class Professor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProfessorID { get; set; }
        public string ProfessorName { get; set; }    
        public DateTime? BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public Boolean IsAdmin { get; set; }
        public ICollection<DomainClass.Class> Classes { get; set; }
    }
}
