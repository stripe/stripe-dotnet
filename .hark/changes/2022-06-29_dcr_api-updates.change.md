---
title: API Updates
pr_url: https://github.com/stripe/stripe-dotnet/pull/2524
is_stripe_api_change: true
released_in_version: 39.121.0
---

* Add support for `DeliverCard`, `FailCard`, `ReturnCard`, and `ShipCard` test helper methods on resource `Issuing.Card`
* Change type of `PaymentLinkPaymentMethodTypesOptions` and `PaymentLinkPaymentMethodTypes` from `literal('card')` to `enum`
* Add support for `HostedRegulatoryReceiptUrl` on `Treasury.ReceivedCredit` and `Treasury.ReceivedDebit`
