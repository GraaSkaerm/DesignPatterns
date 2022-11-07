using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    // TODO: Make dependency injection and inversion
    internal class ConsoleInputHandler
    {
        private bool _handleInput;
        private Thread _handleInputAsyncLoop;
        private ConsoleCommandCollection _consoleCommandCollection;
        
        public ConsoleInputHandler()
        {
            _consoleCommandCollection = new ConsoleCommandCollection();
            _handleInputAsyncLoop = new Thread(HandleInputAsyncLoop);
            _handleInputAsyncLoop.Start();
        }

        private bool IsKeyAvailable()
        {
            return Console.KeyAvailable;
        }

        private ConsoleKeyInfo GetConsoleKeyInfo()
        {
            return Console.ReadKey(true);
        }

        private ConsoleKey GetConsoleKey()
        {
            return GetConsoleKeyInfo().Key;
        }

        private void HandleInput()
        {
            while (_handleInput)
            {
                if (IsKeyAvailable() == false) continue;
                ConsoleKey consoleKey = GetConsoleKey();
                _consoleCommandCollection.Invoke(consoleKey);
            }
        }

        private void HandleInputAsyncLoop()
        {
            while (true)
            {
                HandleInput();
            }
        }

        public void Resume()
        {
            _handleInput = true;
        }

        public void Pause()
        {
            _handleInput = false;
        }



    }
}
