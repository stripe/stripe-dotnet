---
title: Update generated code for beta
pr_url: https://github.com/stripe/stripe-dotnet/pull/2846
is_stripe_api_change: true
released_in_version: 43.16.0-beta.1
---

* Add support for `DecrementAuthorization` method on resource `PaymentIntent`
* Add support for `PaytoPayments` and `TwintPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
* Add support for `Payto` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodPreview`, `MandatePaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethodUpdateOptions`, `PaymentMethod`, `SetupAttemptPaymentMethodDetails`, `SetupIntentPaymentMethodDataOptions`, `SetupIntentPaymentMethodOptionsOptions`, and `SetupIntentPaymentMethodOptions`
* Add support for `Twint` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `DecrementalAuthorization` on `ChargePaymentMethodDetailsCard`
* Add support for `DisplayBrand` on `ConfirmationTokenPaymentMethodPreviewCard`
* Add support for `RequestDecrementalAuthorization` on `PaymentIntentPaymentMethodOptionsCardOptions` and `PaymentIntentPaymentMethodOptionsCard`
