using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Projectkulsys.Models
{
    public class Deparment
    {
        [Key]
        public int Id { get; set; }
        public string Department { get; set; }
    }
}
