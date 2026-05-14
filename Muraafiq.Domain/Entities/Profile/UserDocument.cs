using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.Profile;

public class UserDocument : AuditableEntity
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int DocumentTypeId { get; set; }
    public int MediaId { get; set; }
    public int VerificationStatusId { get; set; }
    public string? DocumentNumber { get; set; }
    public DateTime? ExpiryDate { get; set; }
}
