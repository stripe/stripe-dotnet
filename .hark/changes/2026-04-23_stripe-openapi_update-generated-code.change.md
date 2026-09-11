---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/3367
is_breaking: true
is_stripe_api_change: true
released_in_version: 51.2.0-beta.1
---

* Add support for new resources `SharedPayment.GrantedToken` and `SharedPayment.IssuedToken`
* Add support for `Get` method on resource `SharedPayment.GrantedToken`
* Add support for `Create` and `Revoke` test helper methods on resource `SharedPayment.GrantedToken`
* Add support for `Create`, `Get`, and `Revoke` methods on resource `SharedPayment.IssuedToken`
* Add support for `Blik` on `CheckoutSessionPaymentMethodOptionsOptions`, `Invoice.PaymentSettings.PaymentMethodOptions`, `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions`, `Subscription.PaymentSettings.PaymentMethodOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`
* Add support for `SharedPaymentGrantedToken` on `ConfirmationTokenPaymentMethodDataOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `ValidationErrors` on `Privacy.RedactionJob`
* Add support for `TaxDetails` on `Product`
* ⚠️ Change type of `QuotePreviewInvoice.TotalTaxes.TaxRateDetails.TaxRate` from `string` to `expandable($TaxRate)`
* Add support for `AdmissionsTax`, `AttendanceTax`, `EntertainmentTax`, `GrossReceiptsTax`, `HospitalityTax`, `LuxuryTax`, `ResortTax`, and `TourismTax` on `TaxRegistrationCountryOptionsUsOptions`
* Add support for `Purpose` on `Treasury.OutboundPaymentCreateOptions` and `Treasury.OutboundPayment`
