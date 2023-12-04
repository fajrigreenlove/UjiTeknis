using System.IO;
using Test2.DTO;
using static System.Net.Mime.MediaTypeNames;

class Program
{
   
    static void Main(string[] args)
    {
        var application = new ApplicationInfo
        {
            Path = "C:/apps/",
            Name = "Shield.exe"
        };

        Console.WriteLine($"{application.Path}, {application.Name}");

    }
}

