---
title: API Updates
pr_link: https://github.com/stripe/stripe-dotnet/pull/2658
is_stripe_api_change: true
released_in_version: 41.11.0-beta.1
---

* Add support for `CreateFromCalculation` method on resource `Tax.Transaction`
* Add support for `Paypal` on `MandatePaymentMethodDetails`, `SetupAttemptPaymentMethodDetails`, `SetupIntentPaymentMethodOptionsOptions`, and `SetupIntentPaymentMethodOptions`
* Add support for `SetupFutureUsage` on `OrderPaymentSettingsPaymentMethodOptionsPaypalOptions`, `OrderPaymentSettingsPaymentMethodOptionsPaypal`, `PaymentIntentPaymentMethodOptionsPaypalOptions`, and `PaymentIntentPaymentMethodOptionsPaypal`
* Remove support for `AppliesTo` on `QuotePreviewInvoiceLinesOptions`
* Add support for `ShippingCost` on `TaxCalculationCreateOptions`, `TaxCalculation`, `TaxTransactionCreateReversalOptions`, and `TaxTransaction`
* Add support for `TaxBreakdown` on `TaxCalculation`
* Remove support for `TaxSummary` on `TaxCalculation`
