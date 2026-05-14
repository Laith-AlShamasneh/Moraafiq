namespace Muraafiq.Domain.Entities.Profile;

public class CompanionVerification
{
    public int Id { get; set; }
    public int CompanionId { get; set; }
    public int VerificationStatusId { get; set; }
    public string? ReviewerNotes { get; set; }
    public DateTime? VerifiedAt { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public int? CreatedBy { get; set; }
}
