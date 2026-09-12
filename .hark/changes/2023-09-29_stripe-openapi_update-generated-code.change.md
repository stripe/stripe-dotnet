---
title: Update generated code for beta
pr_url: https://github.com/stripe/stripe-dotnet/pull/2773
is_stripe_api_change: true
released_in_version: 42.8.0-beta.1
---

* Rename resources `Issuing.CardDesign` and `Issuing.CardBundle` to `Issuing.PersonalizationDesign` and `Issuing.PhysicalBundle`
* Add support for `Features` on `AccountSessionComponentsAccountOnboardingOptions`, `AccountSessionComponentsPaymentDetailsOptions`, `AccountSessionComponentsPaymentDetails`, `AccountSessionComponentsPaymentsOptions`, `AccountSessionComponentsPayments`, `AccountSessionComponentsPayoutsOptions`, and `AccountSessionComponentsPayouts`
* Add support for `Reason` on `Event`
