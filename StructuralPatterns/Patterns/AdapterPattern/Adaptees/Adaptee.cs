using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructualPatterns.AdapterPattern.Adaptees
{
    
    internal class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specifik request";
        }
    }
}
