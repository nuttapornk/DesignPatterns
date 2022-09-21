using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.Services.RemoteControl.Samsung
{
    public class SamsungTelevisionRemoteDevice : IDevice
    {
        public void OpenApp(string appName)
        {
            Console.WriteLine($"Samsung : Television open application { appName }");
        }

        public void SetChannel(int number)
        {
            Console.WriteLine($"Samsung : Television Set channel {number}");
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
            Console.WriteLine($"Samsung : Television trun off.");
        }

        public void TrunOn()
        {
            Console.WriteLine($"Samsung : Television trun on.");
        }

        public void VolumnDown()
        {
            Console.WriteLine($"Samsung : Television volumn down.");
        }

        public void VolumnUp()
        {
            Console.WriteLine($"Samsung : Television volumn up.");
        }
    }
}
