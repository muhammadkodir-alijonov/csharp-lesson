using CarShop.Api.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace CarShop.Api.Dtos.Orders;
public class OrderCreateDto
{
    [Required]
    public long ClientId { get; set; }

    [Required]
    public long CarId { get; set; }

    [Required]
    public double Price { get; set; }

    [Required]
    public CarOrderStatus Status { get; set; }
}
