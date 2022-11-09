using CreationalPatterns.AbstractFactory.Factories;
using CreationalPatterns.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Examples
{
    public class AbstractFactoryExample
    {
        public void Run()
        {
            Factory f = new Factory();

            ProductA a = (ProductA)f.MakeProductA();
            ProductB b = (ProductB)f.MakeProductB();


            a.Render();
            b.Render();
        }
    }
}
