using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.StatePattern
{
    internal class Context
    {
        private State _currentState;
        private State _prevState;


        public Context(State state)
        {
            _currentState = state;
        }

        public void SetState(State state)
        {
            _currentState = state;
            _currentState.Context = this;
        }

        public void Run()
        {
            while (true)
            {
                _prevState = _currentState;
                _currentState.OnEnter();

                while (_prevState == _currentState)
                {
                    _currentState.OnExecute();
                }

                _currentState.OnExit();
            }
        }
    }
}
