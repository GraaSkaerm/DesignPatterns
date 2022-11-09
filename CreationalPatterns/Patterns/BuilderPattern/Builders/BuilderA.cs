using CreationalPatterns.BuilderPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.BuilderPattern.Builders
{
    internal class BuilderA : IBuilder
    {

        private Product _product = new Product();

        public void BuildPartA()
        {
            _product.Add("Part A");
        }

        public void BuildPartB()
        {
            _product.Add("Part B");
        }

        public void BuildPartC()
        {
            _product.Add("Part C");
        }

        public Product GetProduct()
        {
            Product t = _product;
            _product = new Product();
            return t;
        }

      
    }
}
