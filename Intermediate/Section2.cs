namespace Intermediate;

/// <summary>
/// Association between Classes
/// </summary>
public static class Section2
{
    public class PresentationObject
    {
        public int Widht { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicate");
        }
    }

    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }
    }

    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class DbMigrator
    {
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating ...");
        }
    }

    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            _logger.Log("We are installing the application");
        }
    }

    public static void Run()
    {
        Inheritance();
        Composition();
    }

    public static void Inheritance()
    {
        Console.WriteLine("Start -> Inheritance");

        var text = new Text();
        text.Widht = 1;
        text.Copy(); //Output: Object copied to clipboard

        Console.WriteLine("Finish -> Inheritance");
    }

    private static void Composition()
    {
        Console.WriteLine("Start -> Composition");

        var dbMigrator = new DbMigrator(new Logger());

        var logger = new Logger();
        var installer = new Installer(logger);

        dbMigrator.Migrate(); //Output: We are migrating ...

        installer.Install(); //Output: We are installing the application

        Console.WriteLine("Finish -> Composition");
    }
}