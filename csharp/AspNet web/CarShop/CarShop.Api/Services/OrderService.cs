using AutoMapper;
using CarShop.Api.Common.DbContexts;
using CarShop.Api.Common.Exceptions;
using CarShop.Api.Common.Helpers;
using CarShop.Api.Common.Utils;
using CarShop.Api.Dtos.Orders;
using CarShop.Api.Interfaces;
using CarShop.Api.Interfaces.Common;
using CarShop.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Api.Services;
public class OrderService : IOrderService
{
    private readonly IMapper _mapper;
    private readonly AppDbContext _repository;
    private readonly IPaginationService _paginationService;

    public OrderService(IMapper mapper, AppDbContext appDbContext, IPaginationService paginationService)
    {
        this._mapper = mapper;
        this._repository = appDbContext;
        this._paginationService = paginationService;
    }

    public async Task<bool> CreateAsync(OrderCreateDto orderCreateDto)
    {
        var user = await _repository.Users.FindAsync(orderCreateDto.ClientId);
        if (user is null) throw new StatusCodeException(HttpStatusCode.NotFound, "User not found");

        var car = await _repository.Cars.FindAsync(orderCreateDto.CarId);
        if (car is null) throw new StatusCodeException(HttpStatusCode.NotFound, "Car not found");

        var order = _mapper.Map<Order>(orderCreateDto);
        order.OrderedAt = TimeHelper.GetCurrentServerTime();

        _repository.Orders.Add(order);
        var dbResult = await _repository.SaveChangesAsync();
        return dbResult > 0;
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var order = await _repository.Orders.FindAsync(id);
        if (order is null) throw new StatusCodeException(HttpStatusCode.NotFound, "Order not found");

        _repository.Orders.Remove(order);
        var result = await _repository.SaveChangesAsync();
        return result > 0;
    }

    public async Task<IEnumerable<OrderDto>> GetAllAsync(PaginationParams @params)
    {
        var query = from order in _repository.Orders.Include(x => x.Car).Include(x => x.Client)
                    orderby order.OrderedAt
                    select _mapper.Map<OrderDto>(order);

        return await _paginationService.ToPagedAsync(query, @params.PageNumber, @params.PageNumber);
    }

    public async Task<OrderDto> GetByIdAsync(long id)
    {
        var order = await _repository.Orders.Include(x => x.Car)
            .Include(x => x.Client)
            .FirstOrDefaultAsync(x => x.Id == id);

        if (order is null) throw new StatusCodeException(HttpStatusCode.NotFound, "Order not found");
        else return _mapper.Map<OrderDto>(order);
    }

    public async Task<bool> UpdateAsync(long id, OrderCreateDto orderCreateDto)
    {
        var order = await _repository.Orders.FindAsync(id);
        if (order is null) throw new StatusCodeException(HttpStatusCode.NotFound, "Order not found");
        else _repository.Entry(order).State = EntityState.Detached;

        var user = await _repository.Users.FindAsync(orderCreateDto.ClientId);
        if (user is null) throw new StatusCodeException(HttpStatusCode.NotFound, "User not found");

        var car = await _repository.Cars.FindAsync(orderCreateDto.CarId);
        if (car is null) throw new StatusCodeException(HttpStatusCode.NotFound, "Car not found");

        var neworder = _mapper.Map<Order>(orderCreateDto);
        neworder.Id = order.Id;
        neworder.OrderedAt = order.OrderedAt;

        if (orderCreateDto.Status == Common.Enums.CarOrderStatus.Delivered)
            neworder.DeliveredAt = TimeHelper.GetCurrentServerTime();

        _repository.Orders.Update(neworder);
        var result = await _repository.SaveChangesAsync();
        return result > 0;
    }
}
