namespace Fundamentals;

public static class ArraysAndList
{
    public static void Start()
    {
        Arrays();
        Lists();
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

    private static void Lists()
    {
        var numbers = new List<int>() { 1, 2, 3, 4 };

        numbers.Add(1);
        numbers.AddRange(new int[] { 5, 6, 7 });

        foreach (var number in numbers)
            Console.WriteLine(number); //Output: 1 2 3 4 1 5 6 7

        Console.WriteLine();
        Console.WriteLine("Index of 1: " + numbers.IndexOf(1)); // Output: 0
        Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1)); // Outout: 4

        Console.WriteLine("Count: " + numbers.Count); // Output: 8

        numbers.Remove(1);
        foreach (var number in numbers)
            Console.WriteLine(number); // Output: 2 3 4 1 5 6 7

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == 1)
                numbers.Remove(numbers[i]);
        }

        foreach (var number in numbers)
            Console.WriteLine(number); // Output: 2 3 4 5 6 7

        numbers.Clear();
        Console.WriteLine("Count: " + numbers.Count); // Output: Count:  0
    }
}
