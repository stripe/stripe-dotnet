---
title: Update generated code (new)
pr_link: https://github.com/stripe/stripe-dotnet/pull/2657
is_stripe_api_change: true
released_in_version: 41.10.0
---

* Add support for `CashappPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
* Add support for `Cashapp` on `ChargePaymentMethodDetails`, `Checkout.SessionPaymentMethodOptionsOptions`, `Checkout.SessionPaymentMethodOptions`, `MandatePaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethodUpdateOptions`, `PaymentMethod`, `SetupAttemptPaymentMethodDetails`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `PreferredLocale` on `PaymentIntentPaymentMethodOptionsAffirmOptions` and `PaymentIntentPaymentMethodOptionsAffirm`
* Add support for `CashappHandleRedirectOrDisplayQrCode` on `PaymentIntentNextAction` and `SetupIntentNextAction`
