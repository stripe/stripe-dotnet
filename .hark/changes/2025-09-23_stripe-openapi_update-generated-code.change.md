---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/3178
is_stripe_api_change: true
released_in_version: 49.1.0-beta.1
---

* Add support for new resources `Billing.Analytics.MeterUsageRow` and `Billing.Analytics.MeterUsage`
* Remove support for resources `Billing.MeterUsageRow` and `Billing.MeterUsage`
* Add support for `Get` method on resource `Billing.Analytics.MeterUsage`
* Remove support for `Get` method on resource `Billing.MeterUsage`
* Add support for `ReportPaymentAttemptInformational` method on resource `PaymentRecord`
* Add support for `MinimumBalanceByCurrency` on `BalanceSettings.Payments.Payouts` and `BalanceSettingsPaymentsPayoutsOptions`
* Change type of `BalanceSettingsPaymentsSettlementTimingOptions.DelayDaysOverride` from `longInteger` to `emptyable(longInteger)`
* Add support for `DelayDaysOverride` on `BalanceSettings.Payments.SettlementTiming`
* Add support for `AutomaticTax` and `InvoiceCreation` on `Checkout.SessionUpdateOptions`
* Add support for `UnitLabel` on `CheckoutSessionLineItemPriceDataProductDataOptions`
* Add support for `InvoiceSettings` on `CheckoutSessionSubscriptionDataOptions`
* Add support for `IntendedSubmissionMethod` on `DisputeUpdateOptions` and `Dispute`
* Change type of `Dispute.SmartDisputes.RecommendedEvidence` from `string` to `array(string)`
* Add support for `Pix` on `Invoice.PaymentSettings.PaymentMethodOptions`, `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions`, `Subscription.PaymentSettings.PaymentMethodOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`
* Add support for `BillingSchedules` on `InvoiceSubscriptionDetailsOptions`, `SubscriptionCreateOptions`, `SubscriptionUpdateOptions`, and `Subscription`
* Add support for `Paypay` on `PaymentAttemptRecord.PaymentMethodDetails` and `PaymentRecord.PaymentMethodDetails`
* Add support for `Wallet` on `PaymentAttemptRecord.PaymentMethodDetails.Card` and `PaymentRecord.PaymentMethodDetails.Card`
* Add support for `Flexible` on `QuotePreviewSubscriptionSchedule.BillingMode`
* Add support for `BilledUntil` on `SubscriptionItem`
