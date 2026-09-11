---
title: Update generated code
pr_link: https://github.com/stripe/stripe-dotnet/pull/2922
is_stripe_api_change: true
released_in_version: 44.12.0
---

* Add support for `MultibancoPayments` and `TwintPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
* Add support for `Twint` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `Multibanco` on `CheckoutSessionPaymentMethodOptionsOptions`, `CheckoutSessionPaymentMethodOptions`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `RefundDestinationDetails`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `MultibancoDisplayDetails` on `PaymentIntentNextAction`
* Add support for `InvoiceSettings` on `Subscription`
