namespace Advanced;

/// <summary>
/// Delegates
/// </summary>
public static class Delegates
{
    public class Photo
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }

        public void Save()
        {
        }
    }

    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);
        //System.Action<>
        //System.Func<>

        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }

        public void Process(string path, Action<Photo> action)
        {
            var photo = Photo.Load(path);

            action(photo);

            photo.Save();
        }
    }

    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }

        public void ApplayContrast(Photo photo)
        {
            Console.WriteLine("Applay contrast");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize photo");
        }
    }

    public static void Run()
    {
        Console.WriteLine("Start -> Delegates");

        var processor = new PhotoProcessor();
        var filters = new PhotoFilters();

        PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
        filterHandler += filters.ApplayContrast;
        filterHandler += filters.Resize;
        filterHandler += RemoveRedEyeFilter;
        processor.Process("photo.jpg", filterHandler);

        Action<Photo> action = filters.ApplyBrightness;
        action += filters.ApplayContrast;
        action += filters.Resize;
        action += RemoveRedEyeFilter;
        processor.Process("photo.jpg", action);

        Console.WriteLine("Finish -> Delegates");
    }

    static void RemoveRedEyeFilter(Photo photo)
    {
        Console.WriteLine("Applay RemoveRedEye");
    }
}
