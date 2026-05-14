using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.Authentication;

public class Role : AuditableEntity
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public string NameEn { get; set; } = string.Empty;
    public string NameAr { get; set; } = string.Empty;
}
