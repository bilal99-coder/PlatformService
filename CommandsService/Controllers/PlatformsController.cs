using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controller
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {

        }
        [HttpPost]
        public ActionResult TestInboundConnection ()
        {
            Console.WriteLine("--> Ibound POST # Command Service");
            return Ok("Inbound test of from Platforms Controller");
        }
    }
}
