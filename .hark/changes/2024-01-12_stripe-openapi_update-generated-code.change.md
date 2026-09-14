---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/2827
is_stripe_api_change: true
released_in_version: 43.10.0
---

* Add support for new resource `CustomerSession`
* Add support for `Create` method on resource `CustomerSession`
* Remove support for `Expand` on `BankAccountDeleteOptions` and `CardDeleteOptions`
* Add support for `AccountType`, `DefaultForCurrency`, and `Documents` on `BankAccountUpdateOptions` and `CardUpdateOptions`
* Remove support for `Owner` on `BankAccountUpdateOptions` and `CardUpdateOptions`
* Change type of `BankAccountAccountHolderTypeOptions` and `CardAccountHolderTypeOptions` from `enum('company'|'individual')` to `emptyStringable(enum('company'|'individual'))`
* Add support for `BillingCycleAnchorConfig` on `SubscriptionCreateOptions` and `Subscription`
