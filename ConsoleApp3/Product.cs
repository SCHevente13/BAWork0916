using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Product
    {
        public string Name { get; set; }
        public int OriginalPrice { get; set; }
        public int SalePrice { get; set; }
        public Product(string name, int originalPrice, int salePercentage)
        {
            Name = name;
            OriginalPrice = originalPrice;
            SalePrice = originalPrice * (salePercentage / 100);
        }
    }
}
