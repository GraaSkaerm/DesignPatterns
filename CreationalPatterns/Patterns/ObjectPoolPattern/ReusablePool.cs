using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.ObjectPoolPattern
{
    internal class ReusablePool
    {
        private Stack<Reusable> _reusables = new Stack<Reusable>();
        private int _size;

        public int Size
        {
            get
            {
                return _size;
            }

            set
            {
                _size = value < 0 ? 0 : value;
            }
        }
            
        public Reusable AcquireReusable()
        {
            if (_size == 0) return null;

            lock (_reusables)
            {
                if (_reusables.Count != 0)
                {
                    Reusable reusable = _reusables.Pop();
                    reusable.IsActive = true;
                    return reusable;
                }
            }

            return MakeReusable();
        }

        public void ReleasReusable(Reusable reusable)
        {
            if (reusable == null) return;

            lock (_reusables)
            {
                if (_reusables.Count <= _size)
                {
                    reusable.IsActive = false;
                    _reusables.Push(reusable);
                    return;
                }
            }

            reusable = null;
        }

        protected virtual Reusable MakeReusable()
        {
            return new Reusable();
        }


    }
}
