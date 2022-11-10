using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.InputHandler
{
    internal class InputCollection
    {
        private Dictionary<ConsoleKey, List<ICommand>> _commandsByConsoleKey;


        public InputCollection()
        {
            _commandsByConsoleKey = new Dictionary<ConsoleKey, List<ICommand>>();
        }

        public void AddCommand(ConsoleKey consolKey, ICommand command)
        {
            if (_commandsByConsoleKey.ContainsKey(consolKey) == false)
            {
                _commandsByConsoleKey.Add(consolKey, new List<ICommand>());
            }

            _commandsByConsoleKey[consolKey].Add(command);
        }

        public List<ICommand> GetCommands(ConsoleKey consoleKey)
        {
            return _commandsByConsoleKey[consoleKey];
        }
      
    }
}
