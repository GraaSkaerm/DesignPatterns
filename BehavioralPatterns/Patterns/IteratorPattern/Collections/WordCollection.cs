using BehavioralPatterns.IteratorPattern.Iterators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.IteratorPattern.Collections
{
    internal class WordCollection : BaseIteratorCollection
    {
        private List<string> _words = new List<string>();

        public List<string> Words { get => _words; }

        private bool _direction = false;

        public void ReversDirection()
        {
            _direction = !_direction;
        }

        public void AddWord(string word)
        {
            _words.Add(word);
        }

        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _direction);
        }
    }
}
