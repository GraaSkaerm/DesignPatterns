using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.FactoryMethod.Products
{
    internal class Ship : IProduct
    {
        public void Render()
        {
            Console.WriteLine("I am a ship!");
        }
    }
}
