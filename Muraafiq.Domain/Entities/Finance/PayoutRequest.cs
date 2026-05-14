using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.Finance;

public class PayoutRequest : AuditableEntity
{
    public long Id { get; set; }
    public int UserId { get; set; }
    public decimal Amount { get; set; }
    public int StatusId { get; set; }
    public DateTime RequestedAt { get; set; } = DateTime.UtcNow;
    public DateTime? ProcessedAt { get; set; }
    public string? BankAccountInfo { get; set; }
    public string? Notes { get; set; }
}
