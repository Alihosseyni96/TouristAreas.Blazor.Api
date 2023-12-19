using Backed.API.Models.Entities;

namespace RestaurantProject.JsonModels
{
    public class touristsArea
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public byte[]? image { get; set; }
        public City? city { get; set; }
        public int? cityId { get; set; }

    }
}
