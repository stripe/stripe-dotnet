---
title: ParseThinEvent__Experimental is no longer needed
pr_url: https://github.com/stripe/stripe-dotnet/pull/3188
is_breaking: true
released_in_version: 49.3.0-alpha.1
---

* ⚠️ Remove the `StripeClient. ParseThinEvent__Experimental` and `PushedEvent` classes. They've been replaced with `StripeClient.ParseEventNotification` and the *`EventNotification` classes respectively.
