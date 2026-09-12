---
title: Move `V2.Event` API resources to `V2.Core.Events`
pr_url: https://github.com/stripe/stripe-dotnet/pull/3200
is_breaking: true
released_in_version: 49.0.0
---

- ⚠️ Move all V2 Event-related classes (`Event`, `EventDestination`,`EventReason` etc) from `Stripe.V2` to `Stripe.V2.Core`. They now correctly match their API path and are in line with all other resources. To update your code:
   - `Stripe.V2.Event` -> `Stripe.V2.Core.Event`
   - `Stripe.V2.EventDestination` -> `Stripe.V2.Core.EventDestination`
   - `Stripe.V2.EventReason` -> `Stripe.V2.Core.EventReason`
   - `Stripe.V2.EventReasonRequest` -> `Stripe.V2.Core.EventReasonRequest`
   - `Stripe.V2.EventRelatedObject` -> `Stripe.V2.Core.EventRelatedObject`
