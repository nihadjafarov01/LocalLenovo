namespace ConsoleTask01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");

            int number = Convert.ToInt32(Console.ReadLine());
            bool isPowerOfTwo = false;
            int powerOfTwo = 0;

            for (int i = 2; i <= number; i *= 2)
            {
                powerOfTwo += 1;

                if (number == i)
                {
                    isPowerOfTwo = true;
                    break;
                }
            }
            if (isPowerOfTwo)
            {
                Console.WriteLine(number + " is 2 to power of " + powerOfTwo);
            }
            else
            {
                Console.WriteLine(number + " is not power of 2");
            }
        }
    }
}