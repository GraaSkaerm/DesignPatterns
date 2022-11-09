using BehavioralPatterns.MediatorPattern.Components;
using BehavioralPatterns.MediatorPattern.Mediators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Examples
{
    internal class MediatorPatternExample
    {
        public void Run()
        {
            ComponentA a = new ComponentA();
            ComponentB b = new ComponentB();

            Mediator m = new Mediator(a, b);

            a.OnClick();

            Console.ReadLine();
        }
    }
}
