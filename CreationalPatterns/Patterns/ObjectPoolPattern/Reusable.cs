using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.ObjectPoolPattern
{
    internal class Reusable
    {
        public bool IsActive { get; set; } = true;
        public string Name { get; set; }
    }
}
