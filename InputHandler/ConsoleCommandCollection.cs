using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /// <summary>
    /// Flyweight console command collection
    /// https://refactoring.guru/design-patterns/command
    /// </summary>
    internal class ConsoleCommandCollection
    {
        private Dictionary<ConsoleKey, CommandCollection> _commandsByConsoleKey;

        public ConsoleCommandCollection()
        {
            _commandsByConsoleKey = new Dictionary<ConsoleKey, CommandCollection>();
        }

        public void AddCommand(ConsoleKey consoleKey, ICommand command)
        {
            if (_commandsByConsoleKey.ContainsKey(consoleKey) == false)
            {
                CommandCollection commandCollection = new CommandCollection();
                commandCollection.AddCommand(command);
                _commandsByConsoleKey.Add(consoleKey, commandCollection);
                return;
            }

            _commandsByConsoleKey[consoleKey].AddCommand(command);
        }


        public void RemoveCommand(ConsoleKey consoleKey, ICommand command)
        {
            if (_commandsByConsoleKey.ContainsKey(consoleKey) == false) return;
            _commandsByConsoleKey[consoleKey].RemoveCommand(command);
        }

        public void Invoke(ConsoleKey consoleKey)
        {
            if (_commandsByConsoleKey.ContainsKey(consoleKey) == false) return;
            _commandsByConsoleKey[consoleKey].Invoke();
        }
    }
}
