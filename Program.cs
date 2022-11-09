
using BehavioralPatterns.Examples;
using CreationalPatterns.Examples;
using StructualPatterns.Examples;

namespace DesignPatterns
{
 
    internal class Program
    {
        public static void Main()
        {
            new AbstractFactoryExample().Run();
            new ChainPatternExample().Run();
            new CompositPatternExample().Run();
        }
    }
}