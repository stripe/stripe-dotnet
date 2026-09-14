---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3036
is_stripe_api_change: true
released_in_version: 47.2.0
---

* Add support for `NetworkAdviceCode` and `NetworkDeclineCode` on `ChargeOutcome`, `InvoiceLastFinalizationError`, `PaymentIntentLastPaymentError`, `SetupAttemptSetupError`, `SetupIntentLastSetupError`, and `StripeError`
* Add support for `CreditsApplicationInvoiceVoided` on `BillingCreditBalanceTransactionCredit`
* Change type of `BillingCreditBalanceTransactionCreditType` from `literal('credits_granted')` to `enum('credits_application_invoice_voided'|'credits_granted')`
* Add support for `AllowRedisplay` on `Card` and `Source`
* Add support for `RegulatedStatus` on `Card`, `ChargePaymentMethodDetailsCard`, `ConfirmationTokenPaymentMethodPreviewCard`, and `PaymentMethodCard`
* Add support for `Funding` on `ChargePaymentMethodDetailsAmazonPay` and `ChargePaymentMethodDetailsRevolutPay`
* Add support for `NetworkTransactionId` on `ChargePaymentMethodDetailsCard`
* Add support for `ReferencePrefix` on `CheckoutSessionPaymentMethodOptionsBacsDebitMandateOptionsOptions`, `CheckoutSessionPaymentMethodOptionsBacsDebitMandateOptions`, `CheckoutSessionPaymentMethodOptionsSepaDebitMandateOptionsOptions`, `CheckoutSessionPaymentMethodOptionsSepaDebitMandateOptions`, `PaymentIntentPaymentMethodOptionsBacsDebitMandateOptionsOptions`, `PaymentIntentPaymentMethodOptionsBacsDebitMandateOptions`, `PaymentIntentPaymentMethodOptionsSepaDebitMandateOptionsOptions`, `PaymentIntentPaymentMethodOptionsSepaDebitMandateOptions`, `SetupIntentPaymentMethodOptionsBacsDebitMandateOptionsOptions`, `SetupIntentPaymentMethodOptionsBacsDebitMandateOptions`, `SetupIntentPaymentMethodOptionsSepaDebitMandateOptionsOptions`, and `SetupIntentPaymentMethodOptionsSepaDebitMandateOptions`
* Add support for `VisaCompliance` on `DisputeEvidenceDetailsEnhancedEligibility`, `DisputeEvidenceEnhancedEvidenceOptions`, and `DisputeEvidenceEnhancedEvidence`
* Add support for `AccountHolderAddress` and `BankAddress` on `FundingInstructionsBankTransferFinancialAddressesIban`, `FundingInstructionsBankTransferFinancialAddressesSortCode`, `FundingInstructionsBankTransferFinancialAddressesSpei`, `FundingInstructionsBankTransferFinancialAddressesZengin`, `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesIban`, `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesSortCode`, `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesSpei`, and `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesZengin`
* Add support for `AccountHolderName` on `FundingInstructionsBankTransferFinancialAddressesSpei` and `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesSpei`
* Add support for `DisabledReason` on `InvoiceAutomaticTax`, `SubscriptionAutomaticTax`, `SubscriptionScheduleDefaultSettingsAutomaticTax`, and `SubscriptionSchedulePhasesAutomaticTax`
* Add support for `TaxId` on `IssuingAuthorizationMerchantData` and `IssuingTransactionMerchantData`
* Add support for `TrialPeriodDays` on `PaymentLinkSubscriptionDataOptions`
* Add support for `Al`, `Am`, `Ao`, `Ba`, `Bb`, `Bs`, `Cd`, `Gn`, `Kh`, `Me`, `Mk`, `Mr`, `Np`, `Pe`, `Sn`, `Sr`, `Tj`, `Ug`, `Uy`, `Zm`, and `Zw` on `TaxRegistrationCountryOptionsOptions` and `TaxRegistrationCountryOptions`
