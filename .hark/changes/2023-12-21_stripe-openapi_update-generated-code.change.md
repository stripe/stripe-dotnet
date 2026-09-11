---
title: Update generated code
pr_link: https://github.com/stripe/stripe-dotnet/pull/2814
is_stripe_api_change: true
released_in_version: 43.8.0
---

* Add support for new resource `FinancialConnections.Transaction`
* Add support for `Get` and `List` methods on resource `Transaction`
* Add support for `Subscribe` and `Unsubscribe` methods on resource `FinancialConnections.Account`
* Add support for `Features` on `AccountSessionComponentsPayoutsOptions`
* Add support for `EditPayoutSchedule`, `InstantPayouts`, and `StandardPayouts` on `AccountSessionComponentsPayoutsFeatures`
* Change type of `CheckoutSessionPaymentMethodOptionsUsBankAccountFinancialConnectionsPrefetchOptions`, `CheckoutSessionPaymentMethodOptionsUsBankAccountFinancialConnectionsPrefetch`, `InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsPrefetchOptions`, `InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsPrefetch`, `PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsPrefetchOptions`, `PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsPrefetch`, `SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsPrefetchOptions`, `SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsPrefetch`, `SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsPrefetchOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsPrefetch` from `literal('balances')` to `enum('balances'|'transactions')`
* Add support for `Subscriptions` and `TransactionRefresh` on `FinancialConnectionsAccount`
* Add support for `NextRefreshAvailableAt` on `FinancialConnectionsAccountBalanceRefresh`
* Add support for `RevolutPay` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
* Add support for `DestinationDetails` on `Refund`
