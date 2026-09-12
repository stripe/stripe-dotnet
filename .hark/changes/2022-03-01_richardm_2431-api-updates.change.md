---
title: "[#2431](https://github.com/stripe/stripe-dotnet/pull/2431) API Updates"
pr_url: https://github.com/stripe/stripe-dotnet/pull/2430
is_stripe_api_change: true
released_in_version: 39.94.0
---

* Add support for new resource `TestHelpers.TestClock`
* Add support for `TestClock` on `CustomerCreateOptions`, `Customer`, `Invoice`, `InvoiceItem`, `QuoteCreateOptions`, `Quote`, `Subscription`, and `SubscriptionSchedule`
* Add support for `PendingInvoiceItemsBehavior` on `InvoiceCreateOptions`
* Change type of `ProductUrlOptions` from `string` to `emptyStringable(string)`
* Add support for `NextAction` on `Refund`
