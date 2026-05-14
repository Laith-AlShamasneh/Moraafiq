using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.Profile;

public class Patient : AuditableEntity
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string? EmergencyContactName { get; set; }
    public string? EmergencyContactPhone { get; set; }
    public int? BloodTypeId { get; set; }
}
