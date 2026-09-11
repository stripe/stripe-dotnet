---
title: Add missing events to Events.cs
pr_link: https://github.com/stripe/stripe-dotnet/pull/2390
released_in_version: 39.76.0
---

* Add support for `BillingPortalConfigurationCreated`, `BillingPortalConfigurationUpdated`, `CheckoutSessionExpired`, `InvoiceFinalizationFailed`, `QuoteAccepted`, `QuoteCanceled`, `QuoteCreated`, `QuoteFinalized`, `TransferFailed`, and `TransferPaid` on `Events`
* Marks `InvoiceFinalizationError` as deprecated. This has been `InvoiceFinalizationFailed` in recent versions of the Stripe API.
