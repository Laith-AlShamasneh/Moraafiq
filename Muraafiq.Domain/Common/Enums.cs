using System.ComponentModel;

namespace Muraafiq.Domain.Common;

public enum OtpStatus
{
    Pending = 1,
    Verified = 2,
    Expired = 3,
    Failed = 4
}