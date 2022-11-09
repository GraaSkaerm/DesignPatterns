using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.StatePattern.States
{
    internal class InitializeState : State
    {
        public override void OnExecute()
        {
            Console.WriteLine("Initializing");
            Context.SetState(new AwaitingInputState());
        }
    }
}
