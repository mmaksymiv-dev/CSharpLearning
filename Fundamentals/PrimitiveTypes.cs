namespace Fundamentals;

public static class PrimitiveTypes
{
    public static void Start()
    {
        VariablesAndConstants();
    }


    /// <summary>
    /// Variables And Constants
    /// </summary>
    private static void VariablesAndConstants()
    {
        byte number = 2;
        int count = 10;
        float totalPrice = 20.95f;
        char character = 'A';
        string firstName = "Mykola";
        bool isWorking = false;

        Console.WriteLine(number); // Output: 2
        Console.WriteLine(count); // Output: 10
        Console.WriteLine(totalPrice); // Output: 20.95
        Console.WriteLine(character); // Output: A
        Console.WriteLine(firstName); // Output: Mykola
        Console.WriteLine(isWorking); // Output: false
    }
}
