namespace Muraafiq.Domain.Entities.Booking;

public class NavigationStep
{
    public long Id { get; set; }
    public long BookingId { get; set; }
    public int StepOrder { get; set; }
    public string InstructionEn { get; set; } = string.Empty;
    public string InstructionAr { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
