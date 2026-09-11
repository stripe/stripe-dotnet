---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3245
is_stripe_api_change: true
released_in_version: 49.3.0-alpha.2
---

* Remove support for resource `V2.Tax.AutomaticRule`
* Remove support for `Create`, `Deactivate`, `Find`, `Get`, and `Update` methods on resource `V2.Tax.AutomaticRule`
* Add support for `SelfReportedIncome` and `SelfReportedMonthlyHousingPayment` on `AccountIndividualOptions`, `AccountPersonCreateOptions`, `AccountPersonUpdateOptions`, `Person`, `TokenAccountIndividualOptions`, and `TokenPersonOptions`
* Add support for `BillingSchedules` and `PhaseEffectiveAt` on `Quote.SubscriptionDataOverrides`, `Quote.SubscriptionData`, `QuoteSubscriptionDataOptions`, `QuoteSubscriptionDataOverrideOptions`, and `QuoteSubscriptionDataOverridesOptions`
* Add support for `BillFrom` on `Subscription.BillingSchedule`
* Add support for `AmendmentEnd` and `LineEndsAt` on `Subscription.BillingSchedule.BillUntil`
* Remove support for `Data` and `RelatedObject` on `V2.Core.Event`
