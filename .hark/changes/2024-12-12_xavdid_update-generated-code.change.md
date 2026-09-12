---
title: Update generated code for beta
pr_url: https://github.com/stripe/stripe-dotnet/pull/3035
is_stripe_api_change: true
released_in_version: 47.2.0-beta.3
---

* Add support for `AllowRedisplay` on `Card` and `Source`
* Remove support for `AmountRefunded` on `PaymentRecord`
* Add support for `Account` on `TerminalReaderActionCollectPaymentMethod`, `TerminalReaderActionConfirmPaymentIntent`, `TerminalReaderActionProcessPaymentIntent`, and `TerminalReaderActionRefundPayment`
