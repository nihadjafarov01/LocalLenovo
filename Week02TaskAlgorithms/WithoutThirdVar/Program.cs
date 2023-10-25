namespace withoutThird
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12;  // a = 47
            int b = 47;  // b = 12

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}