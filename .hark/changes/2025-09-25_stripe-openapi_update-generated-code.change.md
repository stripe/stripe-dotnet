---
title: Update generated code for beta
pr_url: https://github.com/stripe/stripe-dotnet/pull/3193
is_stripe_api_change: true
released_in_version: 49.1.0-beta.1
---

* Add support for `AttachCadence` method on resource `Subscription`
* Add support for `BillingCadence` on `InvoiceCreatePreviewOptions`, `SubscriptionCreateOptions`, `SubscriptionUpdateOptions`, and `Subscription`
* Add support for `BillingCadenceDetails` on `Invoice.Parent` and `QuotePreviewInvoice.Parent`
