using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.Booking;

public class BookingAssignment : AuditableEntity
{
    public long Id { get; set; }
    public long BookingId { get; set; }
    public int CompanionUserId { get; set; }
    public int StatusId { get; set; }
    public DateTime AssignedAt { get; set; }
    public DateTime? AcceptedAt { get; set; }
    public DateTime? StartedAt { get; set; }
    public DateTime? CompletedAt { get; set; }
    public string? RejectReason { get; set; }
}
