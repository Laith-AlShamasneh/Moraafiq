using Muraafiq.Application.Features.Auth.DTOs.Requests;
using Muraafiq.Application.Features.Auth.DTOs.Responses;
using Muraafiq.Shared.Common.Responses;

namespace Muraafiq.Application.Features.Auth.Interfaces;

public interface IAuthService
{
    Task<ServiceResponse<AuthResponse>> RegisterInternalAsync(
        RegisterInternalRequest request,
        CancellationToken cancellationToken = default);

    Task<ServiceResponse<AuthResponse>> RegisterExternalAsync(
        RegisterExternalRequest request,
        CancellationToken cancellationToken = default);
}
