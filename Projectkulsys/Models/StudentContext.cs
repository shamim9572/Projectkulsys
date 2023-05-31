using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Projectkulsys.Models
{
    public class StudentContext : DbContext
    {
          public StudentContext(DbContextOptions<StudentContext> options): base(options)
            {

            }

        public DbSet<Student > Student { get; set; }
        public DbSet <Deparment> Department { get; set; }


    }
}
