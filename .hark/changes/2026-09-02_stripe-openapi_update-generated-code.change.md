---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3438
is_breaking: true
is_stripe_api_change: true
released_in_version: 52.5.0-alpha.2
---

* Add support for new resource `Radar.BillingEvaluation`
* Add support for `Create` method on resource `Radar.BillingEvaluation`
* Add support for `CapitalFinancingManualPayment` on `AccountSession.Components`
* Add support for `SequraPayments` on `Account.Capabilities`
* Add support for `Sequra` on `Charge.PaymentMethodDetails`, `Checkout.Session.PaymentMethodOptions`, `ConfirmationToken.PaymentMethodPreview`, `PaymentAttemptRecord.PaymentMethodDetails`, `PaymentIntent.PaymentMethodOptions`, and `PaymentRecord.PaymentMethodDetails`
* Add support for `PaymentIntentData` on `Checkout.SessionUpdateOptions`
* ⚠️ Change type of `Checkout.Session.PaymentMethodOptions.Bancontact.SetupFutureUsage` from `literal('none')` to `enum('none'|'off_session')`
* Add support for `AddressMatchConfidence` and `NameMatchConfidence` on `Identity.VerificationReport.Email` and `Identity.VerificationReport.Phone`
* Add support for `DomainCountry`, `EmailExistsConfidence`, `ObservedDomainTenureDays`, `ObservedEmailTenureDays`, and `PhoneMatchConfidence` on `Identity.VerificationReport.Email`
* Add support for `Carrier`, `LineType`, and `ObservedPhoneTenureDays` on `Identity.VerificationReport.Phone`
* Add support for `VerificationMethod` on `PaymentIntent.PaymentMethodOptions.BacsDebit`, `PaymentIntentPaymentMethodOptionsBacsDebitOptions`, `SetupIntent.PaymentMethodOptions.BacsDebit`, and `SetupIntentPaymentMethodOptionsBacsDebitOptions`
* Add support for `AadeData` on `PaymentIntentPaymentMethodOptionsCardPresentOptions`
* Add support for `Canceled` on `PaymentRecordReportPaymentAttemptOptions` and `PaymentRecordReportPaymentOptions`
* Add support for `Recurring` on `SharedPayment.GrantedToken.UsageLimits`, `SharedPayment.IssuedToken.UsageLimits`, `SharedPaymentGrantedTokenUsageLimitsOptions`, and `SharedPaymentIssuedTokenUsageLimitsOptions`
* Add support for `PricingToken` on `SubscriptionUpdateOptions`
* ⚠️ Remove support for `CancelAtPeriodEnd` on `Subscription.PendingUpdate`
