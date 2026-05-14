namespace Muraafiq.Domain.Entities.Booking;

public class DispatchQueue
{
    public long Id { get; set; }
    public long BookingId { get; set; }
    public int HospitalId { get; set; }
    public string Status { get; set; } = string.Empty;
    public int AttemptCount { get; set; }
    public DateTime? NextRetryAt { get; set; }
    public DateTime? LockedAt { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
