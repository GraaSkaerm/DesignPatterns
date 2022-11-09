using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructualPatterns.FacadePattern.Systems
{
    internal class MakeTheTableReady
    {
        public void PlacePlates()
        {
            Console.WriteLine("Plates are placed");
        }

        public void PlaceForks()
        {
            Console.WriteLine("Forks are placed");
        }

        public void PlaceKnives()
        {
            Console.WriteLine("Knives are placed");
        }
    }
}
