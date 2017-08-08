![Stripe](https://stripe.com/img/navigation/logo.png?2)  
[![Build status](https://ci.appveyor.com/api/projects/status/rg0pg5tlr1a6f8tf?svg=true)](https://ci.appveyor.com/project/stripe-appveyor-ci/stripe-dotnet)

## Support

Search [issues](https://github.com/stripe/stripe-dotnet/issues) and [pull requests](https://github.com/stripe/stripe-dotnet/pulls) to see if your issue has already been reported.  If it has, please leave a comment or a [reaction](https://github.com/blog/2119-add-reactions-to-pull-requests-issues-and-comments).
[Create a new issue](https://github.com/stripe/stripe-dotnet/issues/new) or reach out to Stripe via [email](https://support.stripe.com/email) if your question is still not answered.

## Installation

### Install Stripe.net via NuGet

From the command line:

```
nuget install Stripe.net
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on "Manage NuGet Packages..."
4. Click on the "Browse"-tab and search for "Stripe.net".
5. Click on the Stripe.net package, select the appropriate version in the right-tab and click "Install".

### Set the API Key for your project

You can configure the Stripe.net package to utilize your Secret API Key in one of two ways:

a) In your application initialization, call this function (you only have to do it once during startup):

```csharp
	StripeConfiguration.SetApiKey("[your api key here]");
```

b) pass the api key to a [StripeRequestOptions](#striperequestoptions):

```csharp
	var planService = new StripePlanService();
	planService.Get(*planId*, new StripeRequestOptions() { ApiKey = "[your api key here]" });
```

You can obtain this API Key from the [API Settings](https://dashboard.stripe.com/account/apikeys) in your dashboard.

### Xamarin/Mono Developers (Optional)

If you are using Xamarin/Mono, you may want to provide your own `HttpMessageHandler`. You can do so by passing an instance to StripeConfiguration.HttpMessageHandler on your application's startup. See [this thread](https://github.com/stripe/stripe-dotnet/issues/567) for details.

## Additional Resources

- [Stripe.net Fundamentals with ASP.NET (MVC)](https://app.pluralsight.com/library/courses/stripe-fundamentals-with-asp-net-mvc) [_PluralSight: Craig McKeachie_]

## Helpful Library Information

### Request Options

All of the service methods accept an optional StripeRequestOptions object. This is used if you need an [Idempotency Key](https://stripe.com/docs/api?lang=curl#idempotent_requests), if you are using [Stripe Connect](https://stripe.com/docs/connect/authentication#authentication-via-the-stripe-account-header), or if you want to pass the Secret API Key on each method.

```cs
	var requestOptions = new StripeRequestOptions();
	requestOptions.ApiKey = "SECRET API KEY";                        // (optional) set the api key on a per-request basis
	requestOptions.IdempotencyKey = "SOME STRING";                   // (optional) create an idempotent request
	requestOptions.StripeConnectAccountId = "CONNECTED ACCOUNT ID";  // (optional) authenticate as a connected account

```

### Responses

The [`StripeResponse`](./src/Stripe.net/Infrastructure/public/StripeResponse.cs) object is an attribute (with the same name) attached to all entities in Stripe.net when they are returned from a service call.

**Example: Access the StripeResponse**
```csharp
var chargeService = new StripeChargeService();
StripeCharge charge = chargeService.Create(...);
StripeResponse response = charge.StripeResponse;
```

The information that can be derived from the StripeResponse is available from the [StripeResponse Class](https://github.com/stripe/stripe-dotnet/blob/master/src/Stripe.net/Infrastructure/Public/StripeResponse.cs).

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

Many of the `List()`-methods support parameters to filter by date.  You can use the `StripeDateFilter` class to combine the filters to make more interesting and complex queries.

**Example: Interesting Queries with StripeDateFilter**
```csharp
	var chargeService = new StripeChargeService();

	var chargesToday = chargeService.List(new StripeChargeListOptions {
		Created = new StripeDateFilter { GreaterThanOrEqual = DateTime.UtcNow.Date }
	});

	var chargesYesterday = chargeService.List(new StripeChargeListOptions {
		Created = new StripeDateFilter {
			GreaterThanOrEqual = DateTime.Now.AddDays(-1).Date,
			LessThan = DateTime.Now.Date
		}
	});
```

## Contribution Guidelines

We encourage anyone with an interest in Stripe or Stripe.net to contribute to the library.  If you're interested in submitting a Pull Request, it is sometimes helpful to submit an Issue first to describe what you believe needs to be built.  This will usually initiate a bit of a back-and-forth between Stripe's development team, the developer community, and you, so you can get a leg up on getting started.

Once you've written your Pull Request, **please make sure it's tested**!  We have two test suites one in the `Stripe.net.Test` project and one in the `Stripe.Test.XUnit` project.  Since we're moving towards XUnit as the preferred testing suite, please try and build tests against the `Stripe.Test.XUnit` project.  If you need help, just reach out through the Pull Request or Issue-- we're happy to help where we can!
