using System.Text;

namespace Fundamentals;

public static class WorkingWithText
{
    public static void Start()
    {
        Strings();
        SummarisingText();
        StringBuilder();
    }

    /// <summary>
    /// Strings
    /// </summary>
    private static void Strings()
    {
        var fullName = "Mykola Mykola ";
        Console.WriteLine("Trim: '{0}'", fullName.Trim());
        Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

        var index = fullName.IndexOf(" ");
        var firstName = fullName.Substring(0, index);
        var lastName = fullName.Substring(index + 1);

        Console.WriteLine("FirstName: " + firstName);
        Console.WriteLine("LastName: " + lastName);

        var names = fullName.Split(" ");
        Console.WriteLine("FirstName: " + names[0]);
        Console.WriteLine("LastName: " + names[1]);

        Console.WriteLine(fullName.Replace("Mykola", "Test"));

        if (String.IsNullOrEmpty(" ".Trim()))
            Console.WriteLine("Invalid");

        var str = "25";
        var age = Convert.ToByte(str);
        Console.WriteLine(age);

        float price = 20.95f;
        Console.WriteLine(price.ToString("C0"));
    }

    private static void SummarisingText()
    {
        var sentece = "This is going to be a really really really really long text";
        var summary = SummerizeText(sentece, 25);
        Console.WriteLine(summary);
    }

    private static string SummerizeText(string text, int maxLength = 20)
    {
        if (text.Length < maxLength)
            return text;

        var words = text.Split(" ");
        var totalCharacters = 0;

        var summaryWords = new List<string>();

        foreach (var word in words)
        {
            summaryWords.Add(word);

            totalCharacters += word.Length + 1;
            if (totalCharacters > maxLength)
                break;
        }

        return String.Join(" ", summaryWords) + "...";
    }

    private static void StringBuilder()
    {
        var buider = new StringBuilder("Hello World");

        //buider.Append('-', 10);
        //buider.AppendLine();
        //buider.Append("Header");
        //buider.AppendLine();
        //buider.Append('-', 10);

        //buider.Replace('-', '+');
        //buider.Remove(0, 10);
        //buider.Insert(0, new string('-', 10));

        buider.Append('-', 10)
            .AppendLine()
            .Append("Header")
            .AppendLine()
            .Append('-', 10)
            .Replace('-', '+')
            .Remove(0, 10)
            .Insert(0, new string('-', 10));

        Console.WriteLine(buider);
        Console.WriteLine("First Char:" + buider[0]);
    }
}
