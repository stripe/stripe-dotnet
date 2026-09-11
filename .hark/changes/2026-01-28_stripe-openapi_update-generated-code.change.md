---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3297
is_stripe_api_change: true
released_in_version: 50.4.0-alpha.1
---

* Add support for new resources `FrMealVouchersOnboarding`, `Reserve.Hold`, `Reserve.Plan`, and `Reserve.Release`
* Add support for `Create`, `Get`, `List`, and `Update` methods on resource `FrMealVouchersOnboarding`
* Add support for `Get` and `List` methods on resources `Reserve.Hold` and `Reserve.Release`
* Add support for `Get` method on resource `Reserve.Plan`
* Add support for `Pause` method on resource `Subscription`
* Add support for `ServicePeriodDetails` on `Discount`
* Add support for `AgenticCommerceSettings` on `AccountSession.Components`
* Add support for `ServicePeriod` on `CouponCreateOptions` and `Coupon`
* Change type of `InvoiceItem.Pricing.PriceDetails.Price` and `InvoiceLineItem.Pricing.PriceDetails.Price` from `string` to `expandable($Price)`
* Add support for `Settings` on `InvoiceDiscountsOptions`, `InvoiceScheduleDetailsAmendmentDiscountActionAddOptions`, `InvoiceScheduleDetailsAmendmentDiscountActionSetOptions`, `InvoiceScheduleDetailsAmendmentItemActionAddDiscountOptions`, `InvoiceScheduleDetailsAmendmentItemActionSetDiscountOptions`, `InvoiceScheduleDetailsPhaseDiscountsOptions`, `InvoiceScheduleDetailsPhaseItemDiscountsOptions`, `InvoiceSubscriptionDetailsItemDiscountsOptions`, `QuoteLineActionAddDiscountOptions`, `QuoteLineActionAddItemDiscountOptions`, `QuoteLineActionSetDiscountOptions`, `QuoteLineActionSetItemDiscountOptions`, `SubscriptionDiscountsOptions`, `SubscriptionItemDiscountsOptions`, `SubscriptionScheduleAmendmentDiscountActionAddOptions`, `SubscriptionScheduleAmendmentDiscountActionSetOptions`, `SubscriptionScheduleAmendmentItemActionAddDiscountOptions`, `SubscriptionScheduleAmendmentItemActionSetDiscountOptions`, `SubscriptionSchedulePhaseDiscountsOptions`, and `SubscriptionSchedulePhaseItemDiscountsOptions`
* Add support for `Subtotal` on `InvoiceLineItem`
* Add support for `BillingCadence` on `SubscriptionListOptions`
