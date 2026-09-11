---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/2675
is_stripe_api_change: true
released_in_version: 41.14.0-beta.2
---

* Add support for `CollectPaymentMethod` and `ConfirmPaymentIntent` methods on resource `Terminal.Reader`
* Add support for `PaypalPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
* Add support for `CollectPaymentMethod` and `ConfirmPaymentIntent` on `TerminalReaderAction`
* Add support for `StripeAccount` on `TerminalReaderActionProcessPaymentIntent` and `TerminalReaderActionRefundPayment`
