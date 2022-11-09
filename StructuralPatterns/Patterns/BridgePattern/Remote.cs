using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructualPatterns.BridgePattern
{
    internal class Remote
    {
        private IDevice _device;

        public Remote(IDevice device)
        {
            _device = device;
        }

        public void SetDevice(IDevice device)
        {
            _device = device;
        }

        public void TogglePower()
        {
            if (_device.IsEnabled())
            {
                _device.Disable();
                return;
            }

            _device.Enable();
        }

        public void VolumeUp()
        {
            int volume = _device.GetVolume();
            _device.SetVolume(volume + 1);
        }

        public void VolumeDown()
        {
            int volume = _device.GetVolume();
            _device.SetVolume(volume - 1);
        }
    }
}
