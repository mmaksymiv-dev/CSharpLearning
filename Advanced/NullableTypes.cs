namespace Advanced;

public static class NullableTypes
{
    public static void Run()
    {
        Console.WriteLine("Start -> Nullable Types");

        //Nullable<DateTime> date = null;
        DateTime? date = null;

        Console.WriteLine("GetValueOrDefault(): " + date.GetValueOrDefault()); //Output: 1/1/0001 12:00:00 AM
        Console.WriteLine("HasValue: " + date.HasValue); //Output: false 
        //Console.WriteLine("Value: " + date.Value); //Erorr

        DateTime? date1 = new DateTime(2025, 1, 1);
        DateTime date2 = date1.GetValueOrDefault();

        Console.WriteLine(date2); //Output: 1/1/2025 12:00:00 AM

        DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;

        Console.WriteLine("Finish -> Nullable Types");
    }
}
