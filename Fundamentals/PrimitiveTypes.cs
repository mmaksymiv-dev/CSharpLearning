namespace Fundamentals;

public static class PrimitiveTypes
{
    public static void Start()
    {
        VariablesAndConstants();
        TypeConversion();
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

        const float Pi = 3.14f;

        Console.WriteLine(number); // Output: 2
        Console.WriteLine(count); // Output: 10
        Console.WriteLine(totalPrice); // Output: 20.95
        Console.WriteLine(character); // Output: A
        Console.WriteLine(firstName); // Output: Mykola
        Console.WriteLine(isWorking); // Output: false

        Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); // Output: 0 255
    }

    /// <summary>
    /// Type Conversion
    /// </summary>
    private static void TypeConversion()
    {
        //byte b = 1;
        //int i = b;
        //Console.WriteLine(i);

        int i = 1000;
        byte b = (byte)i;
        Console.WriteLine(b);

        try
        {
            string str = "true";
            bool cb = Convert.ToBoolean(str);
            Console.WriteLine(cb);
        }
        catch (Exception)
        {
            Console.WriteLine("The number could not be converted to a byte.");
        }
    }
}
