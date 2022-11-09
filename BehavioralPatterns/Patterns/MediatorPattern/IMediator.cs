using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.MediatorPattern
{
    internal interface IMediator
    {
        void Notify(Component sender, string eventName);
    }
}
