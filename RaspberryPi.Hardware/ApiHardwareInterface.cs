using System.Diagnostics;
using System.Threading.Tasks;
using RaspberryPi.Interfaces;

namespace RaspberryPi.Hardware
{
    public class ApiHardwareInterface : IRaspberryPiApi
    {
        public ApiHardwareInterface()
        {
            Lights = new Lights();
        }

        public ILights Lights { get; }
    }
}