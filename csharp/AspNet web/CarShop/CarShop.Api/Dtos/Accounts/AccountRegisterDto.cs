using CarShop.Api.Models;
using System.ComponentModel.DataAnnotations;

namespace CarShop.Api.Dtos.Accounts;
public class AccountRegisterDto
{
    [Required, MaxLength(30), MinLength(6)]
    public string FirstName { get; set; } = String.Empty;

    [Required, MaxLength(30), MinLength(6)]
    public string LastName { get; set; } = String.Empty;

    [Required, MaxLength(30), MinLength(6), EmailAddress]
    public string Email { get; set; } = String.Empty;

    public IFormFile? Image { get; set; }

    [Required, MinLength(8)]
    public string Password { get; set; } = String.Empty;

    public static implicit operator User(AccountRegisterDto dto)
    {
        return new User()
        {
            Email = dto.Email,
            FirstName = dto.FirstName,
            LastName = dto.LastName,
        };
    }
}
