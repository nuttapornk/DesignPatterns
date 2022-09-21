using DesignPatterns.Bridge.Services.RemoteControl;
using DesignPatterns.Bridge.Services.RemoteControl.Sony;
using DesignPatterns.Bridge.Services.RemoteControl.Samsung;
using System;

namespace DesignPatterns.Bridge
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IDevice device = new SamsungTelevisionRemoteDevice();
                var remoteControl = new SamsungTelevistionRemoteControl(device);
                
                remoteControl.TrunOn();
                remoteControl.SetChannel(5);
                remoteControl.OpenYoutube();
                remoteControl.OpenNetflix();
                remoteControl.SetChannel(6);
                remoteControl.VolumnUp();
                remoteControl.VolumnUp();
                remoteControl.VolumnDown();
                remoteControl.TrunOff();
                
            }
            catch (System.Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            





        }
    }
}
