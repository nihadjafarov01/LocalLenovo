namespace ConsoleTask01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 7;
            bool isComposite = false;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isComposite = true;
                    break;
                }
            }
            if (isComposite)
            {
                Console.WriteLine(number + " is composite.");
            }
            else
            {
                Console.WriteLine(number + " is prime.");
            }
        }
    }
}