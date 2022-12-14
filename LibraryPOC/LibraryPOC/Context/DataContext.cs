using LibraryPOC.Model;
using Microsoft.EntityFrameworkCore;

namespace LibraryPOC.Context
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
