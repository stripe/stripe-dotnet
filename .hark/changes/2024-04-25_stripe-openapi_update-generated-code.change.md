---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/2897
is_stripe_api_change: true
released_in_version: 44.4.0
---

* Add support for `SetupFutureUsage` on `CheckoutSessionPaymentMethodOptionsAmazonPay`, `CheckoutSessionPaymentMethodOptionsRevolutPay`, `PaymentIntentPaymentMethodOptionsAmazonPay`, and `PaymentIntentPaymentMethodOptionsRevolutPay`
* Change type of `EntitlementsActiveEntitlementFeature` from `string` to `expandable($Entitlements.Feature)`
* Remove support for inadvertently released identity verification features `Email` and `Phone` on `IdentityVerificationSessionOptionsOptions`
* Add support for `AmazonPay` and `RevolutPay` on `MandatePaymentMethodDetails` and `SetupAttemptPaymentMethodDetails`
* Add support for `EndingBefore`, `Limit`, and `StartingAfter` on `PaymentMethodConfigurationListOptions`
* Add support for `Mobilepay` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
