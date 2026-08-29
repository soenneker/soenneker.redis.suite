using Microsoft.Extensions.DependencyInjection;
using Soenneker.Redis.Lock.Registrars;
using Soenneker.Redis.Util.Server.Registrars;

namespace Soenneker.Redis.Suite.Registrars;

/// <summary>
/// A concoction of Redis utilities and libraries
/// </summary>
public static class RedisSuiteRegistrar
{
    /// <summary>
    /// Registers Redis Suite with a singleton lifetime.
    /// </summary>
    /// <param name="services">Service collection that receives the registration.</param>
    /// <returns>The same service collection, so additional registrations can be chained.</returns>
    public static IServiceCollection AddRedisSuiteAsSingleton(this IServiceCollection services)
    {
        services.AddRedisLockUtilAsSingleton().AddRedisServerUtilAsSingleton();

        return services;
    }

    /// <summary>
    /// Registers Redis Suite with a scoped lifetime.
    /// </summary>
    /// <param name="services">Service collection that receives the registration.</param>
    /// <returns>The same service collection, so additional registrations can be chained.</returns>
    public static IServiceCollection AddRedisSuiteAsScoped(this IServiceCollection services)
    {
        services.AddRedisLockUtilAsScoped().AddRedisServerUtilAsScoped();

        return services;
    }
}
