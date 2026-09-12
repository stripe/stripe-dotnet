---
title: Update generated code for beta
pr_url: https://github.com/stripe/stripe-dotnet/pull/3018
is_stripe_api_change: true
released_in_version: 47.1.0-beta.1
---

* Add support for `TriggerAction` method on resource `PaymentIntent`
* Add support for `IdBankTransferPaymentsBca` and `IdBankTransferPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
* Add support for `BankBcaOnboarding` on `AccountSettingsOptions` and `AccountSettings`
* Add support for `SendMoney` on `AccountSessionComponentsRecipientsFeaturesOptions`
* Add support for `IdBankTransfer` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `InvoicePaymentSettingsPaymentMethodOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `RefundDestinationDetails`, `SetupAttemptPaymentMethodDetails`, `SetupIntentPaymentMethodDataOptions`, `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptions`
* Add support for `Gopay`, `Qris`, and `Shopeepay` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
