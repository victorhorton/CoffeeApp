using System;
namespace CoffeeApp.Models
{
    public enum RoastType
    {
        Unroasted,
        Light,
        Medium,
        Dark
    }

    public class Coffee
	{
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public RoastType? Roast { get; set; }
        public string? Origin { get; set; }

        public Coffee()
		{
		}
	}
}

