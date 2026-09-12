---
title: API Updates
pr_url: https://github.com/stripe/stripe-dotnet/pull/2508
is_stripe_api_change: true
released_in_version: 39.119.0
---

* Add support for `FundCashBalance` test helper method on resource `Customer`
* Add support for `StatementDescriptorPrefixKana` and `StatementDescriptorPrefixKanji` on `AccountSettingsCardPaymentsOptions`, `AccountSettingsCardPayments`, and `AccountSettingsPayments`
* Add support for `StatementDescriptorSuffixKana` and `StatementDescriptorSuffixKanji` on `Checkout.SessionPaymentMethodOptionsCardOptions`, `Checkout.SessionPaymentMethodOptionsCard`, `PaymentIntentPaymentMethodOptionsCardOptions`, and `PaymentIntentPaymentMethodOptionsCard`
* Add support for `TotalExcludingTax` on `CreditNote`
* Change type of `CustomerInvoiceSettingsRenderingOptionsOptions` from `rendering_options_param` to `emptyStringable(rendering_options_param)`
* Add support for `RenderingOptions` on `CustomerInvoiceSettings` and `Invoice`
