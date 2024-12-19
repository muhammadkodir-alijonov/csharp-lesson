using CarShop.Api.Common.Utils;
using CarShop.Api.Dtos.Cars;
using CarShop.Api.Interfaces;
using CarShop.Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Api.Controllers
{
    [Route("api/cars")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;
        private readonly int pageSize = 30;
        public CarsController(ICarService carService)
        {
            this._carService = carService;
        }

        [HttpGet, AllowAnonymous]
        public async Task<IActionResult> GetAllAsync(int page)
            => Ok(await _carService.GetAllAsync(new PaginationParams(page, pageSize)));

        [HttpGet("{id}"), Authorize(Roles = "Admin, User")]
        public async Task<IActionResult> GetByIdAsync(long id)
            => Ok(await _carService.GetAsync(id));

        [HttpPost, Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateAsync([FromForm] CarCreateDto dto)
            => Ok(await _carService.CreateAsync(dto));

        [HttpDelete("{id}"), Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteByIdAsync(long id)
            => Ok(await _carService.DeleteAsync(id));

        [HttpPut("{id}"), Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateByIdAsync(long id, [FromBody] Car obj)
            => Ok(await _carService.UpdateAsync(id, obj));
    }
}
