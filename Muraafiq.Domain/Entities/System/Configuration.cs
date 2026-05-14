using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.System;

public class Configuration : AuditableEntity
{
    public int Id { get; set; }
    public string ConfigKey { get; set; } = string.Empty;
    public string ConfigValue { get; set; } = string.Empty;
    public string? Description { get; set; }
}
