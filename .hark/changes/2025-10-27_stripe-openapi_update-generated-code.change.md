---
title: Update generated code
pr_link: https://github.com/stripe/stripe-dotnet/pull/3230
is_stripe_api_change: true
released_in_version: 49.1.0
---

* Add support for new resources `PaymentAttemptRecord`, `PaymentIntentAmountDetailsLineItem`, and `PaymentRecord`
* Add support for `Get` and `List` methods on resource `PaymentAttemptRecord`
* Add support for `Get`, `ReportPaymentAttemptCanceled`, `ReportPaymentAttemptFailed`, `ReportPaymentAttemptGuaranteed`, `ReportPaymentAttemptInformational`, `ReportPaymentAttempt`, `ReportPayment`, and `ReportRefund` methods on resource `PaymentRecord`
* Add support for `List` method on resource `PaymentIntentAmountDetailsLineItem`
* Add support for `RepresentativeDeclaration` on `Account.Company`, `AccountCompanyOptions`, and `TokenAccountCompanyOptions`
* Add support for `PaymentMethodConfiguration` on `BillingPortalConfigurationFeaturesPaymentMethodUpdateOptions`
* Add support for `Twint` on `Checkout.Session.PaymentMethodOptions` and `CheckoutSessionPaymentMethodOptionsOptions`
* Add support for `PaymentRecordRefund` and `Type` on `CreditNote.Refund` and `CreditNoteRefundOptions`
* Add support for `CustomerSheet` and `MobilePaymentElement` on `CustomerSession.Components` and `CustomerSessionComponentsOptions`
* Add support for `Provider` on `Customer.Tax`
* Add support for `PaymentRecord` on `InvoiceAttachPaymentOptions`, `InvoicePayment.Payment`, and `InvoicePaymentPaymentOptions`
* Change type of `InvoicePaymentPaymentOptions.Type` from `literal('payment_intent')` to `enum('payment_intent'|'payment_record')`
* Add support for `AmountDetails` on `PaymentIntentCaptureOptions`, `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `PaymentIntentIncrementAuthorizationOptions`, and `PaymentIntentUpdateOptions`
* Add support for `PaymentDetails` on `PaymentIntentCaptureOptions`, `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `PaymentIntentIncrementAuthorizationOptions`, `PaymentIntentUpdateOptions`, and `PaymentIntent`
* Add support for `DiscountAmount`, `LineItems`, `Shipping`, and `Tax` on `PaymentIntent.AmountDetails`
* Add support for `NameCollection` on `PaymentLinkCreateOptions`, `PaymentLinkUpdateOptions`, and `PaymentLink`
* Add support for `Crypto` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, and `Refund.DestinationDetails`
* Add support for `MbWay` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
* Add support for `Custom` on `PaymentMethodCreateOptions` and `PaymentMethod`
* Add support for `ExcludedPaymentMethodTypes` on `SetupIntentCreateOptions`, `SetupIntentUpdateOptions`, and `SetupIntent`
* Add support for `Tw` on `Tax.Registration.CountryOptions` and `TaxRegistrationCountryOptionsOptions`
* Add support for `Gip` on `Terminal.Configuration.Tipping` and `TerminalConfigurationTippingOptions`
* Add support for `LastSeenAt` on `Terminal.Reader`
* Add support for `Gt`, `Gte`, `Lt`, `Lte`, and `Types` on `V2.Core.EventListOptions`
* Add support for snapshot event `BalanceSettingsUpdated` with resource `BalanceSettings`
* Add support for snapshot event `InvoicePaymentAttemptRequired` with resource `Invoice`
