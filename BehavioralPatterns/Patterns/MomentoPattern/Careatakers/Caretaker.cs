using BehavioralPatterns.MomentoPattern.Momentos;
using BehavioralPatterns.MomentoPattern.Originators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.MomentoPattern.Careatakers
{
    
    internal class Caretaker
    {
        private Stack<IMomento> _momentos = new Stack<IMomento>();

        private Originator _originator;

        public Caretaker(Originator originator)
        {
            _originator = originator;
        }

        public void BackUp()
        {
            Console.WriteLine($"Saving {_originator.Name}");
            _momentos.Push(_originator.Save());
        }

        public void Undo()
        {
            if (_momentos.Count == 0) return;

            Console.WriteLine($"Restoring {_originator.Name}");

            var momento = _momentos.Pop();

            _originator.Restore(momento);
        }

        public void ShowBackUps()
        {
            Console.WriteLine($"Showing safes: ");

            foreach (var i in _momentos)
            {
                Console.WriteLine(i.GetName());
            }
        }
    }
}
