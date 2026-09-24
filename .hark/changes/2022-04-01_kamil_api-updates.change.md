---
title: API Updates
pr_url: https://github.com/stripe/stripe-dotnet/pull/2446
is_stripe_api_change: true
released_in_version: 39.103.0
---

* Add support for `BankTransferPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
* Add support for `CaptureBefore` on `ChargePaymentMethodDetailsCardPresent`
* Add support for `Address` and `Name` on `Checkout.SessionCustomerDetails`
* Add support for `CustomerBalance` on `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `InvoicePaymentSettingsPaymentMethodOptions`, `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptions`
* Add support for `RequestExtendedAuthorization` on `PaymentIntentPaymentMethodOptionsCardPresentOptions` and `PaymentIntentPaymentMethodOptionsCardPresent`
* Add `payment_intent.partially_funded`, `terminal.reader.action_failed`, and `terminal.reader.action_succeeded` event constants.
