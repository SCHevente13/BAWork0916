using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int Point { get; set; }
        public Student(string everythingDividedBySemicolon)
        {
            string[] data = everythingDividedBySemicolon.Split(';');
            Name = data[0];
            Class = data[1];
            Point = int.Parse(data[2]);
        }
        public override string ToString()
        {
            return $"Name: {Name} | Class: {Class} | Point: {Point}";
        }
    }
}
