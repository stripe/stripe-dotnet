---
title: API Updates
pr_url: https://github.com/stripe/stripe-dotnet/pull/2580
is_stripe_api_change: true
released_in_version: 40.11.0
---

* Change type of `ChargePaymentMethodDetailsCardPresentIncrementalAuthorizationSupported` and `ChargePaymentMethodDetailsCardPresentOvercaptureSupported` from `nullable(boolean)` to `boolean`
* Add support for `Created` on `Checkout.Session`
* Add support for `SetupFutureUsage` on `PaymentIntentPaymentMethodOptionsPixOptions` and `PaymentIntentPaymentMethodOptionsPix`
* Deprecate `SessionSubscriptionDataOptions.items` (use the `line_items` param instead). This will be removed in the next major version.
