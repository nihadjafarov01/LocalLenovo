using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 1, 7, 16, 5, 9 };
            int[] newArray = new int[firstArray.Length];

            for (int i = firstArray.Length - 1; i >= 0; i--)
            {
                newArray[firstArray.Length - 1 - i] = firstArray[i];
            }

            foreach (var item in newArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
