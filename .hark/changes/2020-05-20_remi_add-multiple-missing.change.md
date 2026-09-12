---
title: Add multiple missing features and better docs
pr_url: https://github.com/stripe/stripe-dotnet/pull/2053
released_in_version: 37.2.0
---

* Add `NetworkReasonCode` on `Dispute` which is a gated feature
* Fix `RefundId` on `OrderReturn`, `CustomerId` on `Order` and `BalanceTransactionId` on `Topup` to be deserialized properly
* Add `Deleted` on `ValueList` and `ValueListItem`
* Add `BillingThresholds` on `SubscriptionItem`
