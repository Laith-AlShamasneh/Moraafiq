using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.Finance;

public class Wallet : AuditableEntity
{
    public long Id { get; set; }
    public int UserId { get; set; }
    public decimal Balance { get; set; }
    public int CurrencyId { get; set; }
}
