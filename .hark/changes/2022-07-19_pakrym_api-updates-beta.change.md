---
title: API Updates for beta branch
pr_url: https://github.com/stripe/stripe-dotnet/pull/2536
is_stripe_api_change: true
released_in_version: 39.125.0-beta.1
---

- Updated stable APIs to the latest version
- Add `Price.MigrateTo` property
- Add `SubscriptionSchedule.Amend` method.
- Add `Discount.SubscriptionItem` property.
- Add `Quote.SubscriptionData.BillingBehavior`, `BillingCycleAnchor`, `EndBehavior`, `FromSchedule`, `FromSubscription`, `Prebilling`, `ProrationBehavior` properties.
- Add `Phases` parameter to `Quote.Create`
- Add `Subscription.Discounts`, `Prebilling` properties.
