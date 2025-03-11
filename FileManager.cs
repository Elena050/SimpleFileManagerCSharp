using System;
using Sysrem.IO;

class FileManager
{
    private string currentDirectory;

    public FileManager()
    {
        currentDirectory = Directory.GetCurrentDirectory();
    }

    public void ListFiles()
    {
        Console.WriteLine("Contents of " + currentDirectory);
        foreach (var file in Directory.GetFiles(currentDirectory))
        {
            Console.WriteLine(Path.GetFileName(file));
        }
        foreach (var dir in Directory.GetDirectories(currentDirectory))
        {
            Console.WriteLine(Path.GetFileName(dir));
        }
    }

    public void ChangeDirectory(string newDirectory)
    {
        string path = Path.Combine(currentDirectory, newDirectory);
        if (Directory.Exists(path))
        {
            currentDirectory = path;
            Console.WriteLine("Changed directory to " + currentDirectory);
        }
        else
        {
            Console.WriteLine("Directory not found: " + newDirectory);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        FileManager manager = new FileManager();
        manager.ListFiles();
        manager.ChangeDirectory("folder1");
        manager.ListFiles();
    }
}
