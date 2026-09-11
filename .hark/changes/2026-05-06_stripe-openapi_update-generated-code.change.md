---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3378
is_stripe_api_change: true
released_in_version: 51.2.0-alpha.4
---

* Add support for new resource `PaymentLocation`
* Add support for `Create`, `Delete`, `Get`, and `Update` methods on resource `PaymentLocation`
* Add support for `Protections` on `AccountCapabilitiesCardPaymentsOptions` and `Capability`
* Add support for `GiftCard` on `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, `SetupIntentPaymentMethodDataOptions`, and `SharedPayment.GrantedToken.PaymentMethodDetails`
* Add support for `Metadata` on `DelegatedCheckout.RequestedSessionConfirmOptions`
* Add support for `CreditedItems` on `InvoiceItem.ProrationDetails`
* Add support for `NetworkLifecycle` on `Issuing.Dispute`
* Add support for `StatusDetails` on `Subscription`
