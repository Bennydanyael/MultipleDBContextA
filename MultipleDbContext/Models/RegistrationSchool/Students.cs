using MultipleDbContext.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleDbContext.Models.RegistrationSchool
{
    public class Students
    {
        [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public ClassName ClassName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string MotherName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public Rangking Rangking { get; set; }
    }
}
