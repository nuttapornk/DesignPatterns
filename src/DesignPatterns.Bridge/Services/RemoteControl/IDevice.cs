using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.Services.RemoteControl
{
    public interface IDevice
    {
        void TrunOn();
        void TrunOff();
        void SetChannel(int number);
        void VolumnUp();
        void VolumnDown();
        void TemperatureUp();
        void TemperatureDown();
        void OpenApp(string appName);
    }
}
