namespace Muraafiq.Application.Features.Auth.DTOs.External;

public sealed class ExternalProviderUserDto
{
    public string ProviderKey { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? ProfileImageUrl { get; set; }

    public bool IsEmailVerified { get; set; }
}
