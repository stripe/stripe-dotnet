---
title: API Updates
pr_link: https://github.com/stripe/stripe-dotnet/pull/2474
is_stripe_api_change: true
released_in_version: 39.109.0
---

* Add support for new resources `FinancialConnections.AccountOwner`, `FinancialConnections.AccountOwnership`, `FinancialConnections.Account`, and `FinancialConnections.Session`
* Add support for `FinancialConnections` on `Checkout.SessionPaymentMethodOptionsUsBankAccountOptions`, `Checkout.SessionPaymentMethodOptionsUsBankAccount`, `InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountOptions`, `InvoicePaymentSettingsPaymentMethodOptionsUsBankAccount`, `PaymentIntentPaymentMethodOptionsUsBankAccountOptions`, `PaymentIntentPaymentMethodOptionsUsBankAccount`, `SetupIntentPaymentMethodOptionsUsBankAccountOptions`, `SetupIntentPaymentMethodOptionsUsBankAccount`, `SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccount`
* Add support for `FinancialConnections.Account` on `PaymentIntentPaymentMethodDataUsBankAccountOptions`, `PaymentMethodUsBankAccountOptions`, `PaymentMethodUsBankAccount`, and `SetupIntentPaymentMethodDataUsBankAccountOptions`
