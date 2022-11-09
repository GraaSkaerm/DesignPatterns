using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainPattern.Handlers
{
    internal class HandlerA : BaseHandler
    {
        public override object Handle(object obj)
        {
            if ((obj as string) == "A")
            {
                return "HandlerA handled the object";
            }

            return base.Handle(obj);
        }
    }
}
