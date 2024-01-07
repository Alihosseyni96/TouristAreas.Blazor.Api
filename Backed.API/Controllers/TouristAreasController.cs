using Backed.API.Models;
using Backed.API.Models.Entities;
using Backed.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Security;

namespace Backed.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TouristAreasController : ControllerBase
    {
        private readonly BakedServices _services;
        private readonly IMemoryCache _cache;
        public TouristAreasController(BakedServices services, IMemoryCache cache)
        {
            _services = services;
            _cache = cache;
        }

        [HttpGet]
        public async Task<string> SayHello([FromQuery]string name)
        {
            var t = _cache.Get("name");
            _cache.Set("name", name);
            return "Hello World";
        }

        [HttpPost]
        public async Task AddCity([FromBody] AddCityDto city)
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
            var res =  await _services.Areas();
            return res;
        }

        [HttpGet("{cityId}")]
        public async Task<List<TouristArea>> AreaByCityId([FromRoute]int cityId)
        {
            return await _services.AreaByCityId(cityId);
        }

        [HttpPost]
        public async Task AddImageToArea([FromForm] AddImageForTouristsArea req)
        {
            await _services.AddImageToTouristArea(req);
        }

        [HttpGet("{id}")]
        public async Task<FileContentResult> ImageByAreaId([FromRoute]int id)
        {
            var imageAsByteArray = await _services.ImageByAreaId(id);
            return File(imageAsByteArray , "application/octet-stream");
        }


    }
}
