---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3246
is_stripe_api_change: true
released_in_version: 50.0.0
---

* Add support for new resources `Tax.Association` and `Terminal.OnboardingLink`
* Add support for `Find` method on resource `Tax.Association`
* Add support for `Create` method on resource `Terminal.OnboardingLink`
* Add support for `PaymentMethodConfiguration` on `BillingPortal.Configuration.Features.PaymentMethodUpdate`
* Add support for `TransactionId` on `Charge.PaymentMethodDetails.Ideal`, `PaymentAttemptRecord.PaymentMethodDetails.Ideal`, and `PaymentRecord.PaymentMethodDetails.Ideal`
* Add support for `Created` on `CustomerCustomerBalanceTransactionListOptions` and `InvoicePaymentListOptions`
* Add support for `AccountNumbers` on `FinancialConnections.Account`
* Add support for `FraudRisk` on `IssuingAuthorizationRiskAssessmentOptions`
* Add support for `LatestFraudWarning` on `Issuing.Card`
* Add support for `Hooks` on `PaymentIntentCaptureOptions`, `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `PaymentIntentIncrementAuthorizationOptions`, `PaymentIntentUpdateOptions`, and `PaymentIntent`
* Add support for `MbWay` and `Twint` on `Refund.DestinationDetails`
* Add support for snapshot events `FinancialConnectionsAccountAccountNumbersUpdated` and `FinancialConnectionsAccountUpcomingAccountNumberExpiry` with resource `FinancialConnections.Account`
