---
title: Update generated code for private-preview
pr_url: https://github.com/stripe/stripe-dotnet/pull/3415
is_breaking: true
is_stripe_api_change: true
released_in_version: 52.3.0-alpha.1
---

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
