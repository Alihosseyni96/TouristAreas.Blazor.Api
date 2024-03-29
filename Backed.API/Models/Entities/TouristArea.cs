﻿namespace Backed.API.Models.Entities
{
    public class TouristArea
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[]? Image { get; set; }
        public City? City { get; set; }
        public int? CityId { get; set; }
    }
}
