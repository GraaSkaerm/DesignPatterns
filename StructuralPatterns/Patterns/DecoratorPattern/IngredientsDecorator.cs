using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructualPatterns.DecoratorPattern
{
    internal class IngredientsDecorator : IPizza
    {
        private IPizza _pizza;
        
        public IngredientsDecorator(IPizza pizzaComponent)
        {
            _pizza = pizzaComponent;
        }

        public virtual string GetDescription()
        {
            return _pizza.GetDescription();
        }
    }
}
