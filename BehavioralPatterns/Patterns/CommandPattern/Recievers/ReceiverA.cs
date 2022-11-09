using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.CommandPattern.Recievers
{
    internal class ReceiverA
    {
        public void Foo(string data)
        {
            Console.WriteLine($"Receiver is fooing {data}");
        }

        public void Boo(string data)
        {
            Console.WriteLine($"Receiver is booing {data}");
        }
    }
}
