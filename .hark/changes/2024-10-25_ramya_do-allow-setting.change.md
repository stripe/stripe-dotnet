---
title: Do not allow setting API Version directly on StripeConfiguration
pr_url: https://github.com/stripe/stripe-dotnet/pull/3011
released_in_version: 47.1.0-beta.1
---

* `StripeConfiguration.ApiVersion` is no longer settable. If you were using this to set the beta headers, use the helper method `StripeConfiguration.AddBetaVersion()` instead.
