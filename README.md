[![](https://img.shields.io/nuget/v/Soenneker.Redis.Suite.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Redis.Suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.redis.suite/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.redis.suite/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Redis.Suite.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Redis.Suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.redis.suite/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.redis.suite/actions/workflows/codeql.yml)

# Soenneker.Redis.Suite

A concoction of Redis utilities and libraries.

## Install

```bash
dotnet add package Soenneker.Redis.Suite
```

## Quick start

```csharp
using Soenneker.Redis.Suite.Registrars;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
var result = services.AddRedisSuiteAsSingleton();
```

Registers Redis Suite with a singleton lifetime.

## What you get

- `RedisSuiteRegistrar` — A concoction of Redis utilities and libraries.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `RedisSuiteRegistrar.AddRedisSuiteAsSingleton(services)` | Registers Redis Suite with a singleton lifetime. | The same service collection, so additional registrations can be chained. |
| `RedisSuiteRegistrar.AddRedisSuiteAsScoped(services)` | Registers Redis Suite with a scoped lifetime. | The same service collection, so additional registrations can be chained. |
