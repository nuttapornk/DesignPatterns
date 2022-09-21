using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.Services.RemoteControl
{
    public class TelevistionRemoteControl
    {
        protected readonly IDevice _device;
        public TelevistionRemoteControl(IDevice device)
        {
            _device = device;
        }

        public void TrunOn()
        { 
            _device.TrunOn();
        }

        public void TrunOff() 
        { 
            _device.TrunOff(); 
        }

        public void SetChannel(int number)
        {
            _device.SetChannel(number);
        }

        public void VolumnDown()
        {
            _device.VolumnDown();
        }

        public void VolumnUp()
        {
            _device.VolumnUp();
        }
    }
}
