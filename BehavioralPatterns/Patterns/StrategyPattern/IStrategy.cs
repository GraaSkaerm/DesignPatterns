using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.StrategyPattern
{
    internal interface IStrategy
    {
        object DoAlgorithm(object data);
    }
}
