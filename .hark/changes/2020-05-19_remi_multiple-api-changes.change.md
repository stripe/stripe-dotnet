---
title: Multiple API changes
pr_url: https://github.com/stripe/stripe-dotnet/pull/2047
is_stripe_api_change: true
released_in_version: 37.1.0
---

* Add `BalanceTransactions` as a a list of `BalanceTransaction` on Issuing `Dispute`
* Add `Fingerprint` and `TransactionId` in `ChargePaymentMethodDetailsAlipay` on `Charge`
* Add `Amount` in `InvoiceTransferData` and `InvoiceTransferDataOptions` on `Invoice`
* Add `AmountPercent` in `SubscriptionTransferData` and `SubscriptionTransferDataOptions` on `Subscription`
