using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactory.Products
{
    internal class ProductB : IProductB
    {
        public void Render()
        {
            Console.WriteLine("I am product B!");
        }
    }
}
