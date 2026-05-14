using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.Lookup;

public class MediaCategory : BaseLookupEntity
{
    public int MaxSizeMb { get; set; }
    public string AllowedExtensions { get; set; } = string.Empty;
}
