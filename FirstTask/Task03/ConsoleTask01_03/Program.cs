namespace ConsoleTask01_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 6828375;
            int counter = 0;

            for (int i = 1; i <= number; i *= 10)
            {
                counter++;
            }
            Console.WriteLine(number);
            Console.WriteLine(counter);
        }
    }
}