---
title: Fix V2 list options base class
pr_url: https://github.com/stripe/stripe-dotnet/pull/3026
released_in_version: 47.1.0
---

* Remove `StartingAfter` and `EndingBefore` properties from `Stripe.V2.EventListOptions` and `Stripe.V2.EventDestinationListOptions`.  These properties are not supported on V2 List APIs and would result in a HTTP 400 error if provided.
