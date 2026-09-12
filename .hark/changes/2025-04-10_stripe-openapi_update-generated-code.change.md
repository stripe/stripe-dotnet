---
title: Update generated code for beta
pr_url: https://github.com/stripe/stripe-dotnet/pull/3094
is_stripe_api_change: true
released_in_version: 48.1.0-beta.3
---

* Add support for new resources `Privacy.RedactionJobRootObjects`, `Privacy.RedactionJobValidationError`, and `Privacy.RedactionJob`
* Add support for `Cancel`, `Create`, `Get`, `List`, `Run`, `Update`, and `Validate` methods on resource `RedactionJob`
* Add support for `Get` and `List` methods on resource `RedactionJobValidationError`
* Add support for `MinorityOwnedBusinessDesignation` on `AccountBusinessProfileOptions` and `AccountBusinessProfile`
* Add support for `ExportTaxTransactions` and `PaymentDisputes` on `AccountSessionComponentsOptions`
* Add support for `WalletOptions` on `Checkout.SessionCreateOptions` and `CheckoutSession`
* Add support for `Klarna` on `PaymentMethodDomain`
* Add support for `In` on `TaxRegistrationCountryOptionsOptions` and `TaxRegistrationCountryOptions`
