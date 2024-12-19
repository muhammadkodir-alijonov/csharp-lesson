using CarShop.Api.Common.Utils;
using CarShop.Api.Dtos.Cars;
using CarShop.Api.Models;

namespace CarShop.Api.Interfaces;
public interface ICarService
{
    public Task<IEnumerable<Car>> GetAllAsync(PaginationParams @params);

    public Task<Car> GetAsync(long id);

    public Task<bool> DeleteAsync(long id);

    public Task<bool> CreateAsync(CarCreateDto dto);

    public Task<bool> UpdateAsync(long id, Car obj);

}
