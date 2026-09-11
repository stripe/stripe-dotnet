---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/2806
is_stripe_api_change: true
released_in_version: 43.7.0-beta.1
---

* Add support for `Get` method on resource `FinancialConnections.Transaction`
* Remove support for `IssuingCard` and `IssuingCardsList` on `AccountSessionComponentsOptions`
* Add support for `PaymentMethodRemove`, `PaymentMethodSave`, and `PaymentMethodSetAsDefault` on `CustomerSessionComponentsPaymentElementFeaturesOptions` and `CustomerSessionComponentsPaymentElementFeatures`
* Remove support for `PaymentMethodDetach` and `PaymentMethodSetAsCustomerDefault` on `CustomerSessionComponentsPaymentElementFeaturesOptions` and `CustomerSessionComponentsPaymentElementFeatures`
