using BehavioralPatterns.CommandPattern;
using BehavioralPatterns.CommandPattern.Commands;
using BehavioralPatterns.CommandPattern.Recievers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Examples
{
    internal class CommandPatternExample
    {
        public void Run()
        {
            Invoker invoker = new Invoker();

            invoker.StartCommand = new CommandA(new ReceiverA(), "data(one two three)");
            invoker.FinishCommand = new CommandB();

            invoker.Invoke();
        }
    }
}
