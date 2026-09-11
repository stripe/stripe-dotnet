---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/2933
is_breaking: true
is_stripe_api_change: true
released_in_version: 45.3.0-beta.1
---

* ⚠️ Remove support for `PaymentMethodUpdate` on `CustomerSessionComponentsPaymentElementFeaturesOptions` and `CustomerSessionComponentsPaymentElementFeatures`. Users are expected to completely migrate from using `payment_method_update`.
* Add support for new resource `FinancialConnections.Institution`
* Add support for `Get` and `List` methods on resource `Institution`
* Add support for `Institution` on `CheckoutSessionPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters`, `FinancialConnectionsSessionFiltersOptions`, `FinancialConnectionsSessionFilters`, `InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFiltersOptions`, `InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters`, `PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFiltersOptions`, `PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters`, `SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFiltersOptions`, `SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters`, `SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFiltersOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters`
* Add support for `PaymentMethodAllowRedisplayFilters`, `PaymentMethodRedisplayLimit`, `PaymentMethodRedisplay`, and `PaymentMethodSaveUsage` on `CustomerSessionComponentsPaymentElementFeaturesOptions` and `CustomerSessionComponentsPaymentElementFeatures`
