---
title: API Updates
pr_link: https://github.com/stripe/stripe-dotnet/pull/2534
is_stripe_api_change: true
released_in_version: 39.124.0
---

* Add support for `BlikPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
* Add support for `Blik` on `ChargePaymentMethodDetails`, `MandatePaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethodUpdateOptions`, `PaymentMethod`, `SetupAttemptPaymentMethodDetails`, `SetupIntentPaymentMethodDataOptions`, `SetupIntentPaymentMethodOptionsOptions`, and `SetupIntentPaymentMethodOptions`
* Change type of `Checkout.SessionConsentCollectionPromotionsOptions`, `Checkout.SessionConsentCollectionPromotions`, `PaymentLinkConsentCollectionPromotionsOptions`, and `PaymentLinkConsentCollectionPromotions` from `literal('auto')` to `enum('auto'|'none')`
