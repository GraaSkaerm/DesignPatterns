using BehavioralPatterns.StrategyPattern;
using BehavioralPatterns.StrategyPattern.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Examples
{
    internal class StrategyPatternExample
    {
        public void Run()
        {
            Context context = new Context(new SortStrategy());

            context.RunAlgorithm();

            Console.WriteLine("----");

            context.SetStrategy(new SortAndReverseStrategy());
            context.RunAlgorithm();



        }
    }
}
