/*using LibraryPOC.Model;
using Microsoft.EntityFrameworkCore;

namespace LibraryPOC.Context
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(new Book()
            {
                BookId = 1,
                Title = "The little bigman",
                Category = "Sitcom",
                Publisher = "Rk Publishers",
                DateOfIssue = "14/06/2021",
                Price = 100,
                AuthorID = 1
            },
            new Book()
            {
                BookId = 2,
                Title = "GORA",
                Category = "Patroitism",
                Publisher = "BG Publishers",
                DateOfIssue = "14/06/2021",
                Price = 180,
                AuthorID = 2
            });


        }
    }
}
*/