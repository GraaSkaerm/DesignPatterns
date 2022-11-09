using BehavioralPatterns.MomentoPattern.Careatakers;
using BehavioralPatterns.MomentoPattern.Momentos;
using BehavioralPatterns.MomentoPattern.Originators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Examples
{
    internal class MomentoPatternExample
    {
        public void Run()
        {
            Originator o = new Originator();

            Caretaker caretaker = new Caretaker(o);

            o.Name = "A";
            caretaker.BackUp();

            o.Name = "B";
            caretaker.BackUp();

            o.Name = "C";
            caretaker.BackUp();

            o.Name = "D";


            caretaker.Undo();
            caretaker.Undo();

            Console.WriteLine(o.Name);


        }
    }
}
