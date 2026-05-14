using Muraafiq.Domain.Common;

namespace Muraafiq.Application.Common.Interfaces;

public interface IUserContext
{
    long UserId { get; }
    long PersonId { get; }
    Languages Language { get; }
    bool IsAuthenticated { get; }
    string IpAddress { get; }
    string UserAgent { get; }
}