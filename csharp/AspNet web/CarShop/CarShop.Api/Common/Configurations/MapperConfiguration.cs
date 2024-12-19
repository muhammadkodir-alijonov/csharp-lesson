using AutoMapper;
using CarShop.Api.Dtos.Orders;
using CarShop.Api.Dtos.Users;
using CarShop.Api.Models;

namespace CarShop.Api.Common.Configurations;
public class MapperConfiguration : Profile
{
    public MapperConfiguration()
    {
        CreateMap<OrderCreateDto, Order>().ReverseMap();
        CreateMap<OrderDto, Order>().ReverseMap().ForMember(orderDto => orderDto.Status,
            order => order.MapFrom(x => x.Status.ToString()));
        CreateMap<User, OwnerDto>().ReverseMap();
    }
}
