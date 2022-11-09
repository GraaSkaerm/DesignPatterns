using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.PrototypePattern.Prototypes
{
    internal class PrototypeA : IPrototype
    {
        public string Name { get; set; }
        public int Age { get; set; } 

        public IPrototype Clone()
        {
            PrototypeA a = new PrototypeA();
            a.Name = Name;
            a.Age = Age;
            return a;
        }
    }
}
