using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.PrototypePattern
{
    internal interface IPrototype
    {
        /// <summary>
        /// A fulle copy of an object.
        /// Also known as deep copy.
        /// </summary>
        /// <returns></returns>
        IPrototype Clone();
    }
}
