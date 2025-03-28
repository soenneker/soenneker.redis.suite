﻿using Microsoft.Extensions.DependencyInjection;
using Soenneker.Redis.Lock.Registrars;
using Soenneker.Redis.Util.Server.Registrars;

namespace Soenneker.Redis.Suite.Registrars;

/// <summary>
/// A concoction of Redis utilities and libraries
/// </summary>
public static class RedisSuiteRegistrar
{
    public static IServiceCollection AddRedisSuiteAsSingleton(this IServiceCollection services)
    {
        services.AddRedisLockUtilAsSingleton().AddRedisServerUtilAsSingleton();

        return services;
    }

    public static IServiceCollection AddRedisSuiteAsScoped(this IServiceCollection services)
    {
        services.AddRedisLockUtilAsScoped().AddRedisServerUtilAsScoped();

        return services;
    }
}