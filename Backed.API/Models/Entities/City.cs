﻿namespace Backed.API.Models.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<TouristArea>? TouristAreas { get; set; }
    }
}
