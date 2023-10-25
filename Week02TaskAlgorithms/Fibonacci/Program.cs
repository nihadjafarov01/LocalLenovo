namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eded = 378;
            int n_2 = 0;
            int n_1 = -1;
            int n = 1;
            while (n < eded)
            {
                n_2 = n_1;
                n_1 = n;
                n = n_2 + n_1;
                Console.WriteLine(n);
            }

        }
    }
}