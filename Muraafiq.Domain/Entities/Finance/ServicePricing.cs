using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.Finance;

public class ServicePricing : AuditableEntity
{
    public long Id { get; set; }
    public int ServiceId { get; set; }
    public decimal BasePrice { get; set; }
    public decimal? PricePerHour { get; set; }
    public int CurrencyId { get; set; }
    public DateTime EffectiveFrom { get; set; }
    public DateTime? EffectiveTo { get; set; }
}
