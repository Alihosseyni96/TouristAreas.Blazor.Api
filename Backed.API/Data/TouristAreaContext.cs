using Backed.API.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Backed.API.Data
{
    public class TouristAreaContext  : DbContext
    {
        public TouristAreaContext(DbContextOptions<TouristAreaContext> oprions) : base(oprions)
        {
            
        }

        public DbSet<TouristArea> TouristAreas { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
