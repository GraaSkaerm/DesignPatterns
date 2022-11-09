using BehavioralPatterns.CommandPattern.Recievers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.CommandPattern.Commands
{
    internal class CommandA : ICommand
    {
        private ReceiverA _reciever;
        private string _data;

        public CommandA(ReceiverA receiver, string data)
        {
            _reciever = receiver;
            _data = data;
        }

        public void Execute()
        {
            Console.WriteLine("CommandA executing");
            _reciever.Foo(_data);
            _reciever.Boo(_data);
        }
    }
}
