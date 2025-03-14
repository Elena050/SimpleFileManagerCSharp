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
    public void InfoAboutDirectory(string newDirectory)
    {
        string path = Path.Combine(currentDirectory, newDirectory);
        if (Directory.Exists(path))
        {
        currentDirectory = path;

        Console.WriteLine($"Название каталога: {path.Name}");
        Console.WriteLine($"Дата создания каталога: {path.CreationDate}");
        Console.WriteLine($"Размер каталога: {path.Lenght}");
        Console.WriteLine($"Время последнего изменения каталога: {path.LastWriteTime}")
        }
    }

    public void InfoAboutFile(string NewFile)
    {
        string path = path.Combine(currentFile, newFile);
        if (File.Exists(path))
        {
            currentFile = path;

            Console.WriteLine($"Название файла: {path.Name}");
            Console.WriteLine($"Дата создания файла: {path.CreationDate}");
            Console.WriteLine($"Дата последнего изменения файла: {path.LastWriteDate}");
            Console.WriteLine($"Атрибуты файла: {path.Attributes}")4
        }
    }

    public void CopyFile(string path, string newpath, string fileInf)
    {
        FileInfo fileInf = new FileInfo(path);

        if (fileInf.Exists)
        {
            fileInf.CoptTo(newpath, true);
        }
    }

    public void CopyDirectory(string Directory, string path, string newpath)
    {
       DirectoryInfo dirInf = new DirectoryInfo(path);

       if (dirInf.Exists)
       {
        DirectoryInfo[] dirs = dirInf.GetDirectories();
        Directory.CreateDirectory(newpath);
        foreach (FileInfo file in dirInf.GetFiles())
        {
            string targetFilePath = Path.Combine(newpath, file.Name);
            file.CopyTo(targetFilePath);
        }
       }
    }

    public void DeleteDirectory(string path)
    {
        DirectoryInfo dirInf = new DirectoryInfo(path);

        if (dirInf.Exists()):
        {
            dirInf.Delete(true);
            Console.WriteLine("Каталог удален");
        }

        esle
        {
            Console.WriteLine("Каталога не существует");
        }
    }

    public void DeleteFile(string path)
    {
        FileInfo fileInf = new FileInfo(path);
        if (fileInf.Exists)
        {
            ileInf.Delete();
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
