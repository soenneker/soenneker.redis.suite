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
    /// Adds redis suite as singleton.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The result of the operation.</returns>
    public static IServiceCollection AddRedisSuiteAsSingleton(this IServiceCollection services)
    {
        services.AddRedisLockUtilAsSingleton().AddRedisServerUtilAsSingleton();

        return services;
    }

    /// <summary>
    /// Adds redis suite as scoped.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The result of the operation.</returns>
    public static IServiceCollection AddRedisSuiteAsScoped(this IServiceCollection services)
    {
        services.AddRedisLockUtilAsScoped().AddRedisServerUtilAsScoped();

        return services;
    }
}