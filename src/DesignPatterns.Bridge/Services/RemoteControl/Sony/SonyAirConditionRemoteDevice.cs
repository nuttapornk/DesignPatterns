using System;

namespace DesignPatterns.Bridge.Services.RemoteControl.Sony
{
    public class SonyAirConditionRemoteDevice : IDevice
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
            Console.WriteLine($"Sony : AirCondition temperature down.");
        }

        public void TemperatureUp()
        {
            Console.WriteLine($"Sony : AirCondition temperature up.");
        }

        public void TrunOff()
        {
            Console.WriteLine($"Sony : AirCondition trun on.");
        }

        public void TrunOn()
        {
            Console.WriteLine($"Sony : AirCondition trun on.");
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
