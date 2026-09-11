---
title: "Major version released with the following breaking changes in it:"
pr_link: https://github.com/stripe/stripe-dotnet/pull/1838
released_in_version: 34.0.0
---

* [#1863](https://github.com/stripe/stripe-dotnet/pull/1863) ⚠️  Pin to API version `2019-12-03`
* [#1837](https://github.com/stripe/stripe-dotnet/pull/1837) ⚠️  Renamed `ParametersOptions` to `ReportRunParametersOptions` on `ReportRun`
* [#1841](https://github.com/stripe/stripe-dotnet/pull/1841) ⚠️  `Created` is not be nullable anymore on any resource
* [#1852](https://github.com/stripe/stripe-dotnet/pull/1852) ⚠️  Removed `PhonNumber` on Issuing `Cardholder` in favour of `PhoneNumber` and `PersonalIdNumber` on Person creation and update in favour of `IdNumber`
* [#1850](https://github.com/stripe/stripe-dotnet/pull/1850) ⚠️  Rename a few options classes to have Options in the name instead of Option
  * `InvoiceUpcomingInvoiceItemOption` is now `InvoiceUpcomingInvoiceItemOptions`.
  * `SubscriptionItemOption` is now `SubscriptionItemOptions`.
  * `SubscriptionItemUpdateOption` is now merged into `SubscriptionItemOptions`.
* [#1851](https://github.com/stripe/stripe-dotnet/pull/1851) Fix multiple TODOs in tests
