using Test.DTO;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    public class LaptopData
    {
        private string OS;

        public LaptopData(string name)
        {
            OS = name;
        }

        public void ReturnOs()
        {
            Console.WriteLine(OS);
        }
    }
    static void Main(string[] args)
    {

        LaptopData emp = new LaptopData("OS");
        emp.ReturnOs();
        Console.ReadLine();

    }
}


