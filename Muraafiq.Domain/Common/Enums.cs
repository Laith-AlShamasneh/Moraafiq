namespace Muraafiq.Domain.Common;

public enum UserType : byte
{
    Patient = 1,
    Companion = 2,
    HospitalAdmin = 3,
    SystemAdmin = 4
}
public enum ProviderType : byte
{
    Internal = 1,
    Google = 2,
    Apple = 3
}
public enum OtpStatus
{
    Pending = 1,
    Verified = 2,
    Expired = 3,
    Failed = 4
}