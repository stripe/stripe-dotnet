---
title: Update generated code
pr_link: https://github.com/stripe/stripe-dotnet/pull/3304
is_stripe_api_change: true
released_in_version: 50.4.0
---

* Add support for new resources `Reserve.Hold`, `Reserve.Plan`, and `Reserve.Release`
* Add support for `Location` and `Reader` on `Charge.PaymentMethodDetails.CardPresent`, `Charge.PaymentMethodDetails.InteracPresent`, `ConfirmationToken.PaymentMethodPreview.Card.GeneratedFrom.PaymentMethodDetails.CardPresent`, `PaymentAttemptRecord.PaymentMethodDetails.CardPresent`, `PaymentAttemptRecord.PaymentMethodDetails.InteracPresent`, `PaymentMethod.Card.GeneratedFrom.PaymentMethodDetails.CardPresent`, `PaymentRecord.PaymentMethodDetails.CardPresent`, and `PaymentRecord.PaymentMethodDetails.InteracPresent`
* Add support for `DisplayName` and `ServiceUserNumber` on `Mandate.PaymentMethodDetails.BacsDebit`
* Add support for `TransactionPurpose` on `PaymentIntent.PaymentMethodOptions.UsBankAccount` and `PaymentIntentPaymentMethodOptionsUsBankAccountOptions`
* Add support for `OptionalItems` on `PaymentLinkUpdateOptions`
* Remove support for unused `CardIssuerDecline` on `Radar.PaymentEvaluation.Insights`
* Add support for `PaymentBehavior` on `SubscriptionItemDeleteOptions`
* Add support for `Lk` on `Tax.Registration.CountryOptions` and `TaxRegistrationCountryOptionsOptions`
* Add support for `Cellular` and `StripeS710` on `Terminal.ConfigurationCreateOptions`, `Terminal.ConfigurationUpdateOptions`, and `Terminal.Configuration`
* Add support for snapshot events `ReserveHoldCreated` and `ReserveHoldUpdated` with resource `Reserve.Hold`
* Add support for snapshot events `ReservePlanCreated`, `ReservePlanDisabled`, `ReservePlanExpired`, and `ReservePlanUpdated` with resource `Reserve.Plan`
* Add support for snapshot event `ReserveReleaseCreated` with resource `Reserve.Release`
