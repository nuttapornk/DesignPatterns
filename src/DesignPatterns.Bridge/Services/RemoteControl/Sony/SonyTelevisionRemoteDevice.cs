using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.Services.RemoteControl.Sony
{
    public class SonyTelevisionRemoteDevice : IDevice
    {
        public void OpenApp(string appName)
        {
            Console.WriteLine($"Sony : Television open application {appName}");
        }

        public void SetChannel(int number)
        {
            Console.WriteLine($"Sony : Set channel {number}");
        }

        public void TemperatureDown()
        {
            throw new NotImplementedException();
        }

        public void TemperatureUp()
        {
            throw new NotImplementedException();
        }

        public void TrunOff()
        {
            Console.WriteLine($"Sony : Television trun off.");
        }

        public void TrunOn()
        {
            Console.WriteLine($"Sony : Television trun on.");
        }

        public void VolumnDown()
        {
            Console.WriteLine($"Sony : Television volumn down.");
        }

        public void VolumnUp()
        {
            Console.WriteLine($"Sony : Television volumn up.");
        }
    }
}
