---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3252
is_stripe_api_change: true
released_in_version: 50.1.0-alpha.1
---

* Add support for new resources `BalanceTransfer` and `Radar.AccountEvaluation`
* Add support for `Create` method on resource `BalanceTransfer`
* Add support for `Create`, `Get`, and `Update` methods on resource `Radar.AccountEvaluation`
* Add support for `Schedule` on `Discount`
* Add support for `SpecifiedCommercialTransactionsActUrl` on `Account.BusinessProfile` and `AccountBusinessProfileOptions`
* Add support for `PaypayPayments` on `Account.Settings` and `AccountSettingsOptions`
* Change type of `BillingAnalyticsMeterUsageMeterOptions.DimensionFilters` from `string` to `array(string)`
* Change type of `BillingAnalyticsMeterUsageMeterOptions.TenantFilters` from `string` to `array(string)`
* Add support for `PaymentMethodConfiguration` on `BillingPortal.Configuration.Features.PaymentMethodUpdate`
* Add support for `CarRentalData`, `FlightData`, and `LodgingData` on `ChargePaymentDetailsOptions` and `PaymentIntentPaymentDetailsOptions`
* Add support for `TransactionId` on `Charge.PaymentMethodDetails.Ideal`, `PaymentAttemptRecord.PaymentMethodDetails.Ideal`, and `PaymentRecord.PaymentMethodDetails.Ideal`
* Add support for `Created` on `CustomerCustomerBalanceTransactionListOptions` and `InvoicePaymentListOptions`
* Add support for `AccountNumbers` on `FinancialConnections.Account`
* Add support for `ScheduleDetails` on `Invoice.Parent`, `InvoiceItem.Parent`, `InvoiceLineItem.Parent`, and `QuotePreviewInvoice.Parent`
* Add support for `BillingSchedules` on `InvoiceScheduleDetailsOptions`, `QuotePreviewSubscriptionSchedule`, `SubscriptionScheduleCreateOptions`, `SubscriptionScheduleUpdateOptions`, and `SubscriptionSchedule`
* Add support for `FraudRisk` on `IssuingAuthorizationRiskAssessmentOptions`
* Add support for `LatestFraudWarning` on `Issuing.Card`
* Add support for `SupplementaryPurchaseData` on `OrderPaymentSettingsPaymentMethodOptionsKlarnaOptions` and `PaymentIntentPaymentMethodOptionsKlarnaOptions`
* Add support for `CaptureMethod` on `PaymentIntent.PaymentMethodOptions.CardPresent` and `PaymentIntentPaymentMethodOptionsCardPresentOptions`
* Add support for `AllowRedisplay` and `CustomerAccount` on `PaymentMethodListOptions`
* Add support for `LatestInvoice` on `QuotePreviewSubscriptionSchedule` and `SubscriptionSchedule`
* Add support for `PhaseEffectiveAt` on `QuotePreviewSubscriptionSchedule.DefaultSettings`, `SubscriptionSchedule.DefaultSettings`, and `SubscriptionScheduleDefaultSettingsOptions`
* Add support for `MbWay` and `Twint` on `Refund.DestinationDetails`
* Add support for snapshot events `FinancialConnectionsAccountAccountNumbersUpdated` and `FinancialConnectionsAccountUpcomingAccountNumberExpiry` with resource `FinancialConnections.Account`
