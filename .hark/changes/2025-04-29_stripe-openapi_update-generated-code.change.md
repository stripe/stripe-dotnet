---
title: Update generated code
pr_link: https://github.com/stripe/stripe-dotnet/pull/3102
is_stripe_api_change: true
released_in_version: 48.1.0
---

* Add support for `MinorityOwnedBusinessDesignation` on `Account.BusinessProfile` and `AccountBusinessProfileOptions`
* Add support for `RegistrationDate` on `Account.Company`, `AccountCompanyOptions`, and `TokenAccountCompanyOptions`
* Add support for `UsCfpbData` on `AccountCreateOptions`, `AccountUpdateOptions`, `Person`, and `TokenPersonOptions`
* Add support for `TaxId` on `Charge.BillingDetails`, `ConfirmationToken.PaymentMethodPreview.BillingDetails`, `ConfirmationTokenPaymentMethodDataBillingDetailsOptions`, `PaymentIntentPaymentMethodDataBillingDetailsOptions`, `PaymentMethod.BillingDetails`, `PaymentMethodBillingDetailsOptions`, and `SetupIntentPaymentMethodDataBillingDetailsOptions`
* Add support for `WalletOptions` on `Checkout.SessionCreateOptions` and `Checkout.Session`
* Add support for `Provider` on `Checkout.Session.AutomaticTax`, `Invoice.AutomaticTax`, and `Quote.AutomaticTax`
* Add support for `PaymentMethodOptions` on `TestHelpersConfirmationTokenCreateOptions`
* Add support for `Installments` on `ConfirmationToken.PaymentMethodOptions.Card`
* Add support for `Context` on `Event`
* Add support for `Billie` on `PaymentIntent.PaymentMethodOptions` and `PaymentIntentPaymentMethodOptionsOptions`
* Add support for `Pix` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
* Add support for `Klarna` on `PaymentMethodDomain`
* Add support for `PendingReason` on `Refund`
* Add support for `Aw`, `Az`, `Bd`, `Bf`, `Bj`, `Cm`, `Cv`, `Et`, `In`, `Kg`, `La`, and `Ph` on `Tax.Registration.CountryOptions` and `TaxRegistrationCountryOptionsOptions`
