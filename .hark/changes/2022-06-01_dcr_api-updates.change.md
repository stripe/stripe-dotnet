---
title: API Updates
pr_url: https://github.com/stripe/stripe-dotnet/pull/2498
is_stripe_api_change: true
released_in_version: 39.116.0
---

* Add support for `RadarOptions` on `ChargeCreateOptions`, `Charge`, `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `AccountHolderName`, `AccountNumber`, `AccountType`, `BankCode`, `BankName`, `BranchCode`, and `BranchName` on `FundingInstructionsBankTransferFinancialAddressesZengin` and `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesZengin`
* Change type of `OrderPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferType` and `PaymentIntentPaymentMethodOptionsCustomerBalanceBankTransferType` from `enum` to `literal('jp_bank_transfer')`
* Add support for `Network` on `SetupIntentPaymentMethodOptionsCard`
