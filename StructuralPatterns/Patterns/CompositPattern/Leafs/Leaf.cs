using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructualPatterns.CompositPattern.Leafs
{
    internal class Leaf : IComponent
    {
        public void OnExecute()
        {
            Console.WriteLine("Executing leaf component");
        }
    }
}
