---
title: Update generated code
pr_link: https://github.com/stripe/stripe-dotnet/pull/2865
is_stripe_api_change: true
released_in_version: 43.19.0
---

* Add support for new resources `Issuing.PersonalizationDesign` and `Issuing.PhysicalBundle`
* Add support for `Create`, `Get`, `List`, and `Update` methods on resource `PersonalizationDesign`
* Add support for `Get` and `List` methods on resource `PhysicalBundle`
* Add support for `PersonalizationDesign` on `Issuing.CardCreateOptions`, `Issuing.CardListOptions`, `Issuing.CardUpdateOptions`, and `IssuingCard`
* Change type of `SubscriptionApplicationFeePercentOptions` from `number` to `emptyStringable(number)`
* Add support for `SepaDebit` on `SubscriptionPaymentSettingsPaymentMethodOptionsOptions` and `SubscriptionPaymentSettingsPaymentMethodOptions`
