---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3483
semver_level: major
is_stripe_api_change: true
released_in_version: 53.2.0-alpha.1
---

* Add support for new resources `V2.Billing.ContractTermQuantityChange`, `V2.Billing.ContractTerm`, `V2.Core.AccountSession`, `V2.MoneyManagement.FundingIntent`, `V2.MoneyManagement.InboundFunding`, `V2.MoneyManagement.RewardProgramEnrollment`, `V2.MoneyManagement.RewardProgramRule`, `V2.MoneyManagement.RewardProgram`, and `V2.Risk.Form`
* ⚠️ Remove support for resource `V2.Risk.Inquiry`
* Add support for `Get` and `Update` methods on resource `V2.Risk.Form`
* Add support for `Activate`, `Create`, `Deactivate`, `Get`, and `List` methods on resource `V2.MoneyManagement.RewardProgramEnrollment`
* Add support for `Activate`, `Create`, `Deactivate`, `Get`, `List`, and `Update` methods on resources `V2.MoneyManagement.RewardProgramRule` and `V2.MoneyManagement.RewardProgram`
* Add support for `Get` and `List` methods on resource `V2.MoneyManagement.InboundFunding`
* Add support for `Cancel`, `Confirm`, `Create`, `Get`, `List`, and `Update` methods on resource `V2.MoneyManagement.FundingIntent`
* Add support for `Create` method on resource `V2.Core.AccountSession`
* Add support for `ListContractTerms` and `RetrieveContractTerm` methods on resource `V2.Billing.ContractTerm`
* ⚠️ Remove support for `Get`, `List`, and `Update` methods on resource `V2.Risk.Inquiry`
* ⚠️ Remove support for `FxQuote` method on resource `V2.MoneyManagement.PayoutIntent`
* Add support for `Reject` and `Unreject` methods on resource `V2.Core.Account`
* Add support for `BillingGroup` on `Billing.Alert.SpendThreshold.Filters`, `Billing.AlertNotification`, `Billing.AlertTriggered.GroupBy`, `Billing.BillingAlertAlertNotificationListOptions`, and `BillingAlertSpendThresholdFiltersOptions`
* Add support for `TossPay` on `Charge.PaymentMethodDetails`, `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `PaymentAttemptRecord.PaymentMethodDetails`, `PaymentIntent.PaymentMethodOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, `PaymentRecord.PaymentMethodDetails`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `Mandate` on `Charge.PaymentMethodDetails.Paypay`, `PaymentAttemptRecord.PaymentMethodDetails.Paypay`, `PaymentRecord.PaymentMethodDetails.Paypay`, `Subscription.PaymentSettings`, and `SubscriptionPaymentSettingsOptions`
* Add support for `AutomaticPassThroughFee` on `Checkout.SessionCreateOptions` and `Checkout.Session`
* Add support for `Paypay` on `Checkout.Session.PaymentMethodOptions` and `CheckoutSessionPaymentMethodOptionsOptions`
* Add support for `AdjustableQuantity` on `Checkout.Session.Item.Subscription.Item`
* Add support for `MarketingAttributions` on `CustomerCreateOptions` and `Customer`
* Add support for `MerchantOfRecord` on `PaymentIntent.PaymentDetails.MoneyServices.AccountFunding` and `PaymentIntentPaymentDetailsMoneyServicesAccountFundingOptions`
* Add support for `PaymentMethodData` and `PaymentMethodOptions` on `RefundCreateOptions`
* Add support for `DebitBehavior` on `Subscription.PaymentSettings.PaymentMethodOptions.SepaDebit` and `SubscriptionPaymentSettingsPaymentMethodOptionsSepaDebitOptions`
* Add support for `Terms` on `V2.Billing.ContractCancelOptions`, `V2.Billing.ContractCreateOptions`, and `V2.Billing.Contract`
* Add support for `Rejection` on `V2.Core.Account`
* Add support for `AlipayPayments`, `ScalapayPayments`, and `UpiPayments` on `V2.Core.Account.Configuration.Merchant.Capabilities` and `V2CoreAccountConfigurationMerchantCapabilitiesOptions`
* Add support for `InboundFundings` on `V2.Core.Account.Configuration.MoneyManager.Capabilities` and `V2CoreAccountConfigurationMoneyManagerCapabilitiesOptions`
* ⚠️ Remove support for `Instant` and `SepaCredit` on `V2.Core.Account.Configuration.Recipient.Capabilities.BankAccounts` and `V2CoreAccountConfigurationRecipientCapabilitiesBankAccountsOptions`
* Add support for `Compression` on `V2.Data.QueryRun.ResultOptions`, `V2.Data.ReportRun.ResultOptions`, `V2DataQueryRunResultOptionsOptions`, and `V2DataReportRunResultOptionsOptions`
* ⚠️ Remove support for `CompressFile` on `V2.Data.QueryRun.ResultOptions`, `V2.Data.ReportRun.ResultOptions`, `V2DataQueryRunResultOptionsOptions`, and `V2DataReportRunResultOptionsOptions`
* Add support for `QueryErrors` on `V2.Data.QueryRun.StatusDetails` and `V2.Data.ReportRun.StatusDetails`
* Add support for `Format` on `V2.Data.ReportRun`
* Add support for `RefreshedAt` on `V2.Data.Report`
* Add support for `SchemaName` on `V2.Data.Schema.Column.ForeignKeysFrom` and `V2.Data.Schema.Column.ForeignKeysTo`
* ⚠️ Remove support for `Authentication` and `SessionFingerprint` on `V2.Iam.ActivityLog.Details.UserAccess`
* Add support for `UserAgent` on `V2.Iam.ActivityLog.Details.UserAccess.DashboardClient`
* ⚠️ Remove support for `BrowserVersion`, `Browser`, `DeviceType`, and `Os` on `V2.Iam.ActivityLog.Details.UserAccess.DashboardClient`
* ⚠️ Remove support for `Level` on `V2.Iam.ActivityLog.Details.UserAccess.Risk`
* Add support for `Reference` on `V2.MoneyManagement.FinancialAddress.BankAccount.Iban`
* Add support for `BankAccount`, `Card`, `CryptoWallet`, `Status`, and `Type` on `V2.MoneyManagement.OutboundPayment.TrackingDetails`
* Add support for `RecipientVerification` on `V2.MoneyManagement.PayoutIntent`
* Add support for `FieldsToReview` on `V2.MoneyManagement.PayoutIntent.NextAction.Confirm`
* ⚠️ Remove support for `CaBankAccount`, `EuBankAccount`, and `MxBankAccount` on `V2.MoneyManagement.ReceivedCredit.BankTransfer`
* ⚠️ Remove support for `Network` on `V2.MoneyManagement.ReceivedCredit.BankTransfer.OriginatingBankAccount.Aba`, `V2.MoneyManagement.ReceivedCredit.BankTransfer.OriginatingBankAccount.BreB`, `V2.MoneyManagement.ReceivedCredit.BankTransfer.OriginatingBankAccount.Clabe`, `V2.MoneyManagement.ReceivedCredit.BankTransfer.OriginatingBankAccount.Cpa`, `V2.MoneyManagement.ReceivedCredit.BankTransfer.OriginatingBankAccount.Iban`, `V2.MoneyManagement.ReceivedCredit.BankTransfer.OriginatingBankAccount.Nip`, `V2.MoneyManagement.ReceivedCredit.BankTransfer.OriginatingBankAccount.Pix`, and `V2.MoneyManagement.ReceivedCredit.BankTransfer.OriginatingBankAccount.SortCode`
* Add support for `PayoutMethod`, `Recipient`, and `VerificationType` on `V2.MoneyManagement.RecipientVerification`
* ⚠️ Change type of `V2.MoneyManagement.RecipientVerification.ConsumedBy` from `string` to `an object`
* Add support for `MatchedBusinessType` and `ProvidedBusinessType` on `V2.MoneyManagement.RecipientVerification.MatchResultDetails`
* Add support for `Configuration` on `V2.Provisioning.Resource`
* Add support for `CustomMarketingAction` and `TriggeringSignal` on `V2.Signals.AccountActivityCreateOptions` and `V2.Signals.AccountActivity`
* Add support for `MfaChallenges` on `V2.Signals.AccountActivity.LoginDecision` and `V2SignalsAccountActivityLoginDecisionOptions`
* Add support for `UserAffinity` on `V2.Signals.AccountEvaluation.EvaluatedSignals` and `V2.Signals.AccountSignal`
* ⚠️ Remove support for `UserMerchantFit` on `V2.Signals.AccountEvaluation.EvaluatedSignals` and `V2.Signals.AccountSignal`
* Add support for `AdditionalDetails` on `V2.Signals.AccountSignal.CustomerRisk`
* Add support for `Subscriptions` on `V2.Tax.IntegrationConfigurationUpdateOptions` and `V2.Tax.IntegrationConfiguration`
* Add support for `Include` on `V2.Provisioning.ResourceGetOptions`
* ⚠️ Remove support for `Amount` and `From` on `V2.MoneyManagement.PayoutIntentUpdateOptions`
* Add support for `Parameters` on `V2.Data.QueryRunCreateOptions`
* Add support for `Actions` on `V2.Billing.ContractUpdateOptions`
* Add support for `Severity` on `EventsV2CoreHealthApiErrorFiringEvent`, `EventsV2CoreHealthApiErrorResolvedEvent`, `EventsV2CoreHealthApiLatencyFiringEvent`, `EventsV2CoreHealthApiLatencyResolvedEvent`, `EventsV2CoreHealthAuthorizationRateDropFiringEvent`, `EventsV2CoreHealthAuthorizationRateDropResolvedEvent`, `EventsV2CoreHealthElementsErrorFiringEvent`, `EventsV2CoreHealthElementsErrorResolvedEvent`, `EventsV2CoreHealthFraudRateIncreasedEvent`, `EventsV2CoreHealthInvoiceCountDroppedFiringEvent`, `EventsV2CoreHealthInvoiceCountDroppedResolvedEvent`, `EventsV2CoreHealthIssuingAuthorizationRequestErrorsFiringEvent`, `EventsV2CoreHealthIssuingAuthorizationRequestErrorsResolvedEvent`, `EventsV2CoreHealthIssuingAuthorizationRequestTimeoutFiringEvent`, `EventsV2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEvent`, `EventsV2CoreHealthMeterEventSummariesDelayedFiringEvent`, `EventsV2CoreHealthMeterEventSummariesDelayedResolvedEvent`, `EventsV2CoreHealthMetronomeNotificationLatencyFiringEvent`, `EventsV2CoreHealthMetronomeNotificationLatencyResolvedEvent`, `EventsV2CoreHealthPaymentMethodErrorFiringEvent`, `EventsV2CoreHealthPaymentMethodErrorResolvedEvent`, `EventsV2CoreHealthSepaDebitDelayedFiringEvent`, `EventsV2CoreHealthSepaDebitDelayedResolvedEvent`, `EventsV2CoreHealthTrafficVolumeDropFiringEvent`, `EventsV2CoreHealthTrafficVolumeDropResolvedEvent`, `EventsV2CoreHealthWebhookLatencyFiringEvent`, and `EventsV2CoreHealthWebhookLatencyResolvedEvent`
* Add support for event notifications `V2BillingContractTermCreatedEvent`, `V2BillingContractTermDeletedEvent`, and `V2BillingContractTermUpdatedEvent` with related object `V2.Billing.ContractTerm`
* Add support for event notifications `V2MoneyManagementFundingIntentCanceledEvent`, `V2MoneyManagementFundingIntentCreatedEvent`, `V2MoneyManagementFundingIntentProcessingEvent`, `V2MoneyManagementFundingIntentRequiresActionEvent`, `V2MoneyManagementFundingIntentRequiresConfirmationEvent`, `V2MoneyManagementFundingIntentSucceededEvent`, `V2MoneyManagementFundingIntentUpdatedEvent`, and `V2MoneyManagementFundingIntentValidatingEvent` with related object `V2.MoneyManagement.FundingIntent`
* Add support for event notifications `V2MoneyManagementInboundFundingAvailableEvent`, `V2MoneyManagementInboundFundingCheckFailedEvent`, `V2MoneyManagementInboundFundingCheckProcessingEvent`, `V2MoneyManagementInboundFundingCheckQueuedEvent`, `V2MoneyManagementInboundFundingCheckReturnedEvent`, `V2MoneyManagementInboundFundingCheckSucceededEvent`, `V2MoneyManagementInboundFundingCreatedEvent`, and `V2MoneyManagementInboundFundingUpdatedEvent` with related object `V2.MoneyManagement.InboundFunding`
* Add support for event notifications `V2MoneyManagementRewardProgramRewardEarnedEvent` and `V2MoneyManagementRewardProgramRewardReversedEvent` with related object `V2.MoneyManagement.RewardProgram`
* ⚠️ Remove support for event notifications `V2PaymentsOffSessionPaymentAuthorizationAttemptFailedEvent` and `V2PaymentsOffSessionPaymentAuthorizationAttemptStartedEvent` with related object `V2.Payments.OffSessionPayment`
