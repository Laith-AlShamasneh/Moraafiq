using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.Booking;

public class Booking : AuditableEntity
{
    public long Id { get; set; }
    public int PatientUserId { get; set; }
    public int HospitalId { get; set; }
    public int? ClinicId { get; set; }
    public int ServiceId { get; set; }
    public int StatusId { get; set; }
    public int PriorityLevelId { get; set; }
    public DateTime RequestedAt { get; set; }
    public DateTime? ScheduledAt { get; set; }
    public string? Notes { get; set; }

    // Navigation
    public ICollection<BookingAssignment> Assignments { get; set; } = new List<BookingAssignment>();
    public ICollection<BookingStatusHistory> StatusHistory { get; set; } = new List<BookingStatusHistory>();
}
