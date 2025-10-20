namespace Fundamentals;

public static class ArraysAndList
{
    public static void Start()
    {
        Arrays();
    }

    private static void Arrays()
    {
        var numbers = new int[] { 3, 7, 9, 2, 14, 6 };

        //Length
        Console.WriteLine("Length: " + numbers.Length); // Output: Length: 6

        //IndexOf()
        var index = Array.IndexOf(numbers, 9);
        Console.WriteLine("Index of 9: " + index); // Output: Index of 9: 2

        //Clear()
        Array.Clear(numbers, 0, 2);

        Console.WriteLine("Effect of Clear()");
        foreach (var n in numbers)
            Console.WriteLine(n); // Output: 0 0 9 2 14 6

        //Copy()
        int[] another = new int[3];
        Array.Copy(numbers, another, 3);

        Console.WriteLine("Effect of Clone()");
        foreach (var n in another)
            Console.WriteLine(n); // Output: 0 0 9

        //Sort()
        Array.Sort(numbers);

        Console.WriteLine("Effect of Sort()");
        foreach (var n in numbers)
            Console.WriteLine(n); // Output: 0 0 2 6 9 14

        //Reverse()
        Array.Reverse(numbers);

        Console.WriteLine("Effect of Reverse()");
        foreach (var n in numbers)
            Console.WriteLine(n); // Output: 14 9 6 2 0 0
    }
}
