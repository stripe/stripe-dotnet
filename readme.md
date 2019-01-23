# Stripe.net
[![Build status](https://ci.appveyor.com/api/projects/status/rg0pg5tlr1a6f8tf/branch/master?svg=true)](https://ci.appveyor.com/project/stripe/stripe-dotnet) [![NuGet](https://img.shields.io/nuget/v/stripe.net.svg)](https://www.nuget.org/packages/Stripe.net/)
[![Coverage Status](https://coveralls.io/repos/github/stripe/stripe-dotnet/badge.svg?branch=master)](https://coveralls.io/github/stripe/stripe-dotnet?branch=master)

The official Stripe library, supporting .NET Standard 1.2+, .NET Core 1.0+, and .NET Framework 4.5+

## Documentation

See the [.NET API docs](https://stripe.com/docs/api/dotnet#intro).

## Installation

### Install Stripe.net via NuGet

From the command line:

	nuget install Stripe.net

From Package Manager:

	PM> Install-Package Stripe.net

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on *Manage NuGet Packages...*
4. Click on the *Browse* tab and search for "Stripe.net".
5. Click on the Stripe.net package, select the appropriate version in the right-tab and click *Install*.

### Set the API Key for your project

You can configure the Stripe.net package to use your secret API key in one of two ways:

a) In your application initialization, set your API key (only once once during startup):

```csharp
StripeConfiguration.ApiKey = "[your api key here]";
```

b) Pass the API key to [RequestOptions](#requestoptions):

```csharp
var planService = new PlanService();
planService.Get(*planId*, new RequestOptions { ApiKey = "[your api key here]" });
```

You can obtain your secret API key from the [API Settings](https://dashboard.stripe.com/account/apikeys) in the Dashboard.

### Xamarin/Mono Developers (Optional)

If you are using Xamarin/Mono, you may want to provide your own `HttpMessageHandler`. You can do so by passing an instance to `StripeConfiguration.HttpMessageHandler` on your application's startup. See [this thread](https://github.com/stripe/stripe-dotnet/issues/567) for details.

## Additional Resources

- [Stripe.net Fundamentals with ASP.NET (MVC)](https://app.pluralsight.com/library/courses/stripe-fundamentals-with-asp-net-mvc) [_PluralSight: Craig McKeachie_]

## Support

* Make sure to review open [issues](https://github.com/stripe/stripe-dotnet/issues) and [pull requests](https://github.com/stripe/stripe-dotnet/pulls) before opening a new issue.
* Feel free to leave a comment or [reaction](https://github.com/blog/2119-add-reactions-to-pull-requests-issues-and-comments) on any existing issues.
* For all other support requests, please [reach out to Stripe](https://support.stripe.com/email) via email.

## Helpful Library Information

### Request Options

All of the service methods accept an optional `RequestOptions` object. This is used if you need an [Idempotency Key](https://stripe.com/docs/api?lang=curl#idempotent_requests), if you are using [Stripe Connect](https://stripe.com/docs/connect/authentication#authentication-via-the-stripe-account-header), or if you want to pass the secret API key on each method.

```csharp
var requestOptions = new RequestOptions();
requestOptions.ApiKey = "SECRET API KEY";                        // (optional) set the api key on a per-request basis
requestOptions.IdempotencyKey = "SOME STRING";                   // (optional) create an idempotent request
requestOptions.StripeConnectAccountId = "CONNECTED ACCOUNT ID";  // (optional) authenticate as a connected account
```

### Responses

The [`StripeResponse`](./src/Stripe.net/Infrastructure/public/StripeResponse.cs) object is an attribute (with the same name) attached to all entities in Stripe.net when they are returned from a service call.

**Example: Access the StripeResponse**
```csharp
var chargeService = new ChargeService();
StripeCharge charge = chargeService.Create(...);
StripeResponse response = charge.StripeResponse;
```

The information that can be derived from the `StripeResponse` is available from the [StripeResponse Class](https://github.com/stripe/stripe-dotnet/blob/master/src/Stripe.net/Infrastructure/Public/StripeResponse.cs).

```csharp
public class StripeResponse
{
	// ResponseJson will always tell you the complete json Stripe returned to Stripe.net.
	// this will be the same as the ObjectJson when you execute a create/get/delete call.
	// however, if you execute a List() method, the ResponseJson will have the full api result
	// from Stripe (a charge list with 10 charges, for example).
	public string ResponseJson { get; set; }

	// when you call a List() method, the object json is the object in the response array that represents
	// the entity. The ResponseJson will be the full array returned from Stripe on every entity, however,
	// since that was the full response from Stripe. ObjectJson is always the same as ResponseJson when
	// you are doing a regular create/get/delete, because you are dealing with a single object.
	public string ObjectJson { get; set; }

	// this is the request id of the call, as seen in the Stripe dashboard. I would recommend logging
	// this and/or saving it to your database. this is very useful to help you find your request
	// in the dashboard, or ask Stripe a question about your api call
	public string RequestId { get; set; }

	// this is the request date and time of the call. I would also recommend logging this and/or
	// saving it to your database, as it tells you when Stripe processed the request.
	public DateTime RequestDate { get; set; }
}
```

### Date Filtering

Many of the `List()`-methods support parameters to filter by date.  You can use the `DateFilter` class to combine the filters to make more interesting and complex queries.

**Example: Interesting Queries with DateFilter**
```csharp
var chargeService = new ChargeService();

var chargesToday = chargeService.List(new ChargeListOptions {
	Created = new DateFilter { GreaterThanOrEqual = DateTime.UtcNow.Date }
});

var chargesYesterday = chargeService.List(new ChargeListOptions {
	Created = new DateFilter {
		GreaterThanOrEqual = DateTime.Now.AddDays(-1).Date,
		LessThan = DateTime.Now.Date
	}
});
```

## Contribution Guidelines

We welcome contributions from anyone interested in Stripe or Stripe.net development. If you'd like to submit a pull request, it's best to start with an issue to describe what you'd like to build.

Once you've written your pull request, **please make sure you test your changes**.
