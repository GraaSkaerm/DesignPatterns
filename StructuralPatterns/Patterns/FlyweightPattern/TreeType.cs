using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructualPatterns.FlyweightPattern
{
   
    /// <summary>
    /// Flyweight
    /// </summary>
    internal class TreeType
    {
        public string Type { get; private set; }
        public string Color { get; private set; }

        public TreeType(string type, string color)
        {
            Type = type;
            Color = color;
        }

        public void Print()
        {
            Console.WriteLine($"Type: {Type} Color: {Color}");
        }
    }
}
