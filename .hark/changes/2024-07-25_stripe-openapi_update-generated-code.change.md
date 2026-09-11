---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/2938
is_stripe_api_change: true
released_in_version: 45.6.0-beta.1
---

⚠️ `InvoicePayment.Charge` and `InvoicePayment.PaymentIntent` were removed in favor of `InvoicePaymentPayment`, which encapsulates both. The Charge and PaymentIntent fields are now found at `InvoicePaymentPayment.Charge` `InvoicePaymentPayment.PaymentIntent`

* Add support for new resources `Billing.AlertTriggered`, `Billing.Alert`, and `Tax.Association`
* Add support for `Activate`, `Archive`, `Create`, `Deactivate`, `Get`, and `List` methods on resource `Alert`
* Add support for `Find` method on resource `Association`
* Add support for `Capital` on `AccountSettingsOptions` and `AccountSettings`
* Add support for `AsyncWorkflows` on `PaymentIntentCaptureOptions`, `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `PaymentIntentDecrementAuthorizationOptions`, `PaymentIntentIncrementAuthorizationOptions`, `PaymentIntentUpdateOptions`, and `PaymentIntent`
* Add support for `Payto` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
* Add support for `DisplayName` on `Treasury.FinancialAccountCreateOptions`, `Treasury.FinancialAccountUpdateOptions`, and `TreasuryFinancialAccount`
