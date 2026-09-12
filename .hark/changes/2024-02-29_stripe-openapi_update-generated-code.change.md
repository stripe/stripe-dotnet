---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/2854
is_stripe_api_change: true
released_in_version: 43.17.0
---

* Add support for `Number` on `InvoiceCreateOptions` and `InvoiceUpdateOptions`
* Add support for `EnableCustomerCancellation` on `TerminalReaderActionProcessPaymentIntentProcessConfig`, `TerminalReaderActionProcessSetupIntentProcessConfig`, and `TerminalReaderProcessConfigOptions`
* Add support for `RefundPaymentConfig` on `Terminal.ReaderRefundPaymentOptions` and `TerminalReaderActionRefundPayment`
* Add support for `PaymentMethod` on `TokenBankAccountOptions`
