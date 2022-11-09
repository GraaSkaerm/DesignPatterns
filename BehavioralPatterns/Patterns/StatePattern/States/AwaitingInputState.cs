using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.StatePattern.States
{
    internal class AwaitingInputState : State
    {
        public override void OnExecute()
        {
            Console.WriteLine("Waiting for input");
        }
    }
}
