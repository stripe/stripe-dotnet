---
title: API Updates
pr_link: https://github.com/stripe/stripe-dotnet/pull/2528
is_stripe_api_change: true
released_in_version: 39.122.0
---

* Add support for `Currency` on `Checkout.SessionCreateOptions`, `InvoiceUpcomingLinesOptions`, `InvoiceUpcomingOptions`, `PaymentLinkCreateOptions`, `SubscriptionCreateOptions`, `SubscriptionSchedulePhasesOptions`, `SubscriptionSchedulePhases`, and `Subscription`
* Add support for `CurrencyOptions` on `Checkout.SessionShippingOptionsShippingRateDataFixedAmountOptions`, `CouponCreateOptions`, `CouponUpdateOptions`, `Coupon`, `OrderShippingCostShippingRateDataFixedAmountOptions`, `PriceCreateOptions`, `PriceUpdateOptions`, `Price`, `ProductDefaultPriceDataOptions`, `PromotionCodeRestrictionsOptions`, `PromotionCodeRestrictions`, `ShippingRateFixedAmountOptions`, and `ShippingRateFixedAmount`
* Add support for `Restrictions` on `PromotionCodeUpdateOptions`
* Add support for `FixedAmount` and `TaxBehavior` on `ShippingRateUpdateOptions`
