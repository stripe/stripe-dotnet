---
title: Update generated code
pr_link: https://github.com/stripe/stripe-dotnet/pull/2764
is_stripe_api_change: true
released_in_version: 42.5.0
---

* Add support for `Capture`, `Create`, `Expire`, `Increment`, and `Reverse` test helper methods on resource `Issuing.Authorization`
* Add support for `CreateForceCapture`, `CreateUnlinkedRefund`, and `Refund` test helper methods on resource `Issuing.Transaction`
* Add support for `Nonce` on `EphemeralKeyCreateOptions`
* Add support for `CashbackAmount` on `IssuingAuthorizationAmountDetails`, `IssuingAuthorizationPendingRequestAmountDetails`, `IssuingAuthorizationRequestHistoryAmountDetails`, and `IssuingTransactionAmountDetails`
* Add support for `SerialNumber` on `Terminal.ReaderListOptions`
