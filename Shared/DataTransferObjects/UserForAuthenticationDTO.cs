using System.ComponentModel.DataAnnotations;

namespace Shared;

public record class UserForAuthenticationDTO
{
    [Required(ErrorMessage = "User name is required")]
    public string? UserName { get; init; }
    [Required(ErrorMessage = "Password name is required")]
    public string? Password { get; init; }
}
