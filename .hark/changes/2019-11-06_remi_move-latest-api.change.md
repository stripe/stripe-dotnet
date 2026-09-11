---
title: Move to the latest API version and add new changes
pr_link: https://github.com/stripe/stripe-dotnet/pull/1826
released_in_version: 33.0.0
---

* Move to API version `2019-11-05`
* Add `DefaultSettings` on `SubscriptionSchedule`
* Remove `BillingThresholds`, `CollectionMethod`, `DefaultPaymentMethod` and `DefaultSource` and `invoice_settings` from `SubscriptionSchedule`
* `OffSession` on `PaymentIntent` is now always a boolean
* Disabling using global settings when serializing or deserializing JSON.
