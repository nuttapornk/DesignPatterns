using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.Services.RemoteControl.Samsung
{
    public class SamsungAirConditionRemoteDevice : IDevice
    {
        public void OpenApp(string appName)
        {
            throw new NotImplementedException();
        }

        public void SetChannel(int number)
        {
            throw new NotImplementedException();
        }

        public void TemperatureDown()
        {
            Console.WriteLine($"Samsung : AirCondition temperature down.");
        }

        public void TemperatureUp()
        {
            Console.WriteLine($"Samsung : AirCondition temperature up.");
        }

        public void TrunOff()
        {
            Console.WriteLine($"Samsung : AirCondition trun on.");
        }

        public void TrunOn()
        {
            Console.WriteLine($"Samsung : AirCondition trun on.");
        }

        public void VolumnDown()
        {
            throw new NotImplementedException();
        }

        public void VolumnUp()
        {
            throw new NotImplementedException();
        }
    }
}
