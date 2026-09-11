---
title: Update generated code
pr_link: https://github.com/stripe/stripe-dotnet/pull/3044
is_stripe_api_change: true
released_in_version: 47.3.0
---

* Add support for `Close` method on resource `Treasury.FinancialAccount`
* Add support for `PayByBankPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
* Add support for `DirectorshipDeclaration` and `OwnershipExemptionReason` on `AccountCompanyOptions`, `AccountCompany`, and `TokenAccountCompanyOptions`
* Add support for `ProofOfUltimateBeneficialOwnership` on `AccountDocumentsOptions`
* Add support for `FinancialAccount` on `AccountSessionComponentsOptions`, `AccountSessionComponents`, and `TreasuryOutboundTransferDestinationPaymentMethodDetails`
* Add support for `FinancialAccountTransactions`, `IssuingCard`, and `IssuingCardsList` on `AccountSessionComponentsOptions` and `AccountSessionComponents`
* Add support for `AdviceCode` on `ChargeOutcome`, `InvoiceLastFinalizationError`, `PaymentIntentLastPaymentError`, `SetupAttemptSetupError`, `SetupIntentLastSetupError`, and `StripeError`
* Add support for `PayByBank` on `ChargePaymentMethodDetails`, `CheckoutSessionPaymentMethodOptionsOptions`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethodUpdateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `Country` on `ChargePaymentMethodDetailsPaypal`, `ConfirmationTokenPaymentMethodPreviewPaypal`, and `PaymentMethodPaypal`
* Add support for `Discounts` on `CheckoutSession`
* Add support for `PhoneNumberCollection` on `PaymentLinkUpdateOptions`
* Add support for `Jpy` on `TerminalConfigurationTippingOptions` and `TerminalConfigurationTipping`
* Add support for `Nickname` on `Treasury.FinancialAccountCreateOptions`, `Treasury.FinancialAccountUpdateOptions`, and `TreasuryFinancialAccount`
* Add support for `ForwardingSettings` on `Treasury.FinancialAccountUpdateOptions`
* Add support for `IsDefault` on `TreasuryFinancialAccount`
* Add support for `DestinationPaymentMethodData` on `Treasury.OutboundTransferCreateOptions`
* Change type of `TreasuryOutboundTransferDestinationPaymentMethodDetailsType` from `literal('us_bank_account')` to `enum('financial_account'|'us_bank_account')`
* Add support for `OutboundTransfer` on `TreasuryReceivedCreditLinkedFlowsSourceFlowDetails`
