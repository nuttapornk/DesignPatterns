using DesignPatterns.Bridge.Services.RemoteControl.Samsung;
using System.Linq;

namespace DesignPatterns.Bridge.Services.RemoteControl
{
    public class SamsungTelevistionRemoteControl : TelevistionRemoteControl
    {
        public SamsungTelevistionRemoteControl(IDevice device) : base(device)
        {
            VerifyDevice();            
        }

        private void VerifyDevice()
        {
            if (_device.GetType() != typeof(SamsungTelevisionRemoteDevice))
            {
                throw new System.Exception($"{_device.GetType().ToString().Split('.').Last()} not supported");
            }
        }

        public void OpenYoutube()
        {
            _device.OpenApp("Youtube");
        }

        public void OpenNetflix()
        {
            _device.OpenApp("Netflix");
        }

    }
}
