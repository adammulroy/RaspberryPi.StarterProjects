using System.Diagnostics;
using System.Threading.Tasks;
using RaspberryPi.Interfaces;

namespace RaspberryPi.Hardware
{
    public class RaspberryPiApiHardwareInterface : IRaspberryPiApi
    {
        public RaspberryPiApiHardwareInterface()
        {
            Lights = new Lights();
        }

        public ILights Lights { get; }
    }
}