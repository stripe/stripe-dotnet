---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3237
is_stripe_api_change: true
released_in_version: 49.2.0-alpha.1
---

* Add support for `Tenants` on `Billing.Analytics.MeterUsageRow`
* Add support for `Transfer` on `ApplicationFee.FeeSource`
* Add support for `TransitBalancesTotal` on `Balance`
* Add support for `TenantGroupByKeys` on `BillingAnalyticsMeterUsageMeterOptions`
* Remove support for `RiskDetails` on `DelegatedCheckout.RequestedSessionCreateOptions`
* Add support for `RiskDetails` on `DelegatedCheckout.RequestedSessionConfirmOptions`
* Add support for `AllocatedFunds` on `PaymentIntent`
* Add support for `ApplicationFeeAmount` on `TransferCreateOptions` and `Transfer`
* Add support for `ApplicationFee` on `Transfer`
