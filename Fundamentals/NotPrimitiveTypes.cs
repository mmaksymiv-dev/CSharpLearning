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
}
