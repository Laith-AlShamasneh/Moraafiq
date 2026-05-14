namespace Muraafiq.Shared.Common.Responses;

public class ApiResponse<T>
{
    public bool Success { get; set; }

    public string Message { get; set; } = string.Empty;

    public string? ErrorCode { get; set; }

    public Dictionary<string, string[]>? ValidationErrors { get; set; }

    public T? Data { get; set; }

    public static ApiResponse<T> FromServiceResponse(ServiceResponse<T> response)
    {
        return new()
        {
            Success = response.Success,
            Message = response.Message,
            ErrorCode = response.ErrorCode,
            ValidationErrors = response.ValidationErrors,
            Data = response.Data
        };
    }
}
