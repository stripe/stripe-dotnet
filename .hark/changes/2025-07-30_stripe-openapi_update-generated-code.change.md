---
title: Update generated code
pr_link: https://github.com/stripe/stripe-dotnet/pull/3151
is_stripe_api_change: true
released_in_version: 48.4.0
---

* Add support for `InstantPayoutsPromotion` on `AccountSession.Components` and `AccountSessionComponentsOptions`
* Add support for `AdjustableQuantity` on `BillingPortal.Configuration.Features.SubscriptionUpdate.Products` and `BillingPortalConfigurationFeaturesSubscriptionUpdateProductsOptions`
* Add support for `TransactionId` on `Charge.PaymentMethodDetails.Cashapp`
* Add support for `OriginContext` on `Checkout.SessionCreateOptions` and `Checkout.Session`
* Add support for `Template` on `Checkout.Session.InvoiceCreation.InvoiceData.RenderingOptions`, `CheckoutSessionInvoiceCreationInvoiceDataRenderingOptionsOptions`, `PaymentLink.InvoiceCreation.InvoiceData.RenderingOptions`, and `PaymentLinkInvoiceCreationInvoiceDataRenderingOptionsOptions`
* Add support for `SetupFutureUsage` on `Checkout.Session.PaymentMethodOptions.Pix` and `CheckoutSessionPaymentMethodOptionsPixOptions`
* Add support for `Duration` on `InvoiceScheduleDetailsPhaseOptions` and `SubscriptionSchedulePhaseOptions`
* Add support for `PriceData` on `PaymentLinkLineItemOptions`
* Add support for `Standard` on `Tax.Registration.CountryOptions.Ae`, `Tax.Registration.CountryOptions.Au`, `Tax.Registration.CountryOptions.Ch`, `Tax.Registration.CountryOptions.Gb`, `Tax.Registration.CountryOptions.Jp`, `Tax.Registration.CountryOptions.No`, `Tax.Registration.CountryOptions.Nz`, `Tax.Registration.CountryOptions.Sg`, `TaxRegistrationCountryOptionsAeOptions`, `TaxRegistrationCountryOptionsAlOptions`, `TaxRegistrationCountryOptionsAoOptions`, `TaxRegistrationCountryOptionsAuOptions`, `TaxRegistrationCountryOptionsAwOptions`, `TaxRegistrationCountryOptionsBaOptions`, `TaxRegistrationCountryOptionsBbOptions`, `TaxRegistrationCountryOptionsBdOptions`, `TaxRegistrationCountryOptionsBfOptions`, `TaxRegistrationCountryOptionsBhOptions`, `TaxRegistrationCountryOptionsBsOptions`, `TaxRegistrationCountryOptionsCdOptions`, `TaxRegistrationCountryOptionsChOptions`, `TaxRegistrationCountryOptionsEtOptions`, `TaxRegistrationCountryOptionsGbOptions`, `TaxRegistrationCountryOptionsGnOptions`, `TaxRegistrationCountryOptionsIsOptions`, `TaxRegistrationCountryOptionsJpOptions`, `TaxRegistrationCountryOptionsMeOptions`, `TaxRegistrationCountryOptionsMkOptions`, `TaxRegistrationCountryOptionsMrOptions`, `TaxRegistrationCountryOptionsNoOptions`, `TaxRegistrationCountryOptionsNzOptions`, `TaxRegistrationCountryOptionsOmOptions`, `TaxRegistrationCountryOptionsRsOptions`, `TaxRegistrationCountryOptionsSgOptions`, `TaxRegistrationCountryOptionsSrOptions`, `TaxRegistrationCountryOptionsUyOptions`, `TaxRegistrationCountryOptionsZaOptions`, and `TaxRegistrationCountryOptionsZwOptions`
* Add support for `Aed`, `Bgn`, `Huf`, and `Ron` on `Terminal.Configuration.Tipping` and `TerminalConfigurationTippingOptions`
