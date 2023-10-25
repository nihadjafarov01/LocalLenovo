namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, -2, 3, -4, -5, 6, -7 };
            ConvertToPositive(ref array);
        }
        static void ConvertToPositive(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = -array[i];
                }
                Console.WriteLine(array[i]);
            }
        }
    }
}