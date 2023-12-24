namespace Backed.API.Models
{
    public class AddImageForTouristsArea
    {
        public int AreaId { get; set; }
        public IFormFile Image { get; set; }
    }

    public class AddCityDto
    {
        public string Name { get; set; }

    }
}
