# Stripe.net

[![NuGet](https://img.shields.io/nuget/v/stripe.net.svg)](https://www.nuget.org/packages/Stripe.net/)
[![Build Status](https://ci.appveyor.com/api/projects/status/rg0pg5tlr1a6f8tf/branch/master?svg=true)](https://ci.appveyor.com/project/stripe/stripe-dotnet)
[![Coverage Status](https://coveralls.io/repos/github/stripe/stripe-dotnet/badge.svg?branch=master)](https://coveralls.io/github/stripe/stripe-dotnet?branch=master)

The official [Stripe][stripe] .NET library, supporting .NET Standard 2.0+, .NET Core 2.0+, and .NET Framework 4.6.1+.

## Installation

Using the [.NET Core command-line interface (CLI) tools][dotnet-core-cli-tools]:

```sh
dotnet add package Stripe.net
```

Using the [NuGet Command Line Interface (CLI)][nuget-cli]:

```sh
nuget install Stripe.net
```

Using the [Package Manager Console][package-manager-console]:

```powershell
Install-Package Stripe.net
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on *Manage NuGet Packages...*
4. Click on the *Browse* tab and search for "Stripe.net".
5. Click on the Stripe.net package, select the appropriate version in the
   right-tab and click *Install*.

## Documentation

For a comprehensive list of examples, check out the [API
documentation][api-docs].

## Usage

### Per-request configuration

All of the service methods accept an optional `RequestOptions` object. This is
used if you want to set an [idempotency key][idempotency-keys], if you are
using [Stripe Connect][connect-auth], or if you want to pass the secret API
key on each method.

```c#
var requestOptions = new RequestOptions();
requestOptions.ApiKey = "SECRET API KEY";
requestOptions.IdempotencyKey = "SOME STRING";
requestOptions.StripeAccount = "CONNECTED ACCOUNT ID";
```

### Using a custom `HttpClient`

You can configure the library with your own custom `HttpClient`:

```c#
StripeConfiguration.StripeClient = new StripeClient(
    apiKey,
    httpClient: new SystemNetHttpClient(httpClient));
```

Please refer to the [Advanced client usage][advanced-client-usage] wiki page
to see more examples of using custom clients, e.g. for using a proxy server, a
custom message handler, etc.

### Automatic retries

The library automatically retries requests on intermittent failures like on a
connection error, timeout, or on certain API responses like a status `409
Conflict`. [Idempotency keys][idempotency-keys] are always added to requests to
make any such subsequent retries safe.

By default, it will perform up to two retries. That number can be configured
with `StripeConfiguration.MaxNetworkRetries`:

```c#
StripeConfiguration.MaxNetworkRetries = 0; // Zero retries
```

### Writing a plugin

If you're writing a plugin that uses the library, we'd appreciate it if you
identified using `StripeConfiguration.AppInfo`:

```c#
StripeConfiguration.AppInfo = new AppInfo
{
    Name = "MyAwesomePlugin",
    Url = "https://myawesomeplugin.info",
    Version = "1.2.34",
};
```

This information is passed along when the library makes calls to the Stripe
API. Note that while `Name` is always required, `Url` and `Version` are
optional.

## Development

The test suite depends on [stripe-mock][stripe-mock], so make sure to fetch
and run it from a background terminal
([stripe-mock's README][stripe-mock-usage] also contains instructions for
installing via Homebrew and other methods):

```sh
go get -u github.com/stripe/stripe-mock
stripe-mock
```

Run all tests from the `src/StripeTests` directory:

```sh
dotnet test
```

Run some tests, filtering by name:

```sh
dotnet test --filter FullyQualifiedName~InvoiceServiceTest
```

Run tests for a single target framework:

```sh
dotnet test --framework netcoreapp2.1
```

The library uses [`dotnet-format`][dotnet-format] for code formatting. Code
must be formatted before PRs are submitted, otherwise CI will fail. Run the
formatter with:

```sh
dotnet format src/Stripe.net.sln
```

For any requests, bug or comments, please [open an issue][issues] or [submit a
pull request][pulls].

[advanced-client-usage]: https://github.com/stripe/stripe-dotnet/wiki/Advanced-client-usage
[api-docs]: https://stripe.com/docs/api?lang=dotnet
[api-keys]: https://dashboard.stripe.com/apikeys
[connect-auth]: https://stripe.com/docs/connect/authentication#authentication-via-the-stripe-account-header
[dotnet-core-cli-tools]: https://docs.microsoft.com/en-us/dotnet/core/tools/
[dotnet-format]: https://github.com/dotnet/format
[idempotency-keys]: https://stripe.com/docs/api/idempotent_requests?lang=dotnet
[issues]: https://github.com/stripe/stripe-dotnet/issues/new
[nuget-cli]: https://docs.microsoft.com/en-us/nuget/tools/nuget-exe-cli-reference
[package-manager-console]: https://docs.microsoft.com/en-us/nuget/tools/package-manager-console
[pulls]: https://github.com/stripe/stripe-dotnet/pulls
[stripe]: https://stripe.com
[stripe-mock]: https://github.com/stripe/stripe-mock
[stripe-mock-usage]: https://github.com/stripe/stripe-mock#usage
