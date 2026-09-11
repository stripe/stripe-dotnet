---
title: A few Billing changes
pr_link: https://github.com/stripe/stripe-dotnet/pull/1758
released_in_version: 28.4.0
---

* Add support for `Schedule` to `Subscription`
* Add missing parameters to `UpcomingInvoiceOptions` and `UpcomingInvoiceListLineItemsOptions`: `Schedule`, `SubscriptionCancelAt` and `SubscriptionCancelNow`
* Add missing properties and parameters for a `SubscriptionSchedule` phase: `BillingThresholds`, `CollectionMethod`, `DefaultPaymentMethod` and `InvoiceSettings`
