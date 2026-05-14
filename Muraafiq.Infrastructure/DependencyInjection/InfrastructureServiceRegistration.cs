using Microsoft.Extensions.DependencyInjection;
using Muraafiq.Application.Common.Interfaces;
using Muraafiq.Infrastructure.Persistence;

namespace Muraafiq.Infrastructure.DependencyInjection;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        // 1. Register the Connection Factory as Singleton (configuration parsing happens once)
        services.AddSingleton<ISqlConnectionFactory, SqlConnectionFactory>();

        // 2. Register Unit of Work as Scoped (One instance per HTTP Request)
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}
