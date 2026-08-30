[![](https://img.shields.io/nuget/v/Soenneker.Redis.Suite.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Redis.Suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.redis.suite/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.redis.suite/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Redis.Suite.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Redis.Suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.redis.suite/build-and-test.yml?label=build%20and%20test&style=for-the-badge)](https://github.com/soenneker/soenneker.redis.suite/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.redis.suite/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.redis.suite/actions/workflows/codeql.yml)

# Soenneker.Redis.Suite

One registration package for Soenneker's Redis value, server, and distributed-lock utilities.

## Installation

```bash
dotnet add package Soenneker.Redis.Suite
```

## Configuration

The included utilities use the standard Redis connection setting:

```json
{
  "Azure": {
    "Redis": {
      "ConnectionString": "localhost:6379,abortConnect=false"
    }
  }
}
```

## Registration

```csharp
using Soenneker.Redis.Suite.Registrars;

services.AddRedisSuiteAsScoped();
```

This registers:

- `IRedisUtil` for common key, string, hash, expiration, and conditional operations.
- `IRedisServerUtil` for server-level Redis operations.
- `IRedisLockUtil` for expiring distributed locks.

Use `AddRedisSuiteAsSingleton()` when the wrappers should also live for the application lifetime. With scoped registration, the underlying Redis client remains shared through the registrations provided by the component packages.

`Soenneker.Redis.Dump`, `Soenneker.Redis.Semaphores`, and `Soenneker.Redis.WorkQueue` are separate packages and are not registered by this suite.
