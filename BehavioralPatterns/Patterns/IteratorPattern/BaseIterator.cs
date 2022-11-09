using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.IteratorPattern
{
    internal abstract class BaseIterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        public abstract object Current();

        public abstract int Index();

        public abstract bool MoveNext();

        public abstract void Reset();
    }
}
