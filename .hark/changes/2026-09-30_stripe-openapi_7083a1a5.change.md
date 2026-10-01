---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3437
semver_level: major
is_stripe_api_change: true
released_in_version: 53.1.0-beta.1
---

* Add support for new resources `Radar.BillingEvaluation`, `V2.MoneyManagement.FinancialAddressCreditSimulation`, and `V2.MoneyManagement.FinancialAddressGeneratedMicrodeposits`
* ⚠️ Remove support for resources `V2.FinancialAddressCreditSimulation` and `V2.FinancialAddressGeneratedMicrodeposits`
* Add support for `Create` method on resource `Radar.BillingEvaluation`
* Add support for `List` method on resource `Reserve.Plan`
* Add support for `Credit` method on resource `V2.MoneyManagement.FinancialAddressCreditSimulation`
* Add support for `GenerateMicrodeposits` method on resource `V2.MoneyManagement.FinancialAddressGeneratedMicrodeposits`
* ⚠️ Remove support for `Credit` method on resource `V2.FinancialAddressCreditSimulation`
* ⚠️ Remove support for `GenerateMicrodeposits` method on resource `V2.FinancialAddressGeneratedMicrodeposits`
* Add support for `AfterExpiration` on `BillingPortal.SessionCreateOptions` and `BillingPortal.Session`
* Add support for `SetupCredentialUsage` on `Charge.PaymentMethodDetails.Card`, `PaymentIntent.PaymentMethodOptions.Card`, `PaymentIntentPaymentMethodOptionsCardOptions`, `SetupIntent.PaymentMethodOptions.Card`, and `SetupIntentPaymentMethodOptionsCardOptions`
* Add support for `StoredCredentialUsage` on `Charge.PaymentMethodDetails.Card`, `PaymentAttemptRecord.PaymentMethodDetails.Card`, `PaymentIntent.PaymentMethodOptions.Card`, `PaymentIntentPaymentMethodOptionsCardOptions`, and `PaymentRecord.PaymentMethodDetails.Card`
* Add support for `ExpiresAt` on `CheckoutSessionPaymentMethodOptionsBlikMandateOptionsOptions`, `Subscription.PaymentSettings.PaymentMethodOptions.Blik.MandateOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsBlikMandateOptionsOptions`
* ⚠️ Remove support for `ExpiresAfter` on `CheckoutSessionPaymentMethodOptionsBlikMandateOptionsOptions`, `Subscription.PaymentSettings.PaymentMethodOptions.Blik.MandateOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsBlikMandateOptionsOptions`
* Add support for `PaymentIntentData` on `Checkout.SessionUpdateOptions`
* Add support for `Appeal` on `Dispute.Evidence` and `DisputeEvidenceOptions`
* Add support for `Livemode` on `FxQuote`
* ⚠️ Remove support for `CaptureMethod` on `PaymentIntentPaymentMethodOptionsPaypayOptions`
* Add support for `Active` on `ProductCatalog.TrialOfferCreateOptions`, `ProductCatalog.TrialOfferListOptions`, and `ProductCatalog.TrialOffer`
* Add support for `Nickname` on `ProductCatalog.TrialOfferCreateOptions` and `ProductCatalog.TrialOffer`
* ⚠️ Remove support for `Name` on `ProductCatalog.TrialOfferCreateOptions` and `ProductCatalog.TrialOffer`
* Add support for `StatusDetails` on `QuotePreviewInvoice`
* Add support for `CompanyDetails` and `Reference` on `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions.Billie`
* Add support for `PauseSchedules` on `QuotePreviewSubscriptionSchedule`
* Add support for `Destination` on `Reserve.Hold`, `Reserve.Plan`, and `Reserve.Release`
* Add support for `ManualRelease` on `Reserve.Plan`
* ⚠️ Remove support for `Configurations` on `V2.Core.AccountLink.UseCase.AccountOnboarding`, `V2.Core.AccountLink.UseCase.AccountUpdate`, `V2CoreAccountLinkUseCaseAccountOnboardingOptions`, and `V2CoreAccountLinkUseCaseAccountUpdateOptions`
* Add support for `RelatedObject` and `Request` on `V2.Iam.ActivityLog`
* Add support for `AccountSecurity`, `Authentication`, `Scim`, `Sso`, and `UserProfile` on `V2.Iam.ActivityLog.Details`
* Add support for `DepositInsuranceEligibility` on `V2.MoneyManagement.FinancialAccount.Storage` and `V2MoneyManagementFinancialAccountStorageOptions`
* Add support for `BankAccount` on `V2.MoneyManagement.FinancialAddressCreateOptions` and `V2.MoneyManagement.FinancialAddress`
* Add support for `Type` on `V2.MoneyManagement.FinancialAddress`
* ⚠️ Remove support for `Credentials` and `Currency` on `V2.MoneyManagement.FinancialAddress`
* ⚠️ Remove support for `Level` on `V2.MoneyManagement.InboundTransfer.TransferHistory`
* Add support for `NetworkFeeDetails` on `V2.MoneyManagement.OutboundPaymentQuote.EstimatedFee`
* Add support for `Archived` on `V2.MoneyManagement.PayoutMethod`
* ⚠️ Remove support for `Archived` on `V2.MoneyManagement.PayoutMethod.BankAccount` and `V2.MoneyManagement.PayoutMethod.Card`
* Add support for `AmountReceived` on `V2.MoneyManagement.ReceivedCredit`
* Add support for `OriginatingBankAccount` on `V2.MoneyManagement.ReceivedCredit.BankTransfer`
* ⚠️ Remove support for `OriginType` on `V2.MoneyManagement.ReceivedCredit.BankTransfer`
* Add support for `Identity` on `V2.Signals.AccountActivity.AccountDetails.Data`, `V2.Signals.AccountEvaluation.AccountDetails.Data`, `V2SignalsAccountActivityAccountDetailsDataOptions`, and `V2SignalsAccountEvaluationAccountDetailsDataOptions`
* Add support for `FraudulentWebsite` on `V2.Signals.AccountEvaluation.EvaluatedSignals` and `V2.Signals.AccountSignal`
* Add support for `FraudulentMerchant` on `V2.Signals.AccountSignal`
* ⚠️ Remove support for `CreatedGt`, `CreatedGte`, `CreatedLt`, and `CreatedLte` on `V2.MoneyManagement.AdjustmentListOptions`, `V2.MoneyManagement.InboundTransferListOptions`, `V2.MoneyManagement.ReceivedCreditListOptions`, `V2.MoneyManagement.TransactionEntryListOptions`, and `V2.MoneyManagement.TransactionListOptions`
* ⚠️ Change type of `V2.MoneyManagement.AdjustmentListOptions.Created`, `V2.MoneyManagement.InboundTransferListOptions.Created`, `V2.MoneyManagement.ReceivedCreditListOptions.Created`, `V2.MoneyManagement.TransactionEntryListOptions.Created`, and `V2.MoneyManagement.TransactionListOptions.Created` from `DateTime` to `an object`
* ⚠️ Remove support for `Include` on `V2.MoneyManagement.FinancialAddressGetOptions` and `V2.MoneyManagement.FinancialAddressListOptions`
* Add support for `SettlementCurrency` on `V2.MoneyManagement.FinancialAddressCreateOptions`
* Add support for `Include` on `V2.MoneyManagement.FinancialAccountGetOptions` and `V2.MoneyManagement.FinancialAccountListOptions`
* Add support for `TreasuryTransaction` on `EventsV2MoneyManagementTransactionUpdatedEvent`
* Add support for event notifications `V2SignalsAccountSignalFraudulentMerchantReadyEvent` and `V2SignalsAccountSignalFraudulentWebsiteReadyEvent` with related object `V2.Signals.AccountSignal`
* Add support for error types `InvalidVaultedCredentialException`, `VerificationAttemptFailedException`, `VerificationExpiredException`, and `VerificationNotInitiatedException`
* ⚠️ Remove support for error type `ControlledByDashboardException`
