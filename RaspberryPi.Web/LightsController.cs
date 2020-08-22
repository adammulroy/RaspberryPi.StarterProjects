using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RaspberryPi.Interfaces;

namespace RaspberryPi.Web
{
    [ApiController]
    [Route("api/[controller]")]
    public class LightsController : Controller
    {
        private IRaspberryPiApi _apiInterface;

        public LightsController(IRaspberryPiApi apiInterface)
        {
            _apiInterface = apiInterface;
        }
        
        
        //api/lights/BlinkyOneTime
        [HttpPost("BlinkyOneTime")]
        public async Task<IActionResult> BlinkyOneTime()
        {
            await _apiInterface.Lights.BlinkyOneTime();

            return Accepted();
        }
        
        //api/lights/BlinkyOhNoTooManyTime
        [HttpPost("BlinkyOhNoTooManyTime")]
        public async Task<IActionResult> BlinkyOhNoTooManyTime()
        {
            await _apiInterface.Lights.BlinkyOhNoTooManyTime();

            return Accepted();
        }
        
        //api/lights/BlinkyManyTime
        [HttpPost("BlinkyManyTime")]
        public async Task<IActionResult> BlinkyManyTime()
        {
            await _apiInterface.Lights.BlinkyManyTime();

            return Accepted();
        }
    }
}