using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructualPatterns.FacadePattern.Systems
{
    internal class MakeTheFoodReady
    {
        public void MakeTheDuck()
        {
            Console.WriteLine("Duck is done");

        }

        public void MakeTheGreens()
        {
            Console.WriteLine("Greens are done");

        }

        public void MakeThePotatos()
        {
            Console.WriteLine("Potatos are done");

        }
    }
}
