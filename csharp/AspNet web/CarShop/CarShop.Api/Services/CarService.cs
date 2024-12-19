using CarShop.Api.Common.DbContexts;
using CarShop.Api.Common.Exceptions;
using CarShop.Api.Common.Utils;
using CarShop.Api.Dtos.Cars;
using CarShop.Api.Interfaces;
using CarShop.Api.Interfaces.Common;
using CarShop.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Api.Services;
public class CarService : ICarService
{
    private readonly AppDbContext appDbContext;
    private readonly IPaginationService _paginationSerive;

    public CarService(AppDbContext appDbContext, IPaginationService paginationService)
    {
        this.appDbContext = appDbContext;
        this._paginationSerive = paginationService;
    }

    public async Task<bool> CreateAsync(CarCreateDto dto)
    {
        var entity = (Car)dto;
        appDbContext.Cars.Add(entity);
        var result = await appDbContext.SaveChangesAsync();
        return result > 0;
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var entity = await appDbContext.Cars.FindAsync(id);
        if (entity is not null)
        {
            appDbContext.Cars.Remove(entity);
            var result = await appDbContext.SaveChangesAsync();
            return result > 0;
        }
        else throw new StatusCodeException(HttpStatusCode.NotFound, "Car not found");
    }

    public async Task<IEnumerable<Car>> GetAllAsync(PaginationParams @params)
    {
        var query = appDbContext.Cars.OrderBy(x => x.Id)
            .ThenByDescending(x => x.Price)
            .AsNoTracking();

        return  await _paginationSerive.ToPagedAsync(query, @params.PageNumber, @params.PageSize);
    }

    public async Task<Car> GetAsync(long id)
    {
        var result = await appDbContext.Cars.FindAsync(id);
        if (result is null) throw new StatusCodeException(HttpStatusCode.NotFound, "Car not found");
        else return result;
    }

    public async Task<bool> UpdateAsync(long id, Car obj)
    {
        var entity = await appDbContext.Cars.FindAsync(id);
        if (entity is not null)
        {
            appDbContext.Entry<Car>(entity!).State = EntityState.Detached;
            obj.Id = id;
            appDbContext.Cars.Update(obj);
            var result = await appDbContext.SaveChangesAsync();
            return result > 0;
        }
        else throw new StatusCodeException(HttpStatusCode.NotFound, "Car not found");
    }
}
