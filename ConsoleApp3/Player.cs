using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Point { get; set; }
        public Player(string name)
        {
            Name = name;
            Level = 1;
            Point = 0;
        }
        public Player(string name, int level, int point)
        {
            Name = name;
            Level = level;
            Point = point;
        }
    }
}
