using Muraafiq.Domain.Common;

namespace Muraafiq.Domain.Entities.Authentication;

public class Person : AuditableEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int GenderId { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public int? NationalityId { get; set; }
}
