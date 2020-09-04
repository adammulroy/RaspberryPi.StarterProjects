using System.Threading.Tasks;

namespace RaspberryPi.Interfaces
{
    public interface IRaspberryPiApi
    {
        ILights Lights { get; }
    }

    public interface ILights
    {
        Task BlinkyOneTime();
        Task BlinkyManyTime();
        Task BlinkyOhNoTooManyTime();
    }
}