using CarShop.Api.Dtos.Accounts;
using CarShop.Api.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Api.Controllers
{
    [Route("api/accounts")]
    [ApiController, AllowAnonymous]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountsController(IAccountService accountService)
        {
            this._accountService = accountService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync([FromForm] AccountRegisterDto dto)
            => Ok(await _accountService.RegisterAsync(dto));

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync([FromForm] AccountLoginDto dto)
            => Ok(new { Token = await _accountService.LoginAsync(dto) });
    }
}
