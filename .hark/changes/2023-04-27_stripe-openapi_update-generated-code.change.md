---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/2683
is_stripe_api_change: true
released_in_version: 41.15.0-beta.1
---

* Add support for `BillingCycleAnchor` and `ProrationBehavior` on `CheckoutSessionSubscriptionDataOptions`
* Add support for `TerminalId` on `IssuingAuthorizationMerchantData` and `IssuingTransactionMerchantData`
* Add support for `Metadata` on `PaymentIntentCaptureOptions`
* Add support for `Checks` on `SetupAttemptPaymentMethodDetailsCard`
* Add support for `TaxBreakdown` on `TaxCalculationShippingCost` and `TaxTransactionShippingCost`
* Change type of `TaxRegistrationActiveFromOptions` and `TaxRegistrationExpiresAtOptions` from `longInteger` to `longInteger | literal('now')`
