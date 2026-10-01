---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3461
semver_level: major
is_stripe_api_change: true
released_in_version: 53.1.0-alpha.1
---

* Add support for new resources `V2.Data.QueryRun`, `V2.Data.ReportRun`, `V2.Data.Report`, `V2.Data.Schema`, `V2.MoneyManagement.EarnedCreditSimulation`, `V2.MoneyManagement.EarnedCredit`, and `V2.Provisioning.ResourceAccessConfiguration`
* Add support for `EarnedCredits` method on resource `V2.MoneyManagement.EarnedCreditSimulation`
* Add support for `Get` and `List` methods on resources `V2.Data.Report`, `V2.Data.Schema`, and `V2.MoneyManagement.EarnedCredit`
* Add support for `Create` and `Get` methods on resources `V2.Data.QueryRun` and `V2.Data.ReportRun`
* Add support for `RevealAccessConfiguration` method on resource `V2.Provisioning.Resource`
* Add support for `RefreshRegulatoryReceipt` method on resource `V2.MoneyManagement.Transaction`
* Add support for `CapitalFinancingManualPayment` on `AccountSessionComponentsOptions`
* ⚠️ Remove support for `AuthorizedContentSecurityPolicy`, `AuthorizedEndpoints`, `AuthorizedPermissions`, and `State` on `Apps.Install`
* Add support for `FinancingDocuments` on `Capital.FinancingOffer`
* Add support for `EnabledPaymentTypes` and `OverdueAmount` on `Capital.FinancingSummary.Details`
* Add support for `CardAccountUpdate` on `Charge.PaymentMethodDetails.Card`
* Add support for `OnBehalfOf` on `Checkout.SessionCreateOptions`
* Add support for `BillingCycleAnchor` on `Checkout.Session.Item.Subscription.TrialSettings.EndBehavior`, `CheckoutSessionItemSubscriptionTrialSettingsEndBehaviorOptions`, `CheckoutSessionSubscriptionDataTrialSettingsEndBehaviorOptions`, `PaymentLink.SubscriptionData.TrialSettings.EndBehavior`, and `PaymentLinkSubscriptionDataTrialSettingsEndBehaviorOptions`
* Add support for `PaymentMethodPreselect` on `Checkout.Session.SavedPaymentMethodOptions` and `CheckoutSessionSavedPaymentMethodOptionsOptions`
* Add support for `Es` on `CustomerCustomerTaxExemptionCreateOptions` and `CustomerTaxExemption`
* ⚠️ Remove support for `FinancialActivity` on `FinancialConnections.Transaction.Classifications`
* Add support for `EnablementDetails` on `Invoice.AutomaticTax` and `QuotePreviewInvoice.AutomaticTax`
* Add support for `ReturnCode` on `PaymentAttemptRecord.PaymentMethodDetails.UsBankAccount` and `PaymentRecord.PaymentMethodDetails.UsBankAccount`
* Add support for `RequestCardAccountUpdate` on `PaymentIntent.PaymentMethodOptions.Card` and `PaymentIntentPaymentMethodOptionsCardOptions`
* ⚠️ Remove support for `Name` on `ProductCatalog.TrialOffer`
* ⚠️ Change type of `Radar.PaymentEvaluation.Signals.EarlyFraudWarning.Score` and `Radar.PaymentEvaluation.Signals.FraudulentDispute.Score` from `number` to `nullable(number)`
* Add support for `Status` on `Tax.FormListOptions` and `Tax.Form`
* Add support for `CardNotPresentTransactions`, `GrossAmountOfTransactionsDecimal`, `MonthlyVolumes`, `PaymentTransactionsCount`, and `StateIncomeTaxWithheld` on `Tax.Form.Us1099K`
* Add support for `CashTips`, `Currency`, and `FederalIncomeTaxWithheld` on `Tax.Form.Us1099K`, `Tax.Form.Us1099Misc`, and `Tax.Form.Us1099Nec`
* Add support for `CropInsuranceProceeds`, `DirectSalesForResale`, `ExcessGoldenParachutePayments`, `FatcaFilingRequired`, `FishPurchasedForResale`, `FishingBoatProceeds`, `GrossProceedsPaidToAnAttorney`, `MedicalAndHealthCarePayments`, `NonqualifiedDeferredCompensation`, `OtherIncome`, `Rents`, `Royalties`, `Section409aDeferrals`, and `SubstitutePayments` on `Tax.Form.Us1099Misc`
* Add support for `OvertimeCompensation`, `StateIncome`, and `StateTaxWithheld` on `Tax.Form.Us1099Misc` and `Tax.Form.Us1099Nec`
* Add support for `DirectSalesIndicator`, `FatcaFilingRequirement`, and `NonemployeeCompensation` on `Tax.Form.Us1099Nec`
* ⚠️ Remove support for `TamperState` on `Terminal.ReaderListOptions`
* ⚠️ Remove support for `Configurations` on `V2.Core.AccountLink.UseCase.RecipientOnboarding`, `V2.Core.AccountLink.UseCase.RecipientUpdate`, `V2CoreAccountLinkUseCaseRecipientOnboardingOptions`, and `V2CoreAccountLinkUseCaseRecipientUpdateOptions`
* Add support for `Ousd` on `V2.Core.Account.Configuration.MoneyManager.Capabilities.BusinessStorage.Inbound`, `V2.Core.Account.Configuration.MoneyManager.Capabilities.BusinessStorage.Outbound`, `V2CoreAccountConfigurationMoneyManagerCapabilitiesBusinessStorageInboundOptions`, and `V2CoreAccountConfigurationMoneyManagerCapabilitiesBusinessStorageOutboundOptions`
* Add support for `Origin` on `V2.Core.Vault.NetworkToken`
* Add support for `Bic` on `V2.MoneyManagement.FinancialAddress.BankAccount.Aba`, `V2.MoneyManagement.FinancialAddress.BankAccount.Cpa`, `V2.MoneyManagement.FinancialAddress.BankAccount.Iban`, and `V2.MoneyManagement.FinancialAddress.BankAccount.SortCode`
* Add support for `Iban` on `V2.MoneyManagement.FinancialAddress.BankAccount.SortCode`
* Add support for `StatementDescriptor` on `V2.MoneyManagement.InboundTransferCreateOptions` and `V2.MoneyManagement.InboundTransfer`
* Add support for `NetworkFeeDetails` on `V2.MoneyManagement.PayoutIntent.EstimatedFee`
* ⚠️ Remove support for `Archived` on `V2.MoneyManagement.PayoutMethod.CryptoWallet`
* Add support for `NetworkDetails` on `V2.MoneyManagement.ReceivedDebit.BankTransfer`
* Add support for `EarnedCredit` on `V2.MoneyManagement.Transaction.Flow` and `V2.MoneyManagement.TransactionEntry.TransactionDetails.Flow`
* Add support for `RegulatoryReceipt` on `V2.MoneyManagement.Transaction`
* ⚠️ Remove support for `RetryUntil` on `V2.Payments.OffSessionPayment.RetryDetails`
* ⚠️ Remove support for `Cvc` on `V2PaymentsOffSessionPaymentPaymentMethodDataCardOptions`
* Add support for `FromResource` on `V2.MoneyManagement.OutboundSetupIntentCreateOptions`
* Change type of `V2CoreVaultNetworkTokenCardOptions.Origin` from `literal('card_on_file')` to `enum('card_on_file'|'wallet')`
* Change type of `V2.Core.Vault.NetworkTokenCreateFromCredentialOptions.Type` and `V2.Core.Vault.NetworkTokenCreateOptions.Type` from `literal('card')` to `enum('card')`
* Change type of `V2.Core.Vault.NetworkTokenGenerateCryptogramOptions.Type` from `literal('token_cryptogram')` to `enum('token_cryptogram')`
* ⚠️ Change type of `V2BillingContractPricingLineActionAddPricingPriceDetailsPricingOverrideOverwritePriceOptions.UnitAmount`, `V2BillingContractPricingLineActionUpdatePricingPriceDetailsPricingOverrideActionAddOverwritePriceOptions.UnitAmount`, and `V2BillingContractPricingLinePricingPriceDetailsPricingOverrideOverwritePriceOptions.UnitAmount` from `string` to `decimal_string`
* ⚠️ Change type of `V2BillingContractPricingOverrideMultiplyPricingOptions.Factor` from `string` to `decimal_string`
* Add support for `BillingSettings` on `V2.Billing.ContractUpdateOptions`
* ⚠️ Remove support for `Account`, `EvaluatedAt`, `FraudulentMerchant`, and `Type` on `EventsV2SignalsAccountSignalFraudulentMerchantReadyEvent`
* Add support for event notifications `V2DataQueryRunCreatedEvent`, `V2DataQueryRunFailedEvent`, `V2DataQueryRunSucceededEvent`, and `V2DataQueryRunUpdatedEvent` with related object `V2.Data.QueryRun`
* Add support for event notifications `V2DataReportRunCreatedEvent`, `V2DataReportRunFailedEvent`, `V2DataReportRunSucceededEvent`, and `V2DataReportRunUpdatedEvent` with related object `V2.Data.ReportRun`
* Add support for event notification `V2MoneyManagementEarnedCreditSucceededEvent` with related object `V2.MoneyManagement.EarnedCredit`
