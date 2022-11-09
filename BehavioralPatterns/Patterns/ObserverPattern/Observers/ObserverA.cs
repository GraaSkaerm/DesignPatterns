using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ObserverPattern.Observers
{
    internal class ObserverA : IObserver
    {
        public void OnNotify()
        {
            Console.WriteLine("ObserverA is notified");
        }
    }
}
