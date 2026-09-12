---
title: API Updates
pr_url: https://github.com/stripe/stripe-dotnet/pull/2503
is_stripe_api_change: true
released_in_version: 39.118.0
---

* Add support for `Treasury` on `AccountSettingsOptions` and `AccountSettings`
* Add support for `RenderingOptions` on `CustomerInvoiceSettingsOptions`
* Add support for `EuBankTransfer` on `CustomerBankTransferOptions`, `InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferOptions`, `InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer`, `OrderPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferOptions`, `OrderPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer`, `PaymentIntentPaymentMethodOptionsCustomerBalanceBankTransferOptions`, `PaymentIntentPaymentMethodOptionsCustomerBalanceBankTransfer`, `SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer`
* Change type of `CustomerBankTransferRequestedAddressTypesOptions` from `literal('zengin')` to `enum('iban'|'sort_code'|'spei'|'zengin')`
* Change type of `CustomerBankTransferTypeOptions`, `OrderPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferTypeOptions`, `OrderPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferType`, `PaymentIntentNextActionDisplayBankTransferInstructionsType`, `PaymentIntentPaymentMethodOptionsCustomerBalanceBankTransferTypeOptions`, and `PaymentIntentPaymentMethodOptionsCustomerBalanceBankTransferType` from `literal('jp_bank_transfer')` to `enum('eu_bank_transfer'|'gb_bank_transfer'|'jp_bank_transfer'|'mx_bank_transfer')`
* Add support for `Iban`, `SortCode`, and `Spei` on `FundingInstructionsBankTransferFinancialAddresses` and `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddresses`
* Change type of `OrderPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferRequestedAddressTypesOptions`, `OrderPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferRequestedAddressTypes`, `PaymentIntentPaymentMethodOptionsCustomerBalanceBankTransferRequestedAddressTypesOptions`, and `PaymentIntentPaymentMethodOptionsCustomerBalanceBankTransferRequestedAddressTypes` from `literal('zengin')` to `enum`
* Add support for `CustomUnitAmount` on `PriceCreateOptions` and `Price`
