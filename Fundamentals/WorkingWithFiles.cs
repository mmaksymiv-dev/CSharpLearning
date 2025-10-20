namespace Fundamentals;

public static class WorkingWithFiles
{
    public static void Start()
    {
        FileAndFileInfo();
        DirectoryAndDirectoryInfo();
        Paths();
    }

    /// <summary>
    /// File and FileInfo
    /// </summary>
    private static void FileAndFileInfo()
    {
        var path = @"";
        File.Copy(@"", @"", true);
        File.Delete(path);

        if (File.Exists(path))
        {

        }

        var content = File.ReadAllText(path);

        var fileInfo = new FileInfo(path);
        fileInfo.CopyTo("...");
        fileInfo.Delete();

        if (File.Exists(path))
        {
            //
        }
    }

    /// <summary>
    /// Directory and DirectoryInfo
    /// </summary>
    private static void DirectoryAndDirectoryInfo()
    {
        Directory.CreateDirectory("");

        var directories = Directory.GetDirectories("", "*.*", SearchOption.AllDirectories);
        foreach (var d in directories)
            Console.WriteLine(d);

        Directory.Exists("...");

        var directoryInfo = new DirectoryInfo("...");
        directoryInfo.GetFiles();
        directoryInfo.GetDirectories();
    }

    /// <summary>
    /// Paths
    /// </summary>
    private static void Paths()
    {
        var path = @"";
        var dotIndex = path.IndexOf(".");
        var extension = path.Substring(dotIndex);

        Console.WriteLine("Extension: " + Path.GetExtension(path));
        Console.WriteLine("File Name: " + Path.GetFileName(path));
        Console.WriteLine("File Name without  Extension: " + Path.GetFileNameWithoutExtension(path));
        Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
    }
}
