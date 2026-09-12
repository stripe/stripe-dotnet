---
title: Update generated code for private-preview
pr_url: https://github.com/stripe/stripe-dotnet/pull/3232
is_stripe_api_change: true
released_in_version: 49.1.0-alpha.4
---

* Add support for new resource `V2.Billing.PricingPlanSubscriptionComponents`
* Add support for `Get` method on resource `V2.Billing.PricingPlanSubscriptionComponents`
* Add support for `DimensionPayloadKeys` on `Billing.MeterCreateOptions` and `Billing.Meter`
* Add support for `DimensionFilters` and `DimensionGroupByKeys` on `Billing.BillingMeterMeterEventSummaryListOptions`
* Add support for `Dimensions` on `Billing.MeterEventSummary`
* Add support for `FulfillmentDetails` and `PaymentMethodData` on `DelegatedCheckout.RequestedSessionCreateOptions` and `DelegatedCheckout.RequestedSessionUpdateOptions`
* Add support for `LineItemDetails`, `Metadata`, `PaymentMethod`, and `SharedMetadata` on `DelegatedCheckout.RequestedSessionCreateOptions`, `DelegatedCheckout.RequestedSessionUpdateOptions`, and `DelegatedCheckout.RequestedSession`
* Add support for `Currency`, `Customer`, and `RiskDetails` on `DelegatedCheckout.RequestedSessionCreateOptions`
* Add support for `SellerDetails` and `SetupFutureUsage` on `DelegatedCheckout.RequestedSessionCreateOptions` and `DelegatedCheckout.RequestedSession`
* Add support for `AmountSubtotal`, `AmountTotal`, `CreatedAt`, `ExpiresAt`, `OrderDetails`, `SharedPaymentIssuedToken`, `Status`, `TotalDetails`, and `UpdatedAt` on `DelegatedCheckout.RequestedSession`
* Add support for `Address`, `Email`, `FulfillmentOptions`, `Name`, `Phone`, and `SelectedFulfillmentOption` on `DelegatedCheckout.RequestedSession.FulfillmentDetails`
