---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3269
is_stripe_api_change: true
released_in_version: 50.1.0-alpha.3
---

* Add support for new resource `ProductCatalog.TrialOffer`
* Add support for `Create` method on resource `ProductCatalog.TrialOffer`
* Remove support for `AmountSubtotalAfterDiscount` on `DelegatedCheckout.RequestedSession.LineItemDetail` and `DelegatedCheckout.RequestedSession.TotalDetails`
* Remove support for `AmountTotal`, `UnitAmountAfterDiscount`, and `UnitDiscount` on `DelegatedCheckout.RequestedSession.LineItemDetail`
* Add support for `AmountCartDiscount` and `AmountItemsDiscount` on `DelegatedCheckout.RequestedSession.TotalDetails`
* Remove support for `AmountDiscount` on `DelegatedCheckout.RequestedSession.TotalDetails`
* Add support for `PaymentsOrchestration` on `PaymentIntentCreateOptions` and `PaymentIntent`
