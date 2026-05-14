using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.Lookup;

public class City : AuditableEntity
{
    public int Id { get; set; }
    public int CountryId { get; set; }
    public string NameEn { get; set; } = string.Empty;
    public string NameAr { get; set; } = string.Empty;
}
