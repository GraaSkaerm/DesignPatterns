using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.BuilderPattern.Products
{
    internal class Product
    {
        private List<string> _parts;

        public Product() { _parts = new List<string>(); }


        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Render()
        {
            foreach (string s in _parts)
            {
                Console.WriteLine(s);
            }
        }
    }
}
