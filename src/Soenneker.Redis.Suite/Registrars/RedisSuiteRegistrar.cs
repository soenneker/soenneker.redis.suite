using Microsoft.Extensions.DependencyInjection;
using Soenneker.Redis.Lock.Registrars;
using Soenneker.Redis.Util.Server.Registrars;

namespace Soenneker.Redis.Suite.Registrars;

/// <summary>
/// Registers the Redis value, server, and distributed-lock utilities as a group.
/// </summary>
public static class RedisSuiteRegistrar
{
    /// <summary>
    /// Registers all suite utilities with singleton lifetimes.
    /// </summary>
    /// <param name="services">Service collection that receives the registration.</param>
    /// <returns>The same service collection, so additional registrations can be chained.</returns>
    public static IServiceCollection AddRedisSuiteAsSingleton(this IServiceCollection services)
    {
        services.AddRedisLockUtilAsSingleton().AddRedisServerUtilAsSingleton();

        return services;
    }

    /// <summary>
    /// Registers all suite utility wrappers with scoped lifetimes.
    /// </summary>
    /// <param name="services">Service collection that receives the registration.</param>
    /// <returns>The same service collection, so additional registrations can be chained.</returns>
    public static IServiceCollection AddRedisSuiteAsScoped(this IServiceCollection services)
    {
        services.AddRedisLockUtilAsScoped().AddRedisServerUtilAsScoped();

        return services;
    }
}
