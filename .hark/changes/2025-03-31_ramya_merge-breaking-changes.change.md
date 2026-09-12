---
title: Merge breaking changes from sdk-release/next-major branch to master
pr_url: https://github.com/stripe/stripe-dotnet/pull/3065
released_in_version: 48.0.0
---

* Adds `StripeAccount` and `StripeContext` to `StripeClientOptions`, so you can specify the Stripe-Account or Stripe-Context header at the client (instead of the individual request) level. See [PR #3058](https://github.com/stripe/stripe-dotnet/pull/3058)
* Removes `ApiMode` from `RawRequestOptions`.  ApiMode is automatically determined from the path passed to RawRequest. See [PR #3052](https://github.com/stripe/stripe-dotnet/pull/3052)
* Deprecates `ServiceNested` and `Service<T>` classes.  To implement custom services, use the request methods defined on `StripeClient`. See [PR #3051](https://github.com/stripe/stripe-dotnet/pull/3051)
* Fixes `ListAutoPaging` and `ListAutoPagingAsync` to not mutate options object passed in. See [PR #2899](https://github.com/stripe/stripe-dotnet/pull/2899)
