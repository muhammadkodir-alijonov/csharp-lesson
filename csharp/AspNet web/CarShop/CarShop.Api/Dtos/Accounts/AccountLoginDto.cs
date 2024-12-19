using System.ComponentModel.DataAnnotations;

namespace CarShop.Api.Dtos.Accounts;
public class AccountLoginDto
{
    [Required, MaxLength(30), MinLength(6), EmailAddress]
    public string Email { get; set; } = String.Empty;

    [Required, MinLength(8)]
    public string Password { get; set; } = String.Empty;
}
