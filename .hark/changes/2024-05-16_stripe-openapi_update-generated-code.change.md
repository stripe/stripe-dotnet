---
title: Update generated code
pr_link: https://github.com/stripe/stripe-dotnet/pull/2909
is_stripe_api_change: true
released_in_version: 44.8.0
---

* Add support for `FeeSource` on `ApplicationFee`
* Add support for `NetAvailable` on `BalanceInstantAvailable`
* Add support for `PreferredLocales` on `ChargePaymentMethodDetailsCardPresent`, `ConfirmationTokenPaymentMethodPreviewCardPresent`, and `PaymentMethodCardPresent`
* Add support for `Klarna` on `DisputePaymentMethodDetails`
* Add support for `Archived` and `LookupKey` on `Entitlements.FeatureListOptions`
* Add support for `NoValidAuthorization` on `IssuingDisputeEvidenceOptions` and `IssuingDisputeEvidence`
* Add support for `LossReason` on `IssuingDispute`
* Add support for `Routing` on `PaymentIntentPaymentMethodOptionsCardPresentOptions` and `PaymentIntentPaymentMethodOptionsCardPresent`
* Add support for `ApplicationFeeAmount` and `ApplicationFee` on `Payout`
* Add support for `StripeS700` on `Terminal.ConfigurationCreateOptions`, `Terminal.ConfigurationUpdateOptions`, and `TerminalConfiguration`
