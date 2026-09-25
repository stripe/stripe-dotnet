---
title: Add support for .NET 10
semver_level: minor
---

Stripe.net now provides a native `net10.0` asset with `System.Configuration.ConfigurationManager` 10.0.0. The library remains compiled with C# 8 and continues to support its existing target frameworks.

Applications that move to .NET 10 remain subject to Microsoft's runtime and base class library compatibility changes. On .NET 10, modern `HttpClient` protocol negotiation is used and Stripe.net does not modify the process-wide `ServicePointManager.SecurityProtocol` setting. The test project uses .NET 10's built-in async LINQ APIs instead of its test-only `System.Linq.Async` dependency to avoid extension-method conflicts. No Stripe.net API incompatibility was identified by the .NET 10 test suite.
