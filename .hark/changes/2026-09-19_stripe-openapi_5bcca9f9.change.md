---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3455
semver_level: major
is_stripe_api_change: true
---

* Add support for new resources `V2.MoneyManagement.FinancialAccountWalletExportCredentials`, `V2.MoneyManagement.FinancialAccountWalletExport`, `V2.Provisioning.Eligibility`, `V2.Provisioning.PaymentMethodRequest`, `V2.Provisioning.PaymentProfile`, `V2.Provisioning.Project`, `V2.Provisioning.ProviderConnectionRequest`, `V2.Provisioning.ProviderConnection`, `V2.Provisioning.ProviderServiceDetail`, `V2.Provisioning.Provider`, and `V2.Provisioning.Resource`
* ⚠️ Remove support for resource `Radar.BillingEvaluation`
* ⚠️ Remove support for `Create` method on resource `Radar.BillingEvaluation`
* Add support for `Create`, `Get`, `Link`, `Remove`, `RotateCredentials`, `SubmitInformation`, `Unlink`, and `Update` methods on resource `V2.Provisioning.Resource`
* Add support for `Create`, `Get`, and `SubmitInformation` methods on resource `V2.Provisioning.ProviderConnectionRequest`
* Add support for `List` and `Unlink` methods on resource `V2.Provisioning.ProviderConnection`
* Add support for `Create` method on resources `V2.Provisioning.PaymentMethodRequest` and `V2.Provisioning.Project`
* Add support for `Get` and `Update` methods on resource `V2.Provisioning.PaymentProfile`
* Add support for `Get` method on resource `V2.Provisioning.Eligibility`
* Add support for `ExportCredentials` and `Get` methods on resource `V2.MoneyManagement.FinancialAccountWalletExport`
* Add support for `BlikRecurringPayments` on `Account.Capabilities` and `AccountCapabilitiesOptions`
* Add support for `SequraPayments` on `AccountCapabilitiesOptions`
* Add support for `Capital` on `Account.Settings`
* Add support for `PayoutMethod` on `Balance.InstantAvailable.NetAvailable`
* Add support for `DestinationCurrency` on `BalanceSettings.Payments.Payouts.AutomaticTransferRulesByCurrency` and `BalanceSettingsPaymentsPayoutsAutomaticTransferRulesByCurrencyOptions`
* Add support for `TotalDueAmount` on `Capital.FinancingOffer.AcceptedTerms` and `Capital.FinancingSummary.Details`
* Add support for `IncrementalIntervalTargetAmount` and `StartsAt` on `Capital.FinancingSummary.Details.CurrentRepaymentInterval`
* Add support for `SetupCredentialUsage` on `Charge.PaymentMethodDetails.Card`, `PaymentIntent.PaymentMethodOptions.Card`, `PaymentIntentPaymentMethodOptionsCardOptions`, `SetupIntent.PaymentMethodOptions.Card`, and `SetupIntentPaymentMethodOptionsCardOptions`
* Add support for `StoredCredentialUsage` on `Charge.PaymentMethodDetails.Card`, `PaymentAttemptRecord.PaymentMethodDetails.Card`, `PaymentIntent.PaymentMethodOptions.Card`, `PaymentIntentPaymentMethodOptionsCardOptions`, and `PaymentRecord.PaymentMethodDetails.Card`
* Add support for `PaymentMethodOptions` on `Checkout.SessionApproveOptions`
* Add support for `PaymentReservation` on `Checkout.Session`
* Add support for `Custom` on `Checkout.Session.CurrentAttempt.PaymentMethodDetails`
* Add support for `PaymentMethodPreselect` on `CustomerSession.Components.PaymentElement.Features` and `CustomerSessionComponentsPaymentElementFeaturesOptions`
* Add support for `Bic`, `IbanLast4`, and `Network` on `CustomerCashBalanceTransaction.Funded.BankTransfer.GbBankTransfer`
* Add support for `Appeal` on `DisputeEvidenceOptions`
* Add support for `PreCollectedConsent` on `FinancialConnections.Session`
* Add support for `FinancialActivity` on `FinancialConnections.Transaction.Classifications`
* ⚠️ Remove support for `Credit` on `FinancialConnections.Transaction.Classifications`
* Add support for `InvoicingRules` on `InvoiceItemUpdateOptions`
* ⚠️ Change type of `Mandate.PaymentMethodDetails.Blik.Type` from `enum('off_session'|'on_session')` to `literal('off_session')`
* Add support for `Sequra` on `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentMethodConfigurationUpdateOptions`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `MandateOptions` on `PaymentIntent.PaymentMethodOptions.Blik` and `PaymentIntentPaymentMethodOptionsBlikOptions`
* Change type of `PaymentIntentPaymentMethodOptionsBlikOptions.SetupFutureUsage` from `literal('none')` to `enum('none'|'off_session')`
* ⚠️ Remove support for `CaptureMethod` on `PaymentIntentPaymentMethodOptionsPaypayOptions`
* ⚠️ Change type of `PaymentIntent.PaymentMethodOptions.Blik.SetupFutureUsage` from `literal('none')` to `enum('none'|'off_session')`
* ⚠️ Remove support for `Payto` on `PaymentMethodUpdateOptions`
* Add support for `PayoutMethodOptions` on `Payout`
* Add support for `Blik` on `SetupAttempt.PaymentMethodDetails`, `SetupIntent.PaymentMethodOptions`, and `SetupIntentPaymentMethodOptionsOptions`
* Add support for `ExpiresAt` on `SubscriptionPaymentSettingsPaymentMethodOptionsBlikMandateOptionsOptions`
* ⚠️ Remove support for `ExpiresAfter` on `SubscriptionPaymentSettingsPaymentMethodOptionsBlikMandateOptionsOptions`
* Add support for `CancelAtPeriodEnd` on `Subscription.PendingUpdate`
* Add support for `TamperState` on `Terminal.ReaderListOptions`
* Add support for `CollectionStatusTransitions` and `CollectionStatus` on `V2.Billing.Contract`
* Add support for `Developer` on `V2.Core.Account.Configuration` and `V2CoreAccountConfigurationOptions`
* Add support for `SkipExportableBalances` on `V2.MoneyManagement.FinancialAccount.StatusDetails.Closed.ForwardingSettings` and `V2MoneyManagementFinancialAccountForwardingSettingsOptions`
* Add support for `Crypto` on `V2.MoneyManagement.FinancialAccount.Storage` and `V2MoneyManagementFinancialAccountStorageOptions`
* Add support for `ApplePay` on `V2.MoneyManagement.PayoutMethod` and `V2MoneyManagementOutboundSetupIntentPayoutMethodDataOptions`
* Change type of `V2.MoneyManagement.FinancialAccountGetOptions.Include` and `V2.MoneyManagement.FinancialAccountListOptions.Include` from `literal('payments.balance_by_funds_type')` to `enum('payments.balance_by_funds_type'|'storage.crypto')`
* Add support for `ForwardingSettings` on `V2.MoneyManagement.FinancialAccountUpdateOptions`
* Add support for snapshot events `AppsInstallCreated`, `AppsInstallDeleted`, and `AppsInstallUpdated` with resource `Apps.Install`
* Add support for event notifications `V2BillingContractCollectionBlockedEvent`, `V2BillingContractCollectionCurrentEvent`, `V2BillingContractCollectionPastDueEvent`, and `V2BillingContractCollectionUnpaidEvent` with related object `V2.Billing.Contract`
* Add support for event notifications `V2CoreVaultNetworkTokenActivatedEvent`, `V2CoreVaultNetworkTokenAuthorizationRequirementsChangedEvent`, `V2CoreVaultNetworkTokenDeactivatedEvent`, `V2CoreVaultNetworkTokenDetailsUpdatedEvent`, and `V2CoreVaultNetworkTokenSuspendedEvent` with related object `V2.Core.Vault.NetworkToken`
* Add support for event notifications `V2MoneyManagementFinancialAccountWalletExportCompletedEvent`, `V2MoneyManagementFinancialAccountWalletExportPendingEvent`, and `V2MoneyManagementFinancialAccountWalletExportReadyEvent` with related object `V2.MoneyManagement.FinancialAccount`
* Add support for error type `ServiceUnavailableException`
