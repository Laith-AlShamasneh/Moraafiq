using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.Hospital;

public class Service : AuditableEntity
{
    public int Id { get; set; }
    public int HospitalId { get; set; }
    public string Code { get; set; } = string.Empty;
    public string NameEn { get; set; } = string.Empty;
    public string NameAr { get; set; } = string.Empty;
}
