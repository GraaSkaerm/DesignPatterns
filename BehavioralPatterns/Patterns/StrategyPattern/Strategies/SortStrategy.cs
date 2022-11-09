using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.StrategyPattern.Strategies
{
    internal class SortStrategy : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            List<string> collection = (List<string>)data;


            collection.Sort();

            return collection;
        }
    }
}
