using Backed.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backed.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TouristAreasController : ControllerBase
    {
        private readonly BakedServices _services;
        public TouristAreasController(BakedServices services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<string> SayHello()
        {
            return "Hello World";
        }
    }
}
