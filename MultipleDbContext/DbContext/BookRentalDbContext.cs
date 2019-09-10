using Microsoft.EntityFrameworkCore;
using MultipleDbContext.Models.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleDbContext.Models
{
    public class BookRentalDbContext : DbContext
    {
        public BookRentalDbContext(DbContextOptions<BookRentalDbContext> _options):base(_options)
        {
        }

        public DbSet<Authors> Authors { get; set; }
        public DbSet<Book> Book { get; set; }
    }
}
