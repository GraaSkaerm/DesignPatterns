using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.MediatorPattern.Components
{
    internal class ComponentA : Component
    {
        public void OnClick()
        {
            Console.WriteLine("Clicking...");
            Mediator.Notify(this, "onClick");
        }

        public void OnTick()
        {
            Console.WriteLine("Ticking...");
            Thread.Sleep(1000);

            Mediator.Notify(this, "onTick");
        }

    }
}
