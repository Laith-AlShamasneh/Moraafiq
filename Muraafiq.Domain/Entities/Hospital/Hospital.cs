using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.Hospital;

public class Hospital : AuditableEntity
{
    public int Id { get; set; }
    public string NameEn { get; set; } = string.Empty;
    public string NameAr { get; set; } = string.Empty;
    public int CityId { get; set; }
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }

    public ICollection<Building> Buildings { get; set; } = new List<Building>();
    public ICollection<Clinic> Clinics { get; set; } = new List<Clinic>();
}
