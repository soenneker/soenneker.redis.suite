using Microsoft.Extensions.DependencyInjection;
using Soenneker.Redis.Lock.Registrars;
using Soenneker.Redis.Util.Server.Registrars;

namespace Soenneker.Redis.Suite.Registrars;

/// <summary>
/// A concoction of Redis utilities and libraries
/// </summary>
public static class RedisSuiteRegistrar
{
    public static void AddRedisSuiteAsSingleton(this IServiceCollection services)
    {
        services.AddRedisLockUtilAsSingleton();
        services.AddRedisServerUtilAsSingleton();
    }
}