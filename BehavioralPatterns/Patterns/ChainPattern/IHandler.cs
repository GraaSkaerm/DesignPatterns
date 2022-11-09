using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainPattern
{
    internal interface IHandler
    {
        IHandler SetNext(IHandler handler);

        object Handle(object obj);
    }
}
