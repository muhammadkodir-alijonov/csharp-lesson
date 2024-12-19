namespace CarShop.Api.Interfaces;
public interface IFileService
{
    public Task<string> SaveImageAsync(IFormFile image);
}
