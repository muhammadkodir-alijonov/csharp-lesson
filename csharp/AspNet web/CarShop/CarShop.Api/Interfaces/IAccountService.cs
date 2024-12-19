using CarShop.Api.Dtos.Accounts;

namespace CarShop.Api.Interfaces;
public interface IAccountService
{
    public Task<bool> RegisterAsync(AccountRegisterDto dto);

    public Task<string> LoginAsync(AccountLoginDto dto);
}
