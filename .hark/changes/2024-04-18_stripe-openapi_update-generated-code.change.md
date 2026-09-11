---
title: Update generated code
pr_link: https://github.com/stripe/stripe-dotnet/pull/2894
is_stripe_api_change: true
released_in_version: 44.3.0
---

* Add support for `CreatePreview` method on resource `Invoice`
* Add support for `PaymentMethodData` on `Checkout.SessionCreateOptions`
* Add support for `SavedPaymentMethodOptions` on `Checkout.SessionCreateOptions` and `CheckoutSession`
* Add support for `Mobilepay` on `CheckoutSessionPaymentMethodOptionsOptions` and `CheckoutSessionPaymentMethodOptions`
* Add support for `AllowRedisplay` on `ConfirmationTokenPaymentMethodDataOptions`, `CustomerListPaymentMethodsOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentMethodCreateOptions`, `PaymentMethodUpdateOptions`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `ScheduleDetails` and `SubscriptionDetails` on `InvoiceUpcomingLinesOptions` and `InvoiceUpcomingOptions`
