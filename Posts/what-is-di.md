---
title: "What is Dependency Injection?"
date: 2024-11-08
description: "A beginner-friendly guide to understanding DI in C#."
tags: [csharp, di, fundamentals]
author: John Code
avatar: "/images/authors/john.jpg"
image: "/images/posts/di.png"
---

Dependency Injection (DI) is one of those terms that gets thrown around a lot in the C# and ASP.NET Core ecosystem. If you're new to it, don't worry — this post breaks it down into simple terms with real-world analogies.

## What Even Is It?

Imagine you run a bakery. Every time you bake a cake, you go to the store to buy ingredients. That’s exhausting and inefficient. Instead, imagine someone hands you a pre-stocked basket with everything you need. That’s dependency injection.

In programming terms, **DI is a technique where dependencies (things a class needs to do its work) are provided rather than created by the class itself.**

## Why Use DI?

### 1. Testability

With DI, you can easily substitute mock implementations in tests.

### 2. Flexibility

You can change implementations without touching your class logic.

### 3. Separation of Concerns

Classes stay focused on their job, not how to get their tools.

## Constructor Injection

This is the most common form of DI in .NET:

```csharp
public class MyService
{
    private readonly ILogger<MyService> _logger;

    public MyService(ILogger<MyService> logger)
    {
        _logger = logger;
    }
}
```

ASP.NET Core will automatically resolve this if `ILogger<MyService>` is registered in the service container.

## Registering Services

You typically register services in `Program.cs`:

```csharp
builder.Services.AddScoped<IMyService, MyService>();
```

This tells the DI container: “Whenever something needs an `IMyService`, give them a `MyService`.”

## Common Pitfalls

## Wrapping Up

Dependency Injection is foundational to clean, maintainable C# applications. Once you embrace it, you'll wonder how you ever structured your code without it.

Thanks for learning with me!

Dependency Injection (DI) is a fundamental concept in modern C#. Here's how it works, why it matters, and how ASP.NET Core uses it under the hood.
