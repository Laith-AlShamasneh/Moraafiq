using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.Finance;

public class Payment : AuditableEntity
{
    public long Id { get; set; }
    public long TransactionId { get; set; }
    public string Provider { get; set; } = string.Empty;
    public string? ProviderTransactionId { get; set; }
    public decimal Amount { get; set; }
    public int StatusId { get; set; }
    public DateTime? PaidAt { get; set; }
}
