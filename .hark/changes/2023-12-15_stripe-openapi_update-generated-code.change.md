---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/2810
is_stripe_api_change: true
released_in_version: 43.8.0-beta.1
---

* Add support for `PreviewMode` and `SubscriptionDetails` on `InvoiceUpcomingLinesOptions` and `InvoiceUpcomingOptions`
* Remove support for `SubscriptionTrialFromPlan` on `InvoiceUpcomingLinesOptions` and `InvoiceUpcomingOptions`
* Add support for `BillingBehavior`, `EndBehavior`, and `ProrationBehavior` on `InvoiceScheduleDetailsOptions`
