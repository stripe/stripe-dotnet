---
title: Update generated code for beta
pr_url: https://github.com/stripe/stripe-dotnet/pull/2784
is_stripe_api_change: true
released_in_version: 43.1.0-beta.2
---

* Add support for new resource `Margin`
* Add support for `Create`, `Get`, `List`, and `Update` methods on resource `Margin`
* Add support for `Subsellers` on `CheckoutSessionPaymentMethodOptionsPaypalOptions`, `OrderPaymentSettingsPaymentMethodOptionsPaypalOptions`, `OrderPaymentSettingsPaymentMethodOptionsPaypal`, `PaymentIntentPaymentMethodOptionsPaypalOptions`, `PaymentIntentPaymentMethodOptionsPaypal`, `SetupIntentPaymentMethodOptionsPaypalOptions`, and `SetupIntentPaymentMethodOptionsPaypal`
* Add support for `DefaultMargins` on `InvoiceCreateOptions`, `InvoiceUpdateOptions`, and `Invoice`
* Add support for `TotalMarginAmounts` on `Invoice`
* Add support for `Margins` on `InvoiceItemCreateOptions`, `InvoiceItemUpdateOptions`, and `InvoiceItem`
* Add support for `IsDefault` on `IssuingPersonalizationDesignPreferencesOptions` and `IssuingPersonalizationDesignPreferences`
* Add support for `IsPlatformDefault` on `IssuingPersonalizationDesignPreferencesOptions` and `IssuingPersonalizationDesignPreferences`
* Remove support for `AccountDefault` on `IssuingPersonalizationDesignPreferencesOptions` and `IssuingPersonalizationDesignPreferences`
* Remove support for `PlatformDefault` on `IssuingPersonalizationDesignPreferencesOptions` and `IssuingPersonalizationDesignPreferences`
* Add support for `Liability` on `PaymentLinkAutomaticTaxOptions` and `PaymentLinkAutomaticTax`
* Add support for `Issuer` on `PaymentLinkInvoiceCreationInvoiceDataOptions` and `PaymentLinkInvoiceCreationInvoiceData`
* Add support for `InvoiceSettings` on `PaymentLinkSubscriptionDataOptions` and `PaymentLinkSubscriptionData`
