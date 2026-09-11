---
title: Multiple breaking API changes while removing deprecated Issuing features
pr_link: https://github.com/stripe/stripe-dotnet/pull/1993
released_in_version: 36.0.0
---

* [#1992](https://github.com/stripe/stripe-dotnet/pull/1992), [#1994](https://github.com/stripe/stripe-dotnet/pull/1994) Change `Error` on `ScheduledQueryRun` from `string` to `ScheduledQueryRunError`
* [#1961](https://github.com/stripe/stripe-dotnet/pull/1961) Multiple renames of classes and related fixes
  * Renamed  the class `Fee` to `BalanceTransactionFee` on `BalanceTransaction`
  * Renamed the class `Outcome` to `ChargeOutcome` on `Charge`
  * Renamed the classes `Evidence` to `DisputeEvidence` and `EvidenceDetails` to `DisputeEvidenceDetails` on `Dispute`
  * Renamed the class `OutcomeRule` to `Rule` and moved it to the `Radar` namespace
  * Renamed the classes `ShippingMethod` to `OrderShippingMethod`, `StatusTransitions` to `OrderStatusTransitions` and `DeliveryEstimate` to `OrderShippingMethodDeliveryEstimate` on `Order`
  * Renamed the class `Inventory` to `SkuInventory` on `Sku`
  * Fixed the type of `NextPendingInvoiceItemInvoice` on `Subscription` to be a `DateTime?`
  * `FraudDetails` on `Charge` is now a class `ChargeFraudDetails` instead of a dictionary
  * Removed `Connect` on the `WebhookEndpoint` resource as it is not supported
- [#2001](https://github.com/stripe/stripe-dotnet/pull/2001) Remove deprecated API features
  * Remove `Percentage` filter when listing `TaxRate` as this does not work
  * Remove `Country` and `RoutingNumber` from `ChargePaymentMethodDetailsAcssDebit`
  * Remove `RenewalInterval` on `SubscriptionSchedule`
  * Rename `Parameters` to `ReportRunParameters` on `ReportRun`
  * Fix all Checkout classes to be in the `Stripe.Checkout` namespace
* [#1968](https://github.com/stripe/stripe-dotnet/pull/1968) Remove all deprecated features associated with the Issuing API and resources
