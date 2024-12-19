using CarShop.Api.Common.Enums;

namespace CarShop.Api.Models;
public class Order
{
    public long Id { get; set; }

    public long ClientId { get; set; }
    public virtual User Client { get; set; } = default!;

    public long CarId { get; set; }
    public virtual Car Car { get; set; } = default!;

    public double Price { get; set; }

    public CarOrderStatus Status { get; set; }

    public DateTime? DeliveredAt { get; set; }

    public DateTime OrderedAt { get; set; }
}
