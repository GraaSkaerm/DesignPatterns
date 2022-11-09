using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructualPatterns.FlyweightPattern
{
    internal class Tree
    {
        public int X { get; set; }
        public int Y { get; set; }
        public TreeType TreeType { get; set; }

        public Tree(int x, int y, TreeType type)
        {
            X = x;
            Y = y;
            TreeType = type;
        }

        
    }
}
