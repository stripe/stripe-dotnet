---
title: API Updates
pr_url: https://github.com/stripe/stripe-dotnet/pull/2473
is_stripe_api_change: true
released_in_version: 39.109.0
---

* Add support for `RegisteredAddress` on `AccountIndividualOptions`, `PersonCreateOptions`, `PersonUpdateOptions`, `Person`, `TokenAccountIndividualOptions`, and `TokenPersonOptions`
* Change type of `PaymentIntentAmountDetailsTipAmount` from `nullable(integer)` to `integer`
* Add support for `PaymentMethodData` on `SetupIntentConfirmOptions`, `SetupIntentCreateOptions`, and `SetupIntentUpdateOptions`
