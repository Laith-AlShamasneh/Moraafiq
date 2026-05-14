using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.Lookup;

public class PriorityLevel : BaseLookupEntity
{
    public int SortOrder { get; set; }
    public int? ResponseTimeMinutes { get; set; }
}
