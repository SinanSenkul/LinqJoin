
namespace LinqJoin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Author> authors = new List<Author> // creating the list of objects
            {
                new Author{ AuthorId = 1, Name="Ali"},
                new Author{ AuthorId = 2, Name="Veli"},
                new Author{ AuthorId = 3, Name="Ayşe"},
            };

            List<Book> books = new List<Book> // creating the list of objects
            {
                new Book{ AuthorId = 1, Title="Ali'nin Kitabı", BookId = 1},
                new Book{ AuthorId = 2, Title="Veli'nin Kitabı", BookId = 2},
                new Book{ AuthorId = 2, Title="Veli'nin Kitabı", BookId = 3},
                new Book{ AuthorId = 3, Title="Ayşe'nin Kitabı", BookId = 4},
            };
            var query = from author in authors
                        join @book in books
                        on author.AuthorId equals @book.AuthorId
                        select new
                        {
                            AuthorName = author.Name,
                            Title = @book.Title
                        };
            foreach (var item in query)
            {
                Console.WriteLine($"Yazar: {item.AuthorName}, Kitabı: {item.Title}");
            }
        }
    }
}