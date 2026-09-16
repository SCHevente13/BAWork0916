using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Film
    {
        public string Title { get; set; }
        public double Rating { get; set; }
        public bool Recomended { get; set; }
        public Film(string title, double rating)
        {
            Title = title; 
            Rating = rating;
            if (rating >= 7)
            {
                Recomended = true;
            }
            else
            {
                Recomended = false;
            }
        }
    }
}
