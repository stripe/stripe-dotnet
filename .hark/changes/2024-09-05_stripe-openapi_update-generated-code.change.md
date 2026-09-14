---
title: Update generated code for beta
pr_url: https://github.com/stripe/stripe-dotnet/pull/2956
is_stripe_api_change: true
released_in_version: 45.12.0-beta.1
---

* Add support for new resources `Billing.MeterErrorReport` and `Terminal.ReaderCollectedData`
* Add support for `Get` method on resource `ReaderCollectedData`
* Add support for `Recipients` on `AccountSessionComponentsOptions`
* Add support for `BusinessName` and `TaxIds` on `CheckoutSessionCollectedInformation`
* Add support for `RegulatoryReportingFile` on `Issuing.CreditUnderwritingRecordCorrectOptions`, `Issuing.CreditUnderwritingRecordCreateFromProactiveReviewOptions`, `Issuing.CreditUnderwritingRecordReportDecisionOptions`, and `IssuingCreditUnderwritingRecord`
* Remove support for `Rechnung` on `PaymentMethodUpdateOptions`
