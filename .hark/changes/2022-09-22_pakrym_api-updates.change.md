---
title: API Updates
pr_url: https://github.com/stripe/stripe-dotnet/pull/2578
is_breaking: true
is_stripe_api_change: true
released_in_version: 40.10.0
---

* Add support for `TermsOfService` on `Checkout.SessionConsentCollectionOptions`, `Checkout.SessionConsentCollection`, `Checkout.SessionConsent`, `PaymentLinkConsentCollectionOptions`, and `PaymentLinkConsentCollection`
* ⚠️  Remove support for `Plan` on `Checkout.SessionPaymentMethodOptionsCardInstallmentsOptions`. The property was mistakenly released and never worked.
* Add support for `StatementDescriptor` on `PaymentIntentIncrementAuthorizationOptions`
