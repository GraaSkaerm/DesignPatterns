using BehavioralPatterns.MediatorPattern.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.MediatorPattern.Mediators
{
    internal class Mediator : IMediator
    {
        private ComponentA _a;
        private ComponentB _b;


        public Mediator(ComponentA a, ComponentB b)
        {
            _a = a;
            _b = b;

            _a.Mediator = this;
            _b.Mediator = this;
        }


        public void Notify(Component sender, string eventName)
        {
            if (eventName == "onClick")
            {
                _b.OnUpdate();
                _b.OnRender();
            }

            if (eventName == "onRender" || eventName == "onTick")
            {
                _a.OnTick();
            }
        }
    }
}
