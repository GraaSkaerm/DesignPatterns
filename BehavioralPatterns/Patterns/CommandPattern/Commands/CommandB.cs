using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.CommandPattern.Commands
{
    internal class CommandB : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("CommandB executing");
        }
    }
}
