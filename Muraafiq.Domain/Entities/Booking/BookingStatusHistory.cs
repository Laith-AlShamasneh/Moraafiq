namespace Muraafiq.Domain.Entities.Booking;

public class BookingStatusHistory
{
    public long Id { get; set; }
    public long BookingId { get; set; }
    public int StatusId { get; set; }
    public DateTime ChangedAt { get; set; } = DateTime.UtcNow;
    public int? ChangedBy { get; set; }
    public string? Reason { get; set; }
}
