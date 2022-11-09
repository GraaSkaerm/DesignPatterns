using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructualPatterns.DecoratorPattern
{
    /// <summary>
    /// The concrete component
    /// </summary>
    internal class Pizza : IPizza
    {
        public string GetDescription()
        {
            return "Ingredients: ";
        }
    }
}
