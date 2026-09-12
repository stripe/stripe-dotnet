---
title: Update generated code for private-preview
pr_url: https://github.com/stripe/stripe-dotnet/pull/3360
is_breaking: true
is_stripe_api_change: true
released_in_version: 51.1.0-alpha.2
---

* Add support for new resources `SharedPayment.IssuedToken` and `V2.Data.Reporting.QueryRun`
* Add support for `Create` and `Get` methods on resource `V2.Data.Reporting.QueryRun`
* Add support for `Pause` and `Resume` methods on resource `V2.Payments.OffSessionPayment`
* Add support for `TenantKeys`, `TenantOperator`, and `TenantValues` on `Billing.BillingMeterMeterEventSummaryListOptions`
* Add support for `MoneyServices` on `ChargePaymentDetailsOptions` and `PaymentIntentPaymentDetailsOptions`
* Add support for `PaymentMethodOptions` on `DelegatedCheckout.RequestedSessionCreateOptions`, `DelegatedCheckout.RequestedSessionUpdateOptions`, and `DelegatedCheckout.RequestedSession`
* ⚠️ Remove support for `PaymentMethodData` on `DelegatedCheckout.RequestedSessionConfirmOptions`, `DelegatedCheckout.RequestedSessionCreateOptions`, and `DelegatedCheckout.RequestedSessionUpdateOptions`
* Add support for `CardBrands` and `PaymentMethodTypes` on `DelegatedCheckout.RequestedSession.SellerDetails`
* ⚠️ Change type of `DelegatedCheckout.RequestedSession.SharedPaymentIssuedToken` from `string` to `expandable($SharedPayment.IssuedToken)`
* Add support for `CheckScan` on `Invoice.PaymentSettings.PaymentMethodOptions`, `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions`, `Subscription.PaymentSettings.PaymentMethodOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`
* Add support for `ProcessorDetails` on `PaymentAttemptRecordReportFailedOptions`, `PaymentAttemptRecordReportGuaranteedOptions`, `PaymentRecordFailedOptions`, `PaymentRecordGuaranteedOptions`, `PaymentRecordReportPaymentAttemptFailedOptions`, and `PaymentRecordReportPaymentAttemptGuaranteedOptions`
* Add support for `PaymentDetails` on `PaymentIntentPaymentMethodOptionsCardOptions` and `PaymentIntentPaymentMethodOptionsCardPresentOptions`
* ⚠️ Remove support for `BillFrom` on `QuotePreviewSubscriptionSchedule.BillingSchedule`, `Subscription.BillingSchedule`, and `SubscriptionSchedule.BillingSchedule`
* Add support for `AgentDetails`, `PaymentMethodDetails`, and `RiskDetails` on `SharedPayment.GrantedToken`
* Add support for `PaperChecks` on `V2.Account.Configuration.RecipientData.Features`, `V2.Core.Account.Configuration.Recipient.Capabilities`, `V2.Core.Account.Configuration.Storer.Capabilities.OutboundPayments`, `V2AccountConfigurationRecipientDataFeaturesOptions`, `V2CoreAccountConfigurationRecipientCapabilitiesOptions`, and `V2CoreAccountConfigurationStorerCapabilitiesOutboundPaymentsOptions`
* ⚠️ Change type of `V2.Billing.Cadence.SettingsData.Collection.PaymentMethodOptions.Konbini`, `V2.Billing.CollectionSetting.PaymentMethodOptions.Konbini`, `V2.Billing.CollectionSettingVersion.PaymentMethodOptions.Konbini`, and `V2BillingCollectionSettingPaymentMethodOptionsOptions.Konbini` from `map(string: dynamic)` to `an object`
* ⚠️ Change type of `V2.Billing.Cadence.SettingsData.Collection.PaymentMethodOptions.SepaDebit`, `V2.Billing.CollectionSetting.PaymentMethodOptions.SepaDebit`, `V2.Billing.CollectionSettingVersion.PaymentMethodOptions.SepaDebit`, and `V2BillingCollectionSettingPaymentMethodOptionsOptions.SepaDebit` from `map(string: dynamic)` to `an object`
* Add support for `Id` on `V2.Billing.CadenceSpendModifier.MaxBillingPeriodSpend.Amount.CustomPricingUnit`, `V2.Billing.IntentAction.Apply.SpendModifierRule.MaxBillingPeriodSpend.Amount.CustomPricingUnit`, and `V2BillingIntentActionApplySpendModifierRuleMaxBillingPeriodSpendAmountCustomPricingUnitOptions`
* ⚠️ Change type of `V2.Core.Event.Reason.Request.Client.StripeAction` from `map(string: dynamic)` to `an object`
* ⚠️ Change type of `V2.MoneyManagement.InboundTransfer.TransferHistory.BankDebitProcessing` from `map(string: dynamic)` to `an object`
* ⚠️ Change type of `V2.MoneyManagement.InboundTransfer.TransferHistory.BankDebitQueued` from `map(string: dynamic)` to `an object`
* ⚠️ Change type of `V2.MoneyManagement.InboundTransfer.TransferHistory.BankDebitSucceeded` from `map(string: dynamic)` to `an object`
* ⚠️ Remove support for `Town` on `V2.MoneyManagement.OutboundPayment.TrackingDetails.PaperCheck.MailingAddress`
* Add support for `ApplicationFeeAmountRequested` on `V2.Payments.OffSessionPayment`
* ⚠️ Remove support for `CompartmentId` on `V2.Payments.OffSessionPayment`
* Add support for `RetryUntil` on `V2.Payments.OffSessionPayment.RetryDetails`
* Add support for `ApplicationFeeAmount` on `V2.Payments.OffSessionPaymentCaptureOptions` and `V2.Payments.OffSessionPaymentCreateOptions`
* Add support for `AlertId` on `EventsV2CoreHealthApiErrorResolvedEvent`, `EventsV2CoreHealthApiLatencyResolvedEvent`, `EventsV2CoreHealthAuthorizationRateDropResolvedEvent`, `EventsV2CoreHealthIssuingAuthorizationRequestErrorsFiringEvent`, `EventsV2CoreHealthIssuingAuthorizationRequestErrorsResolvedEvent`, `EventsV2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEvent`, `EventsV2CoreHealthPaymentMethodErrorResolvedEvent`, `EventsV2CoreHealthSepaDebitDelayedFiringEvent`, `EventsV2CoreHealthSepaDebitDelayedResolvedEvent`, `EventsV2CoreHealthTrafficVolumeDropResolvedEvent`, and `EventsV2CoreHealthWebhookLatencyResolvedEvent`
* Add support for `ApiKey` on `EventsV2IamApiKeyCreatedEvent`, `EventsV2IamApiKeyDefaultSecretRevealedEvent`, `EventsV2IamApiKeyExpiredEvent`, `EventsV2IamApiKeyPermissionsUpdatedEvent`, `EventsV2IamApiKeyRotatedEvent`, and `EventsV2IamApiKeyUpdatedEvent`
* Add support for `StripeAccessGrant` on `EventsV2IamStripeAccessGrantApprovedEvent`, `EventsV2IamStripeAccessGrantCanceledEvent`, `EventsV2IamStripeAccessGrantDeniedEvent`, `EventsV2IamStripeAccessGrantRemovedEvent`, `EventsV2IamStripeAccessGrantRequestedEvent`, and `EventsV2IamStripeAccessGrantUpdatedEvent`
* Add support for event notifications `V2DataReportingQueryRunCreatedEvent`, `V2DataReportingQueryRunFailedEvent`, `V2DataReportingQueryRunSucceededEvent`, and `V2DataReportingQueryRunUpdatedEvent` with related object `V2.Data.Reporting.QueryRun`
* Add support for event notifications `V2PaymentsOffSessionPaymentPausedEvent` and `V2PaymentsOffSessionPaymentResumedEvent` with related object `V2.Payments.OffSessionPayment`
