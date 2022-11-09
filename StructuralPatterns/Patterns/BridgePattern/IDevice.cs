using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructualPatterns.BridgePattern
{
    internal interface IDevice
    {
        bool IsEnabled();
        void Enable();
        void Disable();

        void SetVolume(int value);
        int GetVolume();
    }
}
