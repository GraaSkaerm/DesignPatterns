using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.FactoryMethod
{
    internal abstract class BaseFactory
    {
        public void Render()
        {
            Console.WriteLine("I am rendering ShipFactory");
            IProduct p = MakeProduct();
            p.Render();
        }

        public abstract IProduct MakeProduct();
    }
}
