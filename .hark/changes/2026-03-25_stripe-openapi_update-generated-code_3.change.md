---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3345
is_breaking: true
is_stripe_api_change: true
released_in_version: 51.1.0-alpha.1
---

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
