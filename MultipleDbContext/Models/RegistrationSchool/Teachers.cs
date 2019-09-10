using MultipleDbContext.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleDbContext.Models.RegistrationSchool
{
    public class Teachers
    {
        [Key]
        public int TeachersID { get; set; }
        public string TeachersName { get; set; }
        public ClassName ClassName { get; set; }
        public ClassSubject ClassSubject { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string MotherName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public Rangking Rangking { get; set; }
    }
}
