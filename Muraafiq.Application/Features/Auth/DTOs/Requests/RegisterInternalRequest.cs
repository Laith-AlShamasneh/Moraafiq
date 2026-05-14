using Microsoft.AspNetCore.Http;

namespace Muraafiq.Application.Features.Auth.DTOs.Requests;

public sealed class RegisterInternalRequest
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;

    public int GenderId { get; set; }

    public DateTime? BirthDate { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public int PreferredLanguageId { get; set; }

    public int RoleId { get; set; }

    public IFormFile? ProfileImage { get; set; }
}