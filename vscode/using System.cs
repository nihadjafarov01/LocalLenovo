using System.ComponentModel;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            int number = 7;
            bool state = false;

            for (int i = 2; i <7; i++)
            {
               if (number % i == 0)
               {
                   state = true;
                   break;
               }
            }
            Console.WriteLine(state);
            //1

            ////2
            //Console.WriteLine("Eded daxil edin: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool state = false;

            //for (int i = 2; i <= number; i *= 2)
            //{
            //    if (number == i)
            //    {
            //        state = true;
            //    }
            //}
            //Console.WriteLine(state);
            ////2

            ////3
            //int number = 6828375;
            //int counter = 0;

            //for (int i = 1; i <= number; i *= 10)
            //{
            //    counter++;
            //}
            //Console.WriteLine(counter);
            ////3
        }
    }
}