namespace Fundamentals;

public static class NotPrimitiveTypes
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

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

    public static void Start()
    {
        Classes();
        Arrays();
        Strings();
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
}
