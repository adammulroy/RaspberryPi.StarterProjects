using System;
using System.Diagnostics;
using System.Threading.Tasks;
using RaspberryPi.Interfaces;

namespace RaspberryPi.Hardware
{
    public class Lights : ILights
    {
        public Task BlinkyOneTime()
        {
            Debug.WriteLine("We DID IT ONE TIME :D");
            
            return Task.CompletedTask;
        }

        public Task BlinkyManyTime()
        {
            Debug.WriteLine("We DID IT MANY TIME :D");
            
            return Task.CompletedTask;
        }

        public Task BlinkyOhNoTooManyTime()
        {
            Debug.WriteLine("OH NO YOU DID IT TOO MANY TIME D:");

            return Task.CompletedTask;
        }
    }
}