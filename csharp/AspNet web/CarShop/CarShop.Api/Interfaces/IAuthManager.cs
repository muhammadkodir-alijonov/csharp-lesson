using CarShop.Api.Models;

namespace CarShop.Api.Interfaces;
public interface IAuthManager
{
    public string GenerateToken(User user);
}
