using Collection;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntList list1 = new IntList();
            list1.Add(1,5,9,1,0);
            //list1.Sort();
            //list1.Print();
            Console.WriteLine(list1.Search(9));
        }
    }
}