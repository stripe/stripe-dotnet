---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/2776
is_stripe_api_change: true
released_in_version: 42.8.0
---

* Add support for new resource `Issuing.Token`
* Add support for `Get`, `List`, and `Update` methods on resource `Token`
* Add support for `AmountAuthorized`, `ExtendedAuthorization`, `IncrementalAuthorization`, `Multicapture`, and `Overcapture` on `ChargePaymentMethodDetailsCard`
* Add support for `Token` on `IssuingAuthorization` and `IssuingTransaction`
* Add support for `AuthorizationCode` on `IssuingAuthorizationRequestHistory`
* Add support for `RequestExtendedAuthorization`, `RequestMulticapture`, and `RequestOvercapture` on `PaymentIntentPaymentMethodOptionsCardOptions` and `PaymentIntentPaymentMethodOptionsCard`
* Add support for `RequestIncrementalAuthorization` on `PaymentIntentPaymentMethodOptionsCardOptions`, `PaymentIntentPaymentMethodOptionsCardPresentOptions`, and `PaymentIntentPaymentMethodOptionsCard`
* Add support for `FinalCapture` on `PaymentIntentCaptureOptions`
* Add support for `Metadata` on `PaymentLinkPaymentIntentDataOptions`, `PaymentLinkPaymentIntentData`, `PaymentLinkSubscriptionDataOptions`, and `PaymentLinkSubscriptionData`
* Add support for `StatementDescriptorSuffix` and `StatementDescriptor` on `PaymentLinkPaymentIntentDataOptions` and `PaymentLinkPaymentIntentData`
* Add support for `PaymentIntentData` and `SubscriptionData` on `PaymentLinkUpdateOptions`
