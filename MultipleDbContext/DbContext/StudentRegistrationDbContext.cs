using Microsoft.EntityFrameworkCore;
using MultipleDbContext.Models.RegistrationSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleDbContext.Models
{
    public class StudentRegistrationDbContext : DbContext
    {
        public StudentRegistrationDbContext(DbContextOptions<StudentRegistrationDbContext> _options):base(_options)
        {
        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Employees> Employees { get; set; }
    }
}
