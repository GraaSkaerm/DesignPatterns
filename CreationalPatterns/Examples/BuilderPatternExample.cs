using CreationalPatterns.BuilderPattern.Builders;
using CreationalPatterns.BuilderPattern.Directors;
using CreationalPatterns.BuilderPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Examples
{
    public class BuilderPatternExample
    {
        public void Run()
        {
            Director d = new Director();
            BuilderA b = new BuilderA();

            d.Builder = b;

            d.BuildMinimalViableProduct();

            Product mvp = b.GetProduct();

            d.BuildFullFeaturedProduct();

            Product final = b.GetProduct();

            Console.WriteLine("MVP:");
            mvp.Render();

            Console.WriteLine();
            Console.WriteLine("FINAL:");
            final.Render();


        }
    }
}
