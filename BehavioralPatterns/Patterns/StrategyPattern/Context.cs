using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.StrategyPattern
{
    internal class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void RunAlgorithm()
        {
            List<string> data = new List<string>() { "A", "B", "C", };

            var resualt = _strategy.DoAlgorithm(data);

            foreach (var i in resualt as List<string>)
            {
                Console.WriteLine(i);
            }
        }
        
        
    }
}
