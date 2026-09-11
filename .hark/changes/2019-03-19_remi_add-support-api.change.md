---
title: "Add support for API version [2019-03-14](https://docs.stripe.com/changelog/2019-03-14):"
pr_link: https://github.com/stripe/stripe-dotnet/pull/1552
released_in_version: 25.0.0
---

* The library is now pinned to API version `2019-03-14`.
* Subscriptions are now created with `status: "incomplete"` if the first payment fails.
* `PaymentIntentLastPaymentError` was removed in favour of `StripeError`.
