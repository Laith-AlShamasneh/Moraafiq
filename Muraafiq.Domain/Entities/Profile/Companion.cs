using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.Profile;

public class Companion : AuditableEntity
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int VerificationStatusId { get; set; }
    public string? BioEn { get; set; }
    public string? BioAr { get; set; }
    public decimal? HourlyRate { get; set; }
    public decimal RatingAverage { get; set; }
    public int TotalReviews { get; set; }
}
