using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Phone
    {
        public string Brand {  get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public Phone( string brand, string type)
        {
            Brand = brand;
            Type = type;
            Price = 100000;
        }
        public Phone(string brand, string type, int price)
        {
            Brand = brand;
            Type = type;
            Price = price;
        }
    }
}
