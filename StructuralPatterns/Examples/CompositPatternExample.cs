using StructualPatterns.CompositPattern;
using StructualPatterns.CompositPattern.Leafs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructualPatterns.Examples
{
    internal class CompositPatternExample
    {
        public void Run()
        {
            Composit c = new Composit();

            c.Add(new Leaf());

            c.OnExecute();

            c.Remove<Leaf>();

            c.OnExecute();
        }
    }
}
