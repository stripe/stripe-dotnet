---
title: Support for APIs in the new API version 2024-09-30.acacia
pr_link: https://github.com/stripe/stripe-dotnet/pull/2980
is_stripe_api_change: true
released_in_version: 46.0.0
---

This release changes the pinned API version to `2024-09-30.acacia`. Please read the [API Changelog](https://docs.stripe.com/changelog/acacia#2024-09-30.acacia) and carefully review the API changes before upgrading.

### ⚠️ Breaking changes due to changes in the API

* Rename `UsageThresholdConfig` to `UsageThreshold` on `Billing.Alert` and `Billing.AlertCreateOptions`
* Remove support for `Filter` on `Billing.Alert` and `BillingAlert.AlertCreateOptions `. Use the filters on the `UsageThreshold` instead
* Remove support for `CustomerConsentCollected` on `Terminal.ReaderProcessSetupIntentOptions`

### ⚠️ Other Breaking changes in the SDK

Refer to our [migration guide for v46](https://github.com/stripe/stripe-dotnet/wiki/Migration-guide-for-v46) for a list of backwards incompatible changes in this release.  Here is a summary of things to watch out for:

* [Remove obsolete properties and methods](https://github.com/stripe/stripe-dotnet/wiki/Migration-guide-for-v46#removals) from `Service` and `ServiceNested` base classes including `CreateEntity` and other `*Entity` and `*EntityAsync` methods, `BasePath`, and `BaseUrl`
* [Rename `Stripe.Event` to `Stripe.EventTypes`](https://github.com/stripe/stripe-dotnet/wiki/Migration-guide-for-v46#renaming-stripeevents-to-stripeeventtypes). This class contains constants for event type strings.
* For more predictable naming of child services and their corresponding Options classes:
    * [Rename child service classes](https://github.com/stripe/stripe-dotnet/wiki/Migration-guide-for-v46#renaming-child-services) to have the parent service's name as a prefix, e.g. `CapabilityService` is now `AccountCapabilityService`, and rename associated Options classes to match. This makes the classes more discoverable and the relationship between parent and child more clear
    * [Rename Options classes for child services](https://github.com/stripe/stripe-dotnet/wiki/Migration-guide-for-v46#renaming-options-classes) so that the name of the service or resource (e.g. `CustomerFundingInstructions`) comes before the verb (e.g. `Create`, `List`).
* [Nested child service methods have been separated into separate services](https://github.com/stripe/stripe-dotnet/wiki/Migration-guide-for-v46#separating-child-service-methods-into-new-services). These child services were previously represented as special methods within a parent service.
* `Newtonsoft.Json` dependency has been upgraded for all .NET target runtimes. This is potentially a breaking change if you also depend on `Newtonsoft.Json` directly from your application. To migrate, please upgrade the version of Newtonsoft.Json your application depends on.  If you have runtime conflicts with another library dependency, you can use `<bindingRedirect>` to specify which version .NET should load (see https://stackoverflow.com/a/51053646 and https://learn.microsoft.com/en-us/dotnet/framework/configure-apps/file-schema/runtime/bindingredirect-element)

### Additions

* Add support for `UsageThreshold` on `Billing.AlertCreateOptions` and `BillingAlert`
* Add support for `CustomUnitAmount` on `ProductDefaultPriceDataOptions`
* Add support for `AllowRedisplay` on `Terminal.ReaderProcessSetupIntentOptions` and `TerminalReaderProcessConfigOptions`
* Add support for new Usage Billing APIs `Billing.MeterEvent`, `Billing.MeterEventAdjustments`, `Billing.MeterEventSession`, `Billing.MeterEventStream` and the new Events API `Core.Events` under the [v2 namespace ](https://docs.corp.stripe.com/api-v2-overview)
* Add method `ParseThinEvent()` on the `StripeClient` class to parse [thin events](https://docs.corp.stripe.com/event-destinations#events-overview).
* Add methods [RawRequestAsync()](https://github.com/stripe/stripe-dotnet/tree/master?tab=readme-ov-file#custom-requests) on the `StripeClient` class that takes a HTTP method type, url and relevant parameters to make requests to the Stripe API that are not yet supported in the SDK.

#### StripeClient

Add access to services to StripeClient under `V1` and `V2` property accessors, so that instead of
```csharp
StripeConfiguration.ApiKey = apiKey;
var svc = new CustomerService();
svc.Get(customerId);
```
you can write:
```csharp
var client = new StripeClient(apiKey);
client.V1.Customers.Get(customerId)
```
This supports a move towards a services-based client pattern where a `StripeClient` instance consolidates configuration and service access. This enables you simultaneously use multiple clients with different configuration options (such as API keys), and makes it much easier to discover what services are available by inspecting the V1 and V2 properties (either manually or via your code editors auto-completion).
