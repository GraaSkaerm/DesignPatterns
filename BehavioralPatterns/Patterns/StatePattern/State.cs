using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.StatePattern
{
    internal abstract class State
    {
        public Context Context { protected get; set; }

        public virtual void OnEnter() { }
        public abstract void OnExecute();
        public virtual void OnExit() { }

    }
}
