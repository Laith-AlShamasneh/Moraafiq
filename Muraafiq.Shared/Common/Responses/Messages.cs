namespace Muraafiq.Shared.Common.Responses;

public sealed record Message(
    string En,
    string Ar
);

public static class Messages
{
    public static class General
    {
        public static readonly Message Success = new(
            "Operation completed successfully.",
            "تمت العملية بنجاح.");

        public static readonly Message ServerError = new(
            "An unexpected error occurred.",
            "حدث خطأ غير متوقع.");

        public static readonly Message ValidationError = new(
            "Validation failed.",
            "فشل التحقق من صحة البيانات.");

        public static readonly Message Unauthorized = new(
            "Unauthorized access.",
            "غير مصرح بالوصول.");

        public static readonly Message Forbidden = new(
            "Access denied.",
            "تم رفض الوصول.");

        public static readonly Message NotFound = new(
            "Resource not found.",
            "العنصر غير موجود.");
    }

    public static class Authentication
    {
        public static readonly Message InvalidCredentials = new(
            "Invalid email or password.",
            "البريد الإلكتروني أو كلمة المرور غير صحيحة.");

        public static readonly Message EmailAlreadyExists = new(
            "Email already exists.",
            "البريد الإلكتروني مستخدم مسبقاً.");

        public static readonly Message UserNotFound = new(
            "User not found.",
            "المستخدم غير موجود.");

        public static readonly Message InvalidExternalToken = new(
            "Invalid external authentication token.",
            "رمز تسجيل الدخول الخارجي غير صالح.");

        public static readonly Message AccountDisabled = new(
            "This account is disabled.",
            "هذا الحساب معطل.");

        public static readonly Message OtpExpired = new(
            "OTP has expired.",
            "انتهت صلاحية رمز التحقق.");
    }

    public static class File
    {
        public static readonly Message InvalidFileType = new(
            "Invalid file type.",
            "نوع الملف غير مدعوم.");

        public static readonly Message FileTooLarge = new(
            "File size exceeds allowed limit.",
            "حجم الملف أكبر من المسموح.");
    }
}
