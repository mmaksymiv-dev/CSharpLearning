namespace Advanced;

/// <summary>
/// Generics
/// </summary>
public static class Generics
{
    public class GenericList<T>
    {
        public void Add(T value)
        {
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {
        }
    }

    public class Book
    {
    }

    public class Protuct
    {
        public string Title { get; set; }
        public float Price { get; set; }

    }


    // where T : Protuct
    // where T : struct
    // where T : class
    // where T : new()

    // where T : IComparable
    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        //public T Max<T>(T a, T b) where T : IComparable
        //{
        //    return a.CompareTo(b) > 0 ? a : b;
        //}

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }
    }

    // where T : Protuct
    public class DiscountCalculator<TProtuct> where TProtuct : Protuct
    {
        public float CalculateDiscount(TProtuct protuct)
        {
            return protuct.Price;
        }
    }

    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {
        }
        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
    }

    public static void Run()
    {
        Console.WriteLine("Start -> Generics");

        var numbers = new GenericList<int>();
        numbers.Add(1);

        var books = new GenericList<Book>();
        books.Add(new Book());

        var dictionaty = new GenericDictionary<string, Book>();
        dictionaty.Add("1234", new Book());

        var number = new Nullable<int>(5);

        Console.WriteLine("Has Value ? " + number.HasValue); //Output : Has Value ? true
        Console.WriteLine("Value: " + number.GetValueOrDefault()); //Output: Value: 5 

        Console.WriteLine("Finish -> Generics");
    }
}


// C# Generics – Summary and Code Examples
// Introduction to Generics
// Generics in C# are a powerful feature that allows you to create reusable, type-safe, and high-performance code.
// They were introduced in .NET 2.0 to solve problems related to type safety, performance, and code duplication.

// Problem Before Generics
// Before generics, developers had to create separate classes for different data types.For example,
// if you wanted a list to store integers and another to store books, you had to create two different classes:

// public class IntList
// {
//    private int[] _items = new int[10];
//    private int _count;

//    public void Add(int item)
//    {
//        _items[_count++] = item;
//    }

//    public int this[int index] => _items[index];
// }

// public class BookList
// {
//    private Book[] _items = new Book[10];
//    private int _count;
//    public void Add(Book item)
//    {
//        _items[_count++] = item;
//    }

//    public Book this[int index] => _items[index];
// }

// This approach led to code duplication and maintenance issues because any change had to be made in multiple places.

// Using Object as a Workaround
// One way to avoid duplication was to use object as a generic type:

// public class ObjectList
// {
//    private object[] _items = new object[10];
//    private int _count;

//    public void Add(object item)
//    {
//        _items[_count++] = item;
//    }

//    public object this[int index] => _items[index];
// }

// This allowed storing any type of data, but it introduced performance issues due to boxing and
// unboxing when dealing with value types(e.g., integers).

// Solution: Generics
// Generics solve these issues by allowing us to create a single class that can handle any data type in a type-safe way:

// public class GenericList<T>
// {
//    private T[] _items = new T[10];
//    private int _count;

//    public void Add(T item)
//    {
//        _items[_count++] = item;
//    }

//    public T this[int index] => _items[index];
// }

// Now, we can use this class for different types without code duplication:


// var intList = new GenericList<int>();
// intList.Add(10);
// Console.WriteLine(intList[0]); // Output: 10

// var bookList = new GenericList<Book>();
// bookList.Add(new Book { Title = "C# in Depth" });
// Console.WriteLine(bookList[0].Title); // Output: C# in Depth
// Built -in Generic Collections in .NET
// In real-world applications, you rarely need to create your own generic classes. The .NET framework provides
// a set of generic collections in System.Collections.Generic:

// List<T>
// Dictionary<TKey, TValue>
// Queue<T>
// Stack<T>
// HashSet<T>
// LinkedList<T>
// Example of using List<T>:


// List<int> numbers = new List<int>();
// numbers.Add(1);
// numbers.Add(2);
// Console.WriteLine(numbers[0]); // Output: 1
// Example of using Dictionary<TKey, TValue>:


// Dictionary<string, Book> books = new Dictionary<string, Book>();
// books.Add("1234", new Book { Title = "The Pragmatic Programmer" });

// Console.WriteLine(books["1234"].Title); // Output: The Pragmatic Programmer
// Generic Constraints
// Sometimes, you need to restrict the types that can be used as generic parameters. Constraints help enforce such rules.

// 1. Interface Constraint
// To ensure that T implements a specific interface:


// public class Utilities
// {
//    public static T Max<T>(T a, T b) where T : IComparable<T>
//    {
//        return a.CompareTo(b) > 0 ? a : b;
//    }
// }

// Usage
// Console.WriteLine(Utilities.Max(10, 20)); // Output: 20
// 2.Class Constraint
// To restrict T to a specific class or its subclasses:


// public class DiscountCalculator<T> where T : Product
// {
//    public decimal CalculateDiscount(T product)
//    {
//        return product.Price * 0.1m; // 10% discount
//    }
// }
// 3.Value Type Constraint
// To restrict T to value types (int, double, etc.):


// public class Nullable<T> where T : struct
// {
//    private T? _value;

//    public Nullable(T value)
//    {
//        _value = value;
//    }

//    public bool HasValue => _value.HasValue;

//    public T GetValueOrDefault() => _value ?? default;
// }
// 4.Reference Type Constraint
// To restrict T to reference types (classes):


// public class Repository<T> where T : class
// {
//    public void Save(T entity)
//    {
//        Console.WriteLine("Saving entity...");
//    }
// }
// 5.Default Constructor Constraint
// To ensure T has a parameterless constructor:


// public class Factory<T> where T : new()
// {
//    public T CreateInstance()
//    {
//        return new T();
//    }
// }

// Usage
// var factory = new Factory<Book>();
// var book = factory.CreateInstance();
// Conclusion
// Generics eliminate code duplication and improve performance.
// Built-in generic collections in .NET (List<T>, Dictionary<TKey, TValue>) should be used in most cases.
// Generic constraints help enforce type safety.
// In professional development, you mostly use generics rather than creating them.