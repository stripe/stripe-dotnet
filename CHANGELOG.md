<!--
THIS IS A GENERATED FILE. Any changes you make to it directly will be blown away.
Instead, edit a corresponding `.change.md` file and run `hark build`.
-->

# Changelog

> This changelog only covers the **private preview** releases. Each release builds on the most recent GA release; see those notes in [the GA changelog](https://github.com/stripe/stripe-dotnet/blob/master/CHANGELOG.md).

## 52.5.0-alpha.3 - 2026-09-09
* ⚠️ [#3444](https://github.com/stripe/stripe-dotnet/pull/3444) Update generated code for private-preview
  * Add support for new resources `V2.Signals.PaymentRetryEvaluation`, `V2.Signals.PaymentRetrySignal`, and `V2.Tax.IntegrationConfiguration`
  * Add support for `Get` and `Update` methods on resource `V2.Tax.IntegrationConfiguration`
  * Add support for `Get` method on resource `V2.Signals.PaymentRetrySignal`
  * Add support for `Cancel`, `Create`, `Get`, and `Update` methods on resource `V2.Signals.PaymentRetryEvaluation`
  * Add support for `Disable` method on resource `V2.MoneyManagement.PayoutMethod`
  * Add support for `Update` method on resource `V2.Core.ApprovalRequest`
  * ⚠️ Remove support for `Execute` and `Submit` methods on resource `V2.Core.ApprovalRequest`
  * Add support for `CustomerTaxExemption` on `Tax.Calculation.ShippingCost.TaxBreakdown`, `Tax.CalculationLineItem.TaxBreakdown`, and `Tax.Transaction.ShippingCost.TaxBreakdown`
  * Add support for `BackdateStartDate` on `Checkout.Session.Item.Subscription` and `CheckoutSessionItemSubscriptionOptions`
  * Add support for `Signals` on `Identity.VerificationReport`
  * Add support for `NetworkResponseCode` on `Issuing.Authorization.RequestHistory`
  * Add support for `UnitCostPrecision` on `PaymentIntentAmountDetailsLineItem` and `PaymentIntentAmountDetailsLineItemsOptions`
  * Add support for `Active` on `ProductCatalog.TrialOfferListOptions`
  * Add support for `OneTimeFees` on `V2.Billing.ContractCreateOptions` and `V2.Billing.Contract`
  * ⚠️ Remove support for `PaymentMethodCollection` on `V2.Core.Account.Configuration.Merchant.GrossSettlement` and `V2CoreAccountConfigurationMerchantGrossSettlementOptions`
  * Add support for `PayoutMethods` on `V2.Core.Account.Defaults` and `V2CoreAccountDefaultsOptions`
  * Add support for `Reason` on `V2.Core.ApprovalRequest`
  * ⚠️ Remove support for `Description` on `V2.Core.ApprovalRequest`
  * Add support for `ApiKey`, `Type`, and `User` on `V2.Core.ApprovalRequest.RequestedBy` and `V2.Core.ApprovalRequest.Review.ReviewedBy`
  * ⚠️ Remove support for `Id` and `Name` on `V2.Core.ApprovalRequest.RequestedBy` and `V2.Core.ApprovalRequest.Review.ReviewedBy`
  * Add support for `ApprovedAt` on `V2.Core.ApprovalRequest.StatusTransitions`
  * ⚠️ Remove support for `RequiresExecutionAt` on `V2.Core.ApprovalRequest.StatusTransitions`
  * Add support for `CryptoTransaction` on `V2.Core.FeeBatch.CollectionRecord`
  * Add support for `Restricted` on `V2.Core.Vault.GbBankAccount` and `V2.Core.Vault.UsBankAccount`
  * Add support for `Savings` on `V2.MoneyManagement.FinancialAccountCreateOptions` and `V2.MoneyManagement.FinancialAccount`
  * Add support for `EnabledDeliverySchemes` on `V2.MoneyManagement.PayoutMethod.BankAccount`
  * ⚠️ Remove support for `EnabledDeliveryOptions` on `V2.MoneyManagement.PayoutMethod.BankAccount`
  * Add support for `ToAccount` on `V2.MoneyManagement.ReceivedDebit.BalanceTransfer`
  * Add support for `AccountRestricted`, `AccountSuspended`, and `Metadata` on `V2.Signals.AccountActivityCreateOptions` and `V2.Signals.AccountActivity`
  * Add support for `AdditionalDetails` on `V2.Signals.AccountSignal.FraudulentMerchant` and `V2.Signals.AccountSignal.MerchantDelinquency`
  * ⚠️ Remove support for `Indicators` on `V2.Signals.AccountSignal.FraudulentMerchant` and `V2.Signals.AccountSignal.MerchantDelinquency`
  * Add support for `Action`, `Created`, and `Status` on `V2.Core.ApprovalRequestListOptions`
  * Add support for `OneTimeFeeActions` on `V2.Billing.ContractUpdateOptions`
  * Add support for event notifications `V2CoreHealthMetronomeNotificationLatencyFiringEvent`, `V2CoreHealthMetronomeNotificationLatencyResolvedEvent`, and `V2SignalsPaymentRetryEvaluationsRetryRecommendedEvent`
  * Add support for event notifications `V2MoneyManagementPayoutIntentCanceledEvent`, `V2MoneyManagementPayoutIntentCreatedEvent`, `V2MoneyManagementPayoutIntentPostedEvent`, `V2MoneyManagementPayoutIntentProcessingEvent`, and `V2MoneyManagementPayoutIntentRequiresActionEvent` with related object `V2.MoneyManagement.PayoutIntent`

## 52.5.0-alpha.2 - 2026-09-02
This release changes the pinned API version to `2026-08-26.preview`.

* ⚠️ [#3438](https://github.com/stripe/stripe-dotnet/pull/3438) Update generated code for private-preview
  * Add support for new resource `Radar.BillingEvaluation`
  * Add support for `Create` method on resource `Radar.BillingEvaluation`
  * Add support for `CapitalFinancingManualPayment` on `AccountSession.Components`
  * Add support for `SequraPayments` on `Account.Capabilities`
  * Add support for `Sequra` on `Charge.PaymentMethodDetails`, `Checkout.Session.PaymentMethodOptions`, `ConfirmationToken.PaymentMethodPreview`, `PaymentAttemptRecord.PaymentMethodDetails`, `PaymentIntent.PaymentMethodOptions`, and `PaymentRecord.PaymentMethodDetails`
  * Add support for `PaymentIntentData` on `Checkout.SessionUpdateOptions`
  * ⚠️ Change type of `Checkout.Session.PaymentMethodOptions.Bancontact.SetupFutureUsage` from `literal('none')` to `enum('none'|'off_session')`
  * Add support for `AddressMatchConfidence` and `NameMatchConfidence` on `Identity.VerificationReport.Email` and `Identity.VerificationReport.Phone`
  * Add support for `DomainCountry`, `EmailExistsConfidence`, `ObservedDomainTenureDays`, `ObservedEmailTenureDays`, and `PhoneMatchConfidence` on `Identity.VerificationReport.Email`
  * Add support for `Carrier`, `LineType`, and `ObservedPhoneTenureDays` on `Identity.VerificationReport.Phone`
  * Add support for `VerificationMethod` on `PaymentIntent.PaymentMethodOptions.BacsDebit`, `PaymentIntentPaymentMethodOptionsBacsDebitOptions`, `SetupIntent.PaymentMethodOptions.BacsDebit`, and `SetupIntentPaymentMethodOptionsBacsDebitOptions`
  * Add support for `AadeData` on `PaymentIntentPaymentMethodOptionsCardPresentOptions`
  * Add support for `Canceled` on `PaymentRecordReportPaymentAttemptOptions` and `PaymentRecordReportPaymentOptions`
  * Add support for `Recurring` on `SharedPayment.GrantedToken.UsageLimits`, `SharedPayment.IssuedToken.UsageLimits`, `SharedPaymentGrantedTokenUsageLimitsOptions`, and `SharedPaymentIssuedTokenUsageLimitsOptions`
  * Add support for `PricingToken` on `SubscriptionUpdateOptions`
  * ⚠️ Remove support for `CancelAtPeriodEnd` on `Subscription.PendingUpdate`

## 52.5.0-alpha.1 - 2026-08-26
* [#3425](https://github.com/stripe/stripe-dotnet/pull/3425) Add non-verified manged handlers
* ⚠️ [#3430](https://github.com/stripe/stripe-dotnet/pull/3430) Update generated code for private-preview
  * Add support for new resource `CustomerTaxExemption`
  * Add support for `Create`, `Delete`, `Get`, and `List` methods on resource `CustomerTaxExemption`
  * Add support for `Details` on `Account.FutureRequirements.Errors`, `Account.Requirements.Errors`, `BankAccount.FutureRequirements.Errors`, `BankAccount.Requirements.Errors`, `Capability.FutureRequirements.Error`, `Capability.Requirements.Error`, `Person.FutureRequirements.Error`, and `Person.Requirements.Error`
  * Add support for `PaymentMethodSettings` on `AccountSession.Components`
  * ⚠️ Remove support for `SequraPayments` on `Account.Capabilities`
  * Add support for `SubscriptionPause` on `BillingPortalSessionFlowDataOptions`
  * ⚠️ Remove support for `Sequra` on `Charge.PaymentMethodDetails`, `Checkout.Session.PaymentMethodOptions`, `ConfirmationToken.PaymentMethodPreview`, `PaymentAttemptRecord.PaymentMethodDetails`, `PaymentIntent.PaymentMethodOptions`, and `PaymentRecord.PaymentMethodDetails`
  * Add support for `FundingSourceGroup` on `Charge.PaymentMethodDetails.Card.Wallet.Link`
  * Add support for `EnablementDetails` on `Checkout.Session.AutomaticTax`
  * Add support for `Credit` on `FinancialConnections.Transaction.Classifications`
  * Add support for `UserConsent` on `Identity.VerificationSessionCreateOptions` and `Identity.VerificationSessionUpdateOptions`
  * Add support for `Billie` on `InvoicePaymentSettingsPaymentMethodOptionsOptions` and `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`
  * Add support for `CompanyDetails` on `Invoice.PaymentSettings.PaymentMethodOptions.Billie`, `PaymentIntent.PaymentMethodOptions.Billie`, `PaymentIntentPaymentMethodOptionsBillieOptions`, `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions.Billie`, and `Subscription.PaymentSettings.PaymentMethodOptions.Billie`
  * Add support for `Reference` on `Invoice.PaymentSettings.PaymentMethodOptions.Billie`, `PaymentIntent.PaymentMethodOptions.Billie`, `PaymentIntentPaymentMethodOptionsBillieOptions`, and `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions.Billie`
  * Add support for `PosCondition` on `Issuing.Authorization` and `Issuing.TestHelpersAuthorizationCreateOptions`
  * Add support for `CryptoWallet` on `Issuing.CardCreateOptions`, `Issuing.CardUpdateOptions`, and `Issuing.Card`
  * Add support for `PaymentEvaluations` and `PaymentMethodDetails` on `PaymentAttemptRecordReportAuthorizedOptions`
  * Add support for `BlikRecurringPayments` on `V2.Core.Account.Configuration.Merchant.Capabilities` and `V2CoreAccountConfigurationMerchantCapabilitiesOptions`
  * Add support for `UserAccess` on `V2.Iam.ActivityLog.Details`

## 52.4.0-alpha.2 - 2026-08-19
* ⚠️ [#3423](https://github.com/stripe/stripe-dotnet/pull/3423) Update generated code for private-preview
  * Add support for new resources `Billing.FeedbackOption` and `PaymentPlan`
  * ⚠️ Remove support for resource `Billing.FeedbackOptions`
  * Add support for `Create`, `Get`, `List`, and `Update` methods on resource `PaymentPlan`
  * Add support for `Update` method on resource `V2.MoneyManagement.Transaction`
  * Add support for `WechatPayPayments` on `Account.Settings` and `AccountSettingsOptions`
  * ⚠️ Change type of `BillingPortal.Configuration.Features.SubscriptionCancel.CancellationReason.FeedbackOptions` from `$Billing.FeedbackOptions` to `$Billing.FeedbackOption`
  * Add support for `SubscriptionPause` on `BillingPortal.Session.Flow`
  * Add support for `ActiveEntitlements` on `CustomerSession.Components`
  * Add support for `SharedPaymentIssuedToken` on `DelegatedCheckout.RequestedSessionConfirmOptions`
  * Add support for `ManagedPayments` on `InvoiceCreateOptions`, `InvoiceItemCreateOptions`, `InvoiceItem`, `Invoice`, and `QuotePreviewInvoice`
  * Add support for `PaymentPlan` on `Invoice`
  * Add support for `EstimatedFeeDetails` and `EstimatedFee` on `Issuing.Authorization.PendingRequest.HoldAmountDetails` and `Issuing.Authorization.RequestHistory.HoldAmountDetails`
  * ⚠️ Remove support for `Cryptogram` on `PaymentAttemptRecord.PaymentMethodDetails.Card.ThreeDSecure` and `PaymentRecord.PaymentMethodDetails.Card.ThreeDSecure`
  * ⚠️ Change type of `ProductCatalog.TrialOffer.EndBehavior.Transition.Price` from `$Price` to `deletable($Price)`
  * ⚠️ Change type of `Subscription.CancellationDetails.FeedbackOption` from `$Billing.FeedbackOptions` to `$Billing.FeedbackOption`
  * Add support for `CancelAtPeriodEnd` on `Subscription.PendingUpdate`
  * Add support for `Igic` on `Tax.Registration.CountryOptions.At`, `Tax.Registration.CountryOptions.Be`, `Tax.Registration.CountryOptions.Bg`, `Tax.Registration.CountryOptions.Cy`, `Tax.Registration.CountryOptions.Cz`, `Tax.Registration.CountryOptions.De`, `Tax.Registration.CountryOptions.Dk`, `Tax.Registration.CountryOptions.Ee`, `Tax.Registration.CountryOptions.Es`, `Tax.Registration.CountryOptions.Fi`, `Tax.Registration.CountryOptions.Fr`, `Tax.Registration.CountryOptions.Gr`, `Tax.Registration.CountryOptions.Hr`, `Tax.Registration.CountryOptions.Hu`, `Tax.Registration.CountryOptions.Ie`, `Tax.Registration.CountryOptions.It`, `Tax.Registration.CountryOptions.Lt`, `Tax.Registration.CountryOptions.Lu`, `Tax.Registration.CountryOptions.Lv`, `Tax.Registration.CountryOptions.Mt`, `Tax.Registration.CountryOptions.Nl`, `Tax.Registration.CountryOptions.Pl`, `Tax.Registration.CountryOptions.Pt`, `Tax.Registration.CountryOptions.Ro`, `Tax.Registration.CountryOptions.Se`, `Tax.Registration.CountryOptions.Si`, and `Tax.Registration.CountryOptions.Sk`
  * Add support for `Metadata` on `V2.Billing.Contract.PricingLines.Data.Pricing.PriceDetails.PricingOverrides.Data`, `V2.Billing.Contract.PricingOverrides.Data`, `V2.Billing.ContractUpdateOptions`, `V2.MoneyManagement.Transaction`, `V2BillingContractPricingLineActionUpdateOptions`, `V2BillingContractPricingOverrideActionAddOptions`, `V2BillingContractPricingOverrideActionUpdateOptions`, and `V2BillingContractPricingOverrideOptions`
  * Add support for `TaxAmount` on `V2.MoneyManagement.OutboundPaymentQuote.EstimatedFee`
  * Add support for `PayoutMethodOptions` on `V2.MoneyManagement.OutboundPaymentQuote.To` and `V2MoneyManagementOutboundPaymentQuoteToOptions`
  * Change type of `V2BillingContractPricingLineActionUpdatePricingPriceDetailsPricingOverrideActionUpdateOptions.Metadata` from `string` to `emptyable(string)`
  * Add support for snapshot events `PaymentPlanCreated`, `PaymentPlanInstallmentDue`, `PaymentPlanInstallmentPaid`, `PaymentPlanInstallmentWillBeDue`, and `PaymentPlanUpdated` with resource `PaymentPlan`

## 52.4.0-alpha.1 - 2026-08-12
This release changes the pinned API version to `2026-08-12.preview`.

* ⚠️ [#3421](https://github.com/stripe/stripe-dotnet/pull/3421) Update generated code for private-preview
  * Add support for new resource `V2.Tax.OperationsResolveAddressResult`
  * Add support for `ResolveAddress` method on resource `V2.Tax.OperationsResolveAddressResult`
  * Add support for `Confirm` and `FxQuote` methods on resource `V2.MoneyManagement.PayoutIntent`
  * Add support for `CustomerUpdate` on `BillingPortal.Session.Flow`
  * Add support for `FundingSourceGroup` on `Charge.PaymentMethodDetails.Link`
  * ⚠️ Remove support for `PricingGroup` on `Charge.PaymentMethodDetails.Link`
  * Add support for `Celo` on `Crypto.OnrampSession.TransactionDetails.WalletAddresses`
  * Add support for `CustomerPortal` on `CustomerSession.Components`
  * Add support for `AppliedToInvoice` and `Type` on `CustomerCustomerBalanceTransactionCreateOptions`
  * Add support for `ClassificationState` and `EnrichmentState` on `FinancialConnections.Account`
  * Add support for `Country` on `FinancialConnections.Session.Filters`
  * Add support for `Classifications` and `Enrichments` on `FinancialConnections.Transaction`
  * Add support for `CustomerBalance` on `Invoice` and `QuotePreviewInvoice`
  * Add support for `Billie` on `Invoice.PaymentSettings.PaymentMethodOptions`, `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions`, and `Subscription.PaymentSettings.PaymentMethodOptions`
  * Add support for `HoldAmountDetails` and `HoldAmount` on `Issuing.Authorization.PendingRequest` and `Issuing.Authorization.RequestHistory`
  * Add support for `NetworkDeclineCode` on `PaymentAttemptRecordPaymentMethodDetailsCardOptions` and `PaymentRecordPaymentMethodDetailsCardOptions`
  * Add support for `SetupFutureUsage` on `PaymentIntent.PaymentMethodOptions.Sequra`
  * Add support for `Status` on `QuotePreviewSubscriptionSchedule.PauseSchedule.Pause`, `QuotePreviewSubscriptionSchedule.PauseSchedule.Resume`, `SubscriptionSchedule.PauseSchedule.Pause`, and `SubscriptionSchedule.PauseSchedule.Resume`
  * Change type of `SubscriptionSchedulePauseSchedulesOptions.Resume` from `pause_schedule_update_resume_params` to `emptyable(pause_schedule_update_resume_params)`
  * Add support for `Acquirer` on `EventsV2CoreHealthAuthorizationRateDropFiringEventImpactDimension`, `EventsV2CoreHealthAuthorizationRateDropResolvedEventImpactDimension`, `V2.Core.Health.Alert.AuthorizationRateDrop.Dimension`, and `V2.Core.Health.AlertHistoryEntry.AuthorizationRateDrop.Dimension`
  * ⚠️ Change type of `EventsV2CoreHealthAuthorizationRateDropFiringEventImpactDimension.Type`, `EventsV2CoreHealthAuthorizationRateDropResolvedEventImpactDimension.Type`, `V2.Core.Health.Alert.AuthorizationRateDrop.Dimension.Type`, and `V2.Core.Health.AlertHistoryEntry.AuthorizationRateDrop.Dimension.Type` from `literal('issuer')` to `enum('acquirer'|'issuer')`
  * Add support for `ConfirmationMethod` on `V2.MoneyManagement.PayoutIntentCreateOptions` and `V2.MoneyManagement.PayoutIntent`
  * Add support for `EstimatedFees` and `FxQuote` on `V2.MoneyManagement.PayoutIntent`
  * Add support for `Debited` on `V2.MoneyManagement.PayoutIntent.From`
  * Add support for `Confirm` on `V2.MoneyManagement.PayoutIntent.NextAction`
  * ⚠️ Change type of `V2.MoneyManagement.PayoutIntent.NextAction.Type` from `literal('handle_failure')` to `enum('confirm'|'handle_failure')`
  * Add support for `Credited` on `V2.MoneyManagement.PayoutIntent.To`
  * Add support for event notification `V1BalanceSettingsUpdatedEvent` with related object `BalanceSettings`
  * Add support for event notification `V1BillingCreditBalanceTransactionCreatedEvent` with related object `Billing.CreditBalanceTransaction`
  * Add support for event notifications `V1BillingCreditGrantCreatedEvent` and `V1BillingCreditGrantUpdatedEvent` with related object `Billing.CreditGrant`
  * Add support for event notifications `V1BillingMeterCreatedEvent`, `V1BillingMeterDeactivatedEvent`, `V1BillingMeterReactivatedEvent`, and `V1BillingMeterUpdatedEvent` with related object `Billing.Meter`
  * Add support for event notifications `V1FinancialConnectionsAccountAccountNumbersUpdatedEvent`, `V1FinancialConnectionsAccountExpectedDeactivationDateUpdatedEvent`, `V1FinancialConnectionsAccountSupportedPaymentMethodTypesUpdatedEvent`, `V1FinancialConnectionsAccountUpcomingAccountNumberExpiryEvent`, and `V1FinancialConnectionsAccountUpcomingDeactivationEvent` with related object `FinancialConnections.Account`
  * Add support for event notification `V1InvoicePaymentAttemptRequiredEvent` with related object `Invoice`
  * Add support for error type `FxQuoteNeedsRefreshException`

## 52.3.0-alpha.2 - 2026-08-05
* [#3419](https://github.com/stripe/stripe-dotnet/pull/3419) Update generated code for private-preview
  * Add support for new resource `Billing.FeedbackOptions`
  * Add support for `SequraPayments` on `Account.Capabilities`
  * Add support for `FeedbackOptions` on `BillingPortal.Configuration.Features.SubscriptionCancel.CancellationReason`
  * Add support for `Sequra` on `Charge.PaymentMethodDetails`, `Checkout.Session.PaymentMethodOptions`, `ConfirmationToken.PaymentMethodPreview`, `PaymentAttemptRecord.PaymentMethodDetails`, `PaymentIntent.PaymentMethodOptions`, and `PaymentRecord.PaymentMethodDetails`
  * Add support for `RetrievalReferenceNumber` on `Charge.PaymentMethodDetails.CardPresent`, `ConfirmationToken.PaymentMethodPreview.Card.GeneratedFrom.PaymentMethodDetails.CardPresent`, `PaymentAttemptRecord.PaymentMethodDetails.CardPresent`, `PaymentMethod.Card.GeneratedFrom.PaymentMethodDetails.CardPresent`, and `PaymentRecord.PaymentMethodDetails.CardPresent`
  * Add support for `PricingGroup` on `Charge.PaymentMethodDetails.Link`
  * Add support for `TaxRates` on `Checkout.Session.ShippingOption`, `CheckoutSessionShippingOptionOptions`, and `CheckoutSessionShippingOptionsOptions`
  * Add support for `FundingTypesBlocked` on `Checkout.Session.PaymentMethodOptions.Card.Restrictions`
  * Add support for `Healthcare` on `Issuing.TestHelpersAuthorizationCreateOptions`, `IssuingAuthorizationPurchaseDetailsOptions`, and `IssuingTransactionPurchaseDetailsOptions`
  * Add support for `IsAnomalous` on `PaymentAttemptRecordReportGuaranteedOptions`
  * Add support for `AadeData` on `PaymentIntent.PaymentMethodOptions.CardPresent`
  * Add support for `FeedbackOption` on `Subscription.CancellationDetails`
  * Add support for `Application` on `V2.Payments.OffSessionPayment`
  * Add support for `Status` on `V2.MoneyManagement.FinancialAccountStatementListOptions`

## 52.3.0-alpha.1 - 2026-07-29
This release changes the pinned API version to `2026-07-29.preview`.

* ⚠️ [#3415](https://github.com/stripe/stripe-dotnet/pull/3415) Update generated code for private-preview
  * Add support for new resources `V2.MoneyManagement.ReceivedDebitMandate`, `V2.Risk.Inquiry`, `V2.Signals.AccountActivity`, and `V2.Signals.AccountEvaluation`
  * Add support for `Create` and `Get` methods on resource `V2.Signals.AccountEvaluation`
  * Add support for `Create`, `Delete`, and `Get` methods on resource `V2.Signals.AccountActivity`
  * Add support for `Get`, `List`, and `Update` methods on resource `V2.Risk.Inquiry`
  * Add support for `Cancel`, `Get`, and `List` methods on resource `V2.MoneyManagement.ReceivedDebitMandate`
  * Add support for `RateCards` on `Billing.CreditGrant.ApplicabilityConfig.Scope`, `BillingCreditBalanceSummaryFilterApplicabilityScopeOptions`, and `BillingCreditGrantApplicabilityConfigScopeOptions`
  * ⚠️ Change type of `ConfirmationToken.PaymentMethodPreview.GiftCard.Brand`, `GiftCard.Brand`, `GiftCardCreateOptions.Brand`, `PaymentMethod.GiftCard.Brand`, `Terminal.ReaderActivateGiftCardOptions.Brand`, `Terminal.ReaderCashoutGiftCardOptions.Brand`, `Terminal.ReaderCheckGiftCardBalanceOptions.Brand`, and `Terminal.ReaderReloadGiftCardOptions.Brand` from `enum('fiserv_valuelink'|'givex'|'svs')` to `literal('svs')`
  * Add support for `Tempo` on `Crypto.OnrampSession.TransactionDetails.WalletAddresses`
  * Add support for `Healthcare` on `Issuing.Authorization`
  * Add support for `ProductCode` on `Issuing.CardCreateOptions`, `Issuing.CardUpdateOptions`, and `Issuing.Card`
  * Add support for `ProductGraduationState` on `Issuing.Card`
  * Add support for `Cvc` and `Number` on `RadarPaymentEvaluationPaymentDetailsPaymentMethodDetailsCardOptions`
  * Add support for `Card` on `Radar.PaymentEvaluation.PaymentDetails.PaymentMethodDetails`
  * ⚠️ Change type of `TerminalReaderCollectConfigOptions.GiftCardBrand` and `TerminalReaderProcessConfigOptions.GiftCardBrand` from `enum('fiserv_valuelink'|'givex'|'svs')` to `literal('svs')`
  * Add support for `GiftCard` on `Terminal.TestHelpersReaderPresentPaymentMethodOptions`
  * Add support for `AmountDue` and `CustomerBalanceApplied` on `V2.Billing.Intent.AmountDetails`
  * ⚠️ Change type of `V2.Core.AccountEvaluation.EvaluationsTriggered` from `literal('fraudulent_website')` to `enum('fraudulent_website'|'user_account_sharing'|'user_multi_accounting')`
  * Add support for `GrossSettlement` on `V2.Core.Account.Configuration.Merchant` and `V2CoreAccountConfigurationMerchantOptions`
  * ⚠️ Change type of `V2.MoneyManagement.DebitDispute.BankTransfer.Network` from `literal('ach')` to `enum('ach'|'bacs')`
  * ⚠️ Remove support for `ManagedBy` on `V2.MoneyManagement.FinancialAccount`
  * Add support for `PayoutIntent` on `V2.MoneyManagement.OutboundPayment`
  * Add support for `SettlesAt` on `V2.MoneyManagement.ReceivedDebit`
  * Add support for `GbBankAccount` on `V2.MoneyManagement.ReceivedDebit.BankTransfer`
  * ⚠️ Change type of `V2.MoneyManagement.ReceivedDebit.BankTransfer.OriginType` from `literal('us_bank_account')` to `enum('gb_bank_account'|'us_bank_account')`
  * ⚠️ Change type of `V2.MoneyManagement.ReceivedDebit.BankTransfer.PaymentMethodType` from `literal('us_bank_account')` to `enum('gb_bank_account'|'us_bank_account')`
  * Add support for `TargetDate` on `V2.Payments.OffSessionPaymentCreateOptions` and `V2.Payments.OffSessionPayment`
  * Add support for `AccountEvaluation`, `FraudulentWebsite`, `PaymentDelinquencyExposure`, `UserAccountSharing`, and `UserMultiAccounting` on `V2.Signals.AccountSignal`
  * Change type of `V2.MoneyManagement.FinancialAddressDebitSimulationDebitOptions.Network` from `literal('ach')` to `enum('ach'|'bacs')`
  * Add support for `ReceivedDebitMandate` on `V2.MoneyManagement.ReceivedDebitListOptions`
  * ⚠️ Remove support for `PayoutIntent` on `V2.MoneyManagement.OutboundPaymentCreateOptions`
  * Change type of `V2.Core.AccountEvaluationCreateOptions.Signals` from `literal('fraudulent_website')` to `enum('fraudulent_website'|'user_account_sharing'|'user_multi_accounting')`
  * ⚠️ Remove support for `Id` on `EventsV2SignalsAccountSignalFraudulentMerchantReadyEvent`
  * Add support for event notifications `V2MoneyManagementReceivedDebitCreatedEvent` and `V2MoneyManagementReceivedDebitScheduledEvent` with related object `V2.MoneyManagement.ReceivedDebit`
  * Add support for event notifications `V2MoneyManagementReceivedDebitMandateCanceledEvent`, `V2MoneyManagementReceivedDebitMandateCreatedEvent`, `V2MoneyManagementReceivedDebitMandateExpiredEvent`, `V2MoneyManagementReceivedDebitMandatePendingCancellationEvent`, and `V2MoneyManagementReceivedDebitMandateUpdatedEvent` with related object `V2.MoneyManagement.ReceivedDebitMandate`
  * Add support for event notification `V2SignalsAccountEvaluationCompleteEvent` with related object `V2.Signals.AccountEvaluation`
  * Add support for event notifications `V2SignalsAccountSignalFraudulentWebsiteReadyEvent` and `V2SignalsAccountSignalPaymentDelinquencyExposureReadyEvent` with related object `V2.Signals.AccountSignal`

## 52.2.0-alpha.5 - 2026-07-22
* ⚠️ [#3414](https://github.com/stripe/stripe-dotnet/pull/3414) Update generated code for private-preview
  * Add support for new resources `Billing.AlertNotification` and `Crypto.DepositAddress`
  * Add support for `Create`, `Get`, and `List` methods on resource `Crypto.DepositAddress`
  * Add support for `List` method on resource `Billing.AlertNotification`
  * Add support for `Vipps` on `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `PaymentIntent.PaymentMethodOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `Sui` on `Crypto.OnrampSession.TransactionDetails.WalletAddresses`
  * Add support for `UseStripeSdk` on `DelegatedCheckout.RequestedSessionConfirmOptions`
  * Add support for `EvCharging` on `PaymentIntentAmountDetailsLineItem.PaymentMethodOptions.Card` and `PaymentIntentAmountDetailsLineItemsPaymentMethodOptionsCardOptions`
  * Add support for `TaxItems` on `PaymentIntent.PaymentDetails.CarRentalDatum.Total.Tax`, `PaymentIntent.PaymentDetails.FlightDatum.Total.Tax`, and `PaymentIntent.PaymentDetails.LodgingDatum.Total.Tax`
  * ⚠️ Remove support for `Taxes` on `PaymentIntent.PaymentDetails.CarRentalDatum.Total.Tax`, `PaymentIntent.PaymentDetails.FlightDatum.Total.Tax`, and `PaymentIntent.PaymentDetails.LodgingDatum.Total.Tax`
  * Add support for `Card` on `RadarPaymentEvaluationPaymentDetailsPaymentMethodDetailsOptions`
  * ⚠️ Remove support for `AcssDebit`, `AfterpayClearpay`, `Alipay`, `Alma`, `AmazonPay`, `AuBecsDebit`, `BacsDebit`, `Bancontact`, `Billie`, `Bizum`, `Blik`, `Boleto`, `CardPresent`, `Cashapp`, `Crypto`, `CustomerBalance`, `Eps`, `Fpx`, `GiftCard`, `Giropay`, `Gopay`, `Grabpay`, `IdBankTransfer`, `Ideal`, `InteracPresent`, `KakaoPay`, `Konbini`, `KrCard`, `MbWay`, `Mobilepay`, `Multibanco`, `NaverPay`, `NzBankAccount`, `Oxxo`, `P24`, `PayByBank`, `Payco`, `Paynow`, `Paypal`, `Paypay`, `Payto`, `Pix`, `Promptpay`, `Qris`, `Rechnung`, `RevolutPay`, `SamsungPay`, `Satispay`, `Scalapay`, `SepaDebit`, `Shopeepay`, `Sofort`, `StripeBalance`, `Sunbit`, `Swish`, `Tamara`, `Twint`, `Upi`, `UsBankAccount`, `WechatPay`, and `Zip` on `SharedPayment.GrantedToken.PaymentMethodDetails`
  * Add support for `SpendCard` on `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.Stripe` and `V2CoreAccountConfigurationCardCreatorCapabilitiesCommercialStripeOptions`

## 52.2.0-alpha.4 - 2026-07-16
* ⚠️ [#3410](https://github.com/stripe/stripe-dotnet/pull/3410) Update generated code for private-preview
  * ⚠️ Remove support for resource `FrMealVouchersOnboarding`
  * ⚠️ Remove support for `Create`, `Get`, `List`, and `Update` methods on resource `FrMealVouchersOnboarding`
  * Add support for `Create` method on resource `PaymentRecord`
  * ⚠️ Remove support for `FinancialAccountsTransactions`, `FinancialAccounts`, and `RecipientsList` on `AccountSessionComponentsOptions`
  * Add support for `SmartDisputesManagement` on `AccountSession.Components.DisputesList.Features`, `AccountSession.Components.PaymentDetails.Features`, `AccountSession.Components.PaymentDisputes.Features`, and `AccountSession.Components.Payments.Features`
  * Add support for `Mode` on `FinancialConnections.Session.ManualEntry`
  * Add support for `BusinessName` on `Issuing.Card.Shipping`
  * Add support for `PauseSchedules` on `QuotePreviewSubscriptionSchedule`, `SubscriptionScheduleCreateOptions`, `SubscriptionScheduleUpdateOptions`, and `SubscriptionSchedule`
  * Add support for `Trial` on `QuotePreviewSubscriptionSchedule.Phase` and `SubscriptionSchedule.Phase`
  * Add support for `PaymentRecord` on `RefundCreateOptions`
  * Add support for `RedirectToUrl` on `SharedPayment.IssuedToken.NextAction`
  * ⚠️ Change type of `SharedPayment.IssuedToken.NextAction.Type` from `literal('use_stripe_sdk')` to `enum('redirect_to_url'|'use_stripe_sdk')`
  * Add support for snapshot events `FinancialConnectionsAccountExpectedDeactivationDateUpdated`, `FinancialConnectionsAccountSupportedPaymentMethodTypesUpdated`, and `FinancialConnectionsAccountUpcomingDeactivation` with resource `FinancialConnections.Account`
  * Add support for snapshot events `FinancialConnectionsAuthorizationExpectedDeactivationDateUpdated` and `FinancialConnectionsAuthorizationUpcomingDeactivation` with resource `FinancialConnections.Authorization`

## 52.2.0-alpha.3 - 2026-07-08
This release changes the pinned API version to `2026-07-08.preview`.

* ⚠️ [#3407](https://github.com/stripe/stripe-dotnet/pull/3407) Update generated code for private-preview
  * Add support for `ActivateGiftCard`, `CashoutGiftCard`, `CheckGiftCardBalance`, and `ReloadGiftCard` methods on resource `Terminal.Reader`
  * Add support for `AggregationPeriod` on `Billing.AlertRecovered`
  * Add support for `AdministrativeAddress` and `PrincipalPlaceOfBusiness` on `Account.Company`
  * Add support for `AddressCollectionPrecision` on `Checkout.Session.AutomaticTax`
  * Add support for `TaxId` on `Checkout.Session.CollectedInformation`
  * ⚠️ Remove support for `TaxIds` on `Checkout.Session.CollectedInformation`
  * Add support for `SetupFutureUsage` on `Checkout.Session.PaymentMethodOptions.Payco`, `Checkout.Session.PaymentMethodOptions.SamsungPay`, `PaymentIntent.PaymentMethodOptions.Payco`, `PaymentIntent.PaymentMethodOptions.Paypay`, `PaymentIntent.PaymentMethodOptions.SamsungPay`, and `PaymentIntentPaymentMethodOptionsPaypayOptions`
  * Add support for `Network` on `Dispute.PaymentMethodDetails.Card`
  * Add support for `RequirePaymentMethodSupport` on `FinancialConnections.Session.Filters`
  * Add support for `NetworkData` on `Issuing.Authorization.RequestHistory`
  * Add support for `AcquiringInstitutionCountry`, `AcquiringInstitutionId`, `RetrievalReferenceNumber`, `RoutedNetwork`, and `TraceId` on `Issuing.Transaction.NetworkData`
  * Add support for `CustomFields`, `Description`, and `Footer` on `Quote.InvoiceSettings`, `QuotePreviewSubscriptionSchedule.DefaultSettings.InvoiceSettings`, `QuotePreviewSubscriptionSchedule.Phase.InvoiceSettings`, `SubscriptionSchedule.DefaultSettings.InvoiceSettings`, and `SubscriptionSchedule.Phase.InvoiceSettings`
  * Add support for `Paypay` on `SetupAttempt.PaymentMethodDetails`
  * Add support for `MassTransitParkingTax` and `ParkingTax` on `Tax.Registration.CountryOptions.Us`
  * Add support for `GiftCardBrand` on `TerminalReaderCollectConfigOptions` and `TerminalReaderProcessConfigOptions`
  * Add support for `ActivateGiftCard`, `CashoutGiftCard`, `CheckGiftCardBalance`, `DeactivateGiftCard`, and `ReloadGiftCard` on `Terminal.Reader.Action`
  * Add support for `StatusTransitions` on `V2.Billing.Contract`
  * ⚠️ Remove support for `OneTimeFees` on `V2.Billing.ContractCreateOptions` and `V2.Billing.Contract`
  * ⚠️ Remove support for `StatusDetails` on `V2.Billing.Contract`
  * Add support for `Id` and `Priority` on `V2.Billing.Contract.PricingLines.Data.Pricing.PriceDetails.PricingOverrides.Data`
  * ⚠️ Remove support for `PricingOverride` on `V2.Billing.Contract.PricingLines.Data.Pricing.PriceDetails.PricingOverrides.Data`
  * ⚠️ Remove support for `TieringMode` and `Tiers` on `V2.Billing.Contract.PricingLines.Data.Pricing.PriceDetails.PricingOverrides.Data.OverwritePrice`, `V2BillingContractPricingLineActionAddPricingPriceDetailsPricingOverrideOverwritePriceOptions`, `V2BillingContractPricingLineActionUpdatePricingPriceDetailsPricingOverrideActionAddOverwritePriceOptions`, `V2BillingContractPricingLinePricingPriceDetailsPricingOverrideOverwritePriceOptions`, and `V2BillingContractPricingOverrideActionAddOverwritePriceOptions`
  * Add support for `MultiplyPricing` on `V2.Billing.Contract.PricingOverrides.Data`, `V2BillingContractPricingOverrideActionAddOptions`, and `V2BillingContractPricingOverrideOptions`
  * ⚠️ Remove support for `Multiplier` on `V2.Billing.Contract.PricingOverrides.Data`, `V2BillingContractPricingOverrideActionAddOptions`, and `V2BillingContractPricingOverrideOptions`
  * ⚠️ Change type of `V2.Billing.Contract.PricingOverrides.Data.Type`, `V2BillingContractPricingOverrideActionAddOptions.Type`, and `V2BillingContractPricingOverrideOptions.Type` from `literal('multiplier')` to `literal('multiply_pricing')`
  * Add support for `RelatedNetworkObject` on `V2.Core.AccountListOptions` and `V2.Core.Account`
  * Add support for `NetworkBusinessProfileWallet` on `V2.MoneyManagement.PayoutMethod`
  * Add support for `StripeNetworkTransfer` on `V2.MoneyManagement.ReceivedCredit`
  * ⚠️ Change type of `V2BillingContractPricingLineActionAddPricingPriceDetailsPricingOverrideEndsAtOptions.Type`, `V2BillingContractPricingLineEndsAtOptions.Type`, `V2BillingContractPricingLinePricingPriceDetailsPricingOverrideEndsAtOptions.Type`, and `V2BillingContractPricingOverrideEndsAtOptions.Type` from `enum('contract_end'|'timestamp')` to `literal('timestamp')`
  * ⚠️ Change type of `V2BillingContractPricingLineActionAddPricingPriceDetailsPricingOverrideStartsAtOptions.Type`, `V2BillingContractPricingLinePricingPriceDetailsPricingOverrideStartsAtOptions.Type`, `V2BillingContractPricingLineStartsAtOptions.Type`, and `V2BillingContractPricingOverrideStartsAtOptions.Type` from `enum('contract_start'|'timestamp')` to `literal('timestamp')`
  * ⚠️ Change type of `V2BillingContractPricingLineActionAddEndsAtOptions.Type`, `V2BillingContractPricingLineActionUpdateEndsAtOptions.Type`, `V2BillingContractPricingLineActionUpdatePricingPriceDetailsPricingOverrideActionAddEndsAtOptions.Type`, `V2BillingContractPricingLineActionUpdatePricingPriceDetailsPricingOverrideActionUpdateEndsAtOptions.Type`, `V2BillingContractPricingOverrideActionAddEndsAtOptions.Type`, and `V2BillingContractPricingOverrideActionUpdateEndsAtOptions.Type` from `enum('billing_period_end'|'timestamp')` to `literal('timestamp')`
  * ⚠️ Change type of `V2BillingContractPricingLineActionAddStartsAtOptions.Type`, `V2BillingContractPricingLineActionUpdatePricingPriceDetailsPricingOverrideActionAddStartsAtOptions.Type`, `V2BillingContractPricingLineActionUpdatePricingPriceDetailsPricingOverrideActionUpdateStartsAtOptions.Type`, `V2BillingContractPricingLineActionUpdateStartsAtOptions.Type`, `V2BillingContractPricingOverrideActionAddStartsAtOptions.Type`, and `V2BillingContractPricingOverrideActionUpdateStartsAtOptions.Type` from `enum('billing_period_start'|'timestamp')` to `literal('timestamp')`
  * Add support for event notifications `V2BillingContractActivatedEvent`, `V2BillingContractCanceledEvent`, `V2BillingContractCreatedEvent`, `V2BillingContractEndedEvent`, and `V2BillingContractUpdatedEvent` with related object `V2.Billing.Contract`

## 52.2.0-alpha.2 - 2026-07-01
This release changes the pinned API version to `2026-07-01.preview`.

* ⚠️ [#3405](https://github.com/stripe/stripe-dotnet/pull/3405) Update generated code for private-preview
  * Add support for new resources `Crypto.CustomerConsumerWallet`, `Crypto.CustomerPaymentToken`, `Crypto.Customer`, `Crypto.OnrampSession`, and `Crypto.OnrampTransactionLimits`
  * Add support for `Get` and `List` methods on resource `Crypto.Customer`
  * Add support for `Checkout`, `Create`, `Get`, `List`, and `Quote` methods on resource `Crypto.OnrampSession`
  * Add support for `Get` method on resource `Crypto.OnrampTransactionLimits`
  * Add support for `ElectronicCommerceIndicator` on `Charge.PaymentMethodDetails.Card`
  * Add support for `AmountReceived` and `AmountRequested` on `Charge.PaymentMethodDetails.Crypto`, `PaymentAttemptRecord.PaymentMethodDetails.Crypto`, and `PaymentRecord.PaymentMethodDetails.Crypto`
  * Add support for `Fingerprint` on `Charge.PaymentMethodDetails.GiftCard`, `PaymentAttemptRecord.PaymentMethodDetails.GiftCard`, and `PaymentRecord.PaymentMethodDetails.GiftCard`
  * Add support for `AddressCollectionPrecision` on `CheckoutSessionAutomaticTaxOptions`
  * Add support for `Subscription` on `Checkout.Session.Item`
  * ⚠️  Remove support for `Deactivation` on `GiftCardOperation`
  * Add support for `MerchantAmountExchangeRate` on `Issuing.Authorization` and `Issuing.Transaction`
  * Add support for `DeviceId` on `Issuing.Authorization.TokenDetails.NetworkData.Device` and `Issuing.Token.NetworkData.Device`
  * Add support for `Program` on `Issuing.Card`
  * Add support for `PaymentMethodDetails` on `PaymentAttemptRecordReportFailedOptions` and `PaymentRecordReportPaymentAttemptFailedOptions`
  * Add support for `Reason` on `PaymentAttemptRecordReportRefundOptions` and `PaymentRecordReportRefundOptions`
  * Add support for `AmountReconciliation` on `PaymentIntent.PaymentMethodOptions.Crypto` and `PaymentIntentPaymentMethodOptionsCryptoOptions`
  * Add support for `ConnectPermissions` and `Permissions` on `V2.Iam.ApiKeyCreateOptions`, `V2.Iam.ApiKeyUpdateOptions`, and `V2.Iam.ApiKey`
  * Add support for `Credit` on `V2.MoneyManagement.FinancialAccount`
  * Add support for `Account`, `IssuingAuthorization`, `IssuingDispute`, and `IssuingTransaction` on `V2.MoneyManagement.Transaction.Flow` and `V2.MoneyManagement.TransactionEntry.TransactionDetails.Flow`
  * Change type of `V2.MoneyManagement.FinancialAccountCreateOptions.Type` from `literal('storage')` to `enum('credit'|'storage')`
  * Add support for `ExpiresAt` on `V2.Iam.ApiKeyCreateOptions`

## 52.2.0-alpha.1 - 2026-06-24
This release changes the pinned API version to `2026-06-24.preview`.

* ⚠️ [#3403](https://github.com/stripe/stripe-dotnet/pull/3403) Update generated code for private-preview
  * Add support for new resources `V2.Billing.ContractPricingLineQuantityChange`, `V2.Core.Health.AlertHistoryEntry`, `V2.Core.Health.Alert`, `V2.MoneyManagement.FinancialAddressDebitSimulation`, and `V2.MoneyManagement.PayoutIntent`
  * ⚠️ Remove support for resource `V2.Billing.ContractLicensePricingQuantityChange`
  * Add support for `ReportOfferAcceptance` method on resource `Issuing.CreditUnderwritingRecord`
  * Add support for `ProvisionalCredit` test helper method on resource `Issuing.Dispute`
  * Add support for `ReportEarlyFraudWarning` method on resource `PaymentAttemptRecord`
  * Add support for `Search` method on resource `PaymentRecord`
  * Add support for `Debit` method on resource `V2.MoneyManagement.FinancialAddressDebitSimulation`
  * Add support for `Cancel`, `Create`, `Get`, `List`, and `Update` methods on resource `V2.MoneyManagement.PayoutIntent`
  * Add support for `Get` and `List` methods on resource `V2.Core.Health.Alert`
  * Add support for `Delete` method on resource `V2.Billing.Contract`
  * ⚠️ Remove support for `PerformanceLocationDetails` on `Tax.TransactionLineItem`
  * Add support for `FinancialAccountsTransactions`, `FinancialAccounts`, and `RecipientsList` on `AccountSession.Components` and `AccountSessionComponentsOptions`
  * Add support for `Location` and `Reader` on `Charge.PaymentMethodDetails.GiftCard`, `GiftCardOperation`, `PaymentAttemptRecord.PaymentMethodDetails.GiftCard`, and `PaymentRecord.PaymentMethodDetails.GiftCard`
  * Add support for `Subscription` on `CheckoutSessionItemOptions`
  * Add support for `Items` on `Checkout.Session`
  * Add support for `Brand` on `Checkout.Session.CurrentAttempt.PaymentMethodDetails.Card`
  * Add support for `NetworkData` on `Issuing.TestHelpersAuthorizationCaptureOptions` and `Issuing.TestHelpersTransactionCreateForceCaptureOptions`
  * Add support for `EnrichedMerchantData` on `Issuing.Authorization`
  * Add support for `AvailableBalance` and `CurrentBalance` on `Issuing.Authorization.BalanceResponse`
  * ⚠️ Remove support for `Amount` on `Issuing.Authorization.BalanceResponse`
  * Add support for `DecisionDeadlineUpdatedAt` on `Issuing.CreditUnderwritingRecord`
  * Add support for `AcquirerReferenceNumber` on `Issuing.Transaction.NetworkData`
  * Add support for `Tip` on `PaymentIntentAmountDetailsOptions`
  * Add support for `BillingCycleAnchor` on `V2.Billing.ContractCreateOptions` and `V2.Billing.Contract`
  * ⚠️ Remove support for `ContractLineDetails`, `ContractValueDetails`, and `LicenseQuantities` on `V2.Billing.Contract`
  * Add support for `BillSettingsDetails` on `V2.Billing.Contract.BillingSettings` and `V2BillingContractBillingSettingsOptions`
  * Add support for `BillingProfileDetails` and `CollectionSettingsDetails` on `V2.Billing.Contract.BillingSettings`
  * ⚠️ Remove support for `ContractBillingDetails` on `V2.Billing.Contract.BillingSettings` and `V2BillingContractBillingSettingsOptions`
  * ⚠️ Change type of `V2.Billing.Contract.OneTimeFees` from `array(an object)` to `an object`
  * ⚠️ Change type of `V2.Billing.Contract.PricingLines` from `array(an object)` to `an object`
  * ⚠️ Change type of `V2.Billing.Contract.PricingOverrides` from `array(an object)` to `an object`
  * Add support for `Mode` on `V2.Commerce.ProductCatalogImport`
  * Add support for `MoneyManager` on `V2.Core.Account.Configuration`, `V2.Core.Account.Identity.Attestations.TermsOfService`, `V2CoreAccountConfigurationOptions`, `V2CoreAccountIdentityAttestationsTermsOfServiceOptions`, and `V2CoreAccountTokenIdentityAttestationsTermsOfServiceOptions`
  * ⚠️ Remove support for `Storer` on `V2.Core.Account.Configuration`, `V2.Core.Account.Identity.Attestations.TermsOfService`, `V2CoreAccountConfigurationOptions`, `V2CoreAccountIdentityAttestationsTermsOfServiceOptions`, and `V2CoreAccountTokenIdentityAttestationsTermsOfServiceOptions`
  * Add support for `SunbitPayments` on `V2.Core.Account.Configuration.Merchant.Capabilities` and `V2CoreAccountConfigurationMerchantCapabilitiesOptions`
  * Add support for `Ach`, `Becs`, `Eft`, `Fedwire`, `Fps`, `Npp`, `Rtp`, `SepaCredit`, `SepaInstant`, and `Swift` on `V2.Core.Account.Configuration.Recipient.Capabilities.BankAccounts` and `V2CoreAccountConfigurationRecipientCapabilitiesBankAccountsOptions`
  * Add support for `ConsumerMoneyManager` on `V2.Core.Account.Identity.Attestations.TermsOfService` and `V2CoreAccountIdentityAttestationsTermsOfServiceOptions`
  * Add support for `CryptoMoneyManager` on `V2.Core.Account.Identity.Attestations.TermsOfService`, `V2CoreAccountIdentityAttestationsTermsOfServiceOptions`, and `V2CoreAccountTokenIdentityAttestationsTermsOfServiceOptions`
  * ⚠️ Remove support for `ConsumerStorer` on `V2.Core.Account.Identity.Attestations.TermsOfService` and `V2CoreAccountIdentityAttestationsTermsOfServiceOptions`
  * ⚠️ Remove support for `CryptoStorer` on `V2.Core.Account.Identity.Attestations.TermsOfService`, `V2CoreAccountIdentityAttestationsTermsOfServiceOptions`, and `V2CoreAccountTokenIdentityAttestationsTermsOfServiceOptions`
  * ⚠️ Remove support for `MaximumRps` on `V2.Core.BatchJobCreateOptions` and `V2.Core.BatchJob`
  * Add support for `Bic` on `V2.MoneyManagement.FinancialAddress.Credentials.UsBankAccount`
  * ⚠️ Remove support for `SwiftCode` on `V2.MoneyManagement.FinancialAddress.Credentials.UsBankAccount`
  * Add support for `Attachment` on `V2.MoneyManagement.OutboundPayment.DeliveryOptions.PaperCheck` and `V2MoneyManagementOutboundPaymentDeliveryOptionsPaperCheckOptions`
  * Add support for `Processing` on `V2.MoneyManagement.OutboundPayment.StatusDetails` and `V2.MoneyManagement.OutboundTransfer.StatusDetails`
  * Add support for `PayoutMethodOptions` on `V2.MoneyManagement.OutboundPayment.To`, `V2.MoneyManagement.OutboundTransfer.To`, `V2MoneyManagementOutboundPaymentToOptions`, and `V2MoneyManagementOutboundTransferToOptions`
  * Add support for `AccountHolderName` on `V2.MoneyManagement.ReceivedCredit.BankTransfer.UsBankAccount`
  * Add support for `Returned` on `V2.MoneyManagement.ReceivedDebit.StatusDetails`
  * Add support for `ReturnedAt` on `V2.MoneyManagement.ReceivedDebit.StatusTransitions`
  * Add support for `PayoutIntent` on `V2.MoneyManagement.OutboundPaymentCreateOptions`
  * Add support for `Statuses` on `V2.MoneyManagement.FinancialAccountListOptions`
  * ⚠️ Remove support for `Status` on `V2.MoneyManagement.FinancialAccountListOptions`
  * Add support for `Include` on `V2.Billing.ContractListOptions`
  * ⚠️ Remove support for `ContractLines` on `V2.Billing.ContractCreateOptions`
  * ⚠️ Remove support for `LicenseQuantityActions` on `V2.Billing.ContractCreateOptions` and `V2.Billing.ContractUpdateOptions`
  * ⚠️ Add support for `BillingProfileDetails` and `CollectionSettingsDetails` on `V2BillingContractBillingSettingsOptions`
  * ⚠️ Add support for `Amount`, `BillAt`, and `Product` on `V2BillingContractOneTimeFeeOptions`
  * Add support for `LookupKey` on `V2BillingContractOneTimeFeeOptions`
  * ⚠️ Remove support for `BillSchedule`, `BillableItemType`, and `ProductDetails` on `V2BillingContractOneTimeFeeOptions`
  * Add support for `PricingOverrides` and `QuantityChanges` on `V2BillingContractPricingLineActionAddPricingPriceDetailsOptions` and `V2BillingContractPricingLinePricingPriceDetailsOptions`
  * ⚠️ Remove support for `Quantity` on `V2BillingContractPricingLineActionAddPricingPriceDetailsOptions` and `V2BillingContractPricingLinePricingPriceDetailsOptions`
  * ⚠️ Remove support for `OverwritePrice` on `V2BillingContractPricingOverrideOptions`
  * Add support for `PricingLineIds` and `PricingLineLookupKeys` on `V2BillingContractPricingOverrideActionAddMultiplierCriterionOptions` and `V2BillingContractPricingOverrideMultiplierCriterionOptions`
  * ⚠️ Remove support for `BillableItemIds`, `BillableItemLookupKeys`, `BillableItemTypes`, `MetadataConditions`, and `RateCardIds` on `V2BillingContractPricingOverrideActionAddMultiplierCriterionOptions` and `V2BillingContractPricingOverrideMultiplierCriterionOptions`
  * ⚠️ Change type of `V2BillingContractPricingOverrideActionAddOptions.Type` and `V2BillingContractPricingOverrideOptions.Type` from `enum('multiplier'|'overwrite_price')` to `literal('multiplier')`
  * Add support for `Pricing` on `V2BillingContractPricingLineActionUpdateOptions`
  * ⚠️ Remove support for `Price` on `V2BillingContractPricingOverrideActionAddOverwritePriceOptions`
  * Add support for `CancelPricingLines` and `ProrationBehavior` on `V2.Billing.ContractCancelOptions`
  * Add support for event notifications `V2CoreAccountIncludingConfigurationMoneyManagerCapabilityStatusUpdatedEvent` and `V2CoreAccountIncludingConfigurationMoneyManagerUpdatedEvent` with related object `V2.Core.Account`
  * Add support for event notifications `V2MoneyManagementDebitDisputeFailedEvent`, `V2MoneyManagementDebitDisputeSubmittedEvent`, and `V2MoneyManagementDebitDisputeSucceededEvent` with related object `V2.MoneyManagement.DebitDispute`
  * Add support for event notification `V2MoneyManagementOutboundPaymentUnderReviewEvent` with related object `V2.MoneyManagement.OutboundPayment`
  * Add support for event notification `V2MoneyManagementOutboundTransferUnderReviewEvent` with related object `V2.MoneyManagement.OutboundTransfer`
  * ⚠️ Remove support for event notifications `V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEvent` and `V2CoreAccountIncludingConfigurationStorerUpdatedEvent` with related object `V2.Core.Account`

## 52.1.0-alpha.2 - 2026-06-17
* ⚠️ [#3397](https://github.com/stripe/stripe-dotnet/pull/3397) Update generated code for private-preview
  * Add support for `Get` method on resource `Radar.CustomerEvaluation`
  * Add support for `DisableStripeUserAuthentication` on `AccountSession.Components.Bills.Features`
  * Add support for `Tamara` on `Charge.PaymentMethodDetails`, `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `PaymentAttemptRecord.PaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, `PaymentRecord.PaymentMethodDetails`, `SetupIntentPaymentMethodDataOptions`, and `SharedPayment.GrantedToken.PaymentMethodDetails`
  * Add support for `Status` on `Charge.PaymentMethodDetails.Card.AccountFunding`
  * ⚠️ Remove support for `ProcessedTransactionType` on `Charge.PaymentMethodDetails.Card.AccountFunding`
  * Add support for `Items` on `Checkout.SessionCreateOptions`
  * ⚠️ Remove support for `Brand` on `Checkout.Session.CurrentAttempt.PaymentMethodDetails.Card`
  * ⚠️ Remove support for `First6` on `ConfirmationToken.PaymentMethodPreview.GiftCard`, `PaymentMethod.GiftCard`, and `SharedPayment.GrantedToken.PaymentMethodDetails.GiftCard`
  * Add support for `Fingerprint` on `GiftCard`
  * Add support for `Blik` on `Mandate.PaymentMethodDetails`
  * Add support for `BuyerId` on `Order.Payment.Settings.PaymentMethodOptions.WechatPay`, `OrderPaymentSettingsPaymentMethodOptionsWechatPayOptions`, `PaymentIntent.PaymentMethodOptions.WechatPay`, and `PaymentIntentPaymentMethodOptionsWechatPayOptions`
  * Add support for `PaymentMethodDetails` on `PaymentAttemptRecordReportGuaranteedOptions` and `PaymentRecordReportPaymentAttemptGuaranteedOptions`
  * Add support for `Failed` and `RefundGroup` on `PaymentAttemptRecordReportRefundOptions` and `PaymentRecordReportRefundOptions`
  * Change type of `PaymentAttemptRecordReportRefundOptions.Outcome` and `PaymentRecordReportRefundOptions.Outcome` from `literal('refunded')` to `enum('failed'|'refunded')`
  * Add support for `BeneficiaryDetails` on `PaymentIntent.PaymentDetails.MoneyServices` and `PaymentIntentPaymentDetailsMoneyServicesOptions`
  * ⚠️ Remove support for `BeneficiaryAccount` and `BeneficiaryDetails` on `PaymentIntent.PaymentDetails.MoneyServices.AccountFunding` and `PaymentIntentPaymentDetailsMoneyServicesAccountFundingOptions`
  * ⚠️ Remove support for `SenderAccount` on `PaymentIntentPaymentDetailsMoneyServicesAccountFundingOptions`
  * Add support for `GivenName` and `Surname` on `PaymentIntent.PaymentDetails.MoneyServices.AccountFunding.SenderDetails` and `PaymentIntentPaymentDetailsMoneyServicesAccountFundingSenderDetailsOptions`
  * ⚠️ Remove support for `Name` on `PaymentIntent.PaymentDetails.MoneyServices.AccountFunding.SenderDetails` and `PaymentIntentPaymentDetailsMoneyServicesAccountFundingSenderDetailsOptions`
  * Change type of `PaymentIntentPaymentMethodOptionsCardOptions.CaptureMethod` from `literal('manual')` to `enum('automatic_delayed'|'manual')`
  * ⚠️ Remove support for `Wallet` on `PaymentIntentPaymentMethodOptionsCardPaymentDetailsMoneyServicesAccountFundingOptions` and `PaymentIntentPaymentMethodOptionsCardPresentPaymentDetailsMoneyServicesAccountFundingOptions`
  * Add support for `TransactionVerificationOptions` on `PaymentIntent.PaymentMethodOptions.Crypto` and `PaymentIntentPaymentMethodOptionsCryptoOptions`
  * Change type of `TestHelpersPaymentIntentSimulateCryptoDepositOptions.TokenCurrency` from `literal('usdc')` to `enum('usdc'|'usdg'|'usdp')`
  * Add support for `ForcedCapture` on `PaymentIntent.AdvancedFeatureDetails`
  * Add support for `WechatPayHandleAppRedirect` on `PaymentIntent.NextAction` and `SetupIntent.NextAction`
  * Add support for `Ethereum` and `Polygon` on `PaymentIntent.NextAction.CryptoDisplayDetails.DepositAddresses`
  * ⚠️ Change type of `PaymentIntent.NextAction.CryptoDisplayDetails.DepositAddresses.Base.SupportedToken.TokenCurrency`, `PaymentIntent.NextAction.CryptoDisplayDetails.DepositAddresses.Solana.SupportedToken.TokenCurrency`, and `PaymentIntent.NextAction.CryptoDisplayDetails.DepositAddresses.Tempo.SupportedToken.TokenCurrency` from `literal('usdc')` to `enum('usdc'|'usdg'|'usdp')`
  * Add support for `BeneficiaryAccount` on `PaymentIntent.PaymentDetails.MoneyServices`
  * ⚠️ Change type of `PaymentIntent.PaymentMethodOptions.Card.CaptureMethod` from `literal('manual')` to `enum('automatic_delayed'|'manual')`
  * Change type of `PaymentLocationBusinessRegistrationOptions.Siret` from `string` to `emptyable(string)`
  * Add support for `Card` on `PaymentRecordPaymentMethodDetailsOptions`
  * Change type of `PaymentRecordPaymentMethodDetailsOptions.Type` from `literal('custom')` to `enum('card'|'custom')`
  * Add support for `ManagedPayments` on `Product`
  * Add support for `PaymentAttemptRecord` on `RefundCreateOptions` and `RefundListOptions`
  * Add support for `PaymentRecord` on `RefundListOptions`
  * Add support for `Protections` on `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.Celtic.ChargeCard`, `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.Celtic.SpendCard`, `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.CrossRiverBank.ChargeCard`, `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.CrossRiverBank.PrepaidCard`, `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.CrossRiverBank.SpendCard`, `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.FifthThird.ChargeCard`, `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.Lead.PrepaidCard`, `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.Stripe.ChargeCard`, `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.Stripe.PrepaidCard`, `V2.Core.Account.Configuration.CardCreator.Capabilities.Consumer.Celtic.RevolvingCreditCard`, `V2.Core.Account.Configuration.CardCreator.Capabilities.Consumer.CrossRiverBank.PrepaidCard`, `V2.Core.Account.Configuration.CardCreator.Capabilities.Consumer.Lead.DebitCard`, `V2.Core.Account.Configuration.CardCreator.Capabilities.Consumer.Lead.PrepaidCard`, `V2.Core.Account.Configuration.Customer.Capabilities.AutomaticIndirectTax`, `V2.Core.Account.Configuration.Merchant.Capabilities.AchDebitPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.AcssDebitPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.AffirmPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.AfterpayClearpayPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.AlmaPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.AmazonPayPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.AuBecsDebitPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.BacsDebitPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.BancontactPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.BlikPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.BoletoPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.CardPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.CartesBancairesPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.CashappPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.EpsPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.FpxPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.GbBankTransferPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.GrabpayPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.IdealPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.JcbPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.JpBankTransferPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.KakaoPayPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.KlarnaPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.KonbiniPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.KrCardPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.LinkPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.MobilepayPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.MultibancoPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.MxBankTransferPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.NaverPayPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.OxxoPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.P24Payments`, `V2.Core.Account.Configuration.Merchant.Capabilities.PayByBankPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.PaycoPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.PaynowPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.PromptpayPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.RevolutPayPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.SamsungPayPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.SepaBankTransferPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.SepaDebitPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.StripeBalance.Payouts`, `V2.Core.Account.Configuration.Merchant.Capabilities.SwishPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.TwintPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.UsBankTransferPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.ZipPayments`, `V2.Core.Account.Configuration.Recipient.Capabilities.BankAccounts.Instant`, `V2.Core.Account.Configuration.Recipient.Capabilities.BankAccounts.Local`, `V2.Core.Account.Configuration.Recipient.Capabilities.BankAccounts.Wire`, `V2.Core.Account.Configuration.Recipient.Capabilities.Cards`, `V2.Core.Account.Configuration.Recipient.Capabilities.CryptoWallets`, `V2.Core.Account.Configuration.Recipient.Capabilities.PaperChecks`, `V2.Core.Account.Configuration.Recipient.Capabilities.StripeBalance.Payouts`, `V2.Core.Account.Configuration.Recipient.Capabilities.StripeBalance.StripeTransfers`, `V2.Core.Account.Configuration.Storer.Capabilities.Consumer.HoldsCurrencies.Usd`, `V2.Core.Account.Configuration.Storer.Capabilities.FinancialAddresses.BankAccounts`, `V2.Core.Account.Configuration.Storer.Capabilities.FinancialAddresses.CryptoWallets`, `V2.Core.Account.Configuration.Storer.Capabilities.HoldsCurrencies.Eur`, `V2.Core.Account.Configuration.Storer.Capabilities.HoldsCurrencies.Gbp`, `V2.Core.Account.Configuration.Storer.Capabilities.HoldsCurrencies.Usd`, `V2.Core.Account.Configuration.Storer.Capabilities.HoldsCurrencies.Usdc`, `V2.Core.Account.Configuration.Storer.Capabilities.InboundTransfers.BankAccounts`, `V2.Core.Account.Configuration.Storer.Capabilities.OutboundPayments.BankAccounts`, `V2.Core.Account.Configuration.Storer.Capabilities.OutboundPayments.Cards`, `V2.Core.Account.Configuration.Storer.Capabilities.OutboundPayments.CryptoWallets`, `V2.Core.Account.Configuration.Storer.Capabilities.OutboundPayments.FinancialAccounts`, `V2.Core.Account.Configuration.Storer.Capabilities.OutboundPayments.PaperChecks`, `V2.Core.Account.Configuration.Storer.Capabilities.OutboundTransfers.BankAccounts`, `V2.Core.Account.Configuration.Storer.Capabilities.OutboundTransfers.CryptoWallets`, `V2.Core.Account.Configuration.Storer.Capabilities.OutboundTransfers.FinancialAccounts`, `V2CoreAccountConfigurationCardCreatorCapabilitiesCommercialCelticChargeCardOptions`, `V2CoreAccountConfigurationCardCreatorCapabilitiesCommercialCelticSpendCardOptions`, `V2CoreAccountConfigurationCardCreatorCapabilitiesCommercialCrossRiverBankChargeCardOptions`, `V2CoreAccountConfigurationCardCreatorCapabilitiesCommercialCrossRiverBankPrepaidCardOptions`, `V2CoreAccountConfigurationCardCreatorCapabilitiesCommercialCrossRiverBankSpendCardOptions`, `V2CoreAccountConfigurationCardCreatorCapabilitiesCommercialFifthThirdChargeCardOptions`, `V2CoreAccountConfigurationCardCreatorCapabilitiesCommercialLeadPrepaidCardOptions`, `V2CoreAccountConfigurationCardCreatorCapabilitiesCommercialStripeChargeCardOptions`, `V2CoreAccountConfigurationCardCreatorCapabilitiesCommercialStripePrepaidCardOptions`, `V2CoreAccountConfigurationCardCreatorCapabilitiesConsumerCelticRevolvingCreditCardOptions`, `V2CoreAccountConfigurationCardCreatorCapabilitiesConsumerCrossRiverBankPrepaidCardOptions`, `V2CoreAccountConfigurationCardCreatorCapabilitiesConsumerLeadDebitCardOptions`, `V2CoreAccountConfigurationCardCreatorCapabilitiesConsumerLeadPrepaidCardOptions`, `V2CoreAccountConfigurationCustomerCapabilitiesAutomaticIndirectTaxOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesAchDebitPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesAcssDebitPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesAffirmPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesAfterpayClearpayPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesAlmaPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesAmazonPayPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesAuBecsDebitPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesBacsDebitPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesBancontactPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesBlikPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesBoletoPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesCardPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesCartesBancairesPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesCashappPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesEpsPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesFpxPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesGbBankTransferPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesGrabpayPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesIdealPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesJcbPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesJpBankTransferPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesKakaoPayPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesKlarnaPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesKonbiniPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesKrCardPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesLinkPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesMobilepayPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesMultibancoPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesMxBankTransferPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesNaverPayPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesOxxoPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesP24PaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesPayByBankPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesPaycoPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesPaynowPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesPromptpayPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesRevolutPayPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesSamsungPayPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesSepaBankTransferPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesSepaDebitPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesSwishPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesTwintPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesUsBankTransferPaymentsOptions`, `V2CoreAccountConfigurationMerchantCapabilitiesZipPaymentsOptions`, `V2CoreAccountConfigurationRecipientCapabilitiesBankAccountsInstantOptions`, `V2CoreAccountConfigurationRecipientCapabilitiesBankAccountsLocalOptions`, `V2CoreAccountConfigurationRecipientCapabilitiesBankAccountsWireOptions`, `V2CoreAccountConfigurationRecipientCapabilitiesCardsOptions`, `V2CoreAccountConfigurationRecipientCapabilitiesCryptoWalletsOptions`, `V2CoreAccountConfigurationRecipientCapabilitiesPaperChecksOptions`, `V2CoreAccountConfigurationRecipientCapabilitiesStripeBalanceStripeTransfersOptions`, `V2CoreAccountConfigurationStorerCapabilitiesConsumerHoldsCurrenciesUsdOptions`, `V2CoreAccountConfigurationStorerCapabilitiesFinancialAddressesBankAccountsOptions`, `V2CoreAccountConfigurationStorerCapabilitiesFinancialAddressesCryptoWalletsOptions`, `V2CoreAccountConfigurationStorerCapabilitiesHoldsCurrenciesEurOptions`, `V2CoreAccountConfigurationStorerCapabilitiesHoldsCurrenciesGbpOptions`, `V2CoreAccountConfigurationStorerCapabilitiesHoldsCurrenciesUsdOptions`, `V2CoreAccountConfigurationStorerCapabilitiesHoldsCurrenciesUsdcOptions`, `V2CoreAccountConfigurationStorerCapabilitiesInboundTransfersBankAccountsOptions`, `V2CoreAccountConfigurationStorerCapabilitiesOutboundPaymentsBankAccountsOptions`, `V2CoreAccountConfigurationStorerCapabilitiesOutboundPaymentsCardsOptions`, `V2CoreAccountConfigurationStorerCapabilitiesOutboundPaymentsCryptoWalletsOptions`, `V2CoreAccountConfigurationStorerCapabilitiesOutboundPaymentsFinancialAccountsOptions`, `V2CoreAccountConfigurationStorerCapabilitiesOutboundPaymentsPaperChecksOptions`, `V2CoreAccountConfigurationStorerCapabilitiesOutboundTransfersBankAccountsOptions`, `V2CoreAccountConfigurationStorerCapabilitiesOutboundTransfersCryptoWalletsOptions`, and `V2CoreAccountConfigurationStorerCapabilitiesOutboundTransfersFinancialAccountsOptions`

## 52.1.0-alpha.1 - 2026-06-10
This release changes the pinned API version to `2026-06-10.preview`.

* ⚠️ [#3395](https://github.com/stripe/stripe-dotnet/pull/3395) Update generated code for private-preview
  * Add support for new resources `GiftCardOperation`, `GiftCard`, and `TaxFund`
  * Add support for `Get` method on resource `GiftCardOperation`
  * Add support for `Activate`, `Cashout`, `CheckBalance`, `Create`, `Get`, `Reload`, and `VoidOperation` methods on resource `GiftCard`
  * Add support for `Get` and `List` methods on resource `TaxFund`
  * Add support for `UpdateCryptoRefundAddress` method on resource `PaymentIntent`
  * Add support for `PerformanceLocationDetails` on `Tax.CalculationLineItem`, `Tax.TransactionLineItem`, and `TaxCalculationLineItemOptions`
  * ⚠️ Remove support for `MoneyServices` on `ChargePaymentDetailsOptions` and `PaymentIntentPaymentDetailsOptions`
  * Add support for `FrMealVoucher` on `Charge.PaymentMethodDetails.Card.Benefits`
  * Add support for `Multicapture` on `Charge.PaymentMethodDetails.CardPresent`, `ConfirmationToken.PaymentMethodPreview.Card.GeneratedFrom.PaymentMethodDetails.CardPresent`, `PaymentAttemptRecord.PaymentMethodDetails.CardPresent`, `PaymentMethod.Card.GeneratedFrom.PaymentMethodDetails.CardPresent`, and `PaymentRecord.PaymentMethodDetails.CardPresent`
  * Add support for `Pix` on `Checkout.Session.CurrentAttempt.PaymentMethodDetails`
  * Add support for `ProvisionalCredit` on `Issuing.DisputeUpdateOptions` and `Issuing.Dispute`
  * Add support for `Reason` on `PaymentAttemptRecordReportCanceledOptions` and `PaymentRecordReportPaymentAttemptCanceledOptions`
  * Add support for `FiservValuelink`, `Givex`, and `Svs` on `PaymentAttemptRecord.ProcessorDetails` and `PaymentRecord.ProcessorDetails`
  * ⚠️ Change type of `PaymentAttemptRecord.ProcessorDetails.Type` and `PaymentRecord.ProcessorDetails.Type` from `literal('custom')` to `enum('custom'|'fiserv_valuelink'|'givex'|'svs')`
  * Add support for `CaptureBy` and `CaptureDelay` on `PaymentIntent.PaymentMethodOptions.CardPresent`, `PaymentIntent.PaymentMethodOptions.Card`, `PaymentIntentPaymentMethodOptionsCardOptions`, and `PaymentIntentPaymentMethodOptionsCardPresentOptions`
  * ⚠️ Remove support for `LiquidAsset` on `PaymentIntentPaymentMethodOptionsCardPaymentDetailsMoneyServicesAccountFundingOptions` and `PaymentIntentPaymentMethodOptionsCardPresentPaymentDetailsMoneyServicesAccountFundingOptions`
  * Add support for `RequestMulticapture` on `PaymentIntent.PaymentMethodOptions.CardPresent` and `PaymentIntentPaymentMethodOptionsCardPresentOptions`
  * Add support for `IgnoreApplicationFee`, `IgnoreTransferData`, and `RequestPartialAuthorization` on `PaymentIntentPaymentMethodOptionsGiftCardOptions`
  * Add support for `LatestPaymentAttemptRecord` and `PaymentRecord` on `PaymentIntent`
  * ⚠️ Remove support for `Reauthorization` and `ReauthorizeBefore` on `PaymentIntent.AdvancedFeatureDetails`
  * Add support for `RefundAddress` on `PaymentIntent.NextAction.CryptoDisplayDetails.DepositAddresses.Base`, `PaymentIntent.NextAction.CryptoDisplayDetails.DepositAddresses.Solana`, and `PaymentIntent.NextAction.CryptoDisplayDetails.DepositAddresses.Tempo`
  * Add support for `Location` on `PaymentIntent.PaymentDetails` and `SetupIntent.SetupDetails`
  * Add support for `Data` on `RadarAccountEvaluationLoginInitiatedClientDeviceMetadataDetailsOptions`, `RadarAccountEvaluationRegistrationInitiatedClientDeviceMetadataDetailsOptions`, and `RadarCustomerEvaluationEvaluationContextClientDetailsOptions`
  * ⚠️ Change type of `V2.Core.FeeBatch.Adjustments.TaxAdjustment` from `amount` to `an object`
  * ⚠️ Change type of `V2.Core.FeeBatch.Amount`, `V2.Core.FeeBatch.CollectionRecord.Amount`, `V2.Core.FeeBatch.CollectionRecord.Tax.Amount`, `V2.Core.FeeBatch.Tax.Amount`, `V2.Core.FeeEntry.Amount`, and `V2.Core.FeeEntry.Tax.Amount` from `amount` to `an object`
  * Add support for `TaxFund` on `V2.MoneyManagement.Transaction.Flow` and `V2.MoneyManagement.TransactionEntry.TransactionDetails.Flow`

## 51.3.0-alpha.2 - 2026-06-03
This release changes the pinned API version to `2026-06-03.preview`.

* ⚠️ [#3389](https://github.com/stripe/stripe-dotnet/pull/3389) Update generated code for private-preview
  * Add support for new resources `DelegatedCheckout.OrderEvent`, `DelegatedCheckout.Order`, `V2.Billing.ContractLicensePricingQuantityChange`, `V2.Billing.Contract`, and `V2.Signals.AccountSignal`
  * Add support for `Get` method on resource `DelegatedCheckout.Order`
  * Add support for `ListOrders` method on resource `DelegatedCheckout.RequestedSession`
  * Add support for `Get` and `List` methods on resource `V2.Signals.AccountSignal`
  * Add support for `Activate`, `Cancel`, `Create`, `Get`, `List`, and `Update` methods on resource `V2.Billing.Contract`
  * Add support for `BirthAddress` on `AccountIndividualOptions`, `AccountPersonCreateOptions`, `AccountPersonUpdateOptions`, `Person`, `TokenAccountIndividualOptions`, and `TokenPersonOptions`
  * Change type of `ChargePaymentDetailsMoneyServicesOptions.TransactionType` and `PaymentIntentPaymentDetailsMoneyServicesOptions.TransactionType` from `literal('account_funding')` to `enum('account_funding'|'debt_repayment')`
  * Add support for `ProvisioningDecision` and `TokenType` on `Issuing.Authorization.TokenDetails` and `Issuing.Token`
  * Add support for `TokenDecisionRecommendation` on `Issuing.Authorization.TokenDetails.NetworkData.Visa` and `Issuing.Token.NetworkData.Visa`
  * Add support for `Language` on `Issuing.Token.NetworkData.Device`
  * Add support for `DigitalAssetCategory` on `PaymentIntentPaymentMethodOptionsCardPaymentDetailsMoneyServicesAccountFundingOptions` and `PaymentIntentPaymentMethodOptionsCardPresentPaymentDetailsMoneyServicesAccountFundingOptions`
  * Add support for `StaticAddress` on `PaymentIntent.PaymentMethodOptions.Crypto.DepositOptions` and `PaymentIntentPaymentMethodOptionsCryptoDepositOptionsOptions`
  * Add support for `PaymentReference` on `PaymentIntentPaymentsOrchestrationOptions`
  * ⚠️ Remove support for `PaymentDetails` on `PaymentIntentPaymentsOrchestrationOptions`
  * ⚠️ Change type of `PaymentIntent.PaymentDetails.MoneyServices.TransactionType` from `literal('account_funding')` to `enum('account_funding'|'debt_repayment')`
  * Add support for `EndingBefore`, `Limit`, and `StartingAfter` on `PaymentLocationListOptions`
  * Add support for `Schema` on `V2.Data.Reporting.QueryRun.Result.File` and `V2.Reporting.ReportRun.Result.File`
  * Add support for `Include` on `V2.Data.Reporting.QueryRunGetOptions` and `V2.Reporting.ReportRunGetOptions`
  * Add support for `RequirementsCollector` on `V2CoreAccountDefaultsResponsibilitiesOptions`
  * Add support for event notification `V2SignalsAccountSignalMerchantDelinquencyReadyEvent` with related object `V2.Signals.AccountSignal`

## 51.3.0-alpha.1 - 2026-05-27
This release changes the pinned API version to `2026-05-27.preview`.

* ⚠️ [#3387](https://github.com/stripe/stripe-dotnet/pull/3387) Update generated code for private-preview
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

## 51.2.0-alpha.6 - 2026-05-20
* ⚠️ [#3384](https://github.com/stripe/stripe-dotnet/pull/3384) Update generated code for private-preview
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

## 51.2.0-alpha.5 - 2026-05-13
* ⚠️ [#3382](https://github.com/stripe/stripe-dotnet/pull/3382) Update generated code for private-preview
  * Add support for new resources `V2.Core.FeeBatch`, `V2.Core.FeeEntry`, `V2.MoneyManagement.DebitDispute`, and `V2.MoneyManagement.FinancialAccountStatement`
  * Add support for `SimulateNetworkLifecyclePreArbitrationResponse` and `SimulateNetworkLifecyclePreArbitrationSubmission` test helper methods on resource `Issuing.Dispute`
  * Add support for `List` method on resource `PaymentLocation`
  * Add support for `Get` and `List` methods on resources `V2.Core.FeeBatch`, `V2.Core.FeeEntry`, and `V2.MoneyManagement.FinancialAccountStatement`
  * Add support for `Create`, `Get`, and `List` methods on resource `V2.MoneyManagement.DebitDispute`
  * Add support for `Discounts` on `DelegatedCheckout.RequestedSessionCreateOptions`, `DelegatedCheckout.RequestedSessionUpdateOptions`, and `DelegatedCheckout.RequestedSession`
  * Add support for `AmountSale` on `DelegatedCheckout.RequestedSession.LineItemDetail` and `DelegatedCheckout.RequestedSession.TotalDetails`
  * Add support for `AmountDiscount` and `Breakdown` on `DelegatedCheckout.RequestedSession.TotalDetails`
  * ⚠️ Remove support for `CheckDepositAddress` on `Invoice.PaymentSettings.PaymentMethodOptions.CheckScan`, `InvoicePaymentSettingsPaymentMethodOptionsCheckScanOptions`, `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions.CheckScan`, `Subscription.PaymentSettings.PaymentMethodOptions.CheckScan`, and `SubscriptionPaymentSettingsPaymentMethodOptionsCheckScanOptions`
  * Add support for `PaymentEvaluations` on `PaymentAttemptRecordReportGuaranteedOptions`, `PaymentRecordGuaranteedOptions`, and `PaymentRecordReportPaymentAttemptGuaranteedOptions`
  * Add support for `Location` on `PaymentIntentPaymentDetailsOptions` and `SetupIntentSetupDetailsOptions`
  * Add support for `OnboardingDataUpdateAcknowledged` on `PaymentLocationUpdateOptions`
  * Add support for `Customer` on `Radar.CustomerEvaluationUpdateOptions`
  * Add support for `Status` on `Radar.CustomerEvaluationUpdateOptions` and `Radar.CustomerEvaluation`
  * Add support for `PaymentBehavior` on `SubscriptionResumeOptions`
  * Add support for `DisputeDetails` on `V2.MoneyManagement.ReceivedDebit`
  * Add support for `DebitDispute` on `V2.MoneyManagement.Transaction.Flow` and `V2.MoneyManagement.TransactionEntry.TransactionDetails.Flow`
  * Add support for `PaymentAttemptRecord` on `EventsV2PaymentsOffSessionPaymentAttemptFailedEvent` and `EventsV2PaymentsOffSessionPaymentFailedEvent`
  * Add support for event notifications `V2MoneyManagementFinancialAccountStatementCreatedEvent` and `V2MoneyManagementFinancialAccountStatementRestatedEvent` with related object `V2.MoneyManagement.FinancialAccountStatement`

## 51.2.0-alpha.4 - 2026-05-06
* [#3379](https://github.com/stripe/stripe-dotnet/pull/3379) Add EventNotificationHandler (private preview)
* [#3378](https://github.com/stripe/stripe-dotnet/pull/3378) Update generated code for private-preview
  * Add support for new resource `PaymentLocation`
  * Add support for `Create`, `Delete`, `Get`, and `Update` methods on resource `PaymentLocation`
  * Add support for `Protections` on `AccountCapabilitiesCardPaymentsOptions` and `Capability`
  * Add support for `GiftCard` on `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, `SetupIntentPaymentMethodDataOptions`, and `SharedPayment.GrantedToken.PaymentMethodDetails`
  * Add support for `Metadata` on `DelegatedCheckout.RequestedSessionConfirmOptions`
  * Add support for `CreditedItems` on `InvoiceItem.ProrationDetails`
  * Add support for `NetworkLifecycle` on `Issuing.Dispute`
  * Add support for `StatusDetails` on `Subscription`

## 51.2.0-alpha.3 - 2026-04-28
* [#3377](https://github.com/stripe/stripe-dotnet/pull/3377) Update generated code for private-preview
  * Add support for `DebitCard` on `V2.Core.Account.Configuration.CardCreator.Capabilities.Consumer.Lead`, `V2.Core.Account.Identity.Attestations.TermsOfService.CardCreator.Consumer.Lead`, `V2CoreAccountConfigurationCardCreatorCapabilitiesConsumerLeadOptions`, and `V2CoreAccountIdentityAttestationsTermsOfServiceCardCreatorConsumerLeadOptions`

## 51.2.0-alpha.2 - 2026-04-28
* ⚠️ [#3375](https://github.com/stripe/stripe-dotnet/pull/3375) Update generated code for private-preview
  * Add support for new resource `V2.Data.Analytics.MetricQueryResult`
  * Add support for `Create`, `Get`, and `Revoke` methods on resource `SharedPayment.IssuedToken`
  * Add support for `Create` method on resource `V2.Data.Analytics.MetricQueryResult`
  * Add support for `BalanceReport` and `PayoutReconciliationReport` on `AccountSession.Components` and `AccountSessionComponentsOptions`
  * Add support for `AppDistribution` and `SunbitPayments` on `Account.Capabilities` and `AccountCapabilitiesOptions`
  * Add support for `Sunbit` on `Charge.PaymentMethodDetails`, `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `PaymentAttemptRecord.PaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `PaymentRecord.PaymentMethodDetails`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `Last4` on `Charge.PaymentMethodDetails.GiftCard`, `PaymentAttemptRecord.PaymentMethodDetails.GiftCard`, and `PaymentRecord.PaymentMethodDetails.GiftCard`
  * Add support for `Location` and `Reader` on `Charge.PaymentMethodDetails.Klarna`, `PaymentAttemptRecord.PaymentMethodDetails.Klarna`, and `PaymentRecord.PaymentMethodDetails.Klarna`
  * Add support for `Blik` on `CheckoutSessionPaymentMethodOptionsOptions`, `Invoice.PaymentSettings.PaymentMethodOptions`, `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions`, `Subscription.PaymentSettings.PaymentMethodOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`
  * Add support for `SharedPaymentGrantedToken` on `ConfirmationTokenPaymentMethodDataOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * ⚠️ Change type of `CreditNote.TotalTaxes.TaxRateDetails.TaxRate`, `CreditNoteLineItem.Taxes.TaxRateDetails.TaxRate`, `Invoice.TotalTaxes.TaxRateDetails.TaxRate`, `InvoiceLineItem.Taxes.TaxRateDetails.TaxRate`, and `QuotePreviewInvoice.TotalTaxes.TaxRateDetails.TaxRate` from `string` to `expandable($TaxRate)`
  * Add support for `BuyerConsents` on `DelegatedCheckout.RequestedSessionConfirmOptions`
  * Add support for `Consents` on `DelegatedCheckout.RequestedSession.BuyerConsents.Marketing`
  * Add support for `PaymentFacilitatorId` and `SubMerchantId` on `IssuingAuthorizationMerchantDataOptions` and `IssuingTransactionMerchantDataOptions`
  * Add support for `CardPresence` on `Issuing.Authorization`
  * Add support for `AllowedCardPresences` and `BlockedCardPresences` on `Issuing.Card.SpendingControls`, `Issuing.Cardholder.SpendingControls`, `IssuingCardSpendingControlsOptions`, and `IssuingCardholderSpendingControlsOptions`
  * ⚠️ Change type of `PaymentAttemptRecord.PaymentMethodDetails.GiftCard.Balance` and `PaymentRecord.PaymentMethodDetails.GiftCard.Balance` from `PaymentFlowsPrivatePaymentMethodsGiftCardDeprecatedDetailsResourceBalanceAmount` to `nullable(PaymentsPrimitivesPaymentRecordsResourcePaymentMethodGiftCardDetailsResourceBalance)`
  * Add support for `AmountToConfirm` on `PaymentIntentConfirmOptions`
  * Add support for `KlarnaDisplayQrCode` on `PaymentIntent.NextAction`
  * Add support for `ValidationErrors` on `Privacy.RedactionJob`
  * Add support for `TaxDetails` on `Product`
  * Add support for `Moto` on `SetupAttempt.PaymentMethodDetails.Card`
  * Add support for `AdmissionsTax`, `AttendanceTax`, `EntertainmentTax`, `GrossReceiptsTax`, `HospitalityTax`, `LuxuryTax`, `ResortTax`, and `TourismTax` on `TaxRegistrationCountryOptionsUsOptions`
  * Add support for `Purpose` on `Treasury.OutboundPaymentCreateOptions` and `Treasury.OutboundPayment`
  * Add support for `CryptoWallet` on `V2.MoneyManagement.FinancialAddress.Credentials`
  * Add support for `MxBankAccount` on `V2.MoneyManagement.FinancialAddress.Credentials` and `V2.MoneyManagement.ReceivedCredit.BankTransfer`
  * Add support for `CryptoWalletTransfer` on `V2.MoneyManagement.ReceivedCredit`
  * Add support for `EuBankAccount` on `V2.MoneyManagement.ReceivedCredit.BankTransfer`
  * Add support for `CryptoProperties` and `SettlementCurrency` on `V2.MoneyManagement.FinancialAddressCreateOptions`
  * Add support for event notifications `V2CoreApprovalRequestCreatedEvent` and `V2CoreApprovalRequestExpiredEvent` with related object `V2.Core.ApprovalRequest`
  * Add support for event notification `V2ExtendExtensionRunFailedEvent`

## 51.2.0-alpha.1 - 2026-04-24
This release changes the pinned API version to `2026-04-22.preview`.

* ⚠️ [#3369](https://github.com/stripe/stripe-dotnet/pull/3369) Update generated code for private-preview
  * Add support for new resources `V2.Commerce.ProductCatalogImport`, `V2.Core.ApprovalRequest`, `V2.Extend.WorkflowRun`, `V2.Extend.Workflow`, `V2.Iam.ActivityLog`, `V2.Network.BusinessProfile`, and `V2.OrchestratedCommerce.Agreement`
  * ⚠️ Remove support for resources `V2.Core.WorkflowRun` and `V2.Core.Workflow`
  * Add support for `Confirm`, `Create`, `Get`, `List`, and `Terminate` methods on resource `V2.OrchestratedCommerce.Agreement`
  * Add support for `Get` and `Me` methods on resource `V2.Network.BusinessProfile`
  * Add support for `List` method on resource `V2.Iam.ActivityLog`
  * Add support for `Get` and `List` methods on resource `V2.Extend.WorkflowRun`
  * Add support for `Get`, `Invoke`, and `List` methods on resource `V2.Extend.Workflow`
  * Add support for `Cancel`, `Execute`, `Get`, `List`, and `Submit` methods on resource `V2.Core.ApprovalRequest`
  * Add support for `Create` and `Get` methods on resource `V2.Commerce.ProductCatalogImport`
  * ⚠️ Remove support for `Get` and `List` methods on resource `V2.Core.WorkflowRun`
  * ⚠️ Remove support for `Get`, `Invoke`, and `List` methods on resource `V2.Core.Workflow`
  * Add support for `RenewOnboardingLink` method on resource `V2.Core.ClaimableSandbox`
  * ⚠️ Remove support for `Customer` on `SharedPayment.IssuedToken`
  * Add support for `BillManagement` and `SendMoney` on `AccountSession.Components.Bills.Features`
  * Add support for `GiftCard` on `Charge.PaymentMethodDetails`, `PaymentAttemptRecord.PaymentMethodDetails`, and `PaymentRecord.PaymentMethodDetails`
  * Add support for `CustomPaymentMethodTypes` on `Checkout.SessionCreateOptions` and `Checkout.Session`
  * Add support for `PaymentRecord` on `Checkout.Session`
  * ⚠️ Remove support for `SharedPaymentGrantedToken` on `ConfirmationTokenPaymentMethodDataOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntent`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `PaymentMethod` on `ConfirmationToken.PaymentMethodPreview.SepaDebit.GeneratedFrom`, `PaymentMethod.SepaDebit.GeneratedFrom`, and `SharedPayment.GrantedToken.PaymentMethodDetails.SepaDebit.GeneratedFrom`
  * Add support for `ReturnUrl` on `DelegatedCheckout.RequestedSessionConfirmOptions`
  * Add support for `BuyerConsents` on `DelegatedCheckout.RequestedSession`
  * Add support for `CryptoTransactions` on `Issuing.Authorization`, `Issuing.Dispute`, and `Issuing.Transaction`
  * Add support for `PaymentFacilitatorId` and `SubMerchantId` on `Issuing.Authorization.MerchantData` and `Issuing.Transaction.MerchantData`
  * Add support for `Identifiers` on `OrderLineItemProductDataOptions`, `ProductCreateOptions`, `ProductUpdateOptions`, and `Product`
  * Add support for `AgentDetails` on `PaymentIntent`
  * Add support for `ExternalReference` on `PriceCreateOptions` and `PriceUpdateOptions`
  * Add support for `LoginSucceeded` and `RegistrationSucceeded` on `Radar.AccountEvaluation.Events` and `Radar.AccountEvaluationUpdateOptions`
  * Add support for `PrintContent` on `Terminal.Reader.Action`
  * Add support for `AppChannel` on `V2.Core.ClaimableSandboxCreateOptions` and `V2.Core.ClaimableSandbox`
  * Add support for `OnboardingLinkDetails` and `OwnerDetails` on `V2.Core.ClaimableSandbox`
  * ⚠️ Remove support for `ClaimUrl` on `V2.Core.ClaimableSandbox`
  * ⚠️ Remove support for `OwnerAccount` on `V2.Core.ClaimableSandbox.SandboxDetails`
  * Add support for `SnapshotEvent` on `V2.Core.Event`
  * Add support for `MultiprocessorSettlement` on `V2.MoneyManagement.FinancialAccount`
  * Add support for `CaBankAccount` on `V2.MoneyManagement.FinancialAddress.Credentials` and `V2.MoneyManagement.ReceivedCredit.BankTransfer`
  * Add support for `AmountDetails` and `PaymentDetails` on `V2.Payments.OffSessionPaymentCaptureOptions`, `V2.Payments.OffSessionPaymentCreateOptions`, and `V2.Payments.OffSessionPayment`
  * Add support for `Description` on `V2.Payments.OffSessionPaymentCreateOptions` and `V2.Payments.OffSessionPayment`
  * Add support for `Mcc` on `V2PaymentsOffSessionPaymentPaymentMethodOptionsCardOptions`
  * Add support for `Storage` on `V2.MoneyManagement.FinancialAccountUpdateOptions`
  * Add support for `FxQuote` on `V2.MoneyManagement.CurrencyConversionCreateOptions`
  * ⚠️ Add support for `OnboardingLinkDetails` on `V2.Core.ClaimableSandboxCreateOptions`
  * Change type of `V2CoreBatchJobEndpointOptions.HttpMethod` from `literal('post')` to `enum('delete'|'post')`
  * Add support for `TreasuryTransaction` on `EventsV2MoneyManagementTransactionCreatedEvent`
  * Add support for event notifications `V1AccountApplicationAuthorizedEvent`, `V1AccountApplicationDeauthorizedEvent`, `V1AccountExternalAccountCreatedEvent`, `V1AccountExternalAccountDeletedEvent`, `V1AccountExternalAccountUpdatedEvent`, `V1BillingPortalSessionCreatedEvent`, `V1EntitlementsActiveEntitlementSummaryUpdatedEvent`, `V2CoreHealthMeterEventSummariesDelayedFiringEvent`, and `V2CoreHealthMeterEventSummariesDelayedResolvedEvent`
  * Add support for event notification `V1AccountUpdatedEvent` with related object `Account`
  * Add support for event notifications `V1ApplicationFeeCreatedEvent` and `V1ApplicationFeeRefundedEvent` with related object `ApplicationFee`
  * Add support for event notification `V1ApplicationFeeRefundUpdatedEvent` with related object `ApplicationFeeRefund`
  * Add support for event notification `V1BalanceAvailableEvent` with related object `Balance`
  * Add support for event notification `V1BillingAlertTriggeredEvent` with related object `Billing.Alert`
  * Add support for event notifications `V1BillingPortalConfigurationCreatedEvent` and `V1BillingPortalConfigurationUpdatedEvent` with related object `BillingPortal.Configuration`
  * Add support for event notification `V1CapabilityUpdatedEvent` with related object `Capability`
  * Add support for event notification `V1CashBalanceFundsAvailableEvent` with related object `CashBalance`
  * Add support for event notifications `V1ChargeCapturedEvent`, `V1ChargeExpiredEvent`, `V1ChargeFailedEvent`, `V1ChargePendingEvent`, `V1ChargeRefundedEvent`, `V1ChargeSucceededEvent`, and `V1ChargeUpdatedEvent` with related object `Charge`
  * Add support for event notifications `V1ChargeDisputeClosedEvent`, `V1ChargeDisputeCreatedEvent`, `V1ChargeDisputeFundsReinstatedEvent`, `V1ChargeDisputeFundsWithdrawnEvent`, and `V1ChargeDisputeUpdatedEvent` with related object `Dispute`
  * Add support for event notifications `V1ChargeRefundUpdatedEvent`, `V1RefundCreatedEvent`, `V1RefundFailedEvent`, and `V1RefundUpdatedEvent` with related object `Refund`
  * Add support for event notifications `V1CheckoutSessionAsyncPaymentFailedEvent`, `V1CheckoutSessionAsyncPaymentSucceededEvent`, `V1CheckoutSessionCompletedEvent`, and `V1CheckoutSessionExpiredEvent` with related object `Checkout.Session`
  * Add support for event notifications `V1ClimateOrderCanceledEvent`, `V1ClimateOrderCreatedEvent`, `V1ClimateOrderDelayedEvent`, `V1ClimateOrderDeliveredEvent`, and `V1ClimateOrderProductSubstitutedEvent` with related object `Climate.Order`
  * Add support for event notifications `V1ClimateProductCreatedEvent` and `V1ClimateProductPricingUpdatedEvent` with related object `Climate.Product`
  * Add support for event notifications `V1CouponCreatedEvent`, `V1CouponDeletedEvent`, and `V1CouponUpdatedEvent` with related object `Coupon`
  * Add support for event notifications `V1CreditNoteCreatedEvent`, `V1CreditNoteUpdatedEvent`, and `V1CreditNoteVoidedEvent` with related object `CreditNote`
  * Add support for event notifications `V1CustomerCreatedEvent`, `V1CustomerDeletedEvent`, and `V1CustomerUpdatedEvent` with related object `Customer`
  * Add support for event notifications `V1CustomerSubscriptionCreatedEvent`, `V1CustomerSubscriptionDeletedEvent`, `V1CustomerSubscriptionPausedEvent`, `V1CustomerSubscriptionPendingUpdateAppliedEvent`, `V1CustomerSubscriptionPendingUpdateExpiredEvent`, `V1CustomerSubscriptionResumedEvent`, `V1CustomerSubscriptionTrialWillEndEvent`, and `V1CustomerSubscriptionUpdatedEvent` with related object `Subscription`
  * Add support for event notifications `V1CustomerTaxIdCreatedEvent`, `V1CustomerTaxIdDeletedEvent`, and `V1CustomerTaxIdUpdatedEvent` with related object `TaxId`
  * Add support for event notification `V1CustomerCashBalanceTransactionCreatedEvent` with related object `CustomerCashBalanceTransaction`
  * Add support for event notification `V1FileCreatedEvent` with related object `File`
  * Add support for event notifications `V1FinancialConnectionsAccountCreatedEvent`, `V1FinancialConnectionsAccountDeactivatedEvent`, `V1FinancialConnectionsAccountDisconnectedEvent`, `V1FinancialConnectionsAccountReactivatedEvent`, `V1FinancialConnectionsAccountRefreshedBalanceEvent`, `V1FinancialConnectionsAccountRefreshedOwnershipEvent`, and `V1FinancialConnectionsAccountRefreshedTransactionsEvent` with related object `FinancialConnections.Account`
  * Add support for event notifications `V1IdentityVerificationSessionCanceledEvent`, `V1IdentityVerificationSessionCreatedEvent`, `V1IdentityVerificationSessionProcessingEvent`, `V1IdentityVerificationSessionRedactedEvent`, `V1IdentityVerificationSessionRequiresInputEvent`, and `V1IdentityVerificationSessionVerifiedEvent` with related object `Identity.VerificationSession`
  * Add support for event notifications `V1InvoiceCreatedEvent`, `V1InvoiceDeletedEvent`, `V1InvoiceFinalizationFailedEvent`, `V1InvoiceFinalizedEvent`, `V1InvoiceMarkedUncollectibleEvent`, `V1InvoiceOverdueEvent`, `V1InvoiceOverpaidEvent`, `V1InvoicePaidEvent`, `V1InvoicePaymentActionRequiredEvent`, `V1InvoicePaymentFailedEvent`, `V1InvoicePaymentSucceededEvent`, `V1InvoiceSentEvent`, `V1InvoiceUpcomingEvent`, `V1InvoiceUpdatedEvent`, `V1InvoiceVoidedEvent`, and `V1InvoiceWillBeDueEvent` with related object `Invoice`
  * Add support for event notification `V1InvoicePaymentPaidEvent` with related object `InvoicePayment`
  * Add support for event notifications `V1InvoiceitemCreatedEvent` and `V1InvoiceitemDeletedEvent` with related object `InvoiceItem`
  * Add support for event notifications `V1IssuingAuthorizationCreatedEvent`, `V1IssuingAuthorizationRequestEvent`, and `V1IssuingAuthorizationUpdatedEvent` with related object `Issuing.Authorization`
  * Add support for event notifications `V1IssuingCardCreatedEvent` and `V1IssuingCardUpdatedEvent` with related object `Issuing.Card`
  * Add support for event notifications `V1IssuingCardholderCreatedEvent` and `V1IssuingCardholderUpdatedEvent` with related object `Issuing.Cardholder`
  * Add support for event notifications `V1IssuingDisputeClosedEvent`, `V1IssuingDisputeCreatedEvent`, `V1IssuingDisputeFundsReinstatedEvent`, `V1IssuingDisputeFundsRescindedEvent`, `V1IssuingDisputeSubmittedEvent`, and `V1IssuingDisputeUpdatedEvent` with related object `Issuing.Dispute`
  * Add support for event notifications `V1IssuingPersonalizationDesignActivatedEvent`, `V1IssuingPersonalizationDesignDeactivatedEvent`, `V1IssuingPersonalizationDesignRejectedEvent`, and `V1IssuingPersonalizationDesignUpdatedEvent` with related object `Issuing.PersonalizationDesign`
  * Add support for event notifications `V1IssuingTokenCreatedEvent` and `V1IssuingTokenUpdatedEvent` with related object `Issuing.Token`
  * Add support for event notifications `V1IssuingTransactionCreatedEvent`, `V1IssuingTransactionPurchaseDetailsReceiptUpdatedEvent`, and `V1IssuingTransactionUpdatedEvent` with related object `Issuing.Transaction`
  * Add support for event notification `V1MandateUpdatedEvent` with related object `Mandate`
  * Add support for event notifications `V1PaymentIntentAmountCapturableUpdatedEvent`, `V1PaymentIntentCanceledEvent`, `V1PaymentIntentCreatedEvent`, `V1PaymentIntentPartiallyFundedEvent`, `V1PaymentIntentPaymentFailedEvent`, `V1PaymentIntentProcessingEvent`, `V1PaymentIntentRequiresActionEvent`, and `V1PaymentIntentSucceededEvent` with related object `PaymentIntent`
  * Add support for event notifications `V1PaymentLinkCreatedEvent` and `V1PaymentLinkUpdatedEvent` with related object `PaymentLink`
  * Add support for event notifications `V1PaymentMethodAttachedEvent`, `V1PaymentMethodAutomaticallyUpdatedEvent`, `V1PaymentMethodDetachedEvent`, and `V1PaymentMethodUpdatedEvent` with related object `PaymentMethod`
  * Add support for event notifications `V1PayoutCanceledEvent`, `V1PayoutCreatedEvent`, `V1PayoutFailedEvent`, `V1PayoutPaidEvent`, `V1PayoutReconciliationCompletedEvent`, and `V1PayoutUpdatedEvent` with related object `Payout`
  * Add support for event notifications `V1PersonCreatedEvent`, `V1PersonDeletedEvent`, and `V1PersonUpdatedEvent` with related object `Person`
  * Add support for event notifications `V1PlanCreatedEvent`, `V1PlanDeletedEvent`, and `V1PlanUpdatedEvent` with related object `Plan`
  * Add support for event notifications `V1PriceCreatedEvent`, `V1PriceDeletedEvent`, and `V1PriceUpdatedEvent` with related object `Price`
  * Add support for event notifications `V1ProductCreatedEvent`, `V1ProductDeletedEvent`, and `V1ProductUpdatedEvent` with related object `Product`
  * Add support for event notifications `V1PromotionCodeCreatedEvent` and `V1PromotionCodeUpdatedEvent` with related object `PromotionCode`
  * Add support for event notifications `V1QuoteAcceptedEvent`, `V1QuoteCanceledEvent`, `V1QuoteCreatedEvent`, and `V1QuoteFinalizedEvent` with related object `Quote`
  * Add support for event notifications `V1RadarEarlyFraudWarningCreatedEvent` and `V1RadarEarlyFraudWarningUpdatedEvent` with related object `Radar.EarlyFraudWarning`
  * Add support for event notifications `V1ReviewClosedEvent` and `V1ReviewOpenedEvent` with related object `Review`
  * Add support for event notifications `V1SetupIntentCanceledEvent`, `V1SetupIntentCreatedEvent`, `V1SetupIntentRequiresActionEvent`, `V1SetupIntentSetupFailedEvent`, and `V1SetupIntentSucceededEvent` with related object `SetupIntent`
  * Add support for event notification `V1SigmaScheduledQueryRunCreatedEvent` with related object `Sigma.ScheduledQueryRun`
  * Add support for event notifications `V1SourceCanceledEvent`, `V1SourceChargeableEvent`, `V1SourceFailedEvent`, and `V1SourceRefundAttributesRequiredEvent` with related object `Source`
  * Add support for event notifications `V1SubscriptionScheduleAbortedEvent`, `V1SubscriptionScheduleCanceledEvent`, `V1SubscriptionScheduleCompletedEvent`, `V1SubscriptionScheduleCreatedEvent`, `V1SubscriptionScheduleExpiringEvent`, `V1SubscriptionScheduleReleasedEvent`, and `V1SubscriptionScheduleUpdatedEvent` with related object `SubscriptionSchedule`
  * Add support for event notification `V1TaxSettingsUpdatedEvent` with related object `Tax.Settings`
  * Add support for event notifications `V1TaxRateCreatedEvent` and `V1TaxRateUpdatedEvent` with related object `TaxRate`
  * Add support for event notifications `V1TerminalReaderActionFailedEvent`, `V1TerminalReaderActionSucceededEvent`, and `V1TerminalReaderActionUpdatedEvent` with related object `Terminal.Reader`
  * Add support for event notifications `V1TestHelpersTestClockAdvancingEvent`, `V1TestHelpersTestClockCreatedEvent`, `V1TestHelpersTestClockDeletedEvent`, `V1TestHelpersTestClockInternalFailureEvent`, and `V1TestHelpersTestClockReadyEvent` with related object `TestHelpers.TestClock`
  * Add support for event notifications `V1TopupCanceledEvent`, `V1TopupCreatedEvent`, `V1TopupFailedEvent`, `V1TopupReversedEvent`, and `V1TopupSucceededEvent` with related object `Topup`
  * Add support for event notifications `V1TransferCreatedEvent`, `V1TransferReversedEvent`, and `V1TransferUpdatedEvent` with related object `Transfer`
  * Add support for event notifications `V2CommerceProductCatalogImportsFailedEvent`, `V2CommerceProductCatalogImportsProcessingEvent`, `V2CommerceProductCatalogImportsSucceededEvent`, and `V2CommerceProductCatalogImportsSucceededWithErrorsEvent` with related object `V2.Commerce.ProductCatalogImport`
  * Add support for event notifications `V2CoreApprovalRequestApprovedEvent`, `V2CoreApprovalRequestCanceledEvent`, `V2CoreApprovalRequestFailedEvent`, `V2CoreApprovalRequestRejectedEvent`, and `V2CoreApprovalRequestSucceededEvent` with related object `V2.Core.ApprovalRequest`
  * Add support for event notification `V2CoreClaimableSandboxUpdatedEvent` with related object `V2.Core.ClaimableSandbox`
  * Add support for event notifications `V2ExtendWorkflowRunFailedEvent`, `V2ExtendWorkflowRunStartedEvent`, and `V2ExtendWorkflowRunSucceededEvent` with related object `V2.Extend.WorkflowRun`
  * Add support for event notifications `V2OrchestratedCommerceAgreementConfirmedEvent`, `V2OrchestratedCommerceAgreementCreatedEvent`, `V2OrchestratedCommerceAgreementPartiallyConfirmedEvent`, and `V2OrchestratedCommerceAgreementTerminatedEvent` with related object `V2.OrchestratedCommerce.Agreement`
  * ⚠️ Remove support for event notification `V2CoreClaimableSandboxSandboxDetailsOwnerAccountUpdatedEvent` with related object `V2.Core.ClaimableSandbox`
  * Add support for error type `FxQuoteExpiredException`

## 51.1.0-alpha.4 - 2026-04-15
* [#3368](https://github.com/stripe/stripe-dotnet/pull/3368) Update generated code for private-preview
  * Add support for `LatestVersion` on `V2.Billing.LicenseFee`, `V2.Billing.PricingPlan`, and `V2.Billing.RateCard`
  * Add support for `ServiceIntervalCount` and `ServiceInterval` on `V2.Billing.LicenseFee` and `V2.Billing.RateCard`
* ⚠️ [#3363](https://github.com/stripe/stripe-dotnet/pull/3363) Update generated code for private-preview
  * Add support for new resources `V2.Core.WorkflowRun` and `V2.Core.Workflow`
  * Add support for `ReportAuthorized` method on resource `PaymentAttemptRecord`
  * Add support for `Get` and `List` methods on resource `V2.Core.WorkflowRun`
  * Add support for `Get`, `Invoke`, and `List` methods on resource `V2.Core.Workflow`
  * Add support for `NextAction` and `Status` on `SharedPayment.IssuedToken`
  * ⚠️ Remove support for `NetworkId` on `SharedPayment.IssuedToken.SellerDetails`
  * Add support for `Bills` on `AccountSession.Components`
  * Add support for `SettlementCurrencies` on `BalanceSettings.Payments` and `BalanceSettingsPaymentsOptions`
  * Add support for `DefaultSettlementCurrency` on `BalanceSettings.Payments`
  * Add support for `AccountFunding` on `Charge.PaymentMethodDetails.Card`
  * Add support for `AutomaticSurcharge` on `Checkout.SessionCreateOptions`, `Checkout.Session`, `PaymentLinkCreateOptions`, and `PaymentLink`
  * Add support for `Bizum` on `Checkout.Session.PaymentMethodOptions` and `CheckoutSessionPaymentMethodOptionsOptions`
  * Add support for `SurchargeCost` on `Checkout.Session`
  * Add support for `AmountSurcharge` on `Checkout.Session.TotalDetails`
  * Add support for `SharedPaymentGrantedToken` on `ConfirmationTokenPaymentMethodDataOptions`, `PaymentIntentPaymentMethodDataOptions`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `Details` on `Identity.VerificationReport.Email`
  * Add support for `Confirm` on `Identity.VerificationSessionCreateOptions` and `Identity.VerificationSessionUpdateOptions`
  * Add support for `Subscription` on `InvoiceItem.Parent.ScheduleDetails`
  * ⚠️ Remove support for `SharedPaymentGrantedToken` on `PaymentIntentConfirmOptions` and `PaymentIntentCreateOptions`
  * Add support for `MoneyServices` on `PaymentIntent.PaymentDetails`
  * ⚠️ Remove support for `ExternalReference` on `Plan`

## 51.1.0-alpha.3 - 2026-04-08
This release changes the pinned API version to `2026-04-08.preview`.

* [#3361](https://github.com/stripe/stripe-dotnet/pull/3361) Update generated code for private-preview
  * Add support for `PaymentRecord` on `ApplicationFee.FeeSource`
  * Add support for `FleetData` on `ChargePaymentDetailsOptions`, `PaymentIntent.PaymentDetails`, `PaymentIntentAmountDetailsLineItem.PaymentMethodOptions.Card`, `PaymentIntentAmountDetailsLineItemsPaymentMethodOptionsCardOptions`, and `PaymentIntentPaymentDetailsOptions`
  * Add support for `BeneficiaryAccount`, `BeneficiaryDetails`, `SenderAccount`, and `SenderDetails` on `ChargePaymentDetailsMoneyServicesAccountFundingOptions` and `PaymentIntentPaymentDetailsMoneyServicesAccountFundingOptions`
  * Change type of `ChargePaymentDetailsMoneyServicesOptions.TransactionType` and `PaymentIntentPaymentDetailsMoneyServicesOptions.TransactionType` from `literal('account_funding')` to `emptyable(literal('account_funding'))`
  * Add support for `Bizum` on `Invoice.PaymentSettings.PaymentMethodOptions`, `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions`, `Subscription.PaymentSettings.PaymentMethodOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`
  * Add support for `QuantityPrecision` on `PaymentIntentAmountDetailsLineItem` and `PaymentIntentAmountDetailsLineItemsOptions`
  * Add support for `LiquidAsset` and `Wallet` on `PaymentIntentPaymentMethodOptionsCardPaymentDetailsMoneyServicesAccountFundingOptions` and `PaymentIntentPaymentMethodOptionsCardPresentPaymentDetailsMoneyServicesAccountFundingOptions`
  * Add support for `SharedPaymentGrantedToken` on `PaymentMethod`
  * Add support for `Data` on `Radar.PaymentEvaluation.ClientDeviceMetadataDetails` and `RadarPaymentEvaluationClientDeviceMetadataDetailsOptions`
  * Add support for `Sunbit` on `SharedPayment.GrantedToken.PaymentMethodDetails`
  * Add support for error type `CannotProceedException`

## 51.1.0-alpha.2 - 2026-04-01
This release changes the pinned API version to `2026-04-01.preview`.

* ⚠️ [#3360](https://github.com/stripe/stripe-dotnet/pull/3360) Update generated code for private-preview
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

## 51.1.0-alpha.1 - 2026-03-25
This release changes the pinned API version to `2026-03-25.preview`.

This release contains additional breaking changes. See the [GA changelog](https://github.com/stripe/stripe-dotnet/blob/master/CHANGELOG.md#4900---2025-09-30) for more information.

* [#3326](https://github.com/stripe/stripe-dotnet/pull/3326) Update generated code for private-preview
  * Release specs are identical.
* [#3339](https://github.com/stripe/stripe-dotnet/pull/3339) Update generated code for private-preview
  * Release specs are identical.
* ⚠️ [#3352](https://github.com/stripe/stripe-dotnet/pull/3352) Update generated code for private-preview
  * Add support for new resource `RiskSignals`
  * Add support for `FinancialAccountRewards` and `NestingDemo` on `AccountSession.Components`
  * Add support for `UpiPayments` on `Account.Capabilities` and `AccountCapabilitiesOptions`
  * Add support for `RiskSignals` on `Account`
  * Add support for `FraudIntent` on `AccountSignals`
  * Add support for `RiskReserved` on `Balance`
  * ⚠️ Remove support for `BillableItems` on `Billing.Alert.SpendThreshold.Filters`
  * Add support for `Upi` on `Charge.PaymentMethodDetails`, `Checkout.Session.PaymentMethodOptions`, `CheckoutSessionPaymentMethodOptionsOptions`, `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `Mandate.PaymentMethodDetails`, `PaymentAttemptRecord.PaymentMethodDetails`, `PaymentIntent.PaymentMethodOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `PaymentRecord.PaymentMethodDetails`, `SetupAttempt.PaymentMethodDetails`, `SetupIntent.PaymentMethodOptions`, `SetupIntentPaymentMethodDataOptions`, and `SetupIntentPaymentMethodOptionsOptions`
  * ⚠️ Remove support for `SourceType` on `Charge.PaymentMethodDetails.StripeBalance`, `ConfirmationToken.PaymentMethodPreview.StripeBalance`, `ConfirmationTokenPaymentMethodDataStripeBalanceOptions`, `PaymentAttemptRecord.PaymentMethodDetails.StripeBalance`, `PaymentIntentPaymentMethodDataStripeBalanceOptions`, `PaymentMethod.StripeBalance`, `PaymentMethodStripeBalanceOptions`, `PaymentRecord.PaymentMethodDetails.StripeBalance`, and `SetupIntentPaymentMethodDataStripeBalanceOptions`
  * Add support for `IntegrationIdentifier` on `Checkout.SessionCreateOptions` and `Checkout.Session`
  * Change type of `CheckoutSessionLineItemPriceDataProductDataTaxDetailsOptions.TaxCode`, `InvoiceLineItemPriceDataProductDataTaxDetailsOptions.TaxCode`, `InvoiceLinePriceDataProductDataTaxDetailsOptions.TaxCode`, `PaymentLinkLineItemPriceDataProductDataTaxDetailsOptions.TaxCode`, `PlanProductTaxDetailsOptions.TaxCode`, `PriceProductDataTaxDetailsOptions.TaxCode`, and `ProductTaxDetailsOptions.TaxCode` from `string` to `emptyable(string)`
  * Add support for `Crypto` on `CheckoutSessionPaymentMethodOptionsOptions`
  * Add support for `PendingInvoiceItemInterval` on `CheckoutSessionSubscriptionDataOptions`
  * Add support for `AuBecsDebit`, `BacsDebit`, `Boleto`, `Link`, `SepaDebit`, and `UsBankAccount` on `Checkout.Session.CurrentAttempt.PaymentMethodDetails`
  * Add support for `Metadata` on `CreditNoteLineItem` and `CreditNoteLineOptions`
  * Add support for `SelectedFulfillmentOptionOverrides` on `DelegatedCheckout.RequestedSession.FulfillmentDetails`
  * Add support for `LineItemKeys` on `DelegatedCheckout.RequestedSession.FulfillmentDetails.FulfillmentOptions.Digital.DigitalOptions` and `DelegatedCheckout.RequestedSession.FulfillmentDetails.FulfillmentOptions.Shipping.ShippingOptions`
  * Add support for `QuantityDecimal` on `InvoiceInvoiceItemOptions`, `InvoiceItemCreateOptions`, `InvoiceItemUpdateOptions`, `InvoiceItem`, `InvoiceLineItemUpdateOptions`, `InvoiceLineItem`, and `InvoiceLineOptions`
  * Add support for `ExpiresAfterSeconds` on `Invoice.PaymentSettings.PaymentMethodOptions.Pix`, `InvoicePaymentSettingsPaymentMethodOptionsPixOptions`, `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions.Pix`, `Subscription.PaymentSettings.PaymentMethodOptions.Pix`, and `SubscriptionPaymentSettingsPaymentMethodOptionsPixOptions`
  * ⚠️ Add support for `Level` on `IssuingAuthorizationRiskAssessmentCardTestingRiskOptions` and `IssuingAuthorizationRiskAssessmentMerchantDisputeRiskOptions`
  * ⚠️ Remove support for `RiskLevel` on `IssuingAuthorizationRiskAssessmentCardTestingRiskOptions` and `IssuingAuthorizationRiskAssessmentMerchantDisputeRiskOptions`
  * Add support for `LifecycleControls` on `Issuing.CardCreateOptions` and `Issuing.Card`
  * ⚠️ Change type of `PaymentAttemptRecord.PaymentMethodDetails.Card.ExpMonth` and `PaymentRecord.PaymentMethodDetails.Card.ExpMonth` from `longInteger` to `nullable(longInteger)`
  * ⚠️ Change type of `PaymentAttemptRecord.PaymentMethodDetails.Card.ExpYear` and `PaymentRecord.PaymentMethodDetails.Card.ExpYear` from `longInteger` to `nullable(longInteger)`
  * ⚠️ Change type of `PaymentAttemptRecord.PaymentMethodDetails.Card.Moto` and `PaymentRecord.PaymentMethodDetails.Card.Moto` from `boolean` to `nullable(boolean)`
  * Add support for `Cryptogram`, `ElectronicCommerceIndicator`, `ExemptionIndicatorApplied`, and `ExemptionIndicator` on `PaymentAttemptRecord.PaymentMethodDetails.Card.ThreeDSecure` and `PaymentRecord.PaymentMethodDetails.Card.ThreeDSecure`
  * Add support for `Surcharge` on `PaymentIntent.AmountDetails` and `PaymentIntentAmountDetailsOptions`
  * Add support for `MandateOptions` on `PaymentIntent.PaymentMethodOptions.StripeBalance` and `PaymentIntentPaymentMethodOptionsStripeBalanceOptions`
  * Add support for `AmountDetails` and `PaymentDetails` on `PaymentIntentDecrementAuthorizationOptions`
  * Add support for `UpiHandleRedirectOrDisplayQrCode` on `PaymentIntent.NextAction` and `SetupIntent.NextAction`
  * Add support for `ManagedPayments` on `PaymentLinkCreateOptions` and `PaymentLink`
  * Add support for `RecommendedAction` and `Signals` on `Radar.PaymentEvaluation`
  * ⚠️ Remove support for `Insights` on `Radar.PaymentEvaluation`
  * Add support for `StripeBalance` on `SetupIntent.PaymentMethodOptions` and `SetupIntentPaymentMethodOptionsOptions`
  * Add support for `RecurringInterval` on `SharedPayment.GrantedToken.UsageLimits`
  * ⚠️ Change type of `SharedPayment.GrantedToken.UsageLimits.ExpiresAt` from `DateTime` to `nullable(DateTime)`
  * Add support for `PresentmentDetails` on `Subscription`
  * ⚠️ Remove support for `InvoiceResources` on `V2.Billing.Intent`
  * ⚠️ Remove support for `AmountDue` and `CustomerBalanceApplied` on `V2.Billing.Intent.AmountDetails`
  * Add support for `RecurringCreditGrant` on `V2.Billing.IntentAction.Modify.PricingPlanSubscriptionDetails.Overrides.PartialPeriodBehavior`, `V2.Billing.IntentAction.Subscribe.PricingPlanSubscriptionDetails.Overrides.PartialPeriodBehavior`, `V2BillingIntentActionModifyPricingPlanSubscriptionDetailsOverridesPartialPeriodBehaviorOptions`, and `V2BillingIntentActionSubscribePricingPlanSubscriptionDetailsOverridesPartialPeriodBehaviorOptions`
  * Add support for `ConsumerPrivacyDisclosures` and `ConsumerStorer` on `V2.Core.Account.Identity.Attestations.TermsOfService` and `V2CoreAccountIdentityAttestationsTermsOfServiceOptions`
  * ⚠️ Remove support for `Include` on `V2.Billing.IntentCreateOptions` and `V2.Billing.IntentReserveOptions`
* [#3351](https://github.com/stripe/stripe-dotnet/pull/3351) Update generated code for private-preview
  * Release specs are identical.
* ⚠️ [#3345](https://github.com/stripe/stripe-dotnet/pull/3345) Update generated code for private-preview
  * Add support for new resources `V2.Core.AccountEvaluation` and `V2.Core.BatchJob`
  * ⚠️ Remove support for resources `V2.Billing.LicenseFeeSubscription` and `V2.Billing.PricingPlanSubscriptionComponents`
  * Add support for `Cancel`, `Create`, and `Get` methods on resource `V2.Core.BatchJob`
  * Add support for `Create` method on resource `V2.Core.AccountEvaluation`
  * ⚠️ Remove support for `Get` method on resources `V2.Billing.LicenseFeeSubscription` and `V2.Billing.PricingPlanSubscriptionComponents`
  * Add support for `ModifyRates` method on resource `V2.Billing.RateCard`
  * Add support for `RemoveDiscounts` method on resource `V2.Billing.PricingPlanSubscription`
  * ⚠️ Change type of `V2.Billing.Cadence.SettingsData.Collection.PaymentMethodOptions.Card.MandateOptions.Amount`, `V2.Billing.CollectionSetting.PaymentMethodOptions.Card.MandateOptions.Amount`, `V2.Billing.CollectionSettingVersion.PaymentMethodOptions.Card.MandateOptions.Amount`, and `V2BillingCollectionSettingPaymentMethodOptionsCardMandateOptionsOptions.Amount` from `longInteger` to `int64_string`
  * Add support for `InvoiceResources` on `V2.Billing.Intent`
  * Add support for `AmountDue` and `CustomerBalanceApplied` on `V2.Billing.Intent.AmountDetails`
  * Add support for `ExpiresAt` on `V2.Billing.Intent.StatusTransitions`
  * Add support for `Discount` on `V2.Billing.IntentAction.Apply` and `V2BillingIntentActionApplyOptions`
  * Add support for `Timestamp` on `V2.Billing.IntentAction.Apply.EffectiveAt` and `V2BillingIntentActionApplyEffectiveAtOptions`
  * ⚠️ Change type of `V2.Billing.IntentAction.Deactivate.PricingPlanSubscriptionDetails.Overrides.PartialPeriodBehavior.Type`, `V2.Billing.IntentAction.Modify.PricingPlanSubscriptionDetails.Overrides.PartialPeriodBehavior.Type`, `V2.Billing.IntentAction.Subscribe.PricingPlanSubscriptionDetails.Overrides.PartialPeriodBehavior.Type`, `V2BillingIntentActionDeactivatePricingPlanSubscriptionDetailsOverridesPartialPeriodBehaviorOptions.Type`, `V2BillingIntentActionModifyPricingPlanSubscriptionDetailsOverridesPartialPeriodBehaviorOptions.Type`, and `V2BillingIntentActionSubscribePricingPlanSubscriptionDetailsOverridesPartialPeriodBehaviorOptions.Type` from `literal('license_fee')` to `enum('license_fee'|'recurring_credit_grant')`
  * Add support for `ServiceCycle` on `V2.Billing.LicenseFee` and `V2.Billing.RateCard`
  * ⚠️ Remove support for `LatestVersion` on `V2.Billing.LicenseFee`, `V2.Billing.PricingPlan`, and `V2.Billing.RateCard`
  * ⚠️ Remove support for `ServiceIntervalCount` and `ServiceInterval` on `V2.Billing.LicenseFee` and `V2.Billing.RateCard`
  * ⚠️ Change type of `V2.Billing.LicenseFee.TransformQuantity.DivideBy`, `V2.Billing.LicenseFeeVersion.TransformQuantity.DivideBy`, `V2.Billing.RateCardRate.TransformQuantity.DivideBy`, `V2BillingLicenseFeeTransformQuantityOptions.DivideBy`, and `V2BillingRateCardRateTransformQuantityOptions.DivideBy` from `longInteger` to `int64_string`
  * Add support for `DiscountDetails` and `PricingPlanComponentDetails` on `V2.Billing.PricingPlanSubscription`
  * Add support for `Timezone` on `V2.Core.Account.Defaults` and `V2CoreAccountDefaultsOptions`
  * Add support for `AzureEventGrid` on `V2.Core.EventDestinationCreateOptions` and `V2.Core.EventDestination`
  * Add support for `SupportedCurrencies` on `V2.Core.Vault.GbBankAccount`, `V2.Core.Vault.UsBankAccount`, and `V2.MoneyManagement.PayoutMethod.Card`
  * Add support for `BalanceByFundsType` on `V2.MoneyManagement.FinancialAccount.Payments`
  * Add support for `Restricted` on `V2.MoneyManagement.PayoutMethod`
  * Add support for `Currencies` on `V2.MoneyManagement.PayoutMethodsBankAccountSpec.Countries.Field`
  * Add support for `TreasuryTransactionEntry` on `V2.MoneyManagement.TransactionEntry`
  * Add support for `TreasuryCreditReversal`, `TreasuryDebitReversal`, `TreasuryInboundTransfer`, `TreasuryIssuingAuthorization`, `TreasuryOutboundPayment`, `TreasuryOutboundTransfer`, `TreasuryReceivedCredit`, and `TreasuryReceivedDebit` on `V2.MoneyManagement.Transaction.Flow` and `V2.MoneyManagement.TransactionEntry.TransactionDetails.Flow`
  * Add support for `Counterparty`, `Description`, and `TreasuryTransaction` on `V2.MoneyManagement.Transaction`
  * Add support for `Metadata` on `V2.Payments.SettlementAllocationIntentSplit`
  * ⚠️ Change type of `V2.Reporting.ReportRun.Result.File.Size` from `longInteger` to `int64_string`
  * Add support for `StatementDescriptor` on `V2.MoneyManagement.OutboundPaymentCreateOptions` and `V2.MoneyManagement.OutboundTransferCreateOptions`
  * ⚠️ Add support for `Currency` on `V2.Core.Vault.GbBankAccountCreateOptions`, `V2.Core.Vault.UsBankAccountCreateOptions`, `V2MoneyManagementOutboundSetupIntentPayoutMethodDataBankAccountOptions`, and `V2MoneyManagementOutboundSetupIntentPayoutMethodDataCardOptions`
  * Add support for `Include` on `V2.Billing.IntentCreateOptions`, `V2.Billing.IntentReserveOptions`, `V2.Billing.PricingPlanSubscriptionGetOptions`, `V2.Billing.PricingPlanSubscriptionListOptions`, `V2.MoneyManagement.FinancialAccountGetOptions`, and `V2.MoneyManagement.FinancialAccountListOptions`
  * Add support for `Iban` on `V2.Core.Vault.GbBankAccountCreateOptions`
  * Add support for event notifications `V1AccountSignalsIncludingDelinquencyCreatedEvent`, `V2CoreAccountSignalsFraudulentWebsiteReadyEvent`, and `V2SignalsAccountSignalFraudulentMerchantReadyEvent`
  * Add support for event notifications `V2CoreBatchJobBatchFailedEvent`, `V2CoreBatchJobCanceledEvent`, `V2CoreBatchJobCompletedEvent`, `V2CoreBatchJobCreatedEvent`, `V2CoreBatchJobReadyForUploadEvent`, `V2CoreBatchJobTimeoutEvent`, `V2CoreBatchJobUpdatedEvent`, `V2CoreBatchJobUploadTimeoutEvent`, `V2CoreBatchJobValidatingEvent`, and `V2CoreBatchJobValidationFailedEvent` with related object `V2.Core.BatchJob`

## 50.5.0-alpha.4 - 2026-03-18
* ⚠️ [#3319](https://github.com/stripe/stripe-dotnet/pull/3319) Update generated code for private-preview
  * Add support for new resources `Orchestration.PaymentAttempt` and `Radar.CustomerEvaluation`
  * Add support for `Get` method on resource `Orchestration.PaymentAttempt`
  * Add support for `Create` and `Update` methods on resource `Radar.CustomerEvaluation`
  * Add support for `Approve` method on resource `Checkout.Session`
  * Add support for `ReportAuthenticated`, `ReportCanceled`, `ReportFailed`, `ReportGuaranteed`, `ReportInformational`, and `ReportRefund` methods on resource `PaymentAttemptRecord`
  * Add support for `CreateUsPaperCheckOnApplication` on `AccountSessionComponentsCheckScanningFeaturesOptions`
  * Add support for `ApprovalMethod` on `Checkout.SessionCreateOptions` and `Checkout.Session`
  * Add support for `CurrentAttempt` on `Checkout.Session`
  * Add support for `SelectedFulfillmentOptionOverrides` on `DelegatedCheckoutRequestedSessionFulfillmentDetailsOptions`
  * Add support for `PricingPlanSubscriptionDetails` on `InvoiceItem.Parent` and `InvoiceLineItem.Parent`
  * ⚠️ Remove support for `LicenseFeeSubscriptionDetails` on `InvoiceItem.Parent` and `InvoiceLineItem.Parent`
  * ⚠️ Remove support for `PricingPlanSubscription` and `PricingPlanVersion` on `InvoiceItem.Parent.RateCardSubscriptionDetails` and `InvoiceLineItem.Parent.RateCardSubscriptionDetails`
  * Add support for `TokenDetails` on `Issuing.Authorization`
  * Add support for `FailureCode` on `PaymentRecordFailedOptions` and `PaymentRecordReportPaymentAttemptFailedOptions`
  * Add support for `RecurringInterval` on `SharedPaymentGrantedTokenUsageLimitsOptions`
  * Add support for `HomeRuleTax` on `Tax.Registration.CountryOptions.Us` and `TaxRegistrationCountryOptionsUsOptions`
* [#3324](https://github.com/stripe/stripe-dotnet/pull/3324) Update generated code for private-preview
  * Add support for `SimulateCryptoDeposit` test helper method on resource `PaymentIntent`
  * Add support for `DepositOptions` and `Mode` on `PaymentIntent.PaymentMethodOptions.Crypto` and `PaymentIntentPaymentMethodOptionsCryptoOptions`
  * Add support for `CryptoDisplayDetails` on `PaymentIntent.NextAction`

## 50.5.0-alpha.3 - 2026-03-11
* ⚠️ [#3314](https://github.com/stripe/stripe-dotnet/pull/3314) Update generated code for private-preview
  * Add support for new resource `Radar.IssuingAuthorizationEvaluation`
  * Add support for `Create` method on resource `Radar.IssuingAuthorizationEvaluation`
  * ⚠️ Rename `AffiliateAttributions` to `AffiliateAttribution` on `DelegatedCheckout.RequestedSessionConfirmOptions` and `DelegatedCheckout.RequestedSessionCreateOptions`
  * Add support for `AmountToCounter` on `Dispute`
  * Add support for `FrozenFields` on `InvoiceItem`
  * Add support for `Consumer` on `V2.Core.Account.Configuration.CardCreator.Capabilities`, `V2.Core.Account.Identity.Attestations.TermsOfService.CardCreator`, `V2CoreAccountConfigurationCardCreatorCapabilitiesOptions`, and `V2CoreAccountIdentityAttestationsTermsOfServiceCardCreatorOptions`
  * Add support for `FifthThird` on `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial`, `V2.Core.Account.Identity.Attestations.TermsOfService.CardCreator.Commercial`, `V2CoreAccountConfigurationCardCreatorCapabilitiesCommercialOptions`, and `V2CoreAccountIdentityAttestationsTermsOfServiceCardCreatorCommercialOptions`
  * Add support for `PrepaidCard` on `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.CrossRiverBank`, `V2.Core.Account.Identity.Attestations.TermsOfService.CardCreator.Commercial.CrossRiverBank`, `V2CoreAccountConfigurationCardCreatorCapabilitiesCommercialCrossRiverBankOptions`, and `V2CoreAccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankOptions`
  * Add support for `PaymentMethodData` on `V2.Payments.OffSessionPaymentCreateOptions`

## 50.5.0-alpha.2 - 2026-03-04
This release changes the pinned API version to `2026-03-04.preview`.

* ⚠️ [#3309](https://github.com/stripe/stripe-dotnet/pull/3309) Update generated code for private-preview
  * Add support for new resources `Billing.AlertRecovered` and `Profile`
  * Add support for `Reauthorize` method on resource `PaymentIntent`
  * Add support for `Settings` on `QuoteLine.Action.AddDiscount`, `QuoteLine.Action.AddItem.Discount`, `QuoteLine.Action.SetDiscounts`, `QuoteLine.Action.SetItems.Discount`, `QuotePreviewSubscriptionSchedule.Phase.Discount`, `QuotePreviewSubscriptionSchedule.Phase.Item.Discount`, `SubscriptionSchedule.Phase.Discount`, and `SubscriptionSchedule.Phase.Item.Discount`
  * Add support for `SmartDisputes` on `Account.Settings`, `AccountSettingsOptions`, `V2.Core.Account.Configuration.Merchant`, and `V2CoreAccountConfigurationMerchantOptions`
  * Add support for `EmailCustomersOnSuccessfulPayment` on `Account.Settings.Payments` and `AccountSettingsPaymentsOptions`
  * Add support for `BalanceUpdateDetails` on `Billing.CreditBalanceSummary.Balance`
  * Add support for `Reauthorization` and `ReauthorizeBefore` on `Charge.PaymentMethodDetails.CardPresent`, `Charge.PaymentMethodDetails.Card`, `ConfirmationToken.PaymentMethodPreview.Card.GeneratedFrom.PaymentMethodDetails.CardPresent`, `PaymentAttemptRecord.PaymentMethodDetails.CardPresent`, `PaymentMethod.Card.GeneratedFrom.PaymentMethodDetails.CardPresent`, and `PaymentRecord.PaymentMethodDetails.CardPresent`
  * Add support for `Location` and `Reader` on `Charge.PaymentMethodDetails.CardPresent`, `Charge.PaymentMethodDetails.InteracPresent`, `ConfirmationToken.PaymentMethodPreview.Card.GeneratedFrom.PaymentMethodDetails.CardPresent`, `PaymentAttemptRecord.PaymentMethodDetails.CardPresent`, `PaymentAttemptRecord.PaymentMethodDetails.InteracPresent`, `PaymentMethod.Card.GeneratedFrom.PaymentMethodDetails.CardPresent`, `PaymentRecord.PaymentMethodDetails.CardPresent`, and `PaymentRecord.PaymentMethodDetails.InteracPresent`
  * Add support for `ManagedPayments` on `Checkout.SessionCreateOptions`, `Checkout.Session`, `PaymentIntent`, `SetupIntent`, and `Subscription`
  * Add support for `Digital` on `DelegatedCheckout.RequestedSession.FulfillmentDetails.FulfillmentOptions`, `DelegatedCheckout.RequestedSession.FulfillmentDetails.SelectedFulfillmentOption`, and `DelegatedCheckoutRequestedSessionFulfillmentDetailsSelectedFulfillmentOptionOptions`
  * Add support for `AffiliateAttributions` on `DelegatedCheckout.RequestedSessionConfirmOptions`, `DelegatedCheckout.RequestedSessionCreateOptions`, and `DelegatedCheckout.RequestedSession`
  * Add support for `FulfillmentType` on `DelegatedCheckout.RequestedSession.LineItemDetail`
  * Add support for `MarketplaceSellerDetails`, `NetworkProfile`, `PrivacyNoticeUrl`, `ReturnPolicyUrl`, `StorePolicyUrl`, and `TermsOfServiceUrl` on `DelegatedCheckout.RequestedSession.SellerDetails`
  * Add support for `AmountToCounter` on `DisputeUpdateOptions`
  * Add support for `DisplayName` and `ServiceUserNumber` on `Mandate.PaymentMethodDetails.BacsDebit`
  * Add support for `RequestReauthorization` on `PaymentIntent.PaymentMethodOptions.CardPresent`, `PaymentIntent.PaymentMethodOptions.Card`, `PaymentIntentPaymentMethodOptionsCardOptions`, and `PaymentIntentPaymentMethodOptionsCardPresentOptions`
  * Add support for `TransactionPurpose` on `PaymentIntent.PaymentMethodOptions.UsBankAccount` and `PaymentIntentPaymentMethodOptionsUsBankAccountOptions`
  * Add support for `OptionalItems` on `PaymentLinkUpdateOptions`
  * ⚠️ Remove support for `CardIssuerDecline` on `Radar.PaymentEvaluation.Insights`
  * Add support for `PaymentBehavior` on `SubscriptionItemDeleteOptions`
  * Add support for `BillingCycleAnchor` on `Subscription.TrialSettings.EndBehavior`
  * Add support for `Lk` on `Tax.Registration.CountryOptions` and `TaxRegistrationCountryOptionsOptions`
  * Add support for `Cellular` and `StripeS710` on `Terminal.ConfigurationCreateOptions`, `Terminal.ConfigurationUpdateOptions`, and `Terminal.Configuration`
  * Add support for `RecipientOnboarding` and `RecipientUpdate` on `V2.Core.AccountLink.UseCase` and `V2CoreAccountLinkUseCaseOptions`
  * Add support for `Consumer` on `V2.Core.Account.Configuration.Storer.Capabilities` and `V2CoreAccountConfigurationStorerCapabilitiesOptions`
  * Add support for `FundsUsageType` on `V2.MoneyManagement.FinancialAccount.Storage` and `V2MoneyManagementFinancialAccountStorageOptions`
  * Add support for `Purpose` on `V2.MoneyManagement.OutboundPaymentCreateOptions` and `V2.MoneyManagement.OutboundPayment`
  * Add support for `BranchNumber` and `SwiftCode` on `V2.MoneyManagement.PayoutMethod.BankAccount`
  * Add support for snapshot event `BillingAlertRecovered` with resource `Billing.AlertRecovered`
  * Add support for snapshot events `ReserveHoldCreated` and `ReserveHoldUpdated` with resource `Reserve.Hold`
  * Add support for snapshot events `ReservePlanCreated`, `ReservePlanDisabled`, `ReservePlanExpired`, and `ReservePlanUpdated` with resource `Reserve.Plan`
  * Add support for snapshot event `ReserveReleaseCreated` with resource `Reserve.Release`
  * Add support for event notification `V2BillingRateCardCustomPricingUnitOverageRateCreatedEvent` with related object `V2.Billing.RateCardCustomPricingUnitOverageRate`
  * Add support for event notifications `V2IamStripeAccessGrantApprovedEvent`, `V2IamStripeAccessGrantCanceledEvent`, `V2IamStripeAccessGrantDeniedEvent`, `V2IamStripeAccessGrantRemovedEvent`, `V2IamStripeAccessGrantRequestedEvent`, and `V2IamStripeAccessGrantUpdatedEvent`

## 50.5.0-alpha.1 - 2026-02-25
This release uses the API version `2026-01-28.preview`.

* [#3303](https://github.com/stripe/stripe-dotnet/pull/3303) Update generated code for private-preview
  * Add support for new resource `AccountSignals`
  * Add support for `Get` method on resource `AccountSignals`
  * Add support for `AggregationPeriod`, `GroupBy`, and `TriggeredAt` on `Billing.AlertTriggered`
  * Add support for `ExternalAccountCollection` on `AccountLinkCollectionOptionsOptions`
  * Add support for `FundingSource` on `ApplicationFee`
  * Add support for `Hosted` and `UiMode` on `FinancialConnections.SessionCreateOptions` and `FinancialConnections.Session`
  * Add support for `Url` on `FinancialConnections.Session`
  * Add support for `BillingCycleAnchor` on `SubscriptionTrialSettingsEndBehaviorOptions`

## 50.4.0-alpha.4 - 2026-02-19
* ⚠️ [#3302](https://github.com/stripe/stripe-dotnet/pull/3302) Update generated code for private-preview
  * Add support for `SpendThreshold` on `Billing.AlertCreateOptions` and `Billing.Alert`
  * Add support for `InvoiceItem`, `ProrationDetails`, `Proration`, and `Subscription` on `InvoiceLineItem.Parent.ScheduleDetails`
  * Add support for `Custom` on `PaymentMethodUpdateOptions`
  * Add support for `PaymentMethodReference` and `Usage` on `PaymentMethod.Custom`
  * ⚠️ Change type of `QuoteSubscriptionDataOverridesOptions.BillingSchedules` from `emptyable(array(billing_schedules_update_specs))` to `array(billing_schedules_update_specs)`
  * Add support for `OutstandingUsageThrough` and `UnusedTimeFrom` on `SubscriptionBillForOptions`
  * ⚠️ Remove support for `OutstandingUsage` and `UnusedTime` on `SubscriptionBillForOptions`
  * ⚠️ Remove support for `PaymentBehavior` on `SubscriptionResumeOptions`

## 50.4.0-alpha.3 - 2026-02-11
* [#3301](https://github.com/stripe/stripe-dotnet/pull/3301) Update generated code for private-preview
  * Add support for new resources `V2.Billing.CadenceSpendModifier`, `V2.Billing.OneTimeItem`, and `V2.Billing.RateCardCustomPricingUnitOverageRate`
  * Add support for `Create`, `Delete`, `Get`, and `List` methods on resource `V2.Billing.RateCardCustomPricingUnitOverageRate`
  * Add support for `Create`, `Get`, `List`, and `Update` methods on resource `V2.Billing.OneTimeItem`
  * Add support for `Get` method on resource `V2.Billing.CadenceSpendModifier`
  * Add support for `SettlementType` on `ApplicationFee`
  * Add support for `RateCardCustomPricingUnitOverageRateDetails` on `InvoiceItem.Pricing` and `InvoiceLineItem.Pricing`
  * Add support for `DefaultSettings` on `InvoiceScheduleDetailsOptions`
  * Add support for `PaymentBehavior` on `SubscriptionResumeOptions`
  * Add support for `EffectiveAt` and `SpendModifierRule` on `V2.Billing.IntentAction.Apply`, `V2.Billing.IntentAction.Remove`, `V2BillingIntentActionApplyOptions`, and `V2BillingIntentActionRemoveOptions`
  * Change type of `V2.Billing.IntentAction.Apply.Type`, `V2.Billing.IntentAction.Remove.Type`, `V2BillingIntentActionApplyOptions.Type`, and `V2BillingIntentActionRemoveOptions.Type` from `literal('invoice_discount_rule')` to `enum('invoice_discount_rule'|'spend_modifier_rule')`

## 50.4.0-alpha.2 - 2026-02-04
* [#3299](https://github.com/stripe/stripe-dotnet/pull/3299) Update generated code for private-preview
  * Add support for new resource `V2.Core.ConnectionSession`
  * Add support for `Create` and `Get` methods on resource `V2.Core.ConnectionSession`
  * Add support for `List` method on resources `V2.Payments.SettlementAllocationIntentSplit` and `V2.Payments.SettlementAllocationIntent`
  * Add support for `AgenticCommerceSettings` on `AccountSessionComponentsOptions`
  * Add support for `TerminalHardwareOrders` and `TerminalHardwareShop` on `AccountSession.Components` and `AccountSessionComponentsOptions`
  * Add support for `NetworkCostPassthroughReport` on `AccountSession.Components`
  * Add support for `CadenceData` on `V2.Billing.IntentCreateOptions` and `V2.Billing.Intent`
  * Add support for `CancellationDetails` on `V2.Billing.IntentAction.Deactivate`, `V2.Billing.PricingPlanSubscription`, and `V2BillingIntentActionDeactivateOptions`
  * Add support for `ContactPhone` on `V2.Core.AccountCreateOptions`, `V2.Core.AccountTokenCreateOptions`, `V2.Core.AccountUpdateOptions`, and `V2.Core.Account`
  * Add support for `RegistrationDate` on `V2.Core.Account.Identity.BusinessDetails`, `V2CoreAccountIdentityBusinessDetailsOptions`, and `V2CoreAccountTokenIdentityBusinessDetailsOptions`
  * Add support for `Reference` on `V2.MoneyManagement.Adjustment`
  * Add support for `AccruedFees` on `V2.MoneyManagement.FinancialAccount`
  * Add support for `StartingBalance` on `V2.MoneyManagement.FinancialAccount.Payments`
  * Add support for `AccountHolderAddress` and `AccountHolderName` on `V2.MoneyManagement.FinancialAddress.Credentials.UsBankAccount`
  * Add support for `Fingerprint` on `V2.MoneyManagement.PayoutMethod.Card`
  * Add support for `CardSpend` on `V2.MoneyManagement.ReceivedCredit` and `V2.MoneyManagement.ReceivedDebit`
  * Add support for `ApplicationFeeRefund`, `ApplicationFee`, `Charge`, `Dispute`, `Payout`, `Refund`, `ReserveHold`, `ReserveRelease`, `Topup`, `TransferReversal`, and `Transfer` on `V2.MoneyManagement.Transaction.Flow` and `V2.MoneyManagement.TransactionEntry.TransactionDetails.Flow`

## 50.4.0-alpha.1 - 2026-01-28
This release changes the pinned API version to `2026-01-28.preview`.

* [#3297](https://github.com/stripe/stripe-dotnet/pull/3297) Update generated code for private-preview
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

## 50.3.0-alpha.1 - 2026-01-21
* [#3295](https://github.com/stripe/stripe-dotnet/pull/3295) Update generated code for private-preview
  * Remove support for `Pause` method on resource `Subscription`

## 50.2.0-alpha.3 - 2026-01-14
* [#3290](https://github.com/stripe/stripe-dotnet/pull/3290) Update generated code for private-preview
  * Add support for `RiskDetails` on `DelegatedCheckout.RequestedSession`
  * Remove support for `Description`, `Images`, and `Name` on `DelegatedCheckout.RequestedSession.LineItemDetail`
  * Add support for `Name` on `ProductCatalog.TrialOfferCreateOptions` and `ProductCatalog.TrialOffer`
  * Add support for `LoginFailed` and `RegistrationFailed` on `Radar.AccountEvaluation.Events` and `Radar.AccountEvaluationUpdateOptions`
  * Change type of `Radar.AccountEvaluationUpdateOptions.Type` from `literal('registration_succeeded')` to `enum('login_failed'|'login_succeeded'|'registration_failed'|'registration_succeeded')`

## 50.2.0-alpha.2 - 2026-01-07
* [#3274](https://github.com/stripe/stripe-dotnet/pull/3274) Update generated code for private-preview
  * Add support for new resource `Tax.Location`
  * Add support for `Create`, `Get`, and `List` methods on resource `Tax.Location`
  * Add support for `PerformanceLocation` on `CheckoutSessionLineItemPriceDataProductDataTaxDetailsOptions`, `InvoiceLineItemPriceDataProductDataTaxDetailsOptions`, `InvoiceLinePriceDataProductDataTaxDetailsOptions`, `PaymentLinkLineItemPriceDataProductDataTaxDetailsOptions`, `ProductTaxDetailsOptions`, `Tax.CalculationLineItem`, and `TaxCalculationLineItemOptions`
  * Change type of `DelegatedCheckout.RequestedSessionUpdateOptions.Metadata` from `map(string: string)` to `emptyable(map(string: string))`
  * Change type of `DelegatedCheckout.RequestedSessionUpdateOptions.PaymentMethodData` from `payment_method_data` to `emptyable(payment_method_data)`
  * Change type of `DelegatedCheckout.RequestedSessionUpdateOptions.SharedMetadata` from `map(string: string)` to `emptyable(map(string: string))`
  * Add support for `Subscription` on `Invoice.Parent.ScheduleDetails` and `QuotePreviewInvoice.Parent.ScheduleDetails`
  * Change type of `PaymentIntentPaymentDetailsBenefitOptions.FrMealVoucher` and `SetupIntentSetupDetailsBenefitOptions.FrMealVoucher` from `payment_details_benefit_fr_meal_voucher` to `emptyable(payment_details_benefit_fr_meal_voucher)`
  * Add support for `TaxDetails` on `PlanProductOptions` and `PriceProductDataOptions`
  * Add support for `AdmissionsTax`, `AttendanceTax`, `EntertainmentTax`, `GrossReceiptsTax`, `HospitalityTax`, `LuxuryTax`, `ResortTax`, and `TourismTax` on `Tax.Registration.CountryOptions.Us`
  * Add support for `Requirements` on `TaxCode`
* [#3283](https://github.com/stripe/stripe-dotnet/pull/3283) Update generated code for private-preview
  * Add support for `Pause` method on resource `Subscription`
  * Add support for `ExternalReference` on `Plan` and `Price`
  * Add support for `TrackingDetails` on `V2.MoneyManagement.OutboundPayment`
  * Add support for `PaperCheck` on `V2.MoneyManagement.OutboundPayment.DeliveryOptions` and `V2MoneyManagementOutboundPaymentDeliveryOptionsOptions`
  * Add support for event notification `V2CoreAccountIncludingFutureRequirementsUpdatedEvent` with related object `V2.Core.Account`

## 50.2.0-alpha.1 - 2025-12-14
This release changes the pinned API version to `2025-12-15.preview`.

* [#3273](https://github.com/stripe/stripe-dotnet/pull/3273) Update generated code for private-preview
  * Add support for new resources `SharedPayment.GrantedToken`, `V2.Iam.ApiKey`, `V2.Payments.SettlementAllocationIntentSplit`, `V2.Payments.SettlementAllocationIntent`, and `V2.Tax.ManualRule`
  * Add support for `Get` method on resource `SharedPayment.GrantedToken`
  * Add support for `Create` and `Update` test helper methods on resource `SharedPayment.GrantedToken`
  * Add support for `Create`, `Deactivate`, `Get`, `List`, and `Update` methods on resource `V2.Tax.ManualRule`
  * Add support for `Cancel`, `Create`, `Get`, `Submit`, and `Update` methods on resource `V2.Payments.SettlementAllocationIntent`
  * Add support for `Cancel`, `Create`, and `Get` methods on resource `V2.Payments.SettlementAllocationIntentSplit`
  * Add support for `Create`, `Expire`, `Get`, `List`, `Rotate`, and `Update` methods on resource `V2.Iam.ApiKey`
  * Add support for `CheckScanning` on `AccountSessionComponentsOptions`
  * Add support for `TaxDetails` on `CheckoutSessionLineItemPriceDataProductDataOptions`, `InvoiceLineItemPriceDataProductDataOptions`, `InvoiceLinePriceDataProductDataOptions`, `PaymentLinkLineItemPriceDataProductDataOptions`, `ProductCreateOptions`, and `ProductUpdateOptions`
  * Add support for `PaymentMethodData` on `DelegatedCheckout.RequestedSessionConfirmOptions`
  * Add support for `ProductDetails` on `DelegatedCheckout.RequestedSession.LineItemDetail`
  * Add support for `Wallets` on `Issuing.CardListOptions`
  * Add support for `PrimaryAccountIdentifier` on `Issuing.Card.Wallets.ApplePay` and `Issuing.Card.Wallets.GooglePay`
  * Add support for `SharedPaymentGrantedToken` on `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, and `PaymentIntent`
  * Add support for `Instant` on `V2.Account.Configuration.RecipientData.Features.BankAccounts`, `V2.Core.Account.Configuration.Recipient.Capabilities.BankAccounts`, `V2AccountConfigurationRecipientDataFeaturesBankAccountsOptions`, and `V2CoreAccountConfigurationRecipientCapabilitiesBankAccountsOptions`
  * Add support for `CollectAt` on `V2.Billing.IntentAction.Deactivate`, `V2.Billing.IntentAction.Modify`, `V2.Billing.IntentAction.Subscribe`, `V2BillingIntentActionDeactivateOptions`, `V2BillingIntentActionModifyOptions`, and `V2BillingIntentActionSubscribeOptions`
  * Remove support for `BillingDetails` on `V2.Billing.IntentAction.Deactivate`, `V2.Billing.IntentAction.Modify`, `V2.Billing.IntentAction.Subscribe`, `V2BillingIntentActionDeactivateOptions`, `V2BillingIntentActionModifyOptions`, and `V2BillingIntentActionSubscribeOptions`
  * Add support for `Overrides` on `V2.Billing.IntentAction.Deactivate.PricingPlanSubscriptionDetails`, `V2.Billing.IntentAction.Modify.PricingPlanSubscriptionDetails`, `V2.Billing.IntentAction.Subscribe.PricingPlanSubscriptionDetails`, `V2BillingIntentActionDeactivatePricingPlanSubscriptionDetailsOptions`, `V2BillingIntentActionModifyPricingPlanSubscriptionDetailsOptions`, and `V2BillingIntentActionSubscribePricingPlanSubscriptionDetailsOptions`
  * Remove support for `Requested` on `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.Celtic.ChargeCard`, `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.Celtic.SpendCard`, `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.CrossRiverBank.ChargeCard`, `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.CrossRiverBank.SpendCard`, `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.Lead.PrepaidCard`, `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.Stripe.ChargeCard`, `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.Stripe.PrepaidCard`, `V2.Core.Account.Configuration.Recipient.Capabilities.CryptoWallets`, `V2.Core.Account.Configuration.Storer.Capabilities.FinancialAddresses.CryptoWallets`, `V2.Core.Account.Configuration.Storer.Capabilities.HoldsCurrencies.Usdc`, `V2.Core.Account.Configuration.Storer.Capabilities.OutboundPayments.CryptoWallets`, and `V2.Core.Account.Configuration.Storer.Capabilities.OutboundTransfers.CryptoWallets`
  * Add support for `AlternativeReference` on `V2.Core.Vault.GbBankAccount`, `V2.Core.Vault.UsBankAccount`, and `V2.MoneyManagement.PayoutMethod`
  * Add support for `ManagedBy` and `Payments` on `V2.MoneyManagement.FinancialAccount`
  * Add support for `Speed` on `V2.MoneyManagement.OutboundPayment.DeliveryOptions`, `V2.MoneyManagement.OutboundPaymentQuote.DeliveryOptions`, `V2MoneyManagementOutboundPaymentDeliveryOptionsOptions`, and `V2MoneyManagementOutboundPaymentQuoteDeliveryOptionsOptions`
  * Add support for `Types` on `V2.MoneyManagement.FinancialAccountListOptions`
  * Add support for `TopImpactedAccounts` on `EventsV2CoreHealthApiErrorFiringEventImpact`, `EventsV2CoreHealthApiErrorResolvedEventImpact`, `EventsV2CoreHealthApiLatencyFiringEventImpact`, `EventsV2CoreHealthApiLatencyResolvedEventImpact`, `EventsV2CoreHealthPaymentMethodErrorFiringEventImpact`, and `EventsV2CoreHealthPaymentMethodErrorResolvedEventImpact`
  * Add support for event notifications `V2CoreHealthSepaDebitDelayedFiringEvent`, `V2CoreHealthSepaDebitDelayedResolvedEvent`, and `V2PaymentsSettlementAllocationIntentNotFoundEvent`
  * Add support for event notifications `V2PaymentsSettlementAllocationIntentCanceledEvent`, `V2PaymentsSettlementAllocationIntentCreatedEvent`, `V2PaymentsSettlementAllocationIntentErroredEvent`, `V2PaymentsSettlementAllocationIntentFundsNotReceivedEvent`, `V2PaymentsSettlementAllocationIntentMatchedEvent`, `V2PaymentsSettlementAllocationIntentSettledEvent`, and `V2PaymentsSettlementAllocationIntentSubmittedEvent` with related object `V2.Payments.SettlementAllocationIntent`
  * Add support for event notifications `V2PaymentsSettlementAllocationIntentSplitCanceledEvent`, `V2PaymentsSettlementAllocationIntentSplitCreatedEvent`, and `V2PaymentsSettlementAllocationIntentSplitSettledEvent` with related object `V2.Payments.SettlementAllocationIntentSplit`

## 50.1.0-alpha.4 - 2025-12-04
* [#3272](https://github.com/stripe/stripe-dotnet/pull/3272) Update generated code for private-preview
  * Add support for `CheckScanning` on `AccountSession.Components`
  * Add support for `Client` on `V2.Core.Event.Reason.Request`
  * Add support for `StripeBalancePayment` on `V2.MoneyManagement.ReceivedCredit` and `V2.MoneyManagement.ReceivedDebit`
  * Add support for `BalanceTransfer` on `V2.MoneyManagement.ReceivedDebit`
  * Add support for `Include` on `V2.Core.EventGetOptions` and `V2.Core.EventListOptions`
  * Add support for event notifications `V2IamApiKeyCreatedEvent`, `V2IamApiKeyDefaultSecretRevealedEvent`, `V2IamApiKeyExpiredEvent`, `V2IamApiKeyPermissionsUpdatedEvent`, `V2IamApiKeyRotatedEvent`, and `V2IamApiKeyUpdatedEvent`

## 50.1.0-alpha.3 - 2025-11-24
* [#3269](https://github.com/stripe/stripe-dotnet/pull/3269) Update generated code for private-preview
  * Add support for new resource `ProductCatalog.TrialOffer`
  * Add support for `Create` method on resource `ProductCatalog.TrialOffer`
  * Remove support for `AmountSubtotalAfterDiscount` on `DelegatedCheckout.RequestedSession.LineItemDetail` and `DelegatedCheckout.RequestedSession.TotalDetails`
  * Remove support for `AmountTotal`, `UnitAmountAfterDiscount`, and `UnitDiscount` on `DelegatedCheckout.RequestedSession.LineItemDetail`
  * Add support for `AmountCartDiscount` and `AmountItemsDiscount` on `DelegatedCheckout.RequestedSession.TotalDetails`
  * Remove support for `AmountDiscount` on `DelegatedCheckout.RequestedSession.TotalDetails`
  * Add support for `PaymentsOrchestration` on `PaymentIntentCreateOptions` and `PaymentIntent`

## 50.1.0-alpha.2 - 2025-11-20
This release changes the pinned API version to `2025-11-17.preview`.

* [#3264](https://github.com/stripe/stripe-dotnet/pull/3264) Update generated code for private-preview
  * Add support for new resources `V2.Core.AccountPersonToken`, `V2.Core.AccountToken`, and `V2.MoneyManagement.CurrencyConversion`
  * Add support for `Create`, `Get`, and `List` methods on resource `V2.MoneyManagement.CurrencyConversion`
  * Add support for `Create` and `Get` methods on resources `V2.Core.AccountPersonToken` and `V2.Core.AccountToken`
  * Add support for `EffectiveAt` on `InvoiceScheduleDetailsAmendmentOptions`, `InvoiceScheduleDetailsPhaseOptions`, `QuoteLineOptions`, `QuoteLine`, `QuotePreviewSubscriptionSchedule.Phase`, `SubscriptionSchedule.Phase`, `SubscriptionScheduleAmendmentOptions`, and `SubscriptionSchedulePhaseOptions`
  * Add support for `TrialOffer` on `InvoiceScheduleDetailsAmendmentItemActionAddOptions`, `InvoiceScheduleDetailsAmendmentItemActionSetOptions`, `InvoiceScheduleDetailsPhaseItemOptions`, `QuoteLine.Action.AddItem`, `QuoteLine.Action.SetItems`, `QuoteLineActionAddItemOptions`, `QuoteLineActionSetItemOptions`, `QuotePreviewSubscriptionSchedule.Phase.Item`, `SubscriptionSchedule.Phase.Item`, `SubscriptionScheduleAmendmentItemActionAddOptions`, `SubscriptionScheduleAmendmentItemActionSetOptions`, and `SubscriptionSchedulePhaseItemOptions`
  * Change type of `DelegatedCheckout.RequestedSession.AmountSubtotal` from `longInteger` to `nullable(longInteger)`
  * Change type of `DelegatedCheckout.RequestedSession.AmountTotal` from `longInteger` to `nullable(longInteger)`
  * Add support for `AmountDiscount`, `AmountSubtotal`, `AmountTotal`, `UnitAmountAfterDiscount`, and `UnitDiscount` on `DelegatedCheckout.RequestedSession.LineItemDetail`
  * Add support for `AmountSubtotalAfterDiscount` on `DelegatedCheckout.RequestedSession.LineItemDetail` and `DelegatedCheckout.RequestedSession.TotalDetails`
  * Change type of `InvoiceScheduleDetailsOptions.BillingSchedules` from `array(billing_schedules_update_params)` to `emptyable(array(billing_schedules_update_params))`
  * Add support for `CurrentTrial` on `InvoiceSubscriptionDetailsItemOptions`, `SubscriptionItemCreateOptions`, `SubscriptionItemOptions`, `SubscriptionItemUpdateOptions`, and `SubscriptionItem`
  * Change type of `QuoteSubscriptionDataOptions.BillingSchedules` and `QuoteSubscriptionDataOverrideOptions.BillingSchedules` from `emptyable(array(billing_schedules_create_specs))` to `array(billing_schedules_create_specs)`
  * Change type of `Quote.SubscriptionData.BillingSchedules` and `Quote.SubscriptionDataOverrides.BillingSchedules` from `nullable(array(SubscriptionsResourceBillingSchedules))` to `array(QuotesResourceSubscriptionDataBillingSchedules)`
  * Change type of `Quote.SubscriptionData.PhaseEffectiveAt` and `Quote.SubscriptionDataOverrides.PhaseEffectiveAt` from `nullable(enum('billing_period_start'|'phase_start'))` to `enum('billing_period_start'|'line_start')`
  * Change type of `QuotePreviewSubscriptionSchedule.BillingSchedules` and `SubscriptionSchedule.BillingSchedules` from `nullable(array(SubscriptionsResourceBillingSchedules))` to `array(SubscriptionsResourceBillingSchedules)`
  * Remove support for `AmendmentStart`, `LineStartsAt`, and `Relative` on `Subscription.BillingSchedule.BillFrom`
  * Change type of `Subscription.BillingSchedule.BillFrom.ComputedTimestamp` from `nullable(DateTime)` to `DateTime`
  * Change type of `Subscription.BillingSchedule.BillFrom.Type` from `enum` to `literal('timestamp')`
  * Remove support for `AmendmentEnd` and `LineEndsAt` on `Subscription.BillingSchedule.BillUntil`
  * Change type of `V2.Billing.ServiceAction.CreditGrant.Amount.Monetary`, `V2.Billing.ServiceAction.CreditGrantPerTenant.Amount.Monetary`, `V2BillingServiceActionCreditGrantAmountOptions.Monetary`, and `V2BillingServiceActionCreditGrantPerTenantAmountOptions.Monetary` from `amount` to `an object`
  * Add support for `FutureRequirements` on `V2.Core.Account`
  * Add support for `KonbiniPayments` and `ScriptStatementDescriptor` on `V2.Core.Account.Configuration.Merchant` and `V2CoreAccountConfigurationMerchantOptions`
  * Add support for `Eur` on `V2.Core.Account.Configuration.Storer.Capabilities.HoldsCurrencies` and `V2CoreAccountConfigurationStorerCapabilitiesHoldsCurrenciesOptions`
  * Add support for `RequirementsCollector` on `V2.Core.Account.Defaults.Responsibilities`
  * Remove support for `Collector` on `V2.Core.Account.Requirements`
  * Remove support for `V1EventId` on `V2.Core.Event`
  * Remove support for `AmountDetails` and `CaptureMethod` on `V2.Payments.OffSessionPaymentCreateOptions` and `V2.Payments.OffSessionPayment`
  * Change type of `V2.Payments.OffSessionPayment.AmountCapturable` from `amount` to `an object`
  * Change type of `V2.Payments.OffSessionPayment.AmountRequested` from `amount` to `an object`
  * Change type of `V2.Payments.OffSessionPaymentCreateOptions.Amount` from `amount` to `an object`
  * Remove support for `Destination` on `V2PaymentsOffSessionPaymentTransferDataOptions`
  * Add support for `Created` on `V2.Core.EventListOptions`
  * Remove support for `Gt`, `Gte`, `Lt`, and `Lte` on `V2.Core.EventListOptions`
  * Add support for `AccountToken` on `V2.Core.AccountCreateOptions` and `V2.Core.AccountUpdateOptions`
  * Add support for `PersonToken` on `V2.Core.AccountPersonCreateOptions` and `V2.Core.AccountPersonUpdateOptions`
  * Add support for `ImpactedRequestsPercentage` on `EventsV2CoreHealthApiErrorFiringEventImpact`, `EventsV2CoreHealthApiErrorResolvedEventImpact`, `EventsV2CoreHealthApiLatencyFiringEventImpact`, `EventsV2CoreHealthApiLatencyResolvedEventImpact`, `EventsV2CoreHealthPaymentMethodErrorFiringEventImpact`, and `EventsV2CoreHealthPaymentMethodErrorResolvedEventImpact`
  * Add support for `Context` and `RelatedObject` on `EventsV2CoreHealthEventGenerationFailureResolvedEventImpact`
  * Remove support for `Account`, `Livemode`, `MissingDeliveryAttempts`, and `RelatedObjectId` on `EventsV2CoreHealthEventGenerationFailureResolvedEventImpact`
  * Change type of `EventsV2CoreHealthFraudRateIncreasedEventImpact.RealizedFraudAmount` from `amount` to `an object`
  * Change type of `EventsV2CoreHealthIssuingAuthorizationRequestErrorsFiringEventImpact.ApprovedAmount`, `EventsV2CoreHealthIssuingAuthorizationRequestErrorsResolvedEventImpact.ApprovedAmount`, `EventsV2CoreHealthIssuingAuthorizationRequestTimeoutFiringEventImpact.ApprovedAmount`, and `EventsV2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEventImpact.ApprovedAmount` from `amount` to `an object`
  * Change type of `EventsV2CoreHealthIssuingAuthorizationRequestErrorsFiringEventImpact.DeclinedAmount`, `EventsV2CoreHealthIssuingAuthorizationRequestErrorsResolvedEventImpact.DeclinedAmount`, `EventsV2CoreHealthIssuingAuthorizationRequestTimeoutFiringEventImpact.DeclinedAmount`, and `EventsV2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEventImpact.DeclinedAmount` from `amount` to `an object`
  * Add support for thin events `V2PaymentsOffSessionPaymentAttemptFailedEvent` and `V2PaymentsOffSessionPaymentAttemptStartedEvent` with related object `V2.Payments.OffSessionPayment`
  * Remove support for thin event `V1AccountUpdatedEvent` with related object `Account`
  * Remove support for thin events `V1ApplicationFeeCreatedEvent` and `V1ApplicationFeeRefundedEvent` with related object `ApplicationFee`
  * Remove support for thin events `V1BillingPortalConfigurationCreatedEvent` and `V1BillingPortalConfigurationUpdatedEvent` with related object `BillingPortal.Configuration`
  * Remove support for thin event `V1CapabilityUpdatedEvent` with related object `Capability`
  * Remove support for thin events `V1ChargeCapturedEvent`, `V1ChargeExpiredEvent`, `V1ChargeFailedEvent`, `V1ChargePendingEvent`, `V1ChargeRefundedEvent`, `V1ChargeSucceededEvent`, and `V1ChargeUpdatedEvent` with related object `Charge`
  * Remove support for thin events `V1ChargeDisputeClosedEvent`, `V1ChargeDisputeCreatedEvent`, `V1ChargeDisputeFundsReinstatedEvent`, `V1ChargeDisputeFundsWithdrawnEvent`, and `V1ChargeDisputeUpdatedEvent` with related object `Dispute`
  * Remove support for thin events `V1ChargeRefundUpdatedEvent`, `V1RefundCreatedEvent`, `V1RefundFailedEvent`, and `V1RefundUpdatedEvent` with related object `Refund`
  * Remove support for thin events `V1CheckoutSessionAsyncPaymentFailedEvent`, `V1CheckoutSessionAsyncPaymentSucceededEvent`, `V1CheckoutSessionCompletedEvent`, and `V1CheckoutSessionExpiredEvent` with related object `Checkout.Session`
  * Remove support for thin events `V1ClimateOrderCanceledEvent`, `V1ClimateOrderCreatedEvent`, `V1ClimateOrderDelayedEvent`, `V1ClimateOrderDeliveredEvent`, and `V1ClimateOrderProductSubstitutedEvent` with related object `Climate.Order`
  * Remove support for thin events `V1ClimateProductCreatedEvent` and `V1ClimateProductPricingUpdatedEvent` with related object `Climate.Product`
  * Remove support for thin events `V1CouponCreatedEvent`, `V1CouponDeletedEvent`, and `V1CouponUpdatedEvent` with related object `Coupon`
  * Remove support for thin events `V1CreditNoteCreatedEvent`, `V1CreditNoteUpdatedEvent`, and `V1CreditNoteVoidedEvent` with related object `CreditNote`
  * Remove support for thin events `V1CustomerCreatedEvent`, `V1CustomerDeletedEvent`, and `V1CustomerUpdatedEvent` with related object `Customer`
  * Remove support for thin events `V1CustomerSubscriptionCreatedEvent`, `V1CustomerSubscriptionDeletedEvent`, `V1CustomerSubscriptionPausedEvent`, `V1CustomerSubscriptionPendingUpdateAppliedEvent`, `V1CustomerSubscriptionPendingUpdateExpiredEvent`, `V1CustomerSubscriptionResumedEvent`, `V1CustomerSubscriptionTrialWillEndEvent`, and `V1CustomerSubscriptionUpdatedEvent` with related object `Subscription`
  * Remove support for thin events `V1CustomerTaxIdCreatedEvent`, `V1CustomerTaxIdDeletedEvent`, and `V1CustomerTaxIdUpdatedEvent` with related object `TaxId`
  * Remove support for thin event `V1FileCreatedEvent` with related object `File`
  * Remove support for thin events `V1FinancialConnectionsAccountCreatedEvent`, `V1FinancialConnectionsAccountDeactivatedEvent`, `V1FinancialConnectionsAccountDisconnectedEvent`, `V1FinancialConnectionsAccountReactivatedEvent`, `V1FinancialConnectionsAccountRefreshedBalanceEvent`, `V1FinancialConnectionsAccountRefreshedOwnershipEvent`, and `V1FinancialConnectionsAccountRefreshedTransactionsEvent` with related object `FinancialConnections.Account`
  * Remove support for thin events `V1IdentityVerificationSessionCanceledEvent`, `V1IdentityVerificationSessionCreatedEvent`, `V1IdentityVerificationSessionProcessingEvent`, `V1IdentityVerificationSessionRedactedEvent`, `V1IdentityVerificationSessionRequiresInputEvent`, and `V1IdentityVerificationSessionVerifiedEvent` with related object `Identity.VerificationSession`
  * Remove support for thin events `V1InvoiceCreatedEvent`, `V1InvoiceDeletedEvent`, `V1InvoiceFinalizationFailedEvent`, `V1InvoiceFinalizedEvent`, `V1InvoiceMarkedUncollectibleEvent`, `V1InvoiceOverdueEvent`, `V1InvoiceOverpaidEvent`, `V1InvoicePaidEvent`, `V1InvoicePaymentActionRequiredEvent`, `V1InvoicePaymentFailedEvent`, `V1InvoicePaymentSucceededEvent`, `V1InvoiceSentEvent`, `V1InvoiceUpcomingEvent`, `V1InvoiceUpdatedEvent`, `V1InvoiceVoidedEvent`, and `V1InvoiceWillBeDueEvent` with related object `Invoice`
  * Remove support for thin event `V1InvoicePaymentPaidEvent` with related object `InvoicePayment`
  * Remove support for thin events `V1InvoiceitemCreatedEvent` and `V1InvoiceitemDeletedEvent` with related object `InvoiceItem`
  * Remove support for thin events `V1IssuingAuthorizationCreatedEvent`, `V1IssuingAuthorizationRequestEvent`, and `V1IssuingAuthorizationUpdatedEvent` with related object `Issuing.Authorization`
  * Remove support for thin events `V1IssuingCardCreatedEvent` and `V1IssuingCardUpdatedEvent` with related object `Issuing.Card`
  * Remove support for thin events `V1IssuingCardholderCreatedEvent` and `V1IssuingCardholderUpdatedEvent` with related object `Issuing.Cardholder`
  * Remove support for thin events `V1IssuingDisputeClosedEvent`, `V1IssuingDisputeCreatedEvent`, `V1IssuingDisputeFundsReinstatedEvent`, `V1IssuingDisputeFundsRescindedEvent`, `V1IssuingDisputeSubmittedEvent`, and `V1IssuingDisputeUpdatedEvent` with related object `Issuing.Dispute`
  * Remove support for thin events `V1IssuingPersonalizationDesignActivatedEvent`, `V1IssuingPersonalizationDesignDeactivatedEvent`, `V1IssuingPersonalizationDesignRejectedEvent`, and `V1IssuingPersonalizationDesignUpdatedEvent` with related object `Issuing.PersonalizationDesign`
  * Remove support for thin events `V1IssuingTokenCreatedEvent` and `V1IssuingTokenUpdatedEvent` with related object `Issuing.Token`
  * Remove support for thin events `V1IssuingTransactionCreatedEvent`, `V1IssuingTransactionPurchaseDetailsReceiptUpdatedEvent`, and `V1IssuingTransactionUpdatedEvent` with related object `Issuing.Transaction`
  * Remove support for thin event `V1MandateUpdatedEvent` with related object `Mandate`
  * Remove support for thin events `V1PaymentIntentAmountCapturableUpdatedEvent`, `V1PaymentIntentCanceledEvent`, `V1PaymentIntentCreatedEvent`, `V1PaymentIntentPartiallyFundedEvent`, `V1PaymentIntentPaymentFailedEvent`, `V1PaymentIntentProcessingEvent`, `V1PaymentIntentRequiresActionEvent`, and `V1PaymentIntentSucceededEvent` with related object `PaymentIntent`
  * Remove support for thin events `V1PaymentLinkCreatedEvent` and `V1PaymentLinkUpdatedEvent` with related object `PaymentLink`
  * Remove support for thin events `V1PaymentMethodAttachedEvent`, `V1PaymentMethodAutomaticallyUpdatedEvent`, `V1PaymentMethodDetachedEvent`, and `V1PaymentMethodUpdatedEvent` with related object `PaymentMethod`
  * Remove support for thin events `V1PayoutCanceledEvent`, `V1PayoutCreatedEvent`, `V1PayoutFailedEvent`, `V1PayoutPaidEvent`, `V1PayoutReconciliationCompletedEvent`, and `V1PayoutUpdatedEvent` with related object `Payout`
  * Remove support for thin events `V1PersonCreatedEvent`, `V1PersonDeletedEvent`, and `V1PersonUpdatedEvent` with related object `Person`
  * Remove support for thin events `V1PlanCreatedEvent`, `V1PlanDeletedEvent`, and `V1PlanUpdatedEvent` with related object `Plan`
  * Remove support for thin events `V1PriceCreatedEvent`, `V1PriceDeletedEvent`, and `V1PriceUpdatedEvent` with related object `Price`
  * Remove support for thin events `V1ProductCreatedEvent`, `V1ProductDeletedEvent`, and `V1ProductUpdatedEvent` with related object `Product`
  * Remove support for thin events `V1PromotionCodeCreatedEvent` and `V1PromotionCodeUpdatedEvent` with related object `PromotionCode`
  * Remove support for thin events `V1QuoteAcceptedEvent`, `V1QuoteCanceledEvent`, `V1QuoteCreatedEvent`, and `V1QuoteFinalizedEvent` with related object `Quote`
  * Remove support for thin events `V1RadarEarlyFraudWarningCreatedEvent` and `V1RadarEarlyFraudWarningUpdatedEvent` with related object `Radar.EarlyFraudWarning`
  * Remove support for thin events `V1ReviewClosedEvent` and `V1ReviewOpenedEvent` with related object `Review`
  * Remove support for thin events `V1SetupIntentCanceledEvent`, `V1SetupIntentCreatedEvent`, `V1SetupIntentRequiresActionEvent`, `V1SetupIntentSetupFailedEvent`, and `V1SetupIntentSucceededEvent` with related object `SetupIntent`
  * Remove support for thin event `V1SigmaScheduledQueryRunCreatedEvent` with related object `Sigma.ScheduledQueryRun`
  * Remove support for thin events `V1SourceCanceledEvent`, `V1SourceChargeableEvent`, `V1SourceFailedEvent`, and `V1SourceRefundAttributesRequiredEvent` with related object `Source`
  * Remove support for thin events `V1SubscriptionScheduleAbortedEvent`, `V1SubscriptionScheduleCanceledEvent`, `V1SubscriptionScheduleCompletedEvent`, `V1SubscriptionScheduleCreatedEvent`, `V1SubscriptionScheduleExpiringEvent`, `V1SubscriptionScheduleReleasedEvent`, and `V1SubscriptionScheduleUpdatedEvent` with related object `SubscriptionSchedule`
  * Remove support for thin events `V1TaxRateCreatedEvent` and `V1TaxRateUpdatedEvent` with related object `TaxRate`
  * Remove support for thin events `V1TerminalReaderActionFailedEvent`, `V1TerminalReaderActionSucceededEvent`, and `V1TerminalReaderActionUpdatedEvent` with related object `Terminal.Reader`
  * Remove support for thin events `V1TestHelpersTestClockAdvancingEvent`, `V1TestHelpersTestClockCreatedEvent`, `V1TestHelpersTestClockDeletedEvent`, `V1TestHelpersTestClockInternalFailureEvent`, and `V1TestHelpersTestClockReadyEvent` with related object `TestHelpers.TestClock`
  * Remove support for thin events `V1TopupCanceledEvent`, `V1TopupCreatedEvent`, `V1TopupFailedEvent`, `V1TopupReversedEvent`, and `V1TopupSucceededEvent` with related object `Topup`
  * Remove support for thin events `V1TransferCreatedEvent`, `V1TransferReversedEvent`, and `V1TransferUpdatedEvent` with related object `Transfer`

## 50.1.0-alpha.1 - 2025-11-18
This release changes the pinned API version to `2025-11-17.preview`.

* [#3252](https://github.com/stripe/stripe-dotnet/pull/3252) Update generated code for private-preview
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
* [#3257](https://github.com/stripe/stripe-dotnet/pull/3257) Update generated code for private-preview
  * Add support for `BillingSchedulesActions` on `InvoiceScheduleDetailsAmendmentOptions` and `SubscriptionScheduleAmendmentOptions`

## 49.3.0-alpha.2 - 2025-11-13
This release changes the pinned API version to `2025-10-29.preview`.

* [#3245](https://github.com/stripe/stripe-dotnet/pull/3245) Update generated code for private-preview
  * Remove support for resource `V2.Tax.AutomaticRule`
  * Remove support for `Create`, `Deactivate`, `Find`, `Get`, and `Update` methods on resource `V2.Tax.AutomaticRule`
  * Add support for `SelfReportedIncome` and `SelfReportedMonthlyHousingPayment` on `AccountIndividualOptions`, `AccountPersonCreateOptions`, `AccountPersonUpdateOptions`, `Person`, `TokenAccountIndividualOptions`, and `TokenPersonOptions`
  * Add support for `BillingSchedules` and `PhaseEffectiveAt` on `Quote.SubscriptionDataOverrides`, `Quote.SubscriptionData`, `QuoteSubscriptionDataOptions`, `QuoteSubscriptionDataOverrideOptions`, and `QuoteSubscriptionDataOverridesOptions`
  * Add support for `BillFrom` on `Subscription.BillingSchedule`
  * Add support for `AmendmentEnd` and `LineEndsAt` on `Subscription.BillingSchedule.BillUntil`
  * Remove support for `Data` and `RelatedObject` on `V2.Core.Event`
* [#3251](https://github.com/stripe/stripe-dotnet/pull/3251) Update generated code for private-preview
  * Add support for new resource `Issuing.Program`
  * Add support for `Create`, `Get`, `List`, and `Update` methods on resource `Issuing.Program`
  * Add support for `ApplicableFees` on `DelegatedCheckout.RequestedSession.TotalDetails`

## 49.3.0-alpha.1 - 2025-11-06
* ⚠️ [#3188](https://github.com/stripe/stripe-dotnet/pull/3188) ParseThinEvent__Experimental is no longer needed
  * ⚠️ Remove the `StripeClient. ParseThinEvent__Experimental` and `PushedEvent` classes. They've been replaced with `StripeClient.ParseEventNotification` and the *`EventNotification` classes respectively.
* [#3183](https://github.com/stripe/stripe-dotnet/pull/3183) Update generated code for private-preview
  * Add support for `ReportPaymentAttemptInformational` method on resource `PaymentRecord`
  * Add support for `PaypayPayments` on `Account.Capabilities` and `AccountCapabilitiesOptions`
  * Add support for `CreditGrants` on `BillingAlertCreditBalanceThresholdFilterOptions`
  * Add support for `Paypay` on `Charge.PaymentMethodDetails`, `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `PaymentAttemptRecord.PaymentMethodDetails`, `PaymentIntent.PaymentMethodOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `PaymentRecord.PaymentMethodDetails`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `Location` and `Reader` on `Charge.PaymentMethodDetails.Paynow`
  * Add support for `PaymentRecordRefund` and `Type` on `CreditNote.Refund` and `CreditNoteRefundOptions`
  * Add support for `BillingCadence` on `InvoiceListOptions`
  * Add support for new resource `V2.MoneyManagement.RecipientVerification`
  * Add support for `Acknowledge`, `Create`, `Get`, and `RecipientVerifications` methods on resource `V2.MoneyManagement.RecipientVerification`
  * Add support for `Update` method on resources `V2.Billing.PricingPlanSubscription` and `V2.Billing.ServiceAction`
  * Add support for `CryptoWallets` on `V2.Account.Configuration.RecipientData.Features`, `V2.Core.Account.Configuration.Recipient.Capabilities`, `V2AccountConfigurationRecipientDataFeaturesOptions`, and `V2CoreAccountConfigurationRecipientCapabilitiesOptions`
  * Add support for `LookupKey` on `V2.Billing.CadenceCreateOptions`, `V2.Billing.CadenceUpdateOptions`, and `V2.Billing.Cadence`
  * Add support for `SettingsData` on `V2.Billing.Cadence`
  * Add support for `MonthOfYear` on `V2.Billing.Cadence.BillingCycle.Month` and `V2BillingCadenceBillingCycleMonthOptions`
  * Add support for `V1EventId` on `V2.Core.Event`
  * Add support for `RecipientVerification` on `V2.MoneyManagement.OutboundPaymentCreateOptions`, `V2.MoneyManagement.OutboundPayment`, `V2.MoneyManagement.OutboundTransferCreateOptions`, and `V2.MoneyManagement.OutboundTransfer`
  * Add support for `CryptoWallet` on `V2.MoneyManagement.PayoutMethod` and `V2MoneyManagementOutboundSetupIntentPayoutMethodDataOptions`
  * Add support for `WillActivateAt` and `WillCancelAt` on `V2.Billing.PricingPlanSubscription.ServicingStatusTransitions` and `V2.Billing.RateCardSubscription.ServicingStatusTransitions`
  * Add support for `CustomPricingUnitDetails` on `V2.Billing.RateCardRate.CustomPricingUnitAmount`, `V2.Billing.ServiceAction.CreditGrant.Amount.CustomPricingUnit`, and `V2.Billing.ServiceAction.CreditGrantPerTenant.Amount.CustomPricingUnit`
  * Add support for `OriginType` on `V2.MoneyManagement.ReceivedDebit.BankTransfer`
  * Add support for `SepaBankAccount` on `V2.MoneyManagement.FinancialAddressCreateOptions`
  * Remove support for `Price` on `V2.Billing.RateCardRateCreateOptions`
  * Add support for `LookupKeys` on `V2.Billing.CadenceListOptions`
  * Change type of `V2.Billing.CadenceCancelOptions.Include`, `V2.Billing.CadenceCreateOptions.Include`, `V2.Billing.CadenceGetOptions.Include`, `V2.Billing.CadenceListOptions.Include`, and `V2.Billing.CadenceUpdateOptions.Include` from `literal('invoice_discount_rules')` to `enum('invoice_discount_rules'|'settings_data')`
  * Remove support for `Customer` and `Type` on `V2BillingCadencePayerOptions`
  * Remove support for `AlertId` on `EventsV2CoreHealthApiErrorResolvedEvent`, `EventsV2CoreHealthApiLatencyResolvedEvent`, `EventsV2CoreHealthAuthorizationRateDropResolvedEvent`, `EventsV2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEvent`, `EventsV2CoreHealthPaymentMethodErrorResolvedEvent`, `EventsV2CoreHealthTrafficVolumeDropResolvedEvent`, and `EventsV2CoreHealthWebhookLatencyResolvedEvent`
  * Add support for thin event `V1AccountUpdatedEvent` with related object `V2.Account`
  * Add support for thin events `V1ApplicationFeeCreatedEvent`, `V1ApplicationFeeRefundedEvent`, `V1BillingPortalConfigurationCreatedEvent`, `V1BillingPortalConfigurationUpdatedEvent`, `V1CapabilityUpdatedEvent`, `V1ChargeCapturedEvent`, `V1ChargeDisputeClosedEvent`, `V1ChargeDisputeCreatedEvent`, `V1ChargeDisputeFundsReinstatedEvent`, `V1ChargeDisputeFundsWithdrawnEvent`, `V1ChargeDisputeUpdatedEvent`, `V1ChargeExpiredEvent`, `V1ChargeFailedEvent`, `V1ChargePendingEvent`, `V1ChargeRefundUpdatedEvent`, `V1ChargeRefundedEvent`, `V1ChargeSucceededEvent`, `V1ChargeUpdatedEvent`, `V1CheckoutSessionAsyncPaymentFailedEvent`, `V1CheckoutSessionAsyncPaymentSucceededEvent`, `V1CheckoutSessionCompletedEvent`, `V1CheckoutSessionExpiredEvent`, `V1ClimateOrderCanceledEvent`, `V1ClimateOrderCreatedEvent`, `V1ClimateOrderDelayedEvent`, `V1ClimateOrderDeliveredEvent`, `V1ClimateOrderProductSubstitutedEvent`, `V1ClimateProductCreatedEvent`, `V1ClimateProductPricingUpdatedEvent`, `V1CouponCreatedEvent`, `V1CouponDeletedEvent`, `V1CouponUpdatedEvent`, `V1CreditNoteCreatedEvent`, `V1CreditNoteUpdatedEvent`, `V1CreditNoteVoidedEvent`, `V1CustomerCreatedEvent`, `V1CustomerDeletedEvent`, `V1CustomerSubscriptionCreatedEvent`, `V1CustomerSubscriptionDeletedEvent`, `V1CustomerSubscriptionPausedEvent`, `V1CustomerSubscriptionPendingUpdateAppliedEvent`, `V1CustomerSubscriptionPendingUpdateExpiredEvent`, `V1CustomerSubscriptionResumedEvent`, `V1CustomerSubscriptionTrialWillEndEvent`, `V1CustomerSubscriptionUpdatedEvent`, `V1CustomerTaxIdCreatedEvent`, `V1CustomerTaxIdDeletedEvent`, `V1CustomerTaxIdUpdatedEvent`, `V1CustomerUpdatedEvent`, `V1FileCreatedEvent`, `V1FinancialConnectionsAccountCreatedEvent`, `V1FinancialConnectionsAccountDeactivatedEvent`, `V1FinancialConnectionsAccountDisconnectedEvent`, `V1FinancialConnectionsAccountReactivatedEvent`, `V1FinancialConnectionsAccountRefreshedBalanceEvent`, `V1FinancialConnectionsAccountRefreshedOwnershipEvent`, `V1FinancialConnectionsAccountRefreshedTransactionsEvent`, `V1IdentityVerificationSessionCanceledEvent`, `V1IdentityVerificationSessionCreatedEvent`, `V1IdentityVerificationSessionProcessingEvent`, `V1IdentityVerificationSessionRedactedEvent`, `V1IdentityVerificationSessionRequiresInputEvent`, `V1IdentityVerificationSessionVerifiedEvent`, `V1InvoiceCreatedEvent`, `V1InvoiceDeletedEvent`, `V1InvoiceFinalizationFailedEvent`, `V1InvoiceFinalizedEvent`, `V1InvoiceMarkedUncollectibleEvent`, `V1InvoiceOverdueEvent`, `V1InvoiceOverpaidEvent`, `V1InvoicePaidEvent`, `V1InvoicePaymentActionRequiredEvent`, `V1InvoicePaymentFailedEvent`, `V1InvoicePaymentPaidEvent`, `V1InvoicePaymentSucceededEvent`, `V1InvoiceSentEvent`, `V1InvoiceUpcomingEvent`, `V1InvoiceUpdatedEvent`, `V1InvoiceVoidedEvent`, `V1InvoiceWillBeDueEvent`, `V1InvoiceitemCreatedEvent`, `V1InvoiceitemDeletedEvent`, `V1IssuingAuthorizationCreatedEvent`, `V1IssuingAuthorizationRequestEvent`, `V1IssuingAuthorizationUpdatedEvent`, `V1IssuingCardCreatedEvent`, `V1IssuingCardUpdatedEvent`, `V1IssuingCardholderCreatedEvent`, `V1IssuingCardholderUpdatedEvent`, `V1IssuingDisputeClosedEvent`, `V1IssuingDisputeCreatedEvent`, `V1IssuingDisputeFundsReinstatedEvent`, `V1IssuingDisputeFundsRescindedEvent`, `V1IssuingDisputeSubmittedEvent`, `V1IssuingDisputeUpdatedEvent`, `V1IssuingPersonalizationDesignActivatedEvent`, `V1IssuingPersonalizationDesignDeactivatedEvent`, `V1IssuingPersonalizationDesignRejectedEvent`, `V1IssuingPersonalizationDesignUpdatedEvent`, `V1IssuingTokenCreatedEvent`, `V1IssuingTokenUpdatedEvent`, `V1IssuingTransactionCreatedEvent`, `V1IssuingTransactionPurchaseDetailsReceiptUpdatedEvent`, `V1IssuingTransactionUpdatedEvent`, `V1MandateUpdatedEvent`, `V1PaymentIntentAmountCapturableUpdatedEvent`, `V1PaymentIntentCanceledEvent`, `V1PaymentIntentCreatedEvent`, `V1PaymentIntentPartiallyFundedEvent`, `V1PaymentIntentPaymentFailedEvent`, `V1PaymentIntentProcessingEvent`, `V1PaymentIntentRequiresActionEvent`, `V1PaymentIntentSucceededEvent`, `V1PaymentLinkCreatedEvent`, `V1PaymentLinkUpdatedEvent`, `V1PaymentMethodAttachedEvent`, `V1PaymentMethodAutomaticallyUpdatedEvent`, `V1PaymentMethodDetachedEvent`, `V1PaymentMethodUpdatedEvent`, `V1PayoutCanceledEvent`, `V1PayoutCreatedEvent`, `V1PayoutFailedEvent`, `V1PayoutPaidEvent`, `V1PayoutReconciliationCompletedEvent`, `V1PayoutUpdatedEvent`, `V1PersonCreatedEvent`, `V1PersonDeletedEvent`, `V1PersonUpdatedEvent`, `V1PlanCreatedEvent`, `V1PlanDeletedEvent`, `V1PlanUpdatedEvent`, `V1PriceCreatedEvent`, `V1PriceDeletedEvent`, `V1PriceUpdatedEvent`, `V1ProductCreatedEvent`, `V1ProductDeletedEvent`, `V1ProductUpdatedEvent`, `V1PromotionCodeCreatedEvent`, `V1PromotionCodeUpdatedEvent`, `V1QuoteAcceptedEvent`, `V1QuoteCanceledEvent`, `V1QuoteCreatedEvent`, `V1QuoteFinalizedEvent`, `V1RadarEarlyFraudWarningCreatedEvent`, `V1RadarEarlyFraudWarningUpdatedEvent`, `V1RefundCreatedEvent`, `V1RefundFailedEvent`, `V1RefundUpdatedEvent`, `V1ReviewClosedEvent`, `V1ReviewOpenedEvent`, `V1SetupIntentCanceledEvent`, `V1SetupIntentCreatedEvent`, `V1SetupIntentRequiresActionEvent`, `V1SetupIntentSetupFailedEvent`, `V1SetupIntentSucceededEvent`, `V1SigmaScheduledQueryRunCreatedEvent`, `V1SourceCanceledEvent`, `V1SourceChargeableEvent`, `V1SourceFailedEvent`, `V1SourceRefundAttributesRequiredEvent`, `V1SubscriptionScheduleAbortedEvent`, `V1SubscriptionScheduleCanceledEvent`, `V1SubscriptionScheduleCompletedEvent`, `V1SubscriptionScheduleCreatedEvent`, `V1SubscriptionScheduleExpiringEvent`, `V1SubscriptionScheduleReleasedEvent`, `V1SubscriptionScheduleUpdatedEvent`, `V1TaxRateCreatedEvent`, `V1TaxRateUpdatedEvent`, `V1TerminalReaderActionFailedEvent`, `V1TerminalReaderActionSucceededEvent`, `V1TerminalReaderActionUpdatedEvent`, `V1TestHelpersTestClockAdvancingEvent`, `V1TestHelpersTestClockCreatedEvent`, `V1TestHelpersTestClockDeletedEvent`, `V1TestHelpersTestClockInternalFailureEvent`, `V1TestHelpersTestClockReadyEvent`, `V1TopupCanceledEvent`, `V1TopupCreatedEvent`, `V1TopupFailedEvent`, `V1TopupReversedEvent`, `V1TopupSucceededEvent`, `V1TransferCreatedEvent`, `V1TransferReversedEvent`, `V1TransferUpdatedEvent`, `V2CoreHealthIssuingAuthorizationRequestErrorsFiringEvent`, and `V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEvent`
  * Add support for thin event `V2CoreClaimableSandboxCreatedEvent` with related object `V2.Core.ClaimableSandbox`
  * Add support for thin events `V2MoneyManagementRecipientVerificationCreatedEvent` and `V2MoneyManagementRecipientVerificationUpdatedEvent` with related object `V2.MoneyManagement.RecipientVerification`
* [#3243](https://github.com/stripe/stripe-dotnet/pull/3243) Update generated code for private-preview
  * Add support for new resource `TransitBalance`, `V2.Reporting.ReportRun`, `V2.Reporting.Report`
  * Add support for `Create` and `Get` methods on resource `V2.Reporting.ReportRun`
  * Add support for `Get` method on resource `V2.Reporting.Report`
  * Add support for `Create` and `Refill` test helper methods on resource `Capital.FinancingOffer`
  * Add support for `AllocatedFunds` on `Charge`, `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, and `PaymentIntentUpdateOptions`
  * Add support for thin events `V2ReportingReportRunCreatedEvent`, `V2ReportingReportRunFailedEvent`, `V2ReportingReportRunSucceededEvent`, and `V2ReportingReportRunUpdatedEvent` with related object `V2.Reporting.ReportRun`

## 49.2.0-alpha.2 - 2025-10-30
* [#3242](https://github.com/stripe/stripe-dotnet/pull/3242) Update generated code for private-preview
  * Add support for `PaymentMethodPreview` on `DelegatedCheckout.RequestedSession`
  * Add support for `OrderId` on `DelegatedCheckout.RequestedSession.OrderDetails`
  * Add support for `Lead` on `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial`, `V2.Core.Account.Identity.Attestations.TermsOfService.CardCreator.Commercial`, `V2CoreAccountConfigurationCardCreatorCapabilitiesCommercialOptions`, and `V2CoreAccountIdentityAttestationsTermsOfServiceCardCreatorCommercialOptions`
  * Add support for `GlobalAccountHolder` on `V2.Core.Account.Identity.Attestations.TermsOfService.CardCreator.Commercial` and `V2CoreAccountIdentityAttestationsTermsOfServiceCardCreatorCommercialOptions`

## 49.2.0-alpha.1 - 2025-10-29
* [#3237](https://github.com/stripe/stripe-dotnet/pull/3237) Update generated code for private-preview
  * Add support for `Tenants` on `Billing.Analytics.MeterUsageRow`
  * Add support for `Transfer` on `ApplicationFee.FeeSource`
  * Add support for `TransitBalancesTotal` on `Balance`
  * Add support for `TenantGroupByKeys` on `BillingAnalyticsMeterUsageMeterOptions`
  * Remove support for `RiskDetails` on `DelegatedCheckout.RequestedSessionCreateOptions`
  * Add support for `RiskDetails` on `DelegatedCheckout.RequestedSessionConfirmOptions`
  * Add support for `AllocatedFunds` on `PaymentIntent`
  * Add support for `ApplicationFeeAmount` on `TransferCreateOptions` and `Transfer`
  * Add support for `ApplicationFee` on `Transfer`
* [#3235](https://github.com/stripe/stripe-dotnet/pull/3235) Update generated code for private-preview
  * Add support for `ReportRefund` method on resource `PaymentRecord`
  * Add support for `RepresentativeDeclaration` on `Account.Company`, `AccountCompanyOptions`, and `TokenAccountCompanyOptions`
  * Add support for `PaymentMethodConfiguration` on `BillingPortalConfigurationFeaturesPaymentMethodUpdateOptions`
  * Add support for `PaymentPortalUrl` on `Charge.PaymentMethodDetails.Rechnung`, `PaymentAttemptRecord.PaymentMethodDetails.Rechnung`, and `PaymentRecord.PaymentMethodDetails.Rechnung`
  * Add support for `Twint` on `Checkout.Session.PaymentMethodOptions` and `CheckoutSessionPaymentMethodOptionsOptions`
  * Add support for `CustomerSheet`, `MobilePaymentElement`, and `TaxIdElement` on `CustomerSession.Components` and `CustomerSessionComponentsOptions`
  * Add support for `Provider` on `Customer.Tax`
  * Add support for `StartingAfter` on `PaymentAttemptRecordListOptions`
  * Add support for `Reference` on `PaymentIntentAmountDetailsLineItem.PaymentMethodOptions.Klarna` and `PaymentIntentAmountDetailsLineItemsPaymentMethodOptionsKlarnaOptions`
  * Add support for `SubscriptionReference` on `PaymentIntentAmountDetailsLineItem.PaymentMethodOptions.Klarna`
  * Add support for `NameCollection` on `PaymentLinkCreateOptions`, `PaymentLinkUpdateOptions`, and `PaymentLink`
  * Add support for `Crypto` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, and `Refund.DestinationDetails`
  * Add support for `MbWay` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
  * Add support for `Custom` on `PaymentMethodCreateOptions` and `PaymentMethod`
  * Add support for `ExcludedPaymentMethodTypes` on `SetupIntentCreateOptions`, `SetupIntentUpdateOptions`, and `SetupIntent`
  * Add support for `Tw` on `Tax.Registration.CountryOptions` and `TaxRegistrationCountryOptionsOptions`
  * Add support for `Gip` on `Terminal.Configuration.Tipping` and `TerminalConfigurationTippingOptions`
  * Add support for `LastSeenAt` on `Terminal.Reader`
  * Add support for `HighRiskActivitiesDescription`, `HighRiskActivities`, `MoneyServicesDescription`, `OperatesInProhibitedCountries`, `ParticipatesInRegulatedActivity`, `PurposeOfFundsDescription`, `PurposeOfFunds`, `RegulatedActivity`, `SourceOfFundsDescription`, and `SourceOfFunds` on `V2.Core.Account.Configuration.Storer` and `V2CoreAccountConfigurationStorerOptions`
  * Add support for `CryptoWallets` on `V2.Core.Account.Configuration.Storer.Capabilities.FinancialAddresses`, `V2.Core.Account.Configuration.Storer.Capabilities.OutboundPayments`, `V2.Core.Account.Configuration.Storer.Capabilities.OutboundTransfers`, `V2CoreAccountConfigurationStorerCapabilitiesFinancialAddressesOptions`, `V2CoreAccountConfigurationStorerCapabilitiesOutboundPaymentsOptions`, and `V2CoreAccountConfigurationStorerCapabilitiesOutboundTransfersOptions`
  * Add support for `Usdc` on `V2.Core.Account.Configuration.Storer.Capabilities.HoldsCurrencies` and `V2CoreAccountConfigurationStorerCapabilitiesHoldsCurrenciesOptions`
  * Add support for `CryptoStorer` on `V2.Core.Account.Identity.Attestations.TermsOfService` and `V2CoreAccountIdentityAttestationsTermsOfServiceOptions`
  * Add support for `ComplianceScreeningDescription` on `V2.Core.Account.Identity.BusinessDetails` and `V2CoreAccountIdentityBusinessDetailsOptions`
  * Add support for `ExternalAmount` on `V2.MoneyManagement.ReceivedCredit` and `V2.MoneyManagement.ReceivedDebit`

## 49.1.0-alpha.4 - 2025-10-23
* [#3231](https://github.com/stripe/stripe-dotnet/pull/3231) Empty commit
* [#3232](https://github.com/stripe/stripe-dotnet/pull/3232) Update generated code for private-preview
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

## 49.1.0-alpha.3 - 2025-10-17
* [#3220](https://github.com/stripe/stripe-dotnet/pull/3220) Update generated code for private-preview
  * Add support for new resources `DelegatedCheckout.RequestedSession` and `Identity.BlocklistEntry`
  * Add support for `Confirm`, `Create`, `Expire`, `Get`, and `Update` methods on resource `DelegatedCheckout.RequestedSession`
  * Add support for `Create`, `Disable`, `Get`, and `List` methods on resource `Identity.BlocklistEntry`
  * Add support for `BlockedByEntry` on `Identity.VerificationReport.Document`, `Identity.VerificationReport.Selfie`, and `Identity.VerificationReportListOptions`

## 49.1.0-alpha.2 - 2025-10-09
* [#3214](https://github.com/stripe/stripe-dotnet/pull/3214) Update generated code for private-preview
  * Release specs are identical.
* [#3218](https://github.com/stripe/stripe-dotnet/pull/3218) Update generated code for private-preview
  * Add support for new resource `PaymentMethodBalance`
  * Add support for `CheckBalance` method on resource `PaymentMethod`
  * Add support for `Benefits` on `Card`, `Charge.PaymentMethodDetails.Card`, `ConfirmationToken.PaymentMethodPreview.Card`, and `PaymentMethod.Card`
  * Add support for `Benefit` on `PaymentIntent.PaymentDetails` and `PaymentIntentPaymentDetailsOptions`
  * Add support for `SetupDetails` on `SetupIntentConfirmOptions`, `SetupIntentCreateOptions`, `SetupIntentUpdateOptions`, and `SetupIntent`
  * Add support for `CardCreator` on `V2.Core.Account.Configuration`, `V2.Core.Account.Identity.Attestations.TermsOfService`, `V2CoreAccountConfigurationOptions`, and `V2CoreAccountIdentityAttestationsTermsOfServiceOptions`
  * Add support for thin events `V2CoreAccountIncludingConfigurationCardCreatorCapabilityStatusUpdatedEvent` and `V2CoreAccountIncludingConfigurationCardCreatorUpdatedEvent` with related object `V2.Core.Account`
  * Remove support for thin events `V1CustomerDiscountCreatedEvent`, `V1CustomerDiscountDeletedEvent`, and `V1CustomerDiscountUpdatedEvent` with related object `Discount`

## 49.1.0-alpha.1 - 2025-10-01
This release changes the pinned API version to `2025-09-30.preview`.

It is built on top of SDK version 49.0.0 and 49.1.0-beta.1 which contain breaking changes. Please review the changelog for these versions if upgrading from older SDK versions.

* ⚠️ [#3188](https://github.com/stripe/stripe-dotnet/pull/3188) ParseThinEvent__Experimental is no longer needed
  * ⚠️ Remove the `StripeClient. ParseThinEvent__Experimental` and `PushedEvent` classes. They've been replaced with `StripeClient.ParseEventNotification` and the *`EventNotification` classes respectively.
* Remove support for resources `V2.Reporting.ReportRun`, `V2.Reporting.Report`
* Remove support for thin events `V2ReportingReportRunCreatedEvent`, `V2ReportingReportRunFailedEvent`, `V2ReportingReportRunSucceededEvent`, and `V2ReportingReportRunUpdatedEvent` with related object `V2.Reporting.ReportRun`
* [#3183](https://github.com/stripe/stripe-dotnet/pull/3183) Update generated code for private-preview
  * Add support for new resource `V2.MoneyManagement.RecipientVerification`
  * Add support for `Acknowledge`, `Create`, `Get`, and `RecipientVerifications` methods on resource `V2.MoneyManagement.RecipientVerification`
  * Add support for `Update` method on resources `V2.Billing.PricingPlanSubscription` and `V2.Billing.ServiceAction`
  * Add support for `CryptoWallets` on `V2.Account.Configuration.RecipientData.Features`, `V2.Core.Account.Configuration.Recipient.Capabilities`, `V2AccountConfigurationRecipientDataFeaturesOptions`, and `V2CoreAccountConfigurationRecipientCapabilitiesOptions`
  * Add support for `LookupKey` on `V2.Billing.CadenceCreateOptions`, `V2.Billing.CadenceUpdateOptions`, and `V2.Billing.Cadence`
  * Add support for `SettingsData` on `V2.Billing.Cadence`
  * Add support for `MonthOfYear` on `V2.Billing.Cadence.BillingCycle.Month` and `V2BillingCadenceBillingCycleMonthOptions`
  * Add support for `ClaimedAt`, `ExpiresAt`, `SandboxDetails`, and `Status` on `V2.Core.ClaimableSandbox`
  * Remove support for `ApiKeys` on `V2.Core.ClaimableSandbox`
  * Add support for `V1EventId` on `V2.Event`
  * Add support for `RecipientVerification` on `V2.MoneyManagement.OutboundPaymentCreateOptions`, `V2.MoneyManagement.OutboundPayment`, `V2.MoneyManagement.OutboundTransferCreateOptions`, and `V2.MoneyManagement.OutboundTransfer`
  * Add support for `CryptoWallet` on `V2.MoneyManagement.PayoutMethod` and `V2MoneyManagementOutboundSetupIntentPayoutMethodDataOptions`
  * Add support for `WillActivateAt` and `WillCancelAt` on `V2.Billing.PricingPlanSubscription.ServicingStatusTransitions` and `V2.Billing.RateCardSubscription.ServicingStatusTransitions`
  * Add support for `CustomPricingUnitDetails` on `V2.Billing.RateCardRate.CustomPricingUnitAmount`, `V2.Billing.ServiceAction.CreditGrant.Amount.CustomPricingUnit`, and `V2.Billing.ServiceAction.CreditGrantPerTenant.Amount.CustomPricingUnit`
  * Add support for `OriginType` on `V2.MoneyManagement.ReceivedDebit.BankTransfer`
  * Add support for `SepaBankAccount` on `V2.MoneyManagement.FinancialAddressCreateOptions`
  * Remove support for `Price` on `V2.Billing.RateCardRateCreateOptions`
  * Add support for `LookupKeys` on `V2.Billing.CadenceListOptions`
  * Change type of `V2.Billing.CadenceCancelOptions.Include`, `V2.Billing.CadenceCreateOptions.Include`, `V2.Billing.CadenceGetOptions.Include`, `V2.Billing.CadenceListOptions.Include`, and `V2.Billing.CadenceUpdateOptions.Include` from `literal('invoice_discount_rules')` to `enum('invoice_discount_rules'|'settings_data')`
  * Remove support for `Customer` and `Type` on `V2BillingCadencePayerOptions`
  * Remove support for `AlertId` on `EventsV2CoreHealthApiErrorResolvedEvent`, `EventsV2CoreHealthApiLatencyResolvedEvent`, `EventsV2CoreHealthAuthorizationRateDropResolvedEvent`, `EventsV2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEvent`, `EventsV2CoreHealthPaymentMethodErrorResolvedEvent`, `EventsV2CoreHealthTrafficVolumeDropResolvedEvent`, and `EventsV2CoreHealthWebhookLatencyResolvedEvent`
  * Add support for thin event `V1AccountUpdatedEvent` with related object `V2.Account`
  * Add support for thin events `V1ApplicationFeeCreatedEvent`, `V1ApplicationFeeRefundedEvent`, `V1BillingPortalConfigurationCreatedEvent`, `V1BillingPortalConfigurationUpdatedEvent`, `V1CapabilityUpdatedEvent`, `V1ChargeCapturedEvent`, `V1ChargeDisputeClosedEvent`, `V1ChargeDisputeCreatedEvent`, `V1ChargeDisputeFundsReinstatedEvent`, `V1ChargeDisputeFundsWithdrawnEvent`, `V1ChargeDisputeUpdatedEvent`, `V1ChargeExpiredEvent`, `V1ChargeFailedEvent`, `V1ChargePendingEvent`, `V1ChargeRefundUpdatedEvent`, `V1ChargeRefundedEvent`, `V1ChargeSucceededEvent`, `V1ChargeUpdatedEvent`, `V1CheckoutSessionAsyncPaymentFailedEvent`, `V1CheckoutSessionAsyncPaymentSucceededEvent`, `V1CheckoutSessionCompletedEvent`, `V1CheckoutSessionExpiredEvent`, `V1ClimateOrderCanceledEvent`, `V1ClimateOrderCreatedEvent`, `V1ClimateOrderDelayedEvent`, `V1ClimateOrderDeliveredEvent`, `V1ClimateOrderProductSubstitutedEvent`, `V1ClimateProductCreatedEvent`, `V1ClimateProductPricingUpdatedEvent`, `V1CouponCreatedEvent`, `V1CouponDeletedEvent`, `V1CouponUpdatedEvent`, `V1CreditNoteCreatedEvent`, `V1CreditNoteUpdatedEvent`, `V1CreditNoteVoidedEvent`, `V1CustomerCreatedEvent`, `V1CustomerDeletedEvent`, `V1CustomerDiscountCreatedEvent`, `V1CustomerDiscountDeletedEvent`, `V1CustomerDiscountUpdatedEvent`, `V1CustomerSubscriptionCreatedEvent`, `V1CustomerSubscriptionDeletedEvent`, `V1CustomerSubscriptionPausedEvent`, `V1CustomerSubscriptionPendingUpdateAppliedEvent`, `V1CustomerSubscriptionPendingUpdateExpiredEvent`, `V1CustomerSubscriptionResumedEvent`, `V1CustomerSubscriptionTrialWillEndEvent`, `V1CustomerSubscriptionUpdatedEvent`, `V1CustomerTaxIdCreatedEvent`, `V1CustomerTaxIdDeletedEvent`, `V1CustomerTaxIdUpdatedEvent`, `V1CustomerUpdatedEvent`, `V1FileCreatedEvent`, `V1FinancialConnectionsAccountCreatedEvent`, `V1FinancialConnectionsAccountDeactivatedEvent`, `V1FinancialConnectionsAccountDisconnectedEvent`, `V1FinancialConnectionsAccountReactivatedEvent`, `V1FinancialConnectionsAccountRefreshedBalanceEvent`, `V1FinancialConnectionsAccountRefreshedOwnershipEvent`, `V1FinancialConnectionsAccountRefreshedTransactionsEvent`, `V1IdentityVerificationSessionCanceledEvent`, `V1IdentityVerificationSessionCreatedEvent`, `V1IdentityVerificationSessionProcessingEvent`, `V1IdentityVerificationSessionRedactedEvent`, `V1IdentityVerificationSessionRequiresInputEvent`, `V1IdentityVerificationSessionVerifiedEvent`, `V1InvoiceCreatedEvent`, `V1InvoiceDeletedEvent`, `V1InvoiceFinalizationFailedEvent`, `V1InvoiceFinalizedEvent`, `V1InvoiceMarkedUncollectibleEvent`, `V1InvoiceOverdueEvent`, `V1InvoiceOverpaidEvent`, `V1InvoicePaidEvent`, `V1InvoicePaymentActionRequiredEvent`, `V1InvoicePaymentFailedEvent`, `V1InvoicePaymentPaidEvent`, `V1InvoicePaymentSucceededEvent`, `V1InvoiceSentEvent`, `V1InvoiceUpcomingEvent`, `V1InvoiceUpdatedEvent`, `V1InvoiceVoidedEvent`, `V1InvoiceWillBeDueEvent`, `V1InvoiceitemCreatedEvent`, `V1InvoiceitemDeletedEvent`, `V1IssuingAuthorizationCreatedEvent`, `V1IssuingAuthorizationRequestEvent`, `V1IssuingAuthorizationUpdatedEvent`, `V1IssuingCardCreatedEvent`, `V1IssuingCardUpdatedEvent`, `V1IssuingCardholderCreatedEvent`, `V1IssuingCardholderUpdatedEvent`, `V1IssuingDisputeClosedEvent`, `V1IssuingDisputeCreatedEvent`, `V1IssuingDisputeFundsReinstatedEvent`, `V1IssuingDisputeFundsRescindedEvent`, `V1IssuingDisputeSubmittedEvent`, `V1IssuingDisputeUpdatedEvent`, `V1IssuingPersonalizationDesignActivatedEvent`, `V1IssuingPersonalizationDesignDeactivatedEvent`, `V1IssuingPersonalizationDesignRejectedEvent`, `V1IssuingPersonalizationDesignUpdatedEvent`, `V1IssuingTokenCreatedEvent`, `V1IssuingTokenUpdatedEvent`, `V1IssuingTransactionCreatedEvent`, `V1IssuingTransactionPurchaseDetailsReceiptUpdatedEvent`, `V1IssuingTransactionUpdatedEvent`, `V1MandateUpdatedEvent`, `V1PaymentIntentAmountCapturableUpdatedEvent`, `V1PaymentIntentCanceledEvent`, `V1PaymentIntentCreatedEvent`, `V1PaymentIntentPartiallyFundedEvent`, `V1PaymentIntentPaymentFailedEvent`, `V1PaymentIntentProcessingEvent`, `V1PaymentIntentRequiresActionEvent`, `V1PaymentIntentSucceededEvent`, `V1PaymentLinkCreatedEvent`, `V1PaymentLinkUpdatedEvent`, `V1PaymentMethodAttachedEvent`, `V1PaymentMethodAutomaticallyUpdatedEvent`, `V1PaymentMethodDetachedEvent`, `V1PaymentMethodUpdatedEvent`, `V1PayoutCanceledEvent`, `V1PayoutCreatedEvent`, `V1PayoutFailedEvent`, `V1PayoutPaidEvent`, `V1PayoutReconciliationCompletedEvent`, `V1PayoutUpdatedEvent`, `V1PersonCreatedEvent`, `V1PersonDeletedEvent`, `V1PersonUpdatedEvent`, `V1PlanCreatedEvent`, `V1PlanDeletedEvent`, `V1PlanUpdatedEvent`, `V1PriceCreatedEvent`, `V1PriceDeletedEvent`, `V1PriceUpdatedEvent`, `V1ProductCreatedEvent`, `V1ProductDeletedEvent`, `V1ProductUpdatedEvent`, `V1PromotionCodeCreatedEvent`, `V1PromotionCodeUpdatedEvent`, `V1QuoteAcceptedEvent`, `V1QuoteCanceledEvent`, `V1QuoteCreatedEvent`, `V1QuoteFinalizedEvent`, `V1RadarEarlyFraudWarningCreatedEvent`, `V1RadarEarlyFraudWarningUpdatedEvent`, `V1RefundCreatedEvent`, `V1RefundFailedEvent`, `V1RefundUpdatedEvent`, `V1ReviewClosedEvent`, `V1ReviewOpenedEvent`, `V1SetupIntentCanceledEvent`, `V1SetupIntentCreatedEvent`, `V1SetupIntentRequiresActionEvent`, `V1SetupIntentSetupFailedEvent`, `V1SetupIntentSucceededEvent`, `V1SigmaScheduledQueryRunCreatedEvent`, `V1SourceCanceledEvent`, `V1SourceChargeableEvent`, `V1SourceFailedEvent`, `V1SourceRefundAttributesRequiredEvent`, `V1SubscriptionScheduleAbortedEvent`, `V1SubscriptionScheduleCanceledEvent`, `V1SubscriptionScheduleCompletedEvent`, `V1SubscriptionScheduleCreatedEvent`, `V1SubscriptionScheduleExpiringEvent`, `V1SubscriptionScheduleReleasedEvent`, `V1SubscriptionScheduleUpdatedEvent`, `V1TaxRateCreatedEvent`, `V1TaxRateUpdatedEvent`, `V1TerminalReaderActionFailedEvent`, `V1TerminalReaderActionSucceededEvent`, `V1TerminalReaderActionUpdatedEvent`, `V1TestHelpersTestClockAdvancingEvent`, `V1TestHelpersTestClockCreatedEvent`, `V1TestHelpersTestClockDeletedEvent`, `V1TestHelpersTestClockInternalFailureEvent`, `V1TestHelpersTestClockReadyEvent`, `V1TopupCanceledEvent`, `V1TopupCreatedEvent`, `V1TopupFailedEvent`, `V1TopupReversedEvent`, `V1TopupSucceededEvent`, `V1TransferCreatedEvent`, `V1TransferReversedEvent`, `V1TransferUpdatedEvent`, `V2CoreHealthIssuingAuthorizationRequestErrorsFiringEvent`, and `V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEvent`
  * Add support for thin event `V2CoreClaimableSandboxCreatedEvent` with related object `V2.Core.ClaimableSandbox`
  * Add support for thin events `V2MoneyManagementRecipientVerificationCreatedEvent` and `V2MoneyManagementRecipientVerificationUpdatedEvent` with related object `V2.MoneyManagement.RecipientVerification`

## 48.6.0-alpha.2 - 2025-09-17
* [#3173](https://github.com/stripe/stripe-dotnet/pull/3173) generate private-preview SDK w/ mid Sept changes
  * Add support for `Get` method on resource `V2.Core.ClaimableSandbox`
  * Add support for `Category` and `Priority` on `V2.Billing.ServiceAction.CreditGrantPerTenant`, `V2.Billing.ServiceAction.CreditGrant`, `V2BillingServiceActionCreditGrantOptions`, and `V2BillingServiceActionCreditGrantPerTenantOptions`
  * Add support for `Invoices` on `EventsV2BillingCadenceBilledEvent`
  * Add support for thin events `V2CoreClaimableSandboxClaimedEvent`, `V2CoreClaimableSandboxExpiredEvent`, `V2CoreClaimableSandboxExpiringEvent`, and `V2CoreClaimableSandboxSandboxDetailsOwnerAccountUpdatedEvent` with related object `V2.Core.ClaimableSandbox`
  * Remove support for thin event `V2BillingCadenceErroredEvent` with related object `V2.Billing.Cadence`

## 48.6.0-alpha.1 - 2025-08-27
* [#3166](https://github.com/stripe/stripe-dotnet/pull/3166) Use the right API version 2025-08-27.preview
* [#3162](https://github.com/stripe/stripe-dotnet/pull/3162) Update generated code for private-preview
  * Add support for `AttachCadence` method on resource `Subscription`
  * Add support for `Currency` and `ExternalCustomerId` on `Billing.AlertTriggered`
  * Add support for `CustomPricingUnit` on `Billing.AlertTriggered`, `Billing.CreditBalanceSummary.Balance.AvailableBalance`, `Billing.CreditBalanceSummary.Balance.LedgerBalance`, `Billing.CreditBalanceTransaction.Credit.Amount`, `Billing.CreditBalanceTransaction.Debit.Amount`, `Billing.CreditGrant.Amount`, and `BillingCreditGrantAmountOptions`
  * Add support for `Customer` on `Billing.AlertListOptions`
  * Change type of `Billing.Alert.AlertType`, `Billing.AlertCreateOptions.AlertType`, and `Billing.AlertListOptions.AlertType` from `literal('usage_threshold')` to `enum('credit_balance_threshold'|'usage_threshold')`
  * Add support for `CreditBalanceThreshold` on `Billing.AlertCreateOptions` and `Billing.Alert`
  * Add support for `BillableItems` on `Billing.CreditGrant.ApplicabilityConfig.Scope`, `BillingCreditBalanceSummaryFilterApplicabilityScopeOptions`, and `BillingCreditGrantApplicabilityConfigScopeOptions`
  * Change type of `Billing.CreditBalanceSummary.Balance.AvailableBalance.Type`, `Billing.CreditBalanceSummary.Balance.LedgerBalance.Type`, `Billing.CreditBalanceTransaction.Credit.Amount.Type`, `Billing.CreditBalanceTransaction.Debit.Amount.Type`, `Billing.CreditGrant.Amount.Type`, and `BillingCreditGrantAmountOptions.Type` from `literal('monetary')` to `enum('custom_pricing_unit'|'monetary')`
  * Add support for `LicenseFeeSubscriptionDetails` and `RateCardSubscriptionDetails` on `InvoiceItem.Parent` and `InvoiceLineItem.Parent`
  * Change type of `InvoiceItem.Parent.Type` from `literal('subscription_details')` to `enum('license_fee_subscription_details'|'rate_card_subscription_details'|'subscription_details')`
  * Add support for `LicenseFeeDetails` and `RateCardRateDetails` on `InvoiceItem.Pricing` and `InvoiceLineItem.Pricing`
  * Change type of `InvoiceItem.Pricing.Type` and `InvoiceLineItem.Pricing.Type` from `literal('price_details')` to `enum('license_fee_details'|'price_details'|'rate_card_rate_details')`
  * Add support for `BillingCadence` on `InvoiceCreatePreviewOptions`, `SubscriptionCreateOptions`, and `Subscription`
  * Add support for `BillingCadenceDetails` on `Invoice.Parent` and `QuotePreviewInvoice.Parent`
  * Add support for new resources `V2.AccountLink`, `V2.Account`, `V2.Billing.BillSettingVersion`, `V2.Billing.BillSetting`, `V2.Billing.Cadence`, `V2.Billing.CollectionSettingVersion`, `V2.Billing.CollectionSetting`, `V2.Billing.CustomPricingUnit`, `V2.Billing.IntentAction`, `V2.Billing.Intent`, `V2.Billing.LicenseFeeSubscription`, `V2.Billing.LicenseFeeVersion`, `V2.Billing.LicenseFee`, `V2.Billing.LicensedItem`, `V2.Billing.MeteredItem`, `V2.Billing.PricingPlanComponent`, `V2.Billing.PricingPlanSubscription`, `V2.Billing.PricingPlanVersion`, `V2.Billing.PricingPlan`, `V2.Billing.Profile`, `V2.Billing.RateCardRate`, `V2.Billing.RateCardSubscription`, `V2.Billing.RateCardVersion`, `V2.Billing.RateCard`, `V2.Billing.ServiceAction`, `V2.Core.ClaimableSandbox`, `V2.Reporting.ReportRun`, `V2.Reporting.Report`, and `V2.Tax.AutomaticRule`
  * Add support for `Create`, `Deactivate`, `Find`, `Get`, and `Update` methods on resource `V2.Tax.AutomaticRule`
  * Add support for `Create` and `Get` methods on resources `V2.Billing.ServiceAction` and `V2.Reporting.ReportRun`
  * Add support for `Get` method on resources `V2.Billing.LicenseFeeSubscription` and `V2.Reporting.Report`
  * Add support for `Create` method on resources `V2.AccountLink` and `V2.Core.ClaimableSandbox`
  * Add support for `Cancel`, `Create`, `Get`, `List`, and `Update` methods on resources `V2.Billing.Cadence` and `V2.Billing.RateCardSubscription`
  * Add support for `Create`, `Get`, `List`, and `Update` methods on resources `V2.Billing.BillSetting`, `V2.Billing.CollectionSetting`, `V2.Billing.CustomPricingUnit`, `V2.Billing.LicenseFee`, `V2.Billing.LicensedItem`, `V2.Billing.MeteredItem`, `V2.Billing.PricingPlan`, `V2.Billing.Profile`, and `V2.Billing.RateCard`
  * Add support for `Get` and `List` methods on resources `V2.Billing.BillSettingVersion`, `V2.Billing.CollectionSettingVersion`, `V2.Billing.IntentAction`, `V2.Billing.LicenseFeeVersion`, `V2.Billing.PricingPlanSubscription`, `V2.Billing.PricingPlanVersion`, and `V2.Billing.RateCardVersion`
  * Add support for `Create`, `Delete`, `Get`, and `List` methods on resource `V2.Billing.RateCardRate`
  * Add support for `Create`, `Delete`, `Get`, `List`, and `Update` methods on resource `V2.Billing.PricingPlanComponent`
  * Add support for `Cancel`, `Commit`, `Create`, `Get`, `List`, `ReleaseReservation`, and `Reserve` methods on resource `V2.Billing.Intent`
  * Add support for `Close`, `Create`, `Get`, `List`, and `Update` methods on resource `V2.Account`
  * Add support for `Changes` on `V2.Event`
  * Add support for thin events `AccountConfigurationRecipientDataAccountLinkCompletedEvent`, `AccountConfigurationRecipientDataFeatureStatusUpdatedEvent`, and `AccountRequirementsUpdatedEvent` with related object `V2.Account`
  * Add support for thin events `V2BillingCadenceBilledEvent`, `V2BillingCadenceCanceledEvent`, `V2BillingCadenceCreatedEvent`, and `V2BillingCadenceErroredEvent` with related object `V2.Billing.Cadence`
  * Add support for thin events `V2BillingLicenseFeeCreatedEvent` and `V2BillingLicenseFeeUpdatedEvent` with related object `V2.Billing.LicenseFee`
  * Add support for thin event `V2BillingLicenseFeeVersionCreatedEvent` with related object `V2.Billing.LicenseFeeVersion`
  * Add support for thin events `V2BillingLicensedItemCreatedEvent` and `V2BillingLicensedItemUpdatedEvent` with related object `V2.Billing.LicensedItem`
  * Add support for thin events `V2BillingMeteredItemCreatedEvent` and `V2BillingMeteredItemUpdatedEvent` with related object `V2.Billing.MeteredItem`
  * Add support for thin events `V2BillingPricingPlanCreatedEvent` and `V2BillingPricingPlanUpdatedEvent` with related object `V2.Billing.PricingPlan`
  * Add support for thin events `V2BillingPricingPlanComponentCreatedEvent` and `V2BillingPricingPlanComponentUpdatedEvent` with related object `V2.Billing.PricingPlanComponent`
  * Add support for thin events `V2BillingPricingPlanSubscriptionCollectionAwaitingCustomerActionEvent`, `V2BillingPricingPlanSubscriptionCollectionCurrentEvent`, `V2BillingPricingPlanSubscriptionCollectionPastDueEvent`, `V2BillingPricingPlanSubscriptionCollectionPausedEvent`, `V2BillingPricingPlanSubscriptionCollectionUnpaidEvent`, `V2BillingPricingPlanSubscriptionServicingActivatedEvent`, `V2BillingPricingPlanSubscriptionServicingCanceledEvent`, and `V2BillingPricingPlanSubscriptionServicingPausedEvent` with related object `V2.Billing.PricingPlanSubscription`
  * Add support for thin event `V2BillingPricingPlanVersionCreatedEvent` with related object `V2.Billing.PricingPlanVersion`
  * Add support for thin events `V2BillingRateCardCreatedEvent` and `V2BillingRateCardUpdatedEvent` with related object `V2.Billing.RateCard`
  * Add support for thin event `V2BillingRateCardRateCreatedEvent` with related object `V2.Billing.RateCardRate`
  * Add support for thin events `V2BillingRateCardSubscriptionActivatedEvent`, `V2BillingRateCardSubscriptionCanceledEvent`, `V2BillingRateCardSubscriptionCollectionAwaitingCustomerActionEvent`, `V2BillingRateCardSubscriptionCollectionCurrentEvent`, `V2BillingRateCardSubscriptionCollectionPastDueEvent`, `V2BillingRateCardSubscriptionCollectionPausedEvent`, `V2BillingRateCardSubscriptionCollectionUnpaidEvent`, `V2BillingRateCardSubscriptionServicingActivatedEvent`, `V2BillingRateCardSubscriptionServicingCanceledEvent`, and `V2BillingRateCardSubscriptionServicingPausedEvent` with related object `V2.Billing.RateCardSubscription`
  * Add support for thin event `V2BillingRateCardVersionCreatedEvent` with related object `V2.Billing.RateCardVersion`
  * Add support for thin events `V2CoreHealthApiErrorFiringEvent`, `V2CoreHealthApiErrorResolvedEvent`, `V2CoreHealthApiLatencyFiringEvent`, `V2CoreHealthApiLatencyResolvedEvent`, `V2CoreHealthAuthorizationRateDropFiringEvent`, `V2CoreHealthAuthorizationRateDropResolvedEvent`, `V2CoreHealthEventGenerationFailureResolvedEvent`, `V2CoreHealthFraudRateIncreasedEvent`, `V2CoreHealthIssuingAuthorizationRequestTimeoutFiringEvent`, `V2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEvent`, `V2CoreHealthPaymentMethodErrorFiringEvent`, `V2CoreHealthPaymentMethodErrorResolvedEvent`, `V2CoreHealthTrafficVolumeDropFiringEvent`, `V2CoreHealthTrafficVolumeDropResolvedEvent`, `V2CoreHealthWebhookLatencyFiringEvent`, and `V2CoreHealthWebhookLatencyResolvedEvent`
  * Add support for thin events `V2ReportingReportRunCreatedEvent`, `V2ReportingReportRunFailedEvent`, `V2ReportingReportRunSucceededEvent`, and `V2ReportingReportRunUpdatedEvent` with related object `V2.Reporting.ReportRun`
  * Add support for error type `RateLimitException`
