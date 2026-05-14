using Muraafiq.Domain.Common;

namespace Muraafiq.Shared.Constants;

public static class StoragePaths
{
    private static readonly IReadOnlyDictionary<FileUploadType, string> Paths
        = new Dictionary<FileUploadType, string>
        {
            { FileUploadType.UserProfileImage, "assets/images/users/profile" },
            { FileUploadType.UserCoverImage, "assets/images/users/cover" },

            { FileUploadType.CompanionProfileImage, "assets/images/companions/profile" },

            { FileUploadType.CompanionNationalIdFront, "assets/documents/companions/national-id/front" },
            { FileUploadType.CompanionNationalIdBack, "assets/documents/companions/national-id/back" },

            { FileUploadType.CompanionCertificate, "assets/documents/companions/certificates" },

            { FileUploadType.HospitalLogo, "assets/images/hospitals/logos" },

            { FileUploadType.BookingAttachment, "assets/documents/bookings/attachments" },

            { FileUploadType.PaymentReceipt, "assets/documents/payments/receipts" },

            { FileUploadType.Document, "assets/documents/general" }
        };

    public static string Get(FileUploadType type)
    {
        if (!Paths.TryGetValue(type, out var path))
        {
            throw new InvalidOperationException(
                $"No storage path configured for upload type '{type}'.");
        }

        return path;
    }
}
