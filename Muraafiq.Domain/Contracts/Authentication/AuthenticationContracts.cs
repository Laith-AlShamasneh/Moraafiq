namespace Muraafiq.Domain.Contracts.Authentication;

public record RegisterData
{
    public string FirstName { get; init; } = null!;
    public string LastName { get; init; } = null!;
    public int? GenderId { get; init; }
    public DateTime? BirthDate { get; init; }

    public string Email { get; init; } = null!;
    public string Password { get; init; } = null!;
    public string? PhoneNumber { get; init; }

    public int PreferredLanguageId { get; init; }
    public int RoleId { get; init; }

    public int? ExternalProviderId { get; init; }
    public string? ExternalProviderKey { get; init; }
    public string? ProfileImageUrl { get; init; }
}
public record UserAuthResult
{
    public long UserId { get; init; }
    public long PersonId { get; init; }
    public string Email { get; init; } = null!;
    public bool IsProfileComplete { get; init; }
    public string? ProfileImageUrl { get; init; }
}

public record IdentityAvailabilityResult
{
    public bool IsEmailTaken { get; init; }
    public bool IsPhoneTaken { get; init; }
}