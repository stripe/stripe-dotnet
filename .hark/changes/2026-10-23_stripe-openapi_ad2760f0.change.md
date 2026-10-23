---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3483
semver_level: major
is_stripe_api_change: true
---

* Add support for new resources `V2.Core.AccountSessionResource`, `V2.MoneyManagement.FundingIntent`, `V2.MoneyManagement.RewardProgramEnrollment`, `V2.MoneyManagement.RewardProgramRule`, `V2.MoneyManagement.RewardProgram`, and `V2.Risk.Form`
* ⚠️ Remove support for resource `V2.Risk.Inquiry`
* Add support for `Get` and `Update` methods on resource `V2.Risk.Form`
* Add support for `Activate`, `Create`, `Deactivate`, `Get`, and `List` methods on resource `V2.MoneyManagement.RewardProgramEnrollment`
* Add support for `Activate`, `Create`, `Deactivate`, `Get`, `List`, and `Update` methods on resources `V2.MoneyManagement.RewardProgramRule` and `V2.MoneyManagement.RewardProgram`
* Add support for `Cancel`, `Confirm`, `Create`, `Get`, `List`, and `Update` methods on resource `V2.MoneyManagement.FundingIntent`
* Add support for `Create` method on resource `V2.Core.AccountSessionResource`
* ⚠️ Remove support for `Get`, `List`, and `Update` methods on resource `V2.Risk.Inquiry`
* Add support for `RefreshFxQuote` and `RefreshRecipientVerification` methods on resource `V2.MoneyManagement.PayoutIntent`
* ⚠️ Remove support for `FxQuote` method on resource `V2.MoneyManagement.PayoutIntent`
* Add support for `Unarchive` method on resources `V2.Core.Vault.GbBankAccount` and `V2.Core.Vault.UsBankAccount`
* Add support for `PhysicalAddress` on `Account.Company`
* Add support for `TossPay` on `Charge.PaymentMethodDetails`, `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `PaymentAttemptRecord.PaymentMethodDetails`, `PaymentIntent.PaymentMethodOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, `PaymentRecord.PaymentMethodDetails`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `Mandate` on `Charge.PaymentMethodDetails.Paypay`, `PaymentAttemptRecord.PaymentMethodDetails.Paypay`, and `PaymentRecord.PaymentMethodDetails.Paypay`
* Add support for `AutomaticPassThroughFee` on `Checkout.SessionCreateOptions` and `Checkout.Session`
* Add support for `Paypay` on `Checkout.Session.PaymentMethodOptions` and `CheckoutSessionPaymentMethodOptionsOptions`
* Add support for `AdjustableQuantity` on `Checkout.Session.Item.Subscription.Item`
* Add support for `MarketingAttributions` on `CustomerCreateOptions` and `Customer`
* Add support for `DeliveredAt` and `ShippedAt` on `Issuing.Card.Shipping`
* Add support for `MerchantOfRecord` on `PaymentIntent.PaymentDetails.MoneyServices.AccountFunding` and `PaymentIntentPaymentDetailsMoneyServicesAccountFundingOptions`
* Add support for `PaymentMethodData` and `PaymentMethodOptions` on `RefundCreateOptions`
* Add support for `DebitBehavior` on `Subscription.PaymentSettings.PaymentMethodOptions.SepaDebit` and `SubscriptionPaymentSettingsPaymentMethodOptionsSepaDebitOptions`
* Add support for `AlipayPayments`, `ScalapayPayments`, and `UpiPayments` on `V2.Core.Account.Configuration.Merchant.Capabilities` and `V2CoreAccountConfigurationMerchantCapabilitiesOptions`
* ⚠️ Remove support for `DefaultOutboundDestination` on `V2.Core.Account.Configuration.Recipient` and `V2CoreAccountConfigurationRecipientOptions`
* Add support for `Sepa` on `V2.Core.Account.Configuration.Recipient.Capabilities.BankAccounts` and `V2CoreAccountConfigurationRecipientCapabilitiesBankAccountsOptions`
* ⚠️ Remove support for `Instant`, `SepaCredit`, and `Wire` on `V2.Core.Account.Configuration.Recipient.Capabilities.BankAccounts` and `V2CoreAccountConfigurationRecipientCapabilitiesBankAccountsOptions`
* Add support for `Alternatives` on `V2.Core.Account.FutureRequirements` and `V2.Core.Account.Requirements`
* Add support for `ProofOfBusinessPresence` on `V2.Core.Account.Identity.BusinessDetails.Documents`, `V2CoreAccountIdentityBusinessDetailsDocumentsOptions`, and `V2CoreAccountTokenIdentityBusinessDetailsDocumentsOptions`
* Add support for `PartialOutputFile` on `V2.Core.BatchJob.StatusDetails.BatchFailed`
* Add support for `Fingerprint` on `V2.Core.Vault.GbBankAccount`, `V2.Core.Vault.UsBankAccount`, and `V2.MoneyManagement.PayoutMethod.BankAccount`
* Add support for `FedwireFingerprint` on `V2.Core.Vault.UsBankAccount`
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
* Add support for `Address` on `V2.MoneyManagement.FinancialAddress.BankAccount.Aba`
* ⚠️ Remove support for `AccountHolderAddress` on `V2.MoneyManagement.FinancialAddress.BankAccount.Aba`
* ⚠️ Remove support for `Last4` on `V2.MoneyManagement.FinancialAddress.BankAccount.Aba`, `V2.MoneyManagement.FinancialAddress.BankAccount.Iban`, and `V2.MoneyManagement.FinancialAddress.BankAccount.SortCode`
* ⚠️ Remove support for `Country` on `V2.MoneyManagement.FinancialAddress.BankAccount.Iban`
* Add support for `BankAccount`, `Card`, `CryptoWallet`, `Status`, and `Type` on `V2.MoneyManagement.OutboundPayment.TrackingDetails`
* Add support for `RecipientVerification` on `V2.MoneyManagement.PayoutIntent`
* Add support for `FieldsToReview` on `V2.MoneyManagement.PayoutIntent.NextAction.Confirm`
* Add support for `Network` on `V2.MoneyManagement.ReceivedCredit.BankTransfer`
* ⚠️ Remove support for `CaBankAccount`, `EuBankAccount`, `GbBankAccount`, `MxBankAccount`, `SepaBankAccount`, and `UsBankAccount` on `V2.MoneyManagement.ReceivedCredit.BankTransfer`
* ⚠️ Remove support for `Network` on `V2.MoneyManagement.ReceivedCredit.BankTransfer.OriginatingBankAccount.Aba`, `V2.MoneyManagement.ReceivedCredit.BankTransfer.OriginatingBankAccount.BreB`, `V2.MoneyManagement.ReceivedCredit.BankTransfer.OriginatingBankAccount.Clabe`, `V2.MoneyManagement.ReceivedCredit.BankTransfer.OriginatingBankAccount.Cpa`, `V2.MoneyManagement.ReceivedCredit.BankTransfer.OriginatingBankAccount.Iban`, `V2.MoneyManagement.ReceivedCredit.BankTransfer.OriginatingBankAccount.Nip`, `V2.MoneyManagement.ReceivedCredit.BankTransfer.OriginatingBankAccount.Pix`, and `V2.MoneyManagement.ReceivedCredit.BankTransfer.OriginatingBankAccount.SortCode`
* Add support for `PayoutMethod`, `Recipient`, and `VerificationType` on `V2.MoneyManagement.RecipientVerification`
* ⚠️ Change type of `V2.MoneyManagement.RecipientVerification.ConsumedBy` from `string` to `an object`
* Add support for `MatchedBusinessType` and `ProvidedBusinessType` on `V2.MoneyManagement.RecipientVerification.MatchResultDetails`
* Add support for `FeeBatch` on `V2.MoneyManagement.Transaction.Flow` and `V2.MoneyManagement.TransactionEntry.TransactionDetails.Flow`
* ⚠️ Remove support for `FeeTransaction` on `V2.MoneyManagement.Transaction.Flow` and `V2.MoneyManagement.TransactionEntry.TransactionDetails.Flow`
* Add support for `Configuration` on `V2.Provisioning.Resource`
* Add support for `CustomMarketingAction` and `TriggeringSignal` on `V2.Signals.AccountActivityCreateOptions` and `V2.Signals.AccountActivity`
* Add support for `MfaChallenges` on `V2.Signals.AccountActivity.LoginDecision` and `V2SignalsAccountActivityLoginDecisionOptions`
* Add support for `UserAffinity` on `V2.Signals.AccountEvaluation.EvaluatedSignals` and `V2.Signals.AccountSignal`
* ⚠️ Remove support for `UserMerchantFit` on `V2.Signals.AccountEvaluation.EvaluatedSignals` and `V2.Signals.AccountSignal`
* Add support for `Subscriptions` on `V2.Tax.IntegrationConfigurationUpdateOptions` and `V2.Tax.IntegrationConfiguration`
* Add support for `Include` on `V2.Provisioning.ResourceGetOptions`
* ⚠️ Remove support for `Amount` and `From` on `V2.MoneyManagement.PayoutIntentUpdateOptions`
* ⚠️ Remove support for `CreatedGt`, `CreatedGte`, `CreatedLt`, and `CreatedLte` on `V2.MoneyManagement.OutboundPaymentListOptions`
* ⚠️ Change type of `V2.MoneyManagement.OutboundPaymentListOptions.Created` from `DateTime` to `an object`
* ⚠️ Remove support for `DepositInsuranceEligibility` on `V2MoneyManagementFinancialAccountStorageOptions`
* Add support for `Parameters` on `V2.Data.QueryRunCreateOptions`
* Add support for event notifications `V1CustomerDiscountSourceChangedEvent`, `V1EntitlementsActiveEntitlementSummaryEntitlementAddedEvent`, and `V1EntitlementsActiveEntitlementSummaryEntitlementRemovedEvent`
* Add support for event notifications `V1CustomerSubscriptionActiveEvent`, `V1CustomerSubscriptionCancelAtChangedEvent`, `V1CustomerSubscriptionDefaultPaymentMethodChangedEvent`, `V1CustomerSubscriptionIncompleteEvent`, `V1CustomerSubscriptionIncompleteExpiredEvent`, `V1CustomerSubscriptionItemAddedEvent`, `V1CustomerSubscriptionItemPriceChangedEvent`, `V1CustomerSubscriptionItemQuantityChangedEvent`, `V1CustomerSubscriptionItemRemovedEvent`, `V1CustomerSubscriptionItemTaxRatesChangedEvent`, `V1CustomerSubscriptionPastDueEvent`, `V1CustomerSubscriptionTrialingEvent`, and `V1CustomerSubscriptionUnpaidEvent` with related object `Subscription`
* Add support for event notifications `V1FinancialConnectionsAccountBalanceRefreshFailedEvent`, `V1FinancialConnectionsAccountBalanceRefreshSucceededEvent`, `V1FinancialConnectionsAccountInferredBalancesRefreshFailedEvent`, `V1FinancialConnectionsAccountInferredBalancesRefreshSucceededEvent`, `V1FinancialConnectionsAccountOwnershipRefreshFailedEvent`, `V1FinancialConnectionsAccountOwnershipRefreshSucceededEvent`, `V1FinancialConnectionsAccountRiskIntelligenceRefreshFailedEvent`, `V1FinancialConnectionsAccountRiskIntelligenceRefreshSucceededEvent`, `V1FinancialConnectionsAccountTransactionsRefreshFailedEvent`, and `V1FinancialConnectionsAccountTransactionsRefreshSucceededEvent` with related object `FinancialConnections.Account`
* Add support for event notifications `V1InvoiceDiscountAddedEvent`, `V1InvoiceDiscountRemovedEvent`, `V1InvoiceLineItemAddedEvent`, `V1InvoiceLineItemPricingChangedEvent`, `V1InvoiceLineItemQuantityChangedEvent`, and `V1InvoiceLineItemRemovedEvent` with related object `Invoice`
* Add support for event notifications `V1InvoicePaymentCanceledEvent` and `V1InvoicePaymentOpenEvent` with related object `InvoicePayment`
* Add support for event notifications `V1InvoiceitemAmountChangedEvent`, `V1InvoiceitemDiscountAddedEvent`, and `V1InvoiceitemDiscountRemovedEvent` with related object `InvoiceItem`
* Add support for event notifications `V1PriceActivatedEvent`, `V1PriceDeactivatedEvent`, `V1PriceLookupKeyChangedEvent`, and `V1PriceTaxBehaviorChangedEvent` with related object `Price`
* Add support for event notifications `V1ProductActivatedEvent`, `V1ProductDeactivatedEvent`, `V1ProductDefaultPriceChangedEvent`, and `V1ProductTaxCodeChangedEvent` with related object `Product`
* Add support for event notification `V1PromotionCodeFullyRedeemedEvent` with related object `PromotionCode`
* Add support for event notifications `V1SubscriptionSchedulePhaseAddedEvent`, `V1SubscriptionSchedulePhaseDefaultTaxRatesChangedEvent`, `V1SubscriptionSchedulePhaseEndDateChangedEvent`, `V1SubscriptionSchedulePhaseRemovedEvent`, and `V1SubscriptionSchedulePhaseTrialEndChangedEvent` with related object `SubscriptionSchedule`
* Add support for event notifications `V2MoneyManagementFundingIntentCanceledEvent`, `V2MoneyManagementFundingIntentCreatedEvent`, `V2MoneyManagementFundingIntentProcessingEvent`, `V2MoneyManagementFundingIntentRequiresActionEvent`, `V2MoneyManagementFundingIntentRequiresConfirmationEvent`, `V2MoneyManagementFundingIntentSucceededEvent`, `V2MoneyManagementFundingIntentUpdatedEvent`, and `V2MoneyManagementFundingIntentValidatingEvent` with related object `V2.MoneyManagement.FundingIntent`
* Add support for event notifications `V2MoneyManagementPayoutIntentPendingEvent` and `V2MoneyManagementPayoutIntentUpdatedEvent` with related object `V2.MoneyManagement.PayoutIntent`
* Add support for event notifications `V2MoneyManagementRewardProgramRewardEarnedEvent` and `V2MoneyManagementRewardProgramRewardReversedEvent` with related object `V2.MoneyManagement.RewardProgram`
* ⚠️ Remove support for event notifications `V2PaymentsOffSessionPaymentAuthorizationAttemptFailedEvent` and `V2PaymentsOffSessionPaymentAuthorizationAttemptStartedEvent` with related object `V2.Payments.OffSessionPayment`
* Add support for error type `CapabilityNotEnabledException`
