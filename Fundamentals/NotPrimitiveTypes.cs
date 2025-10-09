namespace Fundamentals;

public static class NotPrimitiveTypes
{

    public static void Start()
    {
        Classes();
        Arrays();
        Strings();
        Enums();
        ReferenceTypesAndValueTypes();
    }

    public class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    /// <summary>
    /// Classes
    /// </summary>
    private static void Classes()
    {
        var person = new Person();
        person.FirstName = "Mykola";
        person.LastName = "Maksyniv";
        person.Introduce(); // Output: My name is Mykola Maksymiv

        var calculator = new Calculator();
        var result = calculator.Add(1, 2);

        Console.WriteLine(result); // Output: 3
    }

    /// <summary>
    /// Arrays
    /// </summary>
    private static void Arrays()
    {
        var numbers = new int[3];
        numbers[0] = 1;

        Console.WriteLine(numbers[0]); // Output: 1
        Console.WriteLine(numbers[1]); // Output: 0
        Console.WriteLine(numbers[2]); // Output: 0

        var flags = new bool[3];
        flags[0] = true;

        Console.WriteLine(flags[0]); // Output: True
        Console.WriteLine(flags[1]); // Output: False
        Console.WriteLine(flags[2]); // Output: False

        var names = new string[3] { "name1", "name2", "name3" };

        Console.WriteLine(names[0]); // Output: name1
        Console.WriteLine(names[1]); // Output: name2
        Console.WriteLine(names[2]); // Output: name3
    }

    /// <summary>
    /// Strings
    /// </summary>
    private static void Strings()
    {
        var firstName = "Mykola";
        var lastname = "Maksymiv";

        var fullName = firstName + " " + lastname;

        Console.WriteLine(fullName); // Output: Mykola Maksymiv

        var myFyllName = string.Format("My name is {0} {1}", firstName, lastname);

        Console.WriteLine(myFyllName);  // Output: My name is Mykola Maksymiv

        var names = new string[3] { "name1", "name2", "name3" };
        var formattedNames = string.Join(", ", names);

        Console.WriteLine(formattedNames); // Output: name1, name2, name3
    }

    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3,
    }

    /// <summary>
    /// Enums
    /// </summary>
    private static void Enums()
    {
        var method = ShippingMethod.Express;
        Console.WriteLine((int)method); //Output: 3

        var methodId = 3;
        Console.WriteLine((ShippingMethod)methodId); //Output: Express

        var methodName = "Express";
        var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

        Console.WriteLine(shippingMethod); //Output: Express
    }

    public class Person1
    {
        public int Age;
    }

    /// <summary>
    /// Reference Types And Value Types
    /// </summary>
    private static void ReferenceTypesAndValueTypes()
    {
        var a = 10;
        var b = a;
        b++;
        Console.WriteLine(string.Format("a: {0}, b: {1}", a, b)); //Output: a: 10, b: 11

        var array1 = new int[3] { 1, 2, 3 };
        var array2 = array1;
        array2[0] = 0;

        Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0])); // Output: array1[0]: 0, array2[0]: 0

        var number = 1;
        Increment(number);
        Console.WriteLine(number); // Output: 1;

        var person = new Person1() { Age = 20 };
        MakeOld(person);
        Console.WriteLine(person.Age); //Output: 30 
    }

    private static void Increment(int number)
    {
        number += 10;
    }

    public static void MakeOld(Person1 person)
    {
        person.Age += 10;
    }
}
