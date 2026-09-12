---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/2797
is_stripe_api_change: true
released_in_version: 43.4.0
---

* Add support for `ElectronicCommerceIndicator` on `ChargePaymentMethodDetailsCardThreeDSecure` and `SetupAttemptPaymentMethodDetailsCardThreeDSecure`
* Add support for `ExemptionIndicatorApplied` and `ExemptionIndicator` on `ChargePaymentMethodDetailsCardThreeDSecure`
* Add support for `TransactionId` on `ChargePaymentMethodDetailsCardThreeDSecure`, `IssuingAuthorizationNetworkData`, `IssuingTransactionNetworkData`, and `SetupAttemptPaymentMethodDetailsCardThreeDSecure`
* Add support for `Offline` on `ChargePaymentMethodDetailsCardPresent`
* Add support for `SystemTraceAuditNumber` on `IssuingAuthorizationNetworkData`
* Add support for `NetworkRiskScore` on `IssuingAuthorizationPendingRequest` and `IssuingAuthorizationRequestHistory`
* Add support for `RequestedAt` on `IssuingAuthorizationRequestHistory`
* Add support for `AuthorizationCode` on `IssuingTransactionNetworkData`
* Add support for `ThreeDSecure` on `PaymentIntentPaymentMethodOptionsCardOptions` and `SetupIntentPaymentMethodOptionsCardOptions`
