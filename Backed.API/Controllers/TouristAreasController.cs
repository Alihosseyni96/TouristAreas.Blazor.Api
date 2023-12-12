using Backed.API.Models.Entities;
using Backed.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security;

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

        [HttpPost]
        public async Task AddCity([FromBody]City city)
        {
            await _services.AddCity(city);
        }

        [HttpPost]
        public async Task AddArea([FromBody] TouristArea area)
        {
            await _services.AddTouristArea(area);
        }

        [HttpGet]
        public async Task<List<City>> Cities()
        {
            return await _services.Cities();
        }

        [HttpGet]
        public async Task<List<TouristArea>> Areas()
        {
            return await _services.Areas();
        }

        [HttpGet("{cityId}")]
        public async Task<List<TouristArea>> AreaByCityId([FromRoute]int cityId)
        {
            return await _services.AreaByCityId(cityId);
        }


    }
}
