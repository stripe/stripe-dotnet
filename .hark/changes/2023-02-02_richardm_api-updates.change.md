---
title: API Updates
pr_link: https://github.com/stripe/stripe-dotnet/pull/2640
is_stripe_api_change: true
released_in_version: 41.6.0
---

* Add support for `Resume` method on resource `Subscription`
* Add support for `PaymentLink` on `Checkout.SessionListOptions`
* Add support for `TrialSettings` on `Checkout.SessionSubscriptionDataOptions`, `SubscriptionCreateOptions`, `SubscriptionUpdateOptions`, and `Subscription`
* Add support for `ShippingCost` on `CreditNoteCreateOptions`, `CreditNotePreviewLinesOptions`, `CreditNotePreviewOptions`, `CreditNote`, `InvoiceCreateOptions`, `InvoiceUpdateOptions`, and `Invoice`
* Add support for `AmountShipping` on `CreditNote` and `Invoice`
* Add support for `ShippingDetails` on `InvoiceCreateOptions`, `InvoiceUpdateOptions`, and `Invoice`
* Add support for `SubscriptionResumeAt` on `InvoiceUpcomingLinesOptions` and `InvoiceUpcomingOptions`
* Add support for `InvoiceCreation` on `PaymentLinkCreateOptions`, `PaymentLinkUpdateOptions`, and `PaymentLink`
