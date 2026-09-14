---
title: API Updates
pr_url: https://github.com/stripe/stripe-dotnet/pull/2577
is_stripe_api_change: true
released_in_version: 40.9.0
---

* Add support for `Pix` on `ChargePaymentMethodDetails`, `Checkout.SessionPaymentMethodOptionsOptions`, `Checkout.SessionPaymentMethodOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `FromInvoice` on `InvoiceCreateOptions` and `Invoice`
* Add support for `LatestRevision` on `Invoice`
* Add support for `Amount` on `Issuing.DisputeCreateOptions` and `Issuing.DisputeUpdateOptions`
* Add support for `PixDisplayQrCode` on `PaymentIntentNextAction`
* Add support for `Created` on `Treasury.CreditReversal` and `Treasury.DebitReversal`
