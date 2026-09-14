---
title: Update generated code for beta
pr_url: https://github.com/stripe/stripe-dotnet/pull/2866
is_stripe_api_change: true
released_in_version: 43.20.0-beta.1
---

* Add support for new resources `Billing.MeterEventAdjustment`, `Billing.MeterEvent`, and `Billing.Meter`
* Add support for `Create`, `Deactivate`, `Get`, `List`, `Reactivate`, and `Update` methods on resource `Meter`
* Add support for `Create` method on resources `MeterEventAdjustment` and `MeterEvent`
* Add support for `Create` test helper method on resource `ConfirmationToken`
* Add support for `AddLines`, `RemoveLines`, and `UpdateLines` methods on resource `Invoice`
* Add support for `Multibanco` on `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `RefundDestinationDetails`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `SecondLine` on `IssuingPhysicalBundleFeatures`
* Add support for `MultibancoDisplayDetails` on `PaymentIntentNextAction`
* Add support for `Meter` on `PlanCreateOptions`, `Plan`, `PriceRecurringOptions`, and `PriceRecurring`
