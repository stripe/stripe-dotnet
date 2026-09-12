---
title: Update generated code for private-preview
pr_url: https://github.com/stripe/stripe-dotnet/pull/3302
is_breaking: true
is_stripe_api_change: true
released_in_version: 50.4.0-alpha.4
---

* Add support for `SpendThreshold` on `Billing.AlertCreateOptions` and `Billing.Alert`
* Add support for `InvoiceItem`, `ProrationDetails`, `Proration`, and `Subscription` on `InvoiceLineItem.Parent.ScheduleDetails`
* Add support for `Custom` on `PaymentMethodUpdateOptions`
* Add support for `PaymentMethodReference` and `Usage` on `PaymentMethod.Custom`
* ⚠️ Change type of `QuoteSubscriptionDataOverridesOptions.BillingSchedules` from `emptyable(array(billing_schedules_update_specs))` to `array(billing_schedules_update_specs)`
* Add support for `OutstandingUsageThrough` and `UnusedTimeFrom` on `SubscriptionBillForOptions`
* ⚠️ Remove support for `OutstandingUsage` and `UnusedTime` on `SubscriptionBillForOptions`
* ⚠️ Remove support for `PaymentBehavior` on `SubscriptionResumeOptions`
