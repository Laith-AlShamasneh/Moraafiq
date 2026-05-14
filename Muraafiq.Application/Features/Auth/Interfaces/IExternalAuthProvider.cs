using Muraafiq.Application.Features.Auth.DTOs.External;
using Muraafiq.Shared.Common.Responses;

namespace Muraafiq.Application.Features.Auth.Interfaces;

public interface IExternalAuthService
{
    Task<ServiceResponse<ExternalProviderUserDto>> ValidateTokenAsync(
        int providerId,
        string identityToken,
        CancellationToken cancellationToken = default);
}
