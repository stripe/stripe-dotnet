---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/2831
is_stripe_api_change: true
released_in_version: 43.12.0
---

* Add support for `Issuer` on `InvoiceCreateOptions`, `InvoiceUpcomingLinesOptions`, `InvoiceUpcomingOptions`, `InvoiceUpdateOptions`, and `Invoice`
* Add support for `Liability` on `InvoiceAutomaticTaxOptions`, `InvoiceAutomaticTax`, `SubscriptionAutomaticTaxOptions`, and `SubscriptionAutomaticTax`
* Add support for `Pin` on `Issuing.CardCreateOptions`
* Add support for `RevocationReason` on `MandatePaymentMethodDetailsBacsDebit`
* Add support for `CustomerBalance` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
* Add support for `InvoiceSettings` on `SubscriptionCreateOptions` and `SubscriptionUpdateOptions`
