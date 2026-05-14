namespace Muraafiq.Application.Features.Auth.DTOs.Responses;

public sealed class AuthResponse
{
    public int UserId { get; set; }

    public string AccessToken { get; set; } = null!;

    public string RefreshToken { get; set; } = null!;

    public DateTime ExpiresAt { get; set; }

    public bool IsProfileCompleted { get; set; }

    public UserInfoDto User { get; set; } = null!;
}
public sealed class UserInfoDto
{
    public int UserId { get; set; }

    public int PersonId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string? ProfileImageUrl { get; set; }

    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;
}