---
title: API Updates
pr_url: https://github.com/stripe/stripe-dotnet/pull/2303
is_stripe_api_change: true
released_in_version: 39.44.0
---

* Add support for `acss_debit_payments` on `AccountCapabilities`
* Add support for `acss_debit` on `SetupIntentPaymentMethodOptionsOptions`, `SetupAttemptPaymentMethodDetailsOptions`, `PaymentMethod`, `PaymentMethodOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodDataOptions`, and `MandatePaymentMethodDetails`, and `Checkout.SessionPaymentMethodOptions`.
* Add `acss_debit` to the `type` enum of `PaymentMethod`, `PaymentIntent` and `Checkout.SessionCreateOptions.payment_method_types`.
* Add support for `verify_with_microdeposits` on `PaymentIntentNextAction` and `SetupIntentNextAction`
