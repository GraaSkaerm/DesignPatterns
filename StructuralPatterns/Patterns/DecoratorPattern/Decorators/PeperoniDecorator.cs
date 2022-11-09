using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructualPatterns.DecoratorPattern.Decorators
{
    internal class PeperoniDecorator : IngredientsDecorator
    {
        public PeperoniDecorator(IPizza pizza) : base(pizza)
        {
        }


        public override string GetDescription()
        {
            return base.GetDescription() + "peperoni, ";
        }

    }
}
