using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.Authentication;

public class ExternalAccount : AuditableEntity
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int ProviderId { get; set; } // e.g., Google, Apple
    public string ProviderKey { get; set; } = string.Empty;
}
