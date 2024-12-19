using CarShop.Api.Common.Utils;
using CarShop.Api.Dtos.Orders;

namespace CarShop.Api.Interfaces;
public interface IOrderService
{
    public Task<bool> CreateAsync(OrderCreateDto orderCreateDto);

    public Task<OrderDto> GetByIdAsync(long id);

    public Task<IEnumerable<OrderDto>> GetAllAsync(PaginationParams @params);

    public Task<bool> UpdateAsync(long id, OrderCreateDto orderCreateDto);

    public Task<bool> DeleteAsync(long id);
}
