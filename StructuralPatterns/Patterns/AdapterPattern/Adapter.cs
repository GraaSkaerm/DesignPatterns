using StructualPatterns.AdapterPattern.Adaptees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructualPatterns.AdapterPattern
{
    internal class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is {_adaptee.GetSpecificRequest()}";
        }
    }
}
