---
title: Update generated code
pr_link: https://github.com/stripe/stripe-dotnet/pull/3436
is_breaking: true
is_stripe_api_change: true
released_in_version: 52.4.0
---

* Add support for new resource `Billing.FeedbackOption`
* Add support for `Create`, `Deactivate`, `Get`, `List`, and `Update` methods on resource `Billing.FeedbackOption`
* Add support for `PaymentMethodSettings` on `AccountSession.Components` and `AccountSessionComponentsOptions`
* Add support for `FeedbackOptions` on `BillingPortal.Configuration.Features.SubscriptionCancel.CancellationReason` and `BillingPortalConfigurationFeaturesSubscriptionCancelCancellationReasonOptions`
* Add support for `CustomerUpdate` on `BillingPortal.Session.Flow`
* Add support for `FundingSourceGroup` on `Charge.PaymentMethodDetails.Card.Wallet.Link` and `Charge.PaymentMethodDetails.Link`
* Add support for `FundingTypesBlocked` on `Checkout.Session.PaymentMethodOptions.Card.Restrictions` and `CheckoutSessionPaymentMethodOptionsCardRestrictionsOptions`
* Add support for `Metadata` on `ConfirmationToken`
* Add support for `ActiveEntitlements` and `CustomerPortal` on `CustomerSession.Components` and `CustomerSessionComponentsOptions`
* Add support for `Country` on `FinancialConnections.Session.Filters`
* Add support for `FrozenFields` on `InvoiceItem`
* Add support for `Billie` on `Invoice.PaymentSettings.PaymentMethodOptions`, `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `Subscription.PaymentSettings.PaymentMethodOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`
* ⚠️ Remove support for `Cryptogram` on `PaymentAttemptRecord.PaymentMethodDetails.Card.ThreeDSecure` and `PaymentRecord.PaymentMethodDetails.Card.ThreeDSecure`
* Add support for `ApplicationFeeAmount`, `ApplicationFeePercent`, `OnBehalfOf`, and `TransferData` on `PaymentLinkUpdateOptions`
* Add support for `FeedbackOption` on `Subscription.CancellationDetails` and `SubscriptionCancellationDetailsOptions`
* Add support for `Igic` on `Tax.Registration.CountryOptions.At`, `Tax.Registration.CountryOptions.Be`, `Tax.Registration.CountryOptions.Bg`, `Tax.Registration.CountryOptions.Cy`, `Tax.Registration.CountryOptions.Cz`, `Tax.Registration.CountryOptions.De`, `Tax.Registration.CountryOptions.Dk`, `Tax.Registration.CountryOptions.Ee`, `Tax.Registration.CountryOptions.Es`, `Tax.Registration.CountryOptions.Fi`, `Tax.Registration.CountryOptions.Fr`, `Tax.Registration.CountryOptions.Gr`, `Tax.Registration.CountryOptions.Hr`, `Tax.Registration.CountryOptions.Hu`, `Tax.Registration.CountryOptions.Ie`, `Tax.Registration.CountryOptions.It`, `Tax.Registration.CountryOptions.Lt`, `Tax.Registration.CountryOptions.Lu`, `Tax.Registration.CountryOptions.Lv`, `Tax.Registration.CountryOptions.Mt`, `Tax.Registration.CountryOptions.Nl`, `Tax.Registration.CountryOptions.Pl`, `Tax.Registration.CountryOptions.Pt`, `Tax.Registration.CountryOptions.Ro`, `Tax.Registration.CountryOptions.Se`, `Tax.Registration.CountryOptions.Si`, `Tax.Registration.CountryOptions.Sk`, `TaxRegistrationCountryOptionsAtOptions`, `TaxRegistrationCountryOptionsBeOptions`, `TaxRegistrationCountryOptionsBgOptions`, `TaxRegistrationCountryOptionsCyOptions`, `TaxRegistrationCountryOptionsCzOptions`, `TaxRegistrationCountryOptionsDeOptions`, `TaxRegistrationCountryOptionsDkOptions`, `TaxRegistrationCountryOptionsEeOptions`, `TaxRegistrationCountryOptionsEsOptions`, `TaxRegistrationCountryOptionsFiOptions`, `TaxRegistrationCountryOptionsFrOptions`, `TaxRegistrationCountryOptionsGrOptions`, `TaxRegistrationCountryOptionsHrOptions`, `TaxRegistrationCountryOptionsHuOptions`, `TaxRegistrationCountryOptionsIeOptions`, `TaxRegistrationCountryOptionsItOptions`, `TaxRegistrationCountryOptionsLtOptions`, `TaxRegistrationCountryOptionsLuOptions`, `TaxRegistrationCountryOptionsLvOptions`, `TaxRegistrationCountryOptionsMtOptions`, `TaxRegistrationCountryOptionsNlOptions`, `TaxRegistrationCountryOptionsPlOptions`, `TaxRegistrationCountryOptionsPtOptions`, `TaxRegistrationCountryOptionsRoOptions`, `TaxRegistrationCountryOptionsSeOptions`, `TaxRegistrationCountryOptionsSiOptions`, and `TaxRegistrationCountryOptionsSkOptions`
