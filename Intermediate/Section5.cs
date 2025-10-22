namespace Intermediate;

/// <summary>
/// Interfaces
/// </summary>
public static class Section5
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public Shipment Shipment { get; set; }
        public float TotalPrice { get; set; }

        public bool IsShipped
        {
            get { return Shipment != null; }
        }
    }

    public class Shipment
    {
        public float Cost { get; set; }
        public DateTime ShippingDate { get; set; }
    }

    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }

    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            return 0;
        }
    }

    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed.");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }

    //////////////////////////////////////////////////////////////////////////////////////
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }

    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migrationg started at {0}" + DateTime.Now);

            // Details of migrating the database

            _logger.LogInfo("Migrationg finished at {0}" + DateTime.Now);
        }
    }

    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }
    }

    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }

    //////////////////////////////////////////////////////////////////////////

    public class Message
    {
    }

    public class Video
    {
    }

    public interface INotificationChannel
    {
        void Send(Message message);
    }

    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending mail...");
        }
    }

    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS...");
        }
    }

    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;

        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            // Video encoding logic     
            // ...

            foreach (var channel in _notificationChannels)
                channel.Send(new Message());
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }

    public static void Run()
    {
        InterfacesAndTestability();
        InterfacesAndExtensibility();
        InterfacesAndPolymorphism();
    }

    private static void InterfacesAndTestability()
    {
        Console.WriteLine("Start -> Interfaces and Testability");

        var orderProcessor = new OrderProcessor(new ShippingCalculator());
        var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
        orderProcessor.Process(order);

        Console.WriteLine("Finish -> Interfaces and Testability");
    }

    private static void InterfacesAndExtensibility()
    {
        Console.WriteLine("Start -> Interfaces and Extensibility");

        var dbMigrator = new DbMigrator(new FileLogger("C:\\Projects\\log.txt"));
        dbMigrator.Migrate();

        Console.WriteLine("Finish -> Interfaces and Extensibility");
    }

    private static void InterfacesAndPolymorphism()
    {
        Console.WriteLine("Start -> Interfaces and Polymorphism");

        var encoder = new VideoEncoder();
        encoder.RegisterNotificationChannel(new MailNotificationChannel());
        encoder.RegisterNotificationChannel(new SmsNotificationChannel());
        encoder.Encode(new Video());

        Console.WriteLine("Finish -> Interfaces and Polymorphism");
    }
}