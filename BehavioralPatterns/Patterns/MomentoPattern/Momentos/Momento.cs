using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.MomentoPattern.Momentos
{
    internal class Momento : IMomento
    {
        private string _name;

        public Momento(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
