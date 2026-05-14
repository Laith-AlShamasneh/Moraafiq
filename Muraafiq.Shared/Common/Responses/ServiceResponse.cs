using Muraafiq.Domain.Common;
using Muraafiq.Shared.Common.Enums;

namespace Muraafiq.Shared.Common.Responses;

public class ServiceResponse<T>
{
    public bool Success { get; init; }

    public string Message { get; init; } = string.Empty;

    public string? ErrorCode { get; init; }

    public HttpResponseStatus StatusCode { get; init; }

    public Dictionary<string, string[]>? ValidationErrors { get; init; }

    public T? Data { get; init; }

    public static ServiceResponse<T> SuccessResponse(
        T data,
        string message,
        HttpResponseStatus statusCode = HttpResponseStatus.OK)
    {
        return new()
        {
            Success = true,
            Data = data,
            Message = message,
            StatusCode = statusCode
        };
    }

    public static ServiceResponse<T> FailureResponse(
        string errorCode,
        string message,
        HttpResponseStatus statusCode = HttpResponseStatus.BadRequest,
        Dictionary<string, string[]>? validationErrors = null)
    {
        return new()
        {
            Success = false,
            ErrorCode = errorCode,
            Message = message,
            StatusCode = statusCode,
            ValidationErrors = validationErrors
        };
    }
}
