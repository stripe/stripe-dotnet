---
title: Add support for API version `2019-02-11` with changes to Payment Intents
pr_link: https://github.com/stripe/stripe-dotnet/pull/1501
released_in_version: 23.0.0
---

* The library is now pinned to API version `2019-02-11`.
* `PaymentIntentSourceAction`, `PaymentIntentSourceActionValueAuthorizeWithUrl` and `NextSourceAction` are now replaced by `PaymentIntentNextAction`, `PaymentIntentNextActionRedirectToUrl` and `NextAction` instead.
* `AllowedSourceTypes` is now replaced by `PaymentMethodTypes` instead.
