using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructualPatterns.ProxyPattern
{
    internal class Proxy : IServiceInterface
    {
        private Service _service;

        public Proxy(Service service)
        {
            _service = service;
        }

        public void AwaitAccess()
        {
            Console.WriteLine("Waiting for access to resources...");
            Thread.Sleep(1000);
        }

        public void Run()
        {
            AwaitAccess();

            _service.Run();
        }
    }
}
