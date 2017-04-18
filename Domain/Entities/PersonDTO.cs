using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PersonDTO
    {
        [Key]
        public int idPerson { get; set; }
        public string dni { get; set; }
        public string name { get; set; }
        public string surnames { get; set; }
        public System.DateTime birthDate { get; set; }
        public int age { get; set; }

    }
}
