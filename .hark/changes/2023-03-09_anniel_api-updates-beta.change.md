---
title: API Updates for beta branch
pr_link: https://github.com/stripe/stripe-dotnet/pull/2655
is_stripe_api_change: true
released_in_version: 41.10.0-beta.1
---

* Updated stable APIs to the latest version
* Remove support for `ListTransactions` method on resource `Tax.Transaction`
* Add support for `UpdateBehavior` on `SubscriptionPrebillingOptions`, `SubscriptionPrebilling`, `SubscriptionSchedulePrebillingOptions`, and `SubscriptionSchedulePrebilling`
* Add support for `Prebilling` on `SubscriptionScheduleAmendOptions`
* Add support for `TaxabilityOverride` on `TaxCalculationCustomerDetailsOptions`, `TaxCalculationCustomerDetails`, and `TaxTransactionCustomerDetails`
* Add support for `TaxSummary` on `TaxCalculation`
* Remove support for `TaxBreakdown` on `TaxCalculation`
* Add support for `TaxBehavior` on `TaxSettingsDefaultsOptions` and `TaxSettingsDefaults`
