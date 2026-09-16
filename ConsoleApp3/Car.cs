using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Car
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public int Year { get; set; }
        public int Age { get; set; }
        public Car(string brand, string type, int year)
        {
            Brand = brand;
            Type = type;
            Year = year;
            Age = 2026 - year;
        }
    }
}
