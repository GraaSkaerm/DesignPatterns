using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.InputHandler
{
    internal class InputInvoker
    {
        private InputCollection _inputCollection;

        public InputInvoker(InputCollection inputCollection)
        {
            _inputCollection = inputCollection;
        }

        public void InvokeInputAsyncLoop()
        {
            new Thread(() =>
            {
                while (true)
                {

                    if (Console.KeyAvailable == false) continue;
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    ConsoleKey consoleKey = keyInfo.Key;

                    List<ICommand> commands = _inputCollection.GetCommands(consoleKey);

                    foreach (ICommand command in commands)
                    {
                        command.Execute();
                    }
                }
            }).Start();
        }

    }
}
