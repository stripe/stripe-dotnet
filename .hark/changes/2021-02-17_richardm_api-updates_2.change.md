---
title: API Updates
pr_url: https://github.com/stripe/stripe-dotnet/pull/2288
is_stripe_api_change: true
released_in_version: 39.36.0
---

* Add support for `afterpay_clearpay` on `PaymentMethod`, `PaymentIntentPaymentMethodData`, and `ChargePaymentMethodDetails`.
* Add support for `adjustable_quantity` on `SessionLineItemOptions`
* Add support for `bacs_debit`, `au_becs_debit` and `sepa_debit` on `SetupAttempt.payment_method_details`
