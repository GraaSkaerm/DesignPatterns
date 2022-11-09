using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.SingletonPattern
{
    internal class Singleton
    {

        private static object _lock = new object();
        private static Singleton? _instance;
        
        public string Name { get; set; }
        public static Singleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }

                    return _instance;
                }       
            }
        }

        private Singleton()
        {
            Name = "Singleton";
        }
    }
}
