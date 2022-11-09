using BehavioralPatterns.IteratorPattern.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.IteratorPattern.Iterators
{
    internal class AlphabeticalOrderIterator : BaseIterator
    {
        private WordCollection _wordCollection;
        private bool _direction;
        private int _index = -1;

        public AlphabeticalOrderIterator(WordCollection wordCollection, bool direction)
        {
            _wordCollection = wordCollection;
            _direction = direction;

            if (_direction == true)
            {
                _index = _wordCollection.Words.Count;
            }
        }

        public override object Current()
        {
            return _wordCollection.Words[_index];
        }

        public override int Index()
        {
            return _index;
        }

        public override bool MoveNext()
        {
            int nextIndex = _index + (_direction ? -1 : 1);

            if (nextIndex >= 0 && nextIndex < _wordCollection.Words.Count)
            {
                _index = nextIndex;
                return true;
            }

            return false;
        }

        public override void Reset()
        {
            _index = _direction ? _wordCollection.Words.Count - 1 : 0;
        }
    }
}
