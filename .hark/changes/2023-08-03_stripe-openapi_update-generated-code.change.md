---
title: Update generated code for beta
pr_url: https://github.com/stripe/stripe-dotnet/pull/2737
is_stripe_api_change: true
released_in_version: 41.28.0-beta.1
---

* Add support for `SubmitCard` test helper method on resource `Issuing.Card`
* Add support for `AddressValidation` on `IssuingCardShippingOptions` and `IssuingCardShipping`
* Add support for `Shipping` on `Issuing.CardUpdateOptions`
* Change type of `OrderDescriptionOptions`, `OrderLineItemsProductDataDescriptionOptions`, `OrderLineItemsProductDataTaxCodeOptions`, `OrderShippingDetailsPhoneOptions`, `PaymentMethodConfigurationApplicationOptions`, and `QuoteSubscriptionDataOverridesDescriptionOptions` from `string` to `emptyStringable(string)`
* Add support for `Reason` on `QuoteMarkStaleQuoteOptions`
* Add support for `MarkedStale` on `QuoteStatusDetailsStaleLastReason`
