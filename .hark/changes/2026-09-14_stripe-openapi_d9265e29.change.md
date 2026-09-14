---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3446
semver_level: major
is_stripe_api_change: true
---

* ⚠️ Remove support for `NestingDemo` on `AccountSession.Components`
* Add support for `VerificationMethod` on `Checkout.Session.PaymentMethodOptions.BacsDebit` and `CheckoutSessionPaymentMethodOptionsBacsDebitOptions`
* Add support for `Appeal` on `Dispute.Evidence`
* Add support for `BacsDebit` on `Invoice.PaymentSettings.PaymentMethodOptions`, `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions`, `Subscription.PaymentSettings.PaymentMethodOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`
* Add support for `PricingToken` on `InvoiceCreatePreviewOptions`
* Add support for `FundingSourceGroup` on `PaymentAttemptRecord.PaymentMethodDetails.Link` and `PaymentRecord.PaymentMethodDetails.Link`
* Add support for `PayoutMethodOptions` on `PayoutCreateOptions`
* ⚠️ Remove support for `Igic` on `Tax.Registration.CountryOptions.At`, `Tax.Registration.CountryOptions.Be`, `Tax.Registration.CountryOptions.Bg`, `Tax.Registration.CountryOptions.Cy`, `Tax.Registration.CountryOptions.Cz`, `Tax.Registration.CountryOptions.De`, `Tax.Registration.CountryOptions.Dk`, `Tax.Registration.CountryOptions.Ee`, `Tax.Registration.CountryOptions.Fi`, `Tax.Registration.CountryOptions.Fr`, `Tax.Registration.CountryOptions.Gr`, `Tax.Registration.CountryOptions.Hr`, `Tax.Registration.CountryOptions.Hu`, `Tax.Registration.CountryOptions.Ie`, `Tax.Registration.CountryOptions.It`, `Tax.Registration.CountryOptions.Lt`, `Tax.Registration.CountryOptions.Lu`, `Tax.Registration.CountryOptions.Lv`, `Tax.Registration.CountryOptions.Mt`, `Tax.Registration.CountryOptions.Nl`, `Tax.Registration.CountryOptions.Pl`, `Tax.Registration.CountryOptions.Pt`, `Tax.Registration.CountryOptions.Ro`, `Tax.Registration.CountryOptions.Se`, `Tax.Registration.CountryOptions.Si`, and `Tax.Registration.CountryOptions.Sk`
