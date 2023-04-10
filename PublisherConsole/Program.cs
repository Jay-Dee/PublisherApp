using Microsoft.EntityFrameworkCore;
using PublisherData;
using PublisherDomain;

namespace PublisherConsole {
    internal class Program {
        static void Main(string[] args) {

            //GetAuthors();
            //AddAuthor();
            //GetAuthors();

            //AddAuthorWithBooks();
            RemoveAuthors();
            GetAuthorsWithBooks();

            Console.ReadKey();
        }

        private static void GetAuthors() {
            using(PubContext context = new PubContext()) {
                var authors = context.Authors.ToList();
                foreach (var auth in authors) {
                    Console.WriteLine($"{auth.FirstName} {auth.LastName}");
                }
            }
        }

        private static void AddAuthor() {
            var newAuthor = new Author() { FirstName = "Jane", LastName = "Doe" };
            using(PubContext context = new PubContext()) {
                context.Authors.Add(newAuthor);
                context.SaveChanges();
            }
        }

        private static void AddAuthorWithBooks() {

            for(int authorCounter = 0; authorCounter < 100; authorCounter++) {
                var newAuthorWithBooks = new Author() { FirstName = $"Jane#{authorCounter}", LastName = $"Doe#{authorCounter}" };
                for(int bookCounter = 0; bookCounter < 5; bookCounter++) {
                    newAuthorWithBooks.Books.Add(new Book() { Title = $"Book{bookCounter} by Jane#{authorCounter}", BasePrice = 100 });
                }
                
                using (PubContext ctx = new PubContext()) {
                    ctx.Authors.Add(newAuthorWithBooks);
                    ctx.SaveChanges();
                }
            }
            
        }

        private static void GetAuthorsWithBooks() {
            using(PubContext context = new PubContext()) {
                var allAuthors = context.Authors.Include(a => a.Books).ToList();
                foreach (var auth in allAuthors) {
                    Console.WriteLine($"{auth.FirstName} {auth.LastName}");
                    foreach(var book in auth.Books) {
                        Console.WriteLine(book.Title);
                    }
                }
            }
        }

        private static void RemoveAuthors() {
            for (int authorCounter = 0; authorCounter < 103; authorCounter++) {
                using (PubContext context = new PubContext()) {
                    var authorToRemove = context.Authors.Find(authorCounter);
                    if (authorToRemove != null) {
                        context.Authors.Remove(authorToRemove);
                        context.SaveChanges();
                        Console.WriteLine($"Author {authorToRemove.FirstName} removed successfully");
                    }
                }
            }
        }
    }
}