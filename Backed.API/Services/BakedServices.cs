using Backed.API.Data;
using Backed.API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Backed.API.Services
{
    public class BakedServices
    {
        private readonly TouristAreaContext context;

        public BakedServices(TouristAreaContext context)
        {
            this.context = context;
        }

        public async Task AddCity(City city)
        {
            await context.Cities.AddAsync(city);
            await context.SaveChangesAsync();

        }

        public async Task<List<City>> Cities()
        {
            var res = await context.Cities.ToListAsync();
            return res;
        }

        public async Task AddTouristArea(TouristArea area)
        {
            await context.TouristAreas.AddAsync(area);
            await context.SaveChangesAsync();
        }


        public async Task<List<TouristArea>> Areas()
        {
            return await context.TouristAreas.ToListAsync();
        }

        public async Task<List<TouristArea>> AreaByCityId(int cityId)
        {
            return await context.TouristAreas.Where(x=> x.CityId ==  cityId).ToListAsync(); 
        }


    }
}
