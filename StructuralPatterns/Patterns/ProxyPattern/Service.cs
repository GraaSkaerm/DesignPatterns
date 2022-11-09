using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructualPatterns.ProxyPattern
{
    internal class Service : IServiceInterface
    {
        public void Run()
        {
            Console.WriteLine("Concrete service is running");
        }
    }
}
