using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ObserverPattern
{
    internal class Notifier
    {
        public List<IObserver> Observers { get; set; } = new List<IObserver>();

        public void Invoke()
        {
            foreach (var i in Observers)
            {
                i.OnNotify();
            }
        }
    }
}
