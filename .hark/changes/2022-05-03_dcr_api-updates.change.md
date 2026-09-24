---
title: API Updates
pr_url: https://github.com/stripe/stripe-dotnet/pull/2472
is_stripe_api_change: true
released_in_version: 39.108.0
---

* Add support for new resource `CashBalance`
* Change type of `BillingPortal.ConfigurationApplication` from `$Application` to `deletable($Application)`
* Add support for `Alipay` on `Checkout.SessionPaymentMethodOptionsOptions` and `Checkout.SessionPaymentMethodOptions`
* Add support for `CashBalance` on `Customer`
* Add support for `Application` on `Invoice`, `Quote`, `SubscriptionSchedule`, and `Subscription`
