namespace Advanced;

public static class LambdaExpressions
{
    public class Book
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
    }

    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Title 1", Price = 5},
                new Book() {Title = "Title 2", Price = 7},
                new Book() {Title = "Title 3", Price = 17}
            };
        }
    }

    public static void Run()
    {
        Console.WriteLine("Start -> Lambda Expressions");

        //args => expression
        //number => number * number;

        // () => ...
        // x => ...
        // (x, y, z) => ...
        Func<int, int> square = number => number * number;

        Console.WriteLine(square(5)); //Output: 25

        const int factor = 5;

        Func<int,int> multipler = n => n * factor;

        var result = multipler(10);

        Console.WriteLine(result); // Output: 50

        var books = new BookRepository().GetBooks();

        var cheapBooks = books.FindAll(b => b.Price < 10);

        foreach (var book in cheapBooks)
            Console.WriteLine(book.Title);

        Console.WriteLine("Finish -> Lambda Expressions");
    }
}
