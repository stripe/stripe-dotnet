---
title: Pull in V2 FinancialAccount changes for June release
pr_link: https://github.com/stripe/stripe-dotnet/pull/3145
is_stripe_api_change: true
released_in_version: 48.4.0-beta.2
---

* Add support for `Close` and `Create` methods on resource `V2.MoneyManagement.FinancialAccount`
* Add support for `Storer` on `V2.Core.Account.Configuration` and `V2CoreAccountConfigurationOptions`
* Add support for `StatusDetails` on `V2.MoneyManagement.FinancialAccount`
* Add support for `Status` on `V2.MoneyManagement.FinancialAccountListOptions`
* Add support for thin events `V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEvent` and `V2CoreAccountIncludingConfigurationStorerUpdatedEvent` with related object `V2.Core.Account`
* Add support for error types `AlreadyExistsException` and `NonZeroBalanceException`
