using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.MediatorPattern.Components
{
    internal class ComponentB : Component
    {
        public void OnUpdate()
        {
            Console.WriteLine("Updating...");
        }

        public void OnRender()
        {
            Console.WriteLine("Rendering...");
            Mediator.Notify(this, "onRender");
        }
    }
}
