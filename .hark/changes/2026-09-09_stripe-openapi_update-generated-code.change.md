---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3444
is_breaking: true
is_stripe_api_change: true
released_in_version: 52.5.0-alpha.3
---

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
