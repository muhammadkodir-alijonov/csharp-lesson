using CarShop.Api.Dtos.Users;
using CarShop.Api.Models;

namespace CarShop.Api.Dtos.Orders;
public class OrderDto
{
    public long Id { get; set; }

    public OwnerDto Client { get; set; } = default!;

    public Car Car { get; set; } = default!;

    public double Price { get; set; }

    public string Status { get; set; } = String.Empty;

    public DateTime? DeliveredAt { get; set; }

    public DateTime OrderedAt { get; set; }
}
