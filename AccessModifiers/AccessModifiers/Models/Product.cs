using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers.Models
{
    internal class Product
    {
        public int _count;
        public int _price;

        public Product(int count, int price)
        {
            Count = count;
            Price = price;
        }

        public int Count 
        { 
            get => _count;
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Counta deyer teyin edin!");
                }
                else
                {
                    _count = value;
                }
            }
        }
        public int Price
        {
            get => _price;
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Sisteme elave olunan notebooklarin qiymetleri 0-dan kicik ola bilmez");
                }
            }
        }
    }
}
