using System.Collections;

namespace Intermediate;

/// <summary>
/// Inheritance - Second Pillar of OOP
/// </summary>
public static class Section3
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true);
            if (rating == 0)
                Console.WriteLine("Promoted to Level 1");
            else
                Console.WriteLine("Promoted to Level 2");
        }

        private int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }

    public class GoldCustomer : Customer
    {
        public void OfferVouchar()
        {
            Promote();
        }
    }

    public class Vehicle
    {
        private readonly string _registrationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized.");
        //}

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;

            Console.WriteLine("Vehicle is being initialized. {0}", _registrationNumber);
        }
    }

    public class Car : Vehicle
    {
        public Car(string registarionNumber)
            : base(registarionNumber)
        {
            Console.WriteLine("Car is being initialized. {0}", registarionNumber);
        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {
        }
    }

    public class Text : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
    }

    public static void Run()
    {
        AccessModifiers();
        ConstructorsAndInheritance();
        UpcastingAndDowncasting();
    }

    private static void AccessModifiers()
    {
        Console.WriteLine("Start -> Access Modifiers");

        var customer = new Customer();
        customer.Promote();
        //customer.CalculateRating();

        Console.WriteLine("Finish -> Access Modifiers");
    }

    private static void ConstructorsAndInheritance()
    {
        Console.WriteLine("Start -> Constructors And Inheritance");

        var car = new Car("XYZ1234");

        Console.WriteLine("Finish -> Constructors And Inheritance");
    }

    private static void UpcastingAndDowncasting()
    {
        Console.WriteLine("Start -> Upcasting And Downcasting");

        //Upcasting
        var text = new Text();
        Shape shape = text;
        text.Width = 200;
        shape.Width = 100;
        Console.WriteLine(text.Width); //Output: 100

        StreamReader streamReader = new StreamReader(new MemoryStream());

        var list = new ArrayList();
        list.Add(1);
        list.Add("Mykola");
        list.Add(new Text());

        //Downcasting
        Shape shape1 = new Text();
        Text text1 = (Text)shape1;


        Console.WriteLine("Finish -> Upcasting And Downcasting");
    }
}