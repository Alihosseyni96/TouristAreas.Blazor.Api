using Backed.API.Data;
using Backed.API.Models;
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
            var res= await context.TouristAreas.ToListAsync();
            foreach (var item in res)
            {
                item.Image = null;
            }
            return res;
        }

        public async Task<List<TouristArea>> AreaByCityId(int cityId)
        {
            return await context.TouristAreas.Where(x=> x.CityId ==  cityId).ToListAsync(); 
        }

        public async Task AddImageToTouristArea(AddImageForTouristsArea req)
        {
            var area = await context.TouristAreas.SingleAsync(x => x.Id == req.AreaId);
            using (var ms = new MemoryStream())
            {
                req.Image.CopyTo(ms);
                area.Image = ms.ToArray();
            }
            await context.SaveChangesAsync();
            

        }

        public async Task<byte[]> ImageByAreaId(int areaId)
        {
            var image = (await context.TouristAreas.SingleAsync(x => x.Id == areaId)).Image;
            return image;
        }


    }
}
