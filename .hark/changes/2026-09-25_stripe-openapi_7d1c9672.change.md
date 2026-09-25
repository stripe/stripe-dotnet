---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3437
semver_level: major
is_stripe_api_change: true
---

* Add support for new resource `Radar.BillingEvaluation`
* Add support for `Create` method on resource `Radar.BillingEvaluation`
* Add support for `List` method on resource `Reserve.Plan`
* Add support for `AfterExpiration` on `BillingPortal.SessionCreateOptions` and `BillingPortal.Session`
* Add support for `SetupCredentialUsage` on `Charge.PaymentMethodDetails.Card`, `PaymentIntent.PaymentMethodOptions.Card`, `PaymentIntentPaymentMethodOptionsCardOptions`, `SetupIntent.PaymentMethodOptions.Card`, and `SetupIntentPaymentMethodOptionsCardOptions`
* Add support for `StoredCredentialUsage` on `Charge.PaymentMethodDetails.Card`, `PaymentAttemptRecord.PaymentMethodDetails.Card`, `PaymentIntent.PaymentMethodOptions.Card`, `PaymentIntentPaymentMethodOptionsCardOptions`, and `PaymentRecord.PaymentMethodDetails.Card`
* Add support for `ExpiresAt` on `CheckoutSessionPaymentMethodOptionsBlikMandateOptionsOptions`, `Subscription.PaymentSettings.PaymentMethodOptions.Blik.MandateOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsBlikMandateOptionsOptions`
* ⚠️ Remove support for `ExpiresAfter` on `CheckoutSessionPaymentMethodOptionsBlikMandateOptionsOptions`, `Subscription.PaymentSettings.PaymentMethodOptions.Blik.MandateOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsBlikMandateOptionsOptions`
* Add support for `PaymentIntentData` on `Checkout.SessionUpdateOptions`
* Add support for `Appeal` on `Dispute.Evidence` and `DisputeEvidenceOptions`
* Add support for `Livemode` on `FxQuote`
* ⚠️ Remove support for `CaptureMethod` on `PaymentIntentPaymentMethodOptionsPaypayOptions`
* Add support for `Active` on `ProductCatalog.TrialOfferCreateOptions`, `ProductCatalog.TrialOfferListOptions`, and `ProductCatalog.TrialOffer`
* Add support for `Nickname` on `ProductCatalog.TrialOfferCreateOptions` and `ProductCatalog.TrialOffer`
* ⚠️ Remove support for `Name` on `ProductCatalog.TrialOfferCreateOptions` and `ProductCatalog.TrialOffer`
* Add support for `StatusDetails` on `QuotePreviewInvoice`
* Add support for `CompanyDetails` and `Reference` on `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions.Billie`
* Add support for `PauseSchedules` on `QuotePreviewSubscriptionSchedule`
* Add support for `Destination` on `Reserve.Hold`, `Reserve.Plan`, and `Reserve.Release`
* Add support for `ManualRelease` on `Reserve.Plan`
