---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3475
semver_level: major
is_stripe_api_change: true
---

* Add support for new resources `Radar.Rule`, `V2.MoneyManagement.FundingSession`, and `V2.MoneyManagement.InboundTransferMandate`
* Add support for `Cancel`, `Create`, `Get`, and `List` methods on resource `V2.MoneyManagement.InboundTransferMandate`
* Add support for `Create` method on resource `V2.MoneyManagement.FundingSession`
* Add support for `ExcludedPayoutDestinations` on `AccountSettingsCapitalOptions`
* Add support for `WeroPayments` on `Account.Capabilities`
* Add support for `Location` and `Reader` on `Charge.PaymentMethodDetails.Swish`, `PaymentAttemptRecord.PaymentMethodDetails.Swish`, and `PaymentRecord.PaymentMethodDetails.Swish`
* Add support for `PaymentSettings` on `Checkout.SessionCreateOptions` and `Checkout.Session`
* Add support for `OnBehalfOf` on `Checkout.Session`
* Add support for `FlexibleCredential` on `Issuing.Authorization`
* Add support for `Fuels` on `Issuing.Transaction.PurchaseDetails`
* Add support for `UsBankAccount` on `PaymentAttemptRecordPaymentMethodDetailsOptions`, `PaymentRecordPaymentMethodDetailsOptions`, `Radar.PaymentEvaluation.PaymentDetails.MoneyMovementDetails`, and `RadarPaymentEvaluationPaymentDetailsMoneyMovementDetailsOptions`
* Change type of `PaymentAttemptRecordPaymentMethodDetailsOptions.Type` and `PaymentRecordPaymentMethodDetailsOptions.Type` from `literal('card')` to `enum('card'|'us_bank_account')`
* Add support for `Fleet` on `PaymentIntent.PaymentMethodOptions.CardPresent` and `PaymentIntentPaymentMethodOptionsCardPresentOptions`
* Add support for `SubscriptionReference` on `PaymentIntent.PaymentMethodOptions.Paypay` and `PaymentIntentPaymentMethodOptionsPaypayOptions`
* Add support for `EnablementDetails` on `QuotePreviewSubscriptionSchedule.DefaultSettings.AutomaticTax`, `QuotePreviewSubscriptionSchedule.Phase.AutomaticTax`, `Subscription.AutomaticTax`, `SubscriptionSchedule.DefaultSettings.AutomaticTax`, and `SubscriptionSchedule.Phase.AutomaticTax`
* Change type of `RadarPaymentEvaluationPaymentDetailsMoneyMovementDetailsOptions.MoneyMovementType` from `literal('card')` to `enum('card'|'us_bank_account')`
* Add support for `Rules` on `Radar.PaymentEvaluation`
* ⚠️ Change type of `Radar.PaymentEvaluation.PaymentDetails.MoneyMovementDetails.MoneyMovementType` from `literal('card')` to `enum('card'|'us_bank_account')`
* Add support for `BankInitiatedReturn` on `Radar.PaymentEvaluation.Signals`
* Add support for `UtilityUsersTax` on `Tax.Registration.CountryOptions.Us`
* Add support for `EnableCustomerCancellation` on `Terminal.ReaderActivateGiftCardOptions`, `Terminal.ReaderCashoutGiftCardOptions`, `Terminal.ReaderCheckGiftCardBalanceOptions`, and `Terminal.ReaderReloadGiftCardOptions`
* Add support for `VippsPayments` on `V2.Core.Account.Configuration.Merchant.Capabilities` and `V2CoreAccountConfigurationMerchantCapabilitiesOptions`
* Add support for `BusinessCustodialStorage` on `V2.Core.Account.Configuration.MoneyManager.Capabilities` and `V2CoreAccountConfigurationMoneyManagerCapabilitiesOptions`
* Add support for `Offramp` and `Onramp` on `V2.Core.Account.Configuration.MoneyManager.Capabilities.OutboundPayments`, `V2.Core.Account.Configuration.MoneyManager.Capabilities.OutboundTransfers`, `V2.Core.Account.Configuration.MoneyManager.Capabilities.ReceivedCredits`, `V2CoreAccountConfigurationMoneyManagerCapabilitiesOutboundPaymentsOptions`, `V2CoreAccountConfigurationMoneyManagerCapabilitiesOutboundTransfersOptions`, and `V2CoreAccountConfigurationMoneyManagerCapabilitiesReceivedCreditsOptions`
* Add support for `Pix` on `V2.Core.Account.Configuration.Recipient.Capabilities`, `V2.MoneyManagement.PayoutMethod`, `V2CoreAccountConfigurationRecipientCapabilitiesOptions`, and `V2MoneyManagementOutboundSetupIntentPayoutMethodDataOptions`
* Add support for `Account` on `V2.MoneyManagement.FinancialAddressCreateOptions`, `V2.MoneyManagement.FinancialAddressListOptions`, and `V2.MoneyManagement.FinancialAddress`
* Add support for `SupportedNetworkDetails` on `V2.MoneyManagement.FinancialAddress.CryptoWallet`
* Add support for `NetworkDetails` on `V2.MoneyManagement.InboundTransferCreateOptions` and `V2.MoneyManagement.InboundTransfer`
* Add support for `BacsDebit` on `V2.MoneyManagement.InboundTransfer.From.PaymentMethod`
* Add support for `Bic` on `V2.MoneyManagement.ReceivedCredit.BankTransfer.OriginatingBankAccount.Aba` and `V2.MoneyManagement.ReceivedCredit.BankTransfer.OriginatingBankAccount.SortCode`
* Add support for `OriginatingCryptoWallet`, `TokenCurrency`, and `TransactionHash` on `V2.MoneyManagement.ReceivedCredit.CryptoWalletTransfer`
* Add support for `Invoices` on `V2.Tax.IntegrationConfigurationUpdateOptions` and `V2.Tax.IntegrationConfiguration`
* ⚠️ Remove support for `Account` on `V2.Risk.InquiryListOptions`
* Add support for `Customer` and `Subscription` on `EventsV1InvoiceUpcomingEvent`
* Add support for event notifications `V2MoneyManagementInboundTransferMandateActivatedEvent`, `V2MoneyManagementInboundTransferMandateCreatedEvent`, `V2MoneyManagementInboundTransferMandateExpiredEvent`, `V2MoneyManagementInboundTransferMandateRefusedEvent`, and `V2MoneyManagementInboundTransferMandateRevokedEvent` with related object `V2.MoneyManagement.InboundTransferMandate`
