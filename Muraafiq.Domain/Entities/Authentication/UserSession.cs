namespace Muraafiq.Domain.Entities.Authentication;

public class UserSession
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int DeviceTypeId { get; set; }
    public string? DeviceToken { get; set; }
    public string? IpAddress { get; set; }
    public string? UserAgent { get; set; }
    public DateTime LastActivityAt { get; set; } = DateTime.UtcNow;
    public DateTime ExpiresAt { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
