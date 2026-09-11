---
title: API Updates
pr_link: https://github.com/stripe/stripe-dotnet/pull/2325
is_stripe_api_change: true
released_in_version: 39.51.0
---

* Add support for new `TaxCode` API.
* Add support for `TaxCode` on `Product` API, and `PriceProductDataOptions`
* Add support for `Tax` on `Customer` API
* Add support for `AutomaticTax` on Checkout `Session` API, `Invoice` API, `SubscriptionScheduleDefaultSettings` API, `SubscriptionSchedulePhase` API, `SubscriptionCreateOptions`, and `SubscriptionUpdateOptions`
* Add support for `TaxBehavior` on `Price` API, Checkout `SessionLineItemPriceDataOptions`, `InvoiceSubscriptionItemPriceDataOptions`, `SubscriptionSchedulePhaseAddInvoiceItemPriceDataOptions`, `SubscriptionSchedulePhaseItemPriceDataOptions`, and `SubscriptionAddInvoiceItemPriceDataOptions`
* Add support for `TaxType` on `TaxRate` API
* Add support for `CustomerUpdate` on Checkout `SessionCreateOptions`
