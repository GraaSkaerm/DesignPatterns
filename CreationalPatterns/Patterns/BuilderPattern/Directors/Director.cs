using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.BuilderPattern.Directors
{
    internal class Director
    {
        private IBuilder? _builder;

        public  IBuilder Builder { set => _builder = value; }


        public void BuildMinimalViableProduct()
        {
            if (_builder == null) return;
            _builder.BuildPartA();
        }

        public void BuildFullFeaturedProduct()
        {
            if (_builder == null) return;
            _builder.BuildPartA();
            _builder.BuildPartB();
            _builder.BuildPartC();
        }

    }
}
