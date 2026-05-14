namespace Muraafiq.Application.Features.Auth.DTOs.Requests;

public sealed class RegisterExternalRequest
{
    public int ProviderId { get; set; }

    public string IdentityToken { get; set; } = null!;

    public int RoleId { get; set; }

    public int? GenderId { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? PhoneNumber { get; set; }

    public int? PreferredLanguageId { get; set; }
}
