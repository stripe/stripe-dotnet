---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/2750
is_breaking: true
is_stripe_api_change: true
released_in_version: 42.0.0
---

"⚠️" symbol highlights breaking changes.
* ⚠️Remove support for `AvailableOn` on `BalanceTransactionListOptions`
  * Use of this parameter is discouraged. You may use [`.AddExtraParam`](https://github.com/stripe/stripe-dotnet/#parameters) if sending the parameter is still required.
* ⚠️Remove support for `Destination` on `Charge`
  * Please use `TransferData` or `OnBehalfOf` instead.
* ⚠️Remove support for `ShippingRates` on `Checkout.SessionCreateOptions`
  * Please use `ShippingOptions` instead.
* ⚠️Remove support for `Coupon` and `TrialFromPlan` on `CheckoutSessionSubscriptionDataOptions`
  * Please [migrate to the Prices API](https://stripe.com/docs/billing/migration/migrating-prices), or use [`.AddExtraParam`](https://github.com/stripe/stripe-dotnet/#parameters) if sending the parameter is still required.
* ⚠️Remove support for `Blik` on `MandatePaymentMethodDetails`, `PaymentMethodUpdateOptions`, `SetupAttemptPaymentMethodDetails`, `SetupIntentPaymentMethodOptionsOptions`, and `SetupIntentPaymentMethodOptions`
    * These fields were mistakenly released.
* ⚠️Remove support for `AcssDebit`, `Affirm`, `AuBecsDebit`, `BacsDebit`, `Cashapp`, `SepaDebit`, and `Zip` on `PaymentMethodUpdateOptions`
    * These fields were empty hashes.
* ⚠️Remove support for `Country` on `PaymentMethodLink`
    * This field was not fully operational.
* ⚠️Remove support for `Recurring` on `PriceUpdateOptions`
    * This property should be set on create only.
* ⚠️Remove support for `Attributes`, `Caption`, and `DeactivateOn` on `ProductCreateOptions`, `ProductUpdateOptions`, and `Product`
  * These fields are not fully operational.
* ⚠️Remove support for `AlternateStatementDescriptors` and `Dispute` on `Charge`
  * Use of these parameters is discouraged.
