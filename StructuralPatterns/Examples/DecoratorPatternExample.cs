using StructualPatterns.DecoratorPattern;
using StructualPatterns.DecoratorPattern.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructualPatterns.Examples
{
    internal class DecoratorPatternExample
    {
        public void Run()
        {
            IPizza pizza = new Pizza();

            Console.WriteLine(pizza.GetDescription());


            pizza = new PeperoniDecorator(pizza);

            Console.WriteLine(pizza.GetDescription());


            pizza = new CheeseDecorator(pizza);

            Console.WriteLine(pizza.GetDescription());
        }
    }
}
