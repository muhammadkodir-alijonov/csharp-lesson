using CarShop.Api.Common.DbContexts;
using CarShop.Api.Common.Exceptions;
using CarShop.Api.Common.Security;
using CarShop.Api.Dtos.Accounts;
using CarShop.Api.Interfaces;
using CarShop.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Api.Services;
public class AccountService : IAccountService
{
    private readonly AppDbContext _repository;
    private readonly IFileService _fileService;
    private readonly IAuthManager _authManager;
    public AccountService(AppDbContext appDbContext,
        IFileService fileService,
        IAuthManager authManager)
    {
        this._repository = appDbContext;
        this._fileService = fileService;
        this._authManager = authManager;
    }

    public async Task<string> LoginAsync(AccountLoginDto dto)
    {
        var user = await _repository.Users.FirstOrDefaultAsync(x => x.Email == dto.Email);
        if (user is null) throw new StatusCodeException(HttpStatusCode.NotFound, "User not found, Email is incorrect!");

        var hasherResult = PasswordHasher.Verify(dto.Password, user.PasswordHash, user.Salt);
        if (hasherResult)
        {
            return _authManager.GenerateToken(user);
        }
        else throw new StatusCodeException(HttpStatusCode.BadRequest, "Password is invalid!");
    }

    public async Task<bool> RegisterAsync(AccountRegisterDto dto)
    {
        var emailedUser = await _repository.Users.FirstOrDefaultAsync(x => x.Email == dto.Email);
        if (emailedUser is not null)
            throw new StatusCodeException(HttpStatusCode.Conflict, "Email is already exist");

        var hasherResult = PasswordHasher.Hash(dto.Password);
        var userEntity = (User)dto;
        userEntity.PasswordHash = hasherResult.Hash;
        userEntity.Salt = hasherResult.Salt;

        if (dto.Image is not null)
        {
            userEntity.ImagePath = await _fileService.SaveImageAsync(dto.Image);
        }
        _repository.Users.Add(userEntity);
        var dbResult = await _repository.SaveChangesAsync();
        return dbResult > 0;
    }
}
