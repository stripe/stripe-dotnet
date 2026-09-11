---
title: Update generated code
pr_link: https://github.com/stripe/stripe-dotnet/pull/2887
is_stripe_api_change: true
released_in_version: 43.23.0
---

* Add support for new resources `Entitlements.ActiveEntitlement` and `Entitlements.Feature`
* Add support for `Get` and `List` methods on resource `ActiveEntitlement`
* Add support for `Create`, `Get`, `List`, and `Update` methods on resource `Feature`
* Add support for `Controller` on `AccountCreateOptions`
* Add support for `Fees`, `Losses`, `RequirementCollection`, and `StripeDashboard` on `AccountController`
* Add support for `EventName` on `Billing.MeterEventAdjustmentCreateOptions` and `BillingMeterEventAdjustment`
* Add support for `Cancel` and `Type` on `BillingMeterEventAdjustment`
