namespace Fundamentals;

public static class PrimitiveTypes
{
    public static void Start()
    {
        VariablesAndConstants();
        TypeConversion();
        Operators();
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
        Console.WriteLine(b); // Output: 232

        try
        {
            string str = "true";
            bool cb = Convert.ToBoolean(str);
            Console.WriteLine(cb); // Output: True
        }
        catch (Exception)
        {
            Console.WriteLine("The number could not be converted to a byte.");
        }
    }

    /// <summary>
    /// Operators
    /// </summary>
    private static void Operators()
    {
        var a = 10;
        var b = 3;
        var c = 4;

        Console.WriteLine(a + b); // Output: 13
        Console.WriteLine(a / b); // Output: 3
        Console.WriteLine((float)a / (float)b); // Output: 3.3333

        Console.WriteLine(a + b * c); // Output: 22
        Console.WriteLine((a + b) * c); // Output: 52

        Console.WriteLine(a > b); // Output: True
        Console.WriteLine(a != b); // Output: True
        Console.WriteLine(!(c > b || c == a)); // Output: False
    } 
}
