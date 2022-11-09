using BehavioralPatterns.ChainPattern.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Examples
{
    internal class ChainPatternExample
    {

        public void Run()
        {
            var a = new HandlerA();
            var b = new HandlerB();
            var c = new HandlerC();

            a.SetNext(b).SetNext(c);

            string x = (string)a.Handle("B");
            string y = (string)a.Handle("A");
            string z = (string)a.Handle("C");

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
          
        }
    }
}
