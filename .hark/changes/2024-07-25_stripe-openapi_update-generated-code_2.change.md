---
title: Update generated code
pr_link: https://github.com/stripe/stripe-dotnet/pull/2942
is_stripe_api_change: true
released_in_version: 45.5.0
---

* Add support for `Update` method on resource `Checkout.Session`
* Add support for `TransactionId` on `ChargePaymentMethodDetailsAffirm`
* Add support for `BuyerId` on `ChargePaymentMethodDetailsBlik`
* Add support for `AuthorizationCode` on `ChargePaymentMethodDetailsCard`
* Add support for `BrandProduct` on `ChargePaymentMethodDetailsCardPresent`, `ConfirmationTokenPaymentMethodPreviewCardGeneratedFromPaymentMethodDetailsCardPresent`, `ConfirmationTokenPaymentMethodPreviewCardPresent`, `PaymentMethodCardGeneratedFromPaymentMethodDetailsCardPresent`, and `PaymentMethodCardPresent`
* Add support for `NetworkTransactionId` on `ChargePaymentMethodDetailsCardPresent`, `ChargePaymentMethodDetailsInteracPresent`, `ConfirmationTokenPaymentMethodPreviewCardGeneratedFromPaymentMethodDetailsCardPresent`, and `PaymentMethodCardGeneratedFromPaymentMethodDetailsCardPresent`
* Add support for `CaseType` on `DisputePaymentMethodDetailsCard`
* Add support for `Twint` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
