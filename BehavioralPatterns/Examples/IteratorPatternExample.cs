using BehavioralPatterns.IteratorPattern.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Examples
{
    internal class IteratorPatternExample
    {
        public void Run()
        {
            var wordCollcetion = new WordCollection();

            wordCollcetion.AddWord("A");
            wordCollcetion.AddWord("B");
            wordCollcetion.AddWord("C");

            Console.WriteLine("Normal go through");

            foreach (var i in wordCollcetion.Words)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Reverse");


            wordCollcetion.ReversDirection();

            foreach (var i in wordCollcetion.Words)
            {
                Console.WriteLine(i);
            }


        }
    }
}
