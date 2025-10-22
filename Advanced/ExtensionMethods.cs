namespace Advanced;

public static class ExtensionMethods
{

    public static void Run()
    {
        Console.WriteLine("Start -> Extension Methods");

        string post = "This is supposed to be a very long blog post blah blah blah...";
        var shortenedPost = post.Shorten(5);

        Console.WriteLine(shortenedPost); //Output: This is supposed to be ... 

        IEnumerable<int> numbers = new List<int>() { 1, 5, 3, 10, 2, 18 };
        var max = numbers.Max();

        Console.WriteLine(max); //Output: 18     

        Console.WriteLine("Finish -> Extension Methods");
    }
}

public static class StringExtensions
{
    public static string Shorten(this String str, int numberOfWords)
    {
        if (numberOfWords < 0)
            throw new ArgumentOutOfRangeException("numberOfWords should be greater than or equal to 0.");

        if (numberOfWords == 0)
            return "";

        var words = str.Split(' ');

        if (words.Length <= numberOfWords)
            return str;

        return string.Join(" ", words.Take(numberOfWords)) + "...";
    }
}