using CreationalPatterns.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactory.Factories
{
    internal class Factory : IAbstractFactory
    {
        public IProductA MakeProductA()
        {
            return new ProductA();
        }

        public IProductB MakeProductB()
        {
            return new ProductB();
        }
    }
}
