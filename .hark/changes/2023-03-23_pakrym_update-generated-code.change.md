---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/2661
is_stripe_api_change: true
released_in_version: 41.11.0
---

* Add support for new resources `Tax.CalculationLineItem`, `Tax.Calculation`, `Tax.TransactionLineItem`, and `Tax.Transaction`
* Add support for `Create` and `ListLineItems` methods on resource `Calculation`
* Add support for `CreateFromCalculation`, `CreateReversal`, `Create`, `Get`, and `ListLineItems` methods on resource `Transaction`
* Add support for `CurrencyConversion` on `Checkout.Session`
* Add support for `AutomaticPaymentMethods` on `SetupIntentCreateOptions` and `SetupIntent`
