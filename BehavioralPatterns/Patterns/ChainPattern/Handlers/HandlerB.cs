using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainPattern.Handlers
{
    internal class HandlerB : BaseHandler
    {

        public override object Handle(object obj)
        {
            if ((obj as string) == "B")
            {
                return "HandlerB handled the object";
            }

            return base.Handle(obj);
        }
    }
}
