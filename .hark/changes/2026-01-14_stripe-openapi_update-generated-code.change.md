---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3290
is_stripe_api_change: true
released_in_version: 50.2.0-alpha.3
---

* Add support for `RiskDetails` on `DelegatedCheckout.RequestedSession`
* Remove support for `Description`, `Images`, and `Name` on `DelegatedCheckout.RequestedSession.LineItemDetail`
* Add support for `Name` on `ProductCatalog.TrialOfferCreateOptions` and `ProductCatalog.TrialOffer`
* Add support for `LoginFailed` and `RegistrationFailed` on `Radar.AccountEvaluation.Events` and `Radar.AccountEvaluationUpdateOptions`
* Change type of `Radar.AccountEvaluationUpdateOptions.Type` from `literal('registration_succeeded')` to `enum('login_failed'|'login_succeeded'|'registration_failed'|'registration_succeeded')`
