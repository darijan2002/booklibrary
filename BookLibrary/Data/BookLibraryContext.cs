using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Models
{
    public class BookLibraryContext : DbContext
    {
        public BookLibraryContext (DbContextOptions<BookLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<BookLibrary.Models.Book> Book { get; set; }
    }
}
