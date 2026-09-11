---
title: Multiple API changes
pr_link: https://github.com/stripe/stripe-dotnet/pull/2244
is_stripe_api_change: true
released_in_version: 39.23.0
---

* Add support for `LastFinalizationError` on `Invoice`
* Add support for Issuing `Dispute` to `IBalanceTransactionSource` to support proper deserialization on the `BalanceTransaction.Source`
* Add support for `PaymentMethodType` on `StripeError`
