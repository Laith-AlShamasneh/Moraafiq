using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.Finance;

public class Transaction : AuditableEntity
{
    public long Id { get; set; }
    public long WalletId { get; set; }
    public decimal Amount { get; set; }
    public string Type { get; set; } = string.Empty;
    public int StatusId { get; set; }
    public string? ReferenceType { get; set; }
    public long? ReferenceId { get; set; }
    public string? Description { get; set; }
}
