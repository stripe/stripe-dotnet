---
title: "Generated changes from [#3333](https://github.com/stripe/stripe-dotnet/pull/3333), [#3341](https://github.com/stripe/stripe-dotnet/pull/3341), [#3350](https://github.com/stripe/stripe-dotnet/pull/3350), [#3343](https://github.com/stripe/stripe-dotnet/pull/3343)"
is_breaking: true
is_stripe_api_change: true
section: ⚠️ Breaking changes due to changes in the Stripe API
released_in_version: 51.0.0
---

* Add support for `UpiPayments` on `Account.Capabilities` and `AccountCapabilitiesOptions`
* Add support for `Upi` on `Charge.PaymentMethodDetails`, `Checkout.Session.PaymentMethodOptions`, `CheckoutSessionPaymentMethodOptionsOptions`, `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `Mandate.PaymentMethodDetails`, `PaymentAttemptRecord.PaymentMethodDetails`, `PaymentIntent.PaymentMethodOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `PaymentRecord.PaymentMethodDetails`, `SetupAttempt.PaymentMethodDetails`, `SetupIntent.PaymentMethodOptions`, `SetupIntentPaymentMethodDataOptions`, and `SetupIntentPaymentMethodOptionsOptions`
* Add support for `IntegrationIdentifier` on `Checkout.SessionCreateOptions` and `Checkout.Session`
* Add support for `Crypto` on `CheckoutSessionPaymentMethodOptionsOptions`
* Add support for `PendingInvoiceItemInterval` on `CheckoutSessionSubscriptionDataOptions`
* Add support for `Metadata` on `CreditNoteLineItem` and `CreditNoteLineOptions`
* Add support for `QuantityDecimal` on `InvoiceInvoiceItemOptions`, `InvoiceItemCreateOptions`, `InvoiceItemUpdateOptions`, `InvoiceItem`, `InvoiceLineItemUpdateOptions`, `InvoiceLineItem`, and `InvoiceLineOptions`
* ⚠️ Add support for `Level` on `IssuingAuthorizationRiskAssessmentCardTestingRiskOptions` and `IssuingAuthorizationRiskAssessmentMerchantDisputeRiskOptions`
* ⚠️ Remove support for `RiskLevel` on `IssuingAuthorizationRiskAssessmentCardTestingRiskOptions` and `IssuingAuthorizationRiskAssessmentMerchantDisputeRiskOptions`
* Add support for `LifecycleControls` on `Issuing.CardCreateOptions` and `Issuing.Card`
* ⚠️ Change type of `PaymentAttemptRecord.PaymentMethodDetails.Card.ExpMonth` and `PaymentRecord.PaymentMethodDetails.Card.ExpMonth` from `longInteger` to `nullable(longInteger)`
* ⚠️ Change type of `PaymentAttemptRecord.PaymentMethodDetails.Card.ExpYear` and `PaymentRecord.PaymentMethodDetails.Card.ExpYear` from `longInteger` to `nullable(longInteger)`
* ⚠️ Change type of `PaymentAttemptRecord.PaymentMethodDetails.Card.Moto` and `PaymentRecord.PaymentMethodDetails.Card.Moto` from `boolean` to `nullable(boolean)`
* Add support for `Cryptogram`, `ElectronicCommerceIndicator`, `ExemptionIndicatorApplied`, and `ExemptionIndicator` on `PaymentAttemptRecord.PaymentMethodDetails.Card.ThreeDSecure` and `PaymentRecord.PaymentMethodDetails.Card.ThreeDSecure`
* Add support for `UpiHandleRedirectOrDisplayQrCode` on `PaymentIntent.NextAction` and `SetupIntent.NextAction`
* Add support for `RecommendedAction` and `Signals` on `Radar.PaymentEvaluation`
* ⚠️ Remove support for `Insights` on `Radar.PaymentEvaluation`
