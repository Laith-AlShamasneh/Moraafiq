namespace Muraafiq.Domain.Common;

public enum Languages
{
    En = 1,
    Ar = 2
}
public enum AuthProvider
{
    Local = 0,
    Google = 1,
    Apple = 2,
    Facebook = 3
}
public enum LoginStatus
{
    Success = 1,
    InvalidCredentials = 2,
    LockedOut = 3,
    RequiresTwoFactor = 4
}
public enum DeviceType
{
    Web = 1,
    Mobile = 2,
    Tablet = 3
}
public enum ErrorType
{
    Validation = 1,
    NotFound = 2,
    Unauthorized = 3,
    Conflict = 4,
    ServerError = 5
}
public enum OtpStatus
{
    Pending = 1,
    Verified = 2,
    Expired = 3,
    Failed = 4
}


public enum Gender
{
    Male = 1,
    Female = 2
}

public enum FileUploadType : byte
{
    Unknown = 0,

    // User Media
    UserProfileImage = 1,
    UserCoverImage = 2,

    // Companion
    CompanionProfileImage = 3,
    CompanionNationalIdFront = 4,
    CompanionNationalIdBack = 5,
    CompanionCertificate = 6,

    // Hospital / Organization
    HospitalLogo = 7,

    // Booking / Operations
    BookingAttachment = 8,
    PaymentReceipt = 9,

    // General
    Document = 10
}