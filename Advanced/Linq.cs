namespace Advanced;

/// <summary>
/// LINQ (Language Integrated Query)
/// </summary>
public static class Linq
{
    public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "ADO.Net Step by Step", Price = 5 },
                new Book() {Title = "ASP.NET MVC", Price = 9.99f },
                new Book() {Title = "ASP.NET Web API", Price = 12 },
                new Book() {Title = "C# Advanced Topics", Price = 7 },
                new Book() {Title = "C# Advanced Topics", Price = 9 }
            };
        }
    }

    public static void Run()
    {
        Console.WriteLine("Start -> Linq");

        var books = new BookRepository().GetBooks();

        //var cheapBooks = new List<Book>();

        //foreach (var book in books)
        //{
        //    if (book.Price < 10)
        //        cheapBooks.Add(book);
        //}

        //foreach (var book in cheapBooks)
        //    Console.WriteLine($"{book.Title} {book.Price}");

        //LINQ Query Operators
        var cheaperBook =
            from b in books
            where b.Price < 10
            orderby b.Title
            select b.Title;

        // LINQ Extension Methods
        var cheapBooks = books
                            .Where(b => b.Price < 10)
                            .OrderBy(b => b.Title)
                            .Select(b => b.Title);

        foreach (var b in cheapBooks)
            Console.WriteLine(b);

        var book = books.SingleOrDefault(b => b.Title == "ASP.NET MVC");
        Console.WriteLine(book.Title);

        var pagedBooks = books.Skip(2).Take(3);

        foreach (var b in books)
            Console.WriteLine(b.Title);

        var count = books.Count();
        Console.WriteLine(count);

        var maxPrice = books.Max(b => b.Price);
        Console.WriteLine(maxPrice);

        Console.WriteLine("Finish -> Linq");
    }
}
