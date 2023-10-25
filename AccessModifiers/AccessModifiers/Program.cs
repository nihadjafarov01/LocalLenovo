using AccessModifiers.Models;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nece noutbook var?");
            int notebookCount = Convert.ToInt32(Console.ReadLine());
            Notebook[] array = new Notebook[notebookCount];

            for (int i = 0; i < notebookCount; i++)
            {
                Console.WriteLine($"Notebook {i + 1}");
                Notebook notebook = new Notebook(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
                Console.Write("Brand: ");
                notebook.Brand = Console.ReadLine();

                //Console.Write("Model: ");
                //notebook.Model = Console.ReadLine();

                Console.Write("RAM: ");
                notebook.Ram = Convert.ToInt32(Console.ReadLine());

                Console.Write("Storage: ");
                notebook.Storage = Convert.ToInt32(Console.ReadLine());

                array[i] = notebook;
                notebook.GetFullInfo();
            }
        }
    }
}
