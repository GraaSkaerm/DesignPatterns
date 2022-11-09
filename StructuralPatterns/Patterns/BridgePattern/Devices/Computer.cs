using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructualPatterns.BridgePattern.Devices
{
    internal class Computer : IDevice
    {
        private int _volume;
        private bool _isEnabled;


        public void Disable()
        {
            _isEnabled = false;
        }

        public void Enable()
        {
            _isEnabled = true;
        }

        public int GetVolume()
        {
            return _volume;
        }

        public void SetVolume(int value)
        {
            _volume = value;
        }


        bool IDevice.IsEnabled()
        {
            return _isEnabled;
        }
    }
}
