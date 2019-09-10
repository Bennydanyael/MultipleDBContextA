using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleDbContext.Models.Books
{
    public class Book
    {
        [Key]
        public int BooksID { get; set; }
        public string Booksname { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public double? Prices { get; set; }
        [ForeignKey("Username")]
        public Authors Authors { get; set; }
    }
}
