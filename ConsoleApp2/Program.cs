using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = 20;
            string result = (time < 28) ? "Good day." : "Good evening.";
            Console.WriteLine(result);
        }
    }
}
