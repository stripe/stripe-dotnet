---
title: Update generated code for private-preview
pr_url: https://github.com/stripe/stripe-dotnet/pull/3319
is_breaking: true
is_stripe_api_change: true
released_in_version: 50.5.0-alpha.4
---

* Add support for new resources `Orchestration.PaymentAttempt` and `Radar.CustomerEvaluation`
* Add support for `Get` method on resource `Orchestration.PaymentAttempt`
* Add support for `Create` and `Update` methods on resource `Radar.CustomerEvaluation`
* Add support for `Approve` method on resource `Checkout.Session`
* Add support for `ReportAuthenticated`, `ReportCanceled`, `ReportFailed`, `ReportGuaranteed`, `ReportInformational`, and `ReportRefund` methods on resource `PaymentAttemptRecord`
* Add support for `CreateUsPaperCheckOnApplication` on `AccountSessionComponentsCheckScanningFeaturesOptions`
* Add support for `ApprovalMethod` on `Checkout.SessionCreateOptions` and `Checkout.Session`
* Add support for `CurrentAttempt` on `Checkout.Session`
* Add support for `SelectedFulfillmentOptionOverrides` on `DelegatedCheckoutRequestedSessionFulfillmentDetailsOptions`
* Add support for `PricingPlanSubscriptionDetails` on `InvoiceItem.Parent` and `InvoiceLineItem.Parent`
* ⚠️ Remove support for `LicenseFeeSubscriptionDetails` on `InvoiceItem.Parent` and `InvoiceLineItem.Parent`
* ⚠️ Remove support for `PricingPlanSubscription` and `PricingPlanVersion` on `InvoiceItem.Parent.RateCardSubscriptionDetails` and `InvoiceLineItem.Parent.RateCardSubscriptionDetails`
* Add support for `TokenDetails` on `Issuing.Authorization`
* Add support for `FailureCode` on `PaymentRecordFailedOptions` and `PaymentRecordReportPaymentAttemptFailedOptions`
* Add support for `RecurringInterval` on `SharedPaymentGrantedTokenUsageLimitsOptions`
* Add support for `HomeRuleTax` on `Tax.Registration.CountryOptions.Us` and `TaxRegistrationCountryOptionsUsOptions`
