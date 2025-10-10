namespace Fundamentals;

public static class ControlFlow
{
    public static void Start()
    {
        IfElseAndSwitchCase();
        ForLoops();
        ForeachLoops();
    }

    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    /// <summary>
    /// If/Else and Switch/Case
    /// </summary>
    private static void IfElseAndSwitchCase()
    {
        int hour = 10;

        if (hour > 0 && hour < 12)
            Console.WriteLine("It's morning.");
        else if (hour >= 12 && hour < 18)
            Console.WriteLine("It's afternoon.");
        else
            Console.WriteLine("It's evening.");

        // Output: It's morning.

        bool isGoldCustomer = true;

        //float price;
        //if (isGoldCustomer)
        //    price = 19.95f;
        //else
        //    price = 29.95f;

        float price = isGoldCustomer ? 19.95f : 29.95f;

        Console.WriteLine(price);

        // Output: 19.95.

        var season = Season.Autumn;

        switch (season)
        {
            case Season.Autumn:
            case Season.Summer:
                Console.WriteLine("We've got promotion");
                break;
            default:
                Console.WriteLine("I don't understand that season!");
                break;
        }

        // Output: We've got promotion
    }

    /// <summary>
    /// For Loops
    /// </summary>
    private static void ForLoops()
    {
        for (var i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
        }

        // Output: 2 4 6 8 10

        for (var i = 10; i >= 1; i--)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
        }

        // Output: 10 8 6 4 2
    }

    /// <summary>
    /// Foreach Loops
    /// </summary>
    private static void ForeachLoops()
    {
        var name = "Mykola Maksymiv";

        foreach(var character in name)
            Console.WriteLine(character); // Output : M y k o l a  M a k s y m i v

        var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };

        foreach(var number in numbers)
            Console.WriteLine(number); // Output: 1 2 3 4 5 6 7
    }
}
