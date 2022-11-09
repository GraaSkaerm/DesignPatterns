using CreationalPatterns.FactoryMethod.Factories;
using CreationalPatterns.FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Examples
{
    public class FactoryMethodExample
    {
        public void Run()
        {
            ShipFactory f = new ShipFactory();
            Ship s = (Ship)f.MakeProduct();

            f.Render();
            s.Render();

            Console.ReadLine();
        }
    }
}
