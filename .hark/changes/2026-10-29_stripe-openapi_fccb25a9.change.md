---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3474
semver_level: major
is_stripe_api_change: true
---

* Add support for new resources `PaymentPlan`, `V2.Data.QueryRun`, `V2.Data.ReportRun`, `V2.Data.Report`, and `V2.Data.Schema`
* Add support for `Create`, `Get`, `List`, and `Update` methods on resource `PaymentPlan`
* Add support for `Get` and `List` methods on resources `V2.Data.Report` and `V2.Data.Schema`
* Add support for `Create` and `Get` methods on resources `V2.Data.QueryRun` and `V2.Data.ReportRun`
* ⚠️ Remove support for `AcknowledgeConfirmationOfPayee` and `InitiateConfirmationOfPayee` methods on resource `V2.Core.Vault.GbBankAccount`
* Add support for `SettlementCurrencies` on `BalanceSettings.Payments` and `BalanceSettingsPaymentsOptions`
* Add support for `DefaultSettlementCurrency` on `BalanceSettings.Payments`
* Add support for `Wero` on `Charge.PaymentMethodDetails`, `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `PaymentAttemptRecord.PaymentMethodDetails`, `PaymentIntent.PaymentMethodOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `PaymentRecord.PaymentMethodDetails`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `ExternalToken` on `ConfirmationTokenPaymentMethodDataUsBankAccountOptions`, `PaymentIntentPaymentMethodDataUsBankAccountOptions`, `PaymentMethodUsBankAccountOptions`, `SetupIntentPaymentMethodDataUsBankAccountOptions`, and `TreasuryOutboundPaymentDestinationPaymentMethodDataUsBankAccountOptions`
* Add support for `PaymentPlan` on `Invoice`
* ⚠️ Remove support for `DefaultOutboundDestination` on `V2.Core.Account.Configuration.Recipient` and `V2CoreAccountConfigurationRecipientOptions`
* Add support for `CryptoWallets` on `V2.Core.Account.Configuration.Recipient.Capabilities` and `V2CoreAccountConfigurationRecipientCapabilitiesOptions`
* Add support for `Ach`, `Fedwire`, `Fps`, `Rtp`, `Sepa`, and `Swift` on `V2.Core.Account.Configuration.Recipient.Capabilities.BankAccounts` and `V2CoreAccountConfigurationRecipientCapabilitiesBankAccountsOptions`
* ⚠️ Remove support for `Wire` on `V2.Core.Account.Configuration.Recipient.Capabilities.BankAccounts` and `V2CoreAccountConfigurationRecipientCapabilitiesBankAccountsOptions`
* Add support for `ProofOfBusinessPresence` on `V2.Core.Account.Identity.BusinessDetails.Documents`, `V2CoreAccountIdentityBusinessDetailsDocumentsOptions`, and `V2CoreAccountTokenIdentityBusinessDetailsDocumentsOptions`
* Add support for `PartialOutputFile` on `V2.Core.BatchJob.StatusDetails.BatchFailed`
* Add support for `Fingerprint` on `V2.Core.Vault.GbBankAccount`, `V2.Core.Vault.UsBankAccount`, and `V2.MoneyManagement.PayoutMethod.BankAccount`
* Add support for `FedwireFingerprint` on `V2.Core.Vault.UsBankAccount`
* Add support for `Address` on `V2.MoneyManagement.FinancialAddress.BankAccount.Aba`
* ⚠️ Remove support for `AccountHolderAddress` on `V2.MoneyManagement.FinancialAddress.BankAccount.Aba`
* ⚠️ Remove support for `Last4` on `V2.MoneyManagement.FinancialAddress.BankAccount.Aba`, `V2.MoneyManagement.FinancialAddress.BankAccount.Iban`, and `V2.MoneyManagement.FinancialAddress.BankAccount.SortCode`
* ⚠️ Remove support for `Country` on `V2.MoneyManagement.FinancialAddress.BankAccount.Iban`
* Add support for `TaxAmount` on `V2.MoneyManagement.OutboundPaymentQuote.EstimatedFee`
* Add support for `PayoutMethodOptions` on `V2.MoneyManagement.OutboundPayment.To`, `V2.MoneyManagement.OutboundPaymentQuote.To`, `V2.MoneyManagement.OutboundTransfer.To`, `V2MoneyManagementOutboundPaymentQuoteToOptions`, `V2MoneyManagementOutboundPaymentToOptions`, and `V2MoneyManagementOutboundTransferToOptions`
* Add support for `PayoutIntent` and `TrackingDetails` on `V2.MoneyManagement.OutboundPayment`
* Add support for `RecipientVerification` on `V2.MoneyManagement.OutboundPaymentCreateOptions` and `V2.MoneyManagement.OutboundPayment`
* Add support for `CryptoWallet` on `V2.MoneyManagement.PayoutMethod` and `V2MoneyManagementOutboundSetupIntentPayoutMethodDataOptions`
* Add support for `Network` on `V2.MoneyManagement.ReceivedCredit.BankTransfer`
* ⚠️ Remove support for `GbBankAccount`, `SepaBankAccount`, and `UsBankAccount` on `V2.MoneyManagement.ReceivedCredit.BankTransfer`
* ⚠️ Remove support for `Network` on `V2.MoneyManagement.ReceivedCredit.BankTransfer.OriginatingBankAccount.Aba`, `V2.MoneyManagement.ReceivedCredit.BankTransfer.OriginatingBankAccount.Iban`, and `V2.MoneyManagement.ReceivedCredit.BankTransfer.OriginatingBankAccount.SortCode`
* Add support for `FeeBatch` on `V2.MoneyManagement.Transaction.Flow` and `V2.MoneyManagement.TransactionEntry.TransactionDetails.Flow`
* ⚠️ Remove support for `FeeTransaction` on `V2.MoneyManagement.Transaction.Flow` and `V2.MoneyManagement.TransactionEntry.TransactionDetails.Flow`
* Add support for `Metadata` and `RegulatoryReceipt` on `V2.MoneyManagement.Transaction`
* Add support for `ContactEmail` on `V2.Signals.AccountActivity.AccountDetails.Data`, `V2.Signals.AccountEvaluation.AccountDetails.Data`, `V2SignalsAccountActivityAccountDetailsDataOptions`, and `V2SignalsAccountEvaluationAccountDetailsDataOptions`
* Add support for `StatementDescriptor` on `V2.MoneyManagement.OutboundPaymentCreateOptions` and `V2.MoneyManagement.OutboundTransferCreateOptions`
* ⚠️ Remove support for `CreatedGt`, `CreatedGte`, `CreatedLt`, and `CreatedLte` on `V2.MoneyManagement.OutboundPaymentListOptions`
* ⚠️ Change type of `V2.MoneyManagement.OutboundPaymentListOptions.Created` from `DateTime` to `an object`
* ⚠️ Remove support for `SettlementCurrency` on `V2.MoneyManagement.FinancialAddressCreateOptions`
* ⚠️ Remove support for `DepositInsuranceEligibility` on `V2MoneyManagementFinancialAccountStorageOptions`
* Add support for snapshot events `PaymentPlanCreated`, `PaymentPlanInstallmentDue`, `PaymentPlanInstallmentPaid`, `PaymentPlanInstallmentWillBeDue`, and `PaymentPlanUpdated` with resource `PaymentPlan`
* Add support for event notifications `V2DataQueryRunCreatedEvent`, `V2DataQueryRunFailedEvent`, `V2DataQueryRunSucceededEvent`, and `V2DataQueryRunUpdatedEvent` with related object `V2.Data.QueryRun`
* Add support for event notifications `V2DataReportRunCreatedEvent`, `V2DataReportRunFailedEvent`, `V2DataReportRunSucceededEvent`, and `V2DataReportRunUpdatedEvent` with related object `V2.Data.ReportRun`
