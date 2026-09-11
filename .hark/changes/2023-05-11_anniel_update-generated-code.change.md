---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/2691
is_stripe_api_change: true
released_in_version: 41.17.0-beta.1
---

* Add support for `PayerEmail`, `PayerName`, and `SellerProtection` on `ChargePaymentMethodDetailsPaypal`
* Add support for `CaptureMethod`, `PreferredLocale`, `ReferenceId`, and `SetupFutureUsage` on `CheckoutSessionPaymentMethodOptionsPaypalOptions`
* Add support for `Reference` on `CheckoutSessionPaymentMethodOptionsPaypalOptions`, `OrderPaymentSettingsPaymentMethodOptionsPaypalOptions`, `OrderPaymentSettingsPaymentMethodOptionsPaypal`, `PaymentIntentPaymentMethodOptionsPaypalOptions`, and `PaymentIntentPaymentMethodOptionsPaypal`
* Add support for `RiskCorrelationId` on `CheckoutSessionPaymentMethodOptionsPaypalOptions`, `OrderPaymentSettingsPaymentMethodOptionsPaypalOptions`, and `PaymentIntentPaymentMethodOptionsPaypalOptions`
* Remove support for `BillingAgreementId` and `Currency` on `CheckoutSessionPaymentMethodOptionsPaypalOptions`
* Add support for `Fingerprint`, `PayerId`, and `VerifiedEmail` on `MandatePaymentMethodDetailsPaypal` and `PaymentMethodPaypal`
* Add support for `TaxabilityReason` and `TaxableAmount` on `OrderShippingCostTaxes`, `OrderTotalDetailsBreakdownTaxes`, and `QuotePhaseTotalDetailsBreakdownTaxes`
* Add support for `HeadOffice` on `TaxSettingsUpdateOptions` and `TaxSettings`
