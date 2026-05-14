using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.System;

public class MediaFile : AuditableEntity
{
    public int Id { get; set; }
    public int MediaCategoryId { get; set; }
    public string FileName { get; set; } = string.Empty;
    public string FileExtension { get; set; } = string.Empty;
    public string ContentType { get; set; } = string.Empty;
    public long SizeBytes { get; set; }
    public string StorageKey { get; set; } = string.Empty;
    public string? PublicUrl { get; set; }
}
