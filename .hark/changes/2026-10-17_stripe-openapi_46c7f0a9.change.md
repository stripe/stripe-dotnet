---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3480
semver_level: major
is_stripe_api_change: true
---

* Add support for new resource `Risk.Form`
* Add support for `Get` and `Update` methods on resource `Risk.Form`
* Add support for `BusinessProfileManagement` on `AccountSession.Components`
* Add support for `MarketingAttributions` on `Checkout.SessionCreateOptions` and `Checkout.Session`
* Add support for `MandateOptions` on `Checkout.Session.PaymentMethodOptions.Card`
* ⚠️ Remove support for `Details` on `Identity.VerificationReport.Email`
* ⚠️ Remove support for `Healthcare` on `IssuingAuthorizationPurchaseDetailsOptions` and `IssuingTransactionPurchaseDetailsOptions`
* Add support for `AccountTaxIds`, `CustomFields`, `Description`, and `Footer` on `PaymentLink.SubscriptionData.InvoiceSettings`
* Add support for `Bw`, `Ci`, `Gh`, and `Mu` on `Tax.Registration.CountryOptions`
* Add support for `AccountTakeoverConfirmation`, `AccountTakeoverReport`, `CredentialChange`, `MfaAddition`, and `MfaRemoval` on `V2.Signals.AccountActivityCreateOptions`, `V2.Signals.AccountActivity`, and `V2SignalsAccountEvaluationAccountActivityDetailsDataOptions`
* Add support for `AccountTakeover` on `V2.Signals.AccountEvaluation.EvaluatedSignals` and `V2.Signals.AccountSignal`
* Add support for `CustomerRisk` on `V2.Signals.AccountSignal`
* Add support for event notification `V2SignalsAccountSignalCustomerRiskReadyEvent` with related object `V2.Signals.AccountSignal`
