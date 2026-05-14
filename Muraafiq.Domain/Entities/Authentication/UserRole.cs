using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.Authentication;

public class UserRole : AuditableEntity
{
    public int UserId { get; set; }
    public int RoleId { get; set; }
}
