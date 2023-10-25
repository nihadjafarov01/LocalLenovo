using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers.Models
{
    internal class Notebook:Product
    {
        string _brand;
        string _model;
        int _ram;
        int _storage;

        public void GetFullInfo()
        {
            Console.WriteLine($"{Count} {Price} {Brand} {Model} {Ram} {Storage}");
        }

        public Notebook(int count, int price, string model) : base(count, price)
        {
            Model = model;
        }
        public string Brand
        {
            get => _brand;
            set
            {
                if (value.Length > 3 && value.Length < 30)
                {
                    _brand = value;
                }
                else
                {
                    Console.WriteLine("adlarinin uzunluqlari 3-den kicik ve 30-dan boyuk ola bilmez");
                }
            }
        }
        public string Model
        {
            get => _model;
            set
            {
                _model = value;
            }
        }

        public int Ram
        {
            get => _ram;
            set
            {
                if (value > 0 && value <= 128)
                {
                    _ram = value;
                }
                else
                {
                    Console.WriteLine("Ram deyeri 0-dan kicik 128-den boyuk ola bilmez");
                }
            }
        }
        public int Storage
        {
            get => _storage;
            set
            {
                if (value > 0)
                {
                    _storage = value;
                }
                else
                {
                    Console.WriteLine("Storage deyeri 0-dan kicik ola bilmez");
                }
            }
        }
    }
}
