---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/2900
is_stripe_api_change: true
released_in_version: 44.5.0
---

* Add support for `Paypal` on `DisputePaymentMethodDetails`
* Change type of `DisputePaymentMethodDetailsType` from `literal('card')` to `enum('card'|'paypal')`
* Add support for `PaymentMethodTypes` on `PaymentIntentConfirmOptions`
* Add support for `ShipFromDetails` on `Tax.CalculationCreateOptions`, `TaxCalculation`, and `TaxTransaction`
* Add support for `Bh`, `Eg`, `Ge`, `Ke`, `Kz`, `Ng`, and `Om` on `TaxRegistrationCountryOptionsOptions` and `TaxRegistrationCountryOptions`
