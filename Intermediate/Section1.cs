namespace Intermediate;

/// <summary>
/// Classes
/// </summary>
public static class Section1
{
    public class Person
    {
        public string? Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }

    public class Customer
    {
        public int Id;
        public string? Name;
        public readonly List<Order> Orders = new List<Order>();

        //public Customer()
        //{
        //    Orders = new List<Order>();
        //}

        public Customer(int id)
        {
            Id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            Name = name;
        }

        public void Promote()
        {
            //Orders = new List<Order>();
            // ...
        }
    }

    public class Order
    {
    }

    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(Point? newLocation)
        {
            if (newLocation is null)
                throw new ArgumentNullException(nameof(newLocation));

            //ArgumentNullException.ThrowIfNull(newLocation); // added in .Net 6 version

            Move(newLocation.X, newLocation.Y);
        }
    }

    public class Calculator
    {
        public int Add(params int[] values)
        {
            var sum = 0;
            foreach (var value in values)
                sum += value;

            return sum;
        }
    }

    public class Employee
    {
        private DateTime _birhtdate;

        public void SetBirhtdate(DateTime birhtdate)
        {
            _birhtdate = birhtdate;
        }

        public DateTime GetBirhtdate()
        {
            return _birhtdate;
        }
    }

    public class User
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime Birthdate { get; private set; }

        public User(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Now - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
    }

    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

    }

    public static void Run()
    {
        Classes();
        Constructors();
        Methods();
        Fields();
        AccessModifiers();
        Properties();
        Indexers();
    }

    private static void Classes()
    {
        Console.WriteLine("Start ->  Introduction to Classes");

        var person = new Person();
        person.Name = "Mykola";
        person.Introduce("John"); //Output: Hi John, I am Mykola

        var person1 = Person.Parse("Mykola");
        person.Introduce("John"); //Output: Hi John, I am Mykola

        Console.WriteLine("Finish ->  Introduction to Classes");
    }

    private static void Constructors()
    {
        Console.WriteLine("Start -> Constructors");

        var customer = new Customer(1, "Mykola");
        Console.WriteLine(customer.Id); //Output: 1
        Console.WriteLine(customer.Name); //Output: Mykola

        var order = new Order();
        customer.Orders.Add(order);

        Console.WriteLine("Finish -> Constructors");
    }

    private static void Methods()
    {
        Console.WriteLine("Start -> Methods");

        try
        {
            var point = new Point(10, 20);
            point.Move(new Point(40, 60));

            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y); //Output: Point is at (40, 60)

            point.Move(100, 200);
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y); //Output: Point is at (100, 200)

            point.Move(null);
        }
        catch (Exception)
        {
            Console.WriteLine("An unexpected error occured.");
        }

        var calculator = new Calculator();
        Console.WriteLine(calculator.Add(1, 2));
        Console.WriteLine(calculator.Add(1, 2, 3));
        Console.WriteLine(calculator.Add(1, 2, 3, 4));
        Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));

        int number;
        var result = int.TryParse("abc", out number);

        if (result)
            Console.WriteLine(number);
        else
            Console.WriteLine("Conversion failed.");

        Console.WriteLine("Finish -> Methods");
    }

    private static void Fields()
    {
        Console.WriteLine("Start -> Fields");

        var customer = new Customer(1);
        customer.Orders.Add(new Order());
        customer.Orders.Add(new Order());

        customer.Promote();

        Console.WriteLine(customer.Orders.Count); //Output: 2

        Console.WriteLine("Finish -> Fields");
    }

    private static void AccessModifiers()
    {
        Console.WriteLine("Start -> Access Modifiers");

        var employee = new Employee();
        employee.SetBirhtdate(new DateTime(1999, 12, 16));
        Console.WriteLine(employee.GetBirhtdate());  //Output: 12/16/1999 12:00:00 AM

        Console.WriteLine("Finish -> Access Modifiers");
    }

    private static void Properties()
    {
        Console.WriteLine("Start -> Properties");

        var user = new User(new DateTime(1999, 12, 16));
        Console.WriteLine(user.Age); //Output: 25

        Console.WriteLine("Finish -> Properties");
    }

    private static void Indexers()
    {
        Console.WriteLine("Start -> Indexers");

        var cookie = new HttpCookie();
        cookie["name"] = "Mykola";
        Console.WriteLine(cookie["name"]); //Output: Mykola

        Console.WriteLine("Finish -> Indexers");
    }
}