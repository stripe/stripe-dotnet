---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/2953
is_stripe_api_change: true
released_in_version: 45.9.0-beta.2
---

* Add support for `MbWayPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
* Add support for `MbWay` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
* Remove support for `Phases` on `QuoteCreateOptions` and `QuoteUpdateOptions`
* Remove support for `FromSchedule` on `QuoteSubscriptionDataOptions`
