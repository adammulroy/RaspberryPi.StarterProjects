using System;
using System.Device.Gpio;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using RaspberryPi.Interfaces;

namespace RaspberryPi.Hardware
{
    public class Lights : ILights
    {
        private GpioController _gpioController;

        public Lights()
        {
            //Does this need to be static?
            _gpioController = new GpioController();
        }
        public Task BlinkyOneTime()
        {
            Debug.WriteLine("We DID IT ONE TIME :D");
            
            return Task.CompletedTask;
        }

        public Task BlinkyManyTime()
        {
            Debug.WriteLine("We DID IT MANY TIME :D");
            int pin = 17;
            _gpioController.OpenPin(pin, PinMode.Output);

            if (_gpioController.IsPinOpen(pin))
            {
                int lightTimeInMilliseconds = 1000;
                int dimTimeInMilliseconds = 200;

                for (int i = 0; i < 20; i++)
                {
                    Debug.WriteLine($"Light for {lightTimeInMilliseconds}ms");
                    _gpioController.Write(pin, PinValue.High);
                    Thread.Sleep(lightTimeInMilliseconds);
                    Debug.WriteLine($"Dim for {dimTimeInMilliseconds}ms");
                    _gpioController.Write(pin, PinValue.Low);
                    Thread.Sleep(dimTimeInMilliseconds); 
                }
            }
            else
            {
                Debug.WriteLine("Pin isn't open to activate light?");
            }
            
            return Task.CompletedTask;
        }

        public Task BlinkyOhNoTooManyTime()
        {
            Debug.WriteLine("OH NO YOU DID IT TOO MANY TIME D:");

            return Task.CompletedTask;
        }
    }
}