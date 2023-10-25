using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee user = new Employee("Nihad","Jafarov",20);
            Console.WriteLine(user.Username);
            
        }
    }
}