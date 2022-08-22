/*using LibraryPOC.Model;
using Microsoft.EntityFrameworkCore;

namespace LibraryPOC.Context
{
    public class AuthorContext : DbContext
    {
        public AuthorContext(DbContextOptions<AuthorContext> options) : base(options)
        {

        }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author
            {
                AuthorID = 1,
                Name = "Jake Paul",
                Country = "Indonasia"
            },
            new Author
            {
                AuthorID = 2,
                Name = "RB Tagore",
                Country = "India"
            });
        }

    }
}
*/