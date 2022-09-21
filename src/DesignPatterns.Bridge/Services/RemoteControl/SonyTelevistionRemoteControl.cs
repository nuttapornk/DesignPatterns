using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.Services.RemoteControl
{
    public class SonyTelevistionRemoteControl : TelevistionRemoteControl
    {
        public SonyTelevistionRemoteControl(IDevice device) : base(device)
        {
        }

        public void OpenYoutube()
        {
            _device.OpenApp("Youtube");
        }
    }
}
