using CarShop.Api.Common.Attributes;
using CarShop.Api.Models;
using System.ComponentModel.DataAnnotations;

namespace CarShop.Api.Dtos.Cars;
public class CarCreateDto
{
    [Required(ErrorMessage = "Please enter valid name")]
    [MaxLength(30)]
    [MinLength(2)]
    public string Name { get; set; } = String.Empty;

    public int Version { get; set; }

    public string Company { get; set; } = String.Empty;

    [Required(ErrorMessage = "Please enter valid color")]
    [ValidColor(ErrorMessage = "This color is not supported")]
    public string Color { get; set; } = String.Empty;

    [Required]
    public double Price { get; set; }

    public DateTime ProductionAt { get; set; }

    public static implicit operator Car(CarCreateDto dto)
    {
        return new Car()
        {
            Name = dto.Name,
            Color = dto.Color,
            Company = dto.Company,
            Price = dto.Price,
            ProductionAt = dto.ProductionAt,
            Version = dto.Version
        };
    }
}
