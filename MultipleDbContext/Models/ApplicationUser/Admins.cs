using MultipleDbContext.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleDbContext.Models
{
    public class Admins
    {
        [Key]
        public int AdminsID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }
        public Religions Religions { get; set; }
    }
}
