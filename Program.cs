
using BehavioralPatterns.Examples;
using CreationalPatterns.Examples;
using DesignPatterns.InputHandler;
using StructualPatterns.Examples;

namespace DesignPatterns
{
    internal class PrintCommand : ICommand
    {
        private string _message;

        public PrintCommand(string message)
        {
            _message = message;
        }

        public void Execute()
        {
            Console.WriteLine(_message);
        }
    }


    internal class Program
    {
        public static void Main()
        {


            InputCollection collection = new InputCollection();
            collection.AddCommand(ConsoleKey.J, new PrintCommand("J"));
            collection.AddCommand(ConsoleKey.K, new PrintCommand("K"));
            InputInvoker inputInvoker = new InputInvoker(collection);

            inputInvoker.InvokeInputAsyncLoop();


            while (true)
            {

            }

            //new AbstractFactoryExample().Run();
            //new ChainPatternExample().Run();
            //new CompositPatternExample().Run();
        }
    }
}