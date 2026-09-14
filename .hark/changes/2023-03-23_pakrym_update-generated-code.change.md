---
title: Update generated code for beta (new)
pr_url: https://github.com/stripe/stripe-dotnet/pull/2662
is_stripe_api_change: true
released_in_version: 41.12.0-beta.1
---

* Add support for new resources `Tax.CalculationLineItem` and `Tax.TransactionLineItem`
* Add support for `CollectInputs` method on resource `Terminal.Reader`
* Add support for `FinancingOffer` on `CapitalFinancingSummary`
* Add support for `FxRate` on `CheckoutSessionCurrencyConversion`
* Add support for `AutomaticPaymentMethods` on `SetupIntentCreateOptions` and `SetupIntent`
* Remove support for `Preview` on `TaxCalculationCreateOptions`
* Change type of `TaxCalculationLineItems` from `$LineItem` to `$Tax.CalculationLineItem`
* Change type of `TaxTransactionLineItems` from `$LineItem` to `$Tax.TransactionLineItem`
* Add support for `CollectInputs` on `TerminalReaderAction`
