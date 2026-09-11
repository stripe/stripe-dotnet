---
title: Update generated code
pr_link: https://github.com/stripe/stripe-dotnet/pull/2874
is_stripe_api_change: true
released_in_version: 43.20.0
---

* Add support for new resources `ConfirmationToken` and `Forwarding.Request`
* Add support for `Get` method on resource `ConfirmationToken`
* Add support for `Create`, `Get`, and `List` methods on resource `Request`
* Add support for `MobilepayPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
* Add support for `Mobilepay` on `ChargePaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `PaymentReference` on `ChargePaymentMethodDetailsUsBankAccount`
* Add support for `ConfirmationToken` on `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `SetupIntentConfirmOptions`, and `SetupIntentCreateOptions`
* Add support for `Name` on `Terminal.ConfigurationCreateOptions`, `Terminal.ConfigurationUpdateOptions`, and `TerminalConfiguration`
* Add support for `Payout` on `TreasuryReceivedDebitLinkedFlows`
