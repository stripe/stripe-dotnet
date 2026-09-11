---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/3037
is_stripe_api_change: true
released_in_version: 47.3.0-beta.1
---

* Add support for `Close` method on resource `Treasury.FinancialAccount`
* Add support for `OwnershipExemptionReason` on `AccountCompanyOptions`, `AccountCompany`, and `TokenAccountCompanyOptions`
* Add support for `DirectorshipDeclaration` on `AccountCompany`
* Add support for `AdviceCode` on `ChargeOutcome`, `InvoiceLastFinalizationError`, `PaymentIntentLastPaymentError`, `SetupAttemptSetupError`, `SetupIntentLastSetupError`, and `StripeError`
* Add support for `BrandProduct` on `Card`, `SourceCardPresent`, `SourceCard`, and `SourceThreeDSecure`
* Add support for `Country` on `ChargePaymentMethodDetailsPaypal`, `ConfirmationTokenPaymentMethodPreviewPaypal`, and `PaymentMethodPaypal`
* Add support for `PhoneNumberCollection` on `PaymentLinkUpdateOptions`
* Add support for `Nickname` on `Treasury.FinancialAccountCreateOptions`, `Treasury.FinancialAccountUpdateOptions`, and `TreasuryFinancialAccount`
* Add support for `ForwardingSettings` on `Treasury.FinancialAccountUpdateOptions`
* Add support for `IsDefault` on `TreasuryFinancialAccount`
* Add support for `DestinationPaymentMethodData` on `Treasury.OutboundTransferCreateOptions`
* Add support for `FinancialAccount` on `TreasuryOutboundTransferDestinationPaymentMethodDetails`
* Change type of `TreasuryOutboundTransferDestinationPaymentMethodDetailsType` from `literal('us_bank_account')` to `enum('financial_account'|'us_bank_account')`
* Add support for `OutboundTransfer` on `TreasuryReceivedCreditLinkedFlowsSourceFlowDetails`
