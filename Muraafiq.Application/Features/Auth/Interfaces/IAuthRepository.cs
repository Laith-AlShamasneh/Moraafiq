using Muraafiq.Domain.Contracts.Authentication;

namespace Muraafiq.Application.Features.Auth.Interfaces;

public interface IAuthRepository
{
    Task<IdentityAvailabilityResult> CheckIdentityAvailabilityAsync(
        string email,
        string? phoneNumber,
        CancellationToken cancellationToken = default);

    Task<UserAuthResult> RegisterUserAsync(
        RegisterData data,
        CancellationToken cancellationToken = default);

    Task<UserAuthResult?> GetUserByEmailAsync(
        string email,
        CancellationToken cancellationToken = default);

    Task<UserAuthResult?> GetUserByExternalProviderAsync(
        int providerId,
        string providerKey,
        CancellationToken cancellationToken = default);

    Task LinkExternalAccountAsync(
        long userId,
        int providerId,
        string providerKey,
        CancellationToken cancellationToken = default);

    Task SaveRefreshTokenAsync(
        long userId,
        string token,
        DateTime expiresAt,
        CancellationToken cancellationToken = default);

    Task RevokeRefreshTokenAsync(
        string token,
        CancellationToken cancellationToken = default);
}
