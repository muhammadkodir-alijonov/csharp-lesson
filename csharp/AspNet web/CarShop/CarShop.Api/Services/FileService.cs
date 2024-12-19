using CarShop.Api.Common.Helpers;
using CarShop.Api.Interfaces;

namespace CarShop.Api.Servicese;

public class FileService : IFileService
{
    private readonly string images = "images";
    private readonly string _rootpath;
    public FileService(IWebHostEnvironment webHostEnvironment)
    {
        _rootpath = webHostEnvironment.WebRootPath;
    }

    public async Task<string> SaveImageAsync(IFormFile image)
    {
        string imageName = ImageHelper.MakeImageName(image.FileName);

        string imagePath = Path.Combine(_rootpath, images, imageName);
        var stream = new FileStream(imagePath, FileMode.Create);
        try
        {
            await image.CopyToAsync(stream);
            return Path.Combine(images, imageName);
        }
        catch
        {
            return "";
        }
        finally
        {
            stream.Close();
        }
    }
}
