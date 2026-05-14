using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.Hospital;

public class Staff : AuditableEntity
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int HospitalId { get; set; }
    public string? JobTitle { get; set; }
}
