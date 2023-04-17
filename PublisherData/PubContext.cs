using Microsoft.EntityFrameworkCore;
using PublisherDomain;
using System.Globalization;

namespace PublisherData {
    public class PubContext : DbContext {
        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PubDatabase");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Author>().HasData(GenerateAuthors());
            modelBuilder.Entity<Book>().HasData(GenerateBooks());
        }

        private IEnumerable<Author> GenerateAuthors() {
            for (int authorCounter = 1; authorCounter <= 10; authorCounter++) {
                yield return new Author() { Id = authorCounter, FirstName = $"FirstName{authorCounter}", LastName = $"LastName{authorCounter}" };
            }
        }

        private IEnumerable<Book> GenerateBooks() {
            int id = 0;
            for (int authorCounter = 1; authorCounter <= 10; authorCounter++) {
                for(int bookCounter = 1; bookCounter <= 5; bookCounter++) {
                    yield return new Book() { BookId = ++id, Title = $"Book_{bookCounter}_by_Author_{authorCounter}", BasePrice = 100, AuthorId = authorCounter, PublishDate = new DateTime(2000 + authorCounter * bookCounter, authorCounter, bookCounter)};
                }
            }
        }
    }
}