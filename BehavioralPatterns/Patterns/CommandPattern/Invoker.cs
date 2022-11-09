using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.CommandPattern
{
    internal class Invoker
    {
        private ICommand _startCommand;
        private ICommand _finishCommand;

        public ICommand StartCommand { set => _startCommand = value; }
        public ICommand FinishCommand { set => _finishCommand = value; }

        public void Invoke()
        {
            if (_startCommand is ICommand)
            {
                _startCommand.Execute();
            }

            if (_finishCommand is ICommand)
            {
                _finishCommand.Execute();
            }
        }
    }
}
