---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3384
is_breaking: true
is_stripe_api_change: true
released_in_version: 51.2.0-alpha.6
---

* Add support for new resource `PaymentLocationCapability`
* Add support for `Get`, `List`, and `Update` methods on resource `PaymentLocationCapability`
* Add support for `Close` and `SimulateNetworkLifecycleDisputeResponse` test helper methods on resource `Issuing.Dispute`
* Change type of `DelegatedCheckoutRequestedSessionDiscountsOptions.Codes` from `array(string)` to `emptyable(array(string))`
* ⚠️ Remove support for `CreditedItems` on `InvoiceItem.ProrationDetails`
* Add support for `BalanceResponse` on `Issuing.Authorization`
* Add support for `PaymentEvaluations` on `PaymentAttemptRecordReportCanceledOptions`, `PaymentAttemptRecordReportFailedOptions`, `PaymentRecordFailedOptions`, `PaymentRecordReportPaymentAttemptCanceledOptions`, and `PaymentRecordReportPaymentAttemptFailedOptions`
* Add support for `Enabled` on `PaymentIntentPaymentDetailsBenefitFrMealVoucherOptions` and `SetupIntentSetupDetailsBenefitFrMealVoucherOptions`
* Add support for `AdvancedFeatureDetails` and `AllowedPaymentMethodTypes` on `PaymentIntent`
* Change type of `PaymentLocationAddressOptions.City` from `string` to `emptyable(string)`
* Change type of `PaymentLocationAddressOptions.Line1` from `string` to `emptyable(string)`
* Change type of `PaymentLocationAddressOptions.Line2` from `string` to `emptyable(string)`
* Change type of `PaymentLocationAddressOptions.PostalCode` from `string` to `emptyable(string)`
* Change type of `PaymentLocationAddressOptions.State` from `string` to `emptyable(string)`
* ⚠️ Remove support for `PaymentBehavior` on `SubscriptionResumeOptions`
* ⚠️ Remove support for `StatusDetails` on `Subscription`
