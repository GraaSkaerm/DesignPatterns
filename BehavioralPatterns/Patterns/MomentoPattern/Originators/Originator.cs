using BehavioralPatterns.MomentoPattern.Momentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.MomentoPattern.Originators
{
    internal class Originator
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }

        public IMomento Save()
        {
            return new Momento(_name);
        }

        public void Restore(IMomento momento)
        {
            if (momento is not Momento)
            {
                throw new Exception("Momento not valid.");
            }

            _name = momento.GetName();
        }
    }
}
