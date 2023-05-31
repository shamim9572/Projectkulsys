using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Projectkulsys.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Required")]
        public string FirstName { get; set; }



        [Required(ErrorMessage = "Required")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Required")]
        public string Mobilenumber { get; set; }


        [Required(ErrorMessage = "Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Required")]
        [Display(Name = "Discription")]
        public string Discription { get; set; }
        public int DepId { get; set; }


        [NotMapped]

        public string Department { get; set;}
    }
}
