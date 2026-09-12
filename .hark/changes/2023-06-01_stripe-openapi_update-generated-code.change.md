---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/2701
is_stripe_api_change: true
released_in_version: 41.19.0
---

* Add support for `Numeric` and `Text` on `Checkout.SessionCustomFieldsOptions` and `PaymentLinkCustomFieldsOptions`
* Add support for `MaximumLength` and `MinimumLength` on `Checkout.SessionCustomFieldsNumeric` and `Checkout.SessionCustomFieldsText`
* Add support for `PreferredLocales` on `Issuing.CardholderCreateOptions`, `Issuing.CardholderUpdateOptions`, and `Issuing.Cardholder`
* Add support for `Description`, `Iin`, and `Issuer` on `PaymentMethodCardPresent` and `PaymentMethodInteracPresent`
* Add support for `PayerEmail` on `PaymentMethodPaypal`
