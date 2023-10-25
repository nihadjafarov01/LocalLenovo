namespace ConsoleAppLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //int[] array = { 1, 2, 3, 3, 4, 4, 4, 5, 6, };
            //int counter = 1;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            counter++;
            //            array[j] = 0;
            //        }
            //    }
            //    if (array[i] != 0)
            //    {
            //        Console.WriteLine(array[i] + " -> " + counter + " dene");
            //    }
            //    counter = 1;
            //}
            #endregion

            #region Task2
            Console.WriteLine("Arrayin olcusunu daxil edin: ");
            int lengthOfArray = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[lengthOfArray];

            for (int i = 0; i < lengthOfArray; i++)
            {
                Console.WriteLine("Arraye element elave etmek isteyirsiz? (Yes, yes, Y, y) ");
                string cavab = Console.ReadLine();
                if (cavab == "Yes" || cavab == "yes" || cavab == "Y" || cavab == "y")
                {
                    Console.WriteLine("Element daxil edin: ");
                    int element = Convert.ToInt32(Console.ReadLine());
                    array[i] = element;
                }
                else
                {
                    break;
                }
            }
            for (int j = 0; j < lengthOfArray; j++)
            {
                Console.Write(array[j] + ", ");
            }
            #endregion
            }
    }
    }