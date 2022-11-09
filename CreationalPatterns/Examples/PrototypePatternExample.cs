using CreationalPatterns.PrototypePattern.Prototypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Examples
{
    public class PrototypePatternExample
    {
        public void Run()
        {
            var a = new PrototypeA();
            a.Name = "A";

            PrototypeA b = (PrototypeA)a.Clone();

            b.Name = "B";


            Console.WriteLine(a.Name);
            Console.WriteLine(b.Name);


        }
    }
}
