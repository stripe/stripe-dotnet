---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3403
is_breaking: true
is_stripe_api_change: true
released_in_version: 52.2.0-alpha.1
---

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
