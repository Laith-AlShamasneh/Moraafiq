using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.Authentication;

public class User : AuditableEntity
{
    public int Id { get; set; }
    public int PersonId { get; set; }
    public string Email { get; set; } = string.Empty;
    public string? PhoneNumber { get; set; }
    public string? PasswordHash { get; set; }
    public int? PreferredLanguageId { get; set; }
    public bool IsEmailConfirmed { get; set; }
    public bool IsPhoneConfirmed { get; set; }
    public bool IsLocked { get; set; }

    // Navigation Properties
    public Person Person { get; set; } = null!;
    public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    public ICollection<ExternalAccount> ExternalAccounts { get; set; } = new List<ExternalAccount>();
    public Patient? PatientProfile { get; set; }
    public Companion? CompanionProfile { get; set; }
}
