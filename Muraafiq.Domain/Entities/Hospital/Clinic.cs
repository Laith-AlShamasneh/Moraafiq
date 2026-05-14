using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.Hospital;

public class Clinic : AuditableEntity
{
    public int Id { get; set; }
    public int HospitalId { get; set; }
    public int? FloorId { get; set; }
    public string NameEn { get; set; } = string.Empty;
    public string NameAr { get; set; } = string.Empty;
    public string? SpecialtyCode { get; set; }
}
