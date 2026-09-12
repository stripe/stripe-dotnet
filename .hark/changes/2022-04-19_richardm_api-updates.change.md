---
title: API Updates
pr_url: https://github.com/stripe/stripe-dotnet/pull/2455
is_stripe_api_change: true
released_in_version: 39.106.0
---

* Add support for new resources `FundingInstructions` and `Terminal.Configuration`
* Add support for `CreateFundingInstructions` method on resource `Customer`
* Add support for `CustomerBalance` on `ChargePaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, and `PaymentMethod`
* Add support for `CashBalance` on `CustomerCreateOptions` and `CustomerUpdateOptions`
* Add support for `AmountDetails` on `PaymentIntent`
* Add support for `DisplayBankTransferInstructions` on `PaymentIntentNextAction`
* Add support for `ConfigurationOverrides` on `Terminal.LocationCreateOptions`, `Terminal.LocationUpdateOptions`, and `Terminal.Location`
