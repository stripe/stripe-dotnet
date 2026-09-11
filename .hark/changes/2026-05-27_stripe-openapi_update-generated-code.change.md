---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3387
is_breaking: true
is_stripe_api_change: true
released_in_version: 51.3.0-alpha.1
---

* Change type of `BillingAlertSpendThresholdOptions.GroupBy` from `literal('pricing_plan_subscription')` to `enum('billing_cadence'|'pricing_plan_subscription')`
* ⚠️ Change type of `Billing.Alert.SpendThreshold.GroupBy` from `literal('pricing_plan_subscription')` to `enum('billing_cadence'|'pricing_plan_subscription')`
* Add support for `WechatPay` on `Invoice.PaymentSettings.PaymentMethodOptions`, `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions`, `Subscription.PaymentSettings.PaymentMethodOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`
* Add support for `GiftCard` on `PaymentIntent.PaymentMethodOptions` and `PaymentIntentPaymentMethodOptionsOptions`
* Add support for `PaymentDetails` on `PaymentIntentPaymentsOrchestrationOptions`
* Add support for `Enabled` on `PaymentIntent.PaymentDetails.Benefit.FrMealVoucher` and `SetupIntent.SetupDetails.Benefit.FrMealVoucher`
* ⚠️ Remove support for `LoginFailed`, `RegistrationFailed`, `RegistrationSuccess`, and `Type` on `Radar.CustomerEvaluationUpdateOptions`
* ⚠️ Remove support for `LatestVersion` on `V2.Billing.LicenseFee`, `V2.Billing.PricingPlan`, and `V2.Billing.RateCard`
* ⚠️ Remove support for `ServiceIntervalCount` and `ServiceInterval` on `V2.Billing.LicenseFee` and `V2.Billing.RateCard`
* Add support for `DebitAgreement` on `V2.MoneyManagement.ReceivedCredit.StripeBalancePayment`
* Add support for `CanonicalPath` on `EventsV2CoreHealthTrafficVolumeDropFiringEventImpact` and `EventsV2CoreHealthTrafficVolumeDropResolvedEventImpact`
* Add support for snapshot event `PaymentIntentExpired` with resource `PaymentIntent`
* Add support for event notifications `V2CoreHealthElementsErrorFiringEvent`, `V2CoreHealthElementsErrorResolvedEvent`, `V2CoreHealthInvoiceCountDroppedFiringEvent`, and `V2CoreHealthInvoiceCountDroppedResolvedEvent`
