using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class CommandCollection
    {
        private List<ICommand> _commands;

        public CommandCollection()
        {
            _commands = new List<ICommand>();
        }

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void RemoveCommand(ICommand command)
        {
            _commands.Remove(command);
        }

        public void Invoke()
        {
            foreach (ICommand command in _commands)
            {
                command.Execute();
            }
        }

        public bool HasCommand(ICommand command)
        {
            return _commands.Contains(command);
        }
    }
}
