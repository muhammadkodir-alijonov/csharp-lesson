namespace CarShop.Api.Models
{
    public class Car
    {
        public long Id { get; set; }

        public string Name { get; set; } = String.Empty;

        public int Version { get; set; }

        public string Company { get; set; } = String.Empty;

        public string Color { get; set; } = String.Empty;

        public double Price { get; set; }

        public DateTime ProductionAt { get; set; }
    }
}
