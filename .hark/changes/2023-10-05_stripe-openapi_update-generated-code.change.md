---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/2775
is_stripe_api_change: true
released_in_version: 42.9.0-beta.1
---

* Add support for `MarkDraft` and `MarkStale` methods on resource `Quote`
* Remove support for `DraftQuote` and `MarkStaleQuote` methods on resource `Quote`
* Add support for `Liability` on `CheckoutSessionAutomaticTaxOptions` and `CheckoutSessionAutomaticTax`
* Add support for `Issuer` on `CheckoutSessionInvoiceCreationInvoiceDataOptions` and `CheckoutSessionInvoiceCreationInvoiceData`
* Add support for `InvoiceSettings` on `CheckoutSessionSubscriptionDataOptions`
* Add support for `PersonalizationDesign` on `Issuing.CardListOptions`
* Add support for `AllowBackdatedLines` on `QuoteCreateOptions`, `QuoteUpdateOptions`, and `Quote`
