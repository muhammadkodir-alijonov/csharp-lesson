using CarShop.Api.Common.Utils;
using CarShop.Api.Interfaces.Common;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace CarShop.Api.Services
{
    public class PaginatorService : IPaginationService
    {
        private readonly IHttpContextAccessor _accessor;

        public PaginatorService(IHttpContextAccessor httpContextAccessor)
        {
            this._accessor = httpContextAccessor;
        }
        public async Task<IList<T>> ToPagedAsync<T>(IQueryable<T> items, int pageNumber, int pageSize)
        {
            int totalItems = await items.CountAsync();
            PaginationMetaData paginationMetaData = new PaginationMetaData()
            {
                CurrentPage = pageNumber,
                PageSize = pageSize,
                TotalItems = totalItems,
                TotalPages = (int)Math.Ceiling((double)totalItems / (double)pageSize),
                HasPrevious = pageNumber > 1
            };
            paginationMetaData.HasNext = paginationMetaData.CurrentPage < paginationMetaData.TotalPages;//this is error
            string json = JsonConvert.SerializeObject(paginationMetaData);
            _accessor.HttpContext!.Response.Headers.Add("X-Pagination", json);
            int skipCount = (pageNumber - 1) * pageSize;// We can use without this code:ex: like skipCount =1;
            int takeCount = pageSize;// We can use without this code:ex: like takeCount =4;
            return await items.Skip(skipCount)
                              .Take(takeCount)
                              .ToListAsync(); // coz, finished process returns liek List(Async) 
        }
    }
}
