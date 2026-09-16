using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3
{
    internal class Film
    {
        public string Title { get; set; }
        public double Rating { get; set; }
        public bool Recommended { get; set; }
        public Film(string title, double rating)
        {
            Title = title; 
            Rating = rating;
            if (rating >= 7)
            {
                Recommended = true;
            }
            else
            {
                Recommended = false;
            }
        }
        public override string ToString()
        {
            return $"Title: {Title} | Rating: {Rating} | Recommended: {Recommended}";
        }
    }
}
