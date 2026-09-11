---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/3031
is_stripe_api_change: true
released_in_version: 47.2.0-beta.1
---

* Add support for `NetworkAdviceCode` and `NetworkDeclineCode` on `ChargeOutcome`, `InvoiceLastFinalizationError`, `PaymentIntentLastPaymentError`, `SetupAttemptSetupError`, `SetupIntentLastSetupError`, and `StripeError`
* Add support for `Funding` on `ChargePaymentMethodDetailsAmazonPay` and `ChargePaymentMethodDetailsRevolutPay`
* Add support for `AmountRequested` and `PartialAuthorization` on `ChargePaymentMethodDetailsCard`
* Add support for `Metadata` on `CheckoutSessionLineItemsOptions` and `LineItem`
* Add support for `LineItems` on `Checkout.SessionUpdateOptions`, `CheckoutSessionPermissionsUpdateOptions`, and `CheckoutSessionPermissionsUpdate`
* Add support for `AdjustableQuantity` and `Display` on `LineItem`
* Add support for `RequestPartialAuthorization` on `PaymentIntentPaymentMethodOptionsCardOptions` and `PaymentIntentPaymentMethodOptionsCard`
* Add support for `PaymentMethodOptions` on `PaymentIntentIncrementAuthorizationOptions`
