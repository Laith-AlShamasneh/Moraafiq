using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.Hospital;

public class Floor : AuditableEntity
{
    public int Id { get; set; }
    public int BuildingId { get; set; }
    public int FloorNumber { get; set; }
    public string? NameEn { get; set; }
    public string? NameAr { get; set; }
}
