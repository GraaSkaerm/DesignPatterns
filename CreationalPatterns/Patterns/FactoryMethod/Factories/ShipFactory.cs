using CreationalPatterns.FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.FactoryMethod.Factories
{
    internal class ShipFactory : BaseFactory
    {
        public override IProduct MakeProduct()
        {
            return new Ship();
        }
    }
}
