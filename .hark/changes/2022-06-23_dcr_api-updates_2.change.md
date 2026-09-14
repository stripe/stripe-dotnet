---
title: API Updates
pr_url: https://github.com/stripe/stripe-dotnet/pull/2513
is_stripe_api_change: true
released_in_version: 39.120.0
---

* Add support for `PromptpayPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
* Add support for `Promptpay` on `ChargePaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `SubtotalExcludingTax` on `CreditNote` and `Invoice`
* Add support for `AmountExcludingTax` and `UnitAmountExcludingTax` on `CreditNoteLineItem` and `InvoiceLineItem`
* Add support for `RenderingOptions` on `InvoiceCreateOptions` and `InvoiceUpdateOptions`
* Add support for `TotalExcludingTax` on `Invoice`
* Add support for `AutomaticPaymentMethods` on `OrderPaymentSettings`
* Add support for `PromptpayDisplayQrCode` on `PaymentIntentNextAction`
