---
title: Update generated code for private-preview
pr_url: https://github.com/stripe/stripe-dotnet/pull/3324
is_stripe_api_change: true
released_in_version: 50.5.0-alpha.4
---

* Add support for `SimulateCryptoDeposit` test helper method on resource `PaymentIntent`
* Add support for `DepositOptions` and `Mode` on `PaymentIntent.PaymentMethodOptions.Crypto` and `PaymentIntentPaymentMethodOptionsCryptoOptions`
* Add support for `CryptoDisplayDetails` on `PaymentIntent.NextAction`
