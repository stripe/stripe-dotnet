---
title: Update generated code for private-preview
pr_url: https://github.com/stripe/stripe-dotnet/pull/3243
is_stripe_api_change: true
released_in_version: 49.3.0-alpha.1
---

* Add support for new resource `TransitBalance`, `V2.Reporting.ReportRun`, `V2.Reporting.Report`
* Add support for `Create` and `Get` methods on resource `V2.Reporting.ReportRun`
* Add support for `Get` method on resource `V2.Reporting.Report`
* Add support for `Create` and `Refill` test helper methods on resource `Capital.FinancingOffer`
* Add support for `AllocatedFunds` on `Charge`, `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, and `PaymentIntentUpdateOptions`
* Add support for thin events `V2ReportingReportRunCreatedEvent`, `V2ReportingReportRunFailedEvent`, `V2ReportingReportRunSucceededEvent`, and `V2ReportingReportRunUpdatedEvent` with related object `V2.Reporting.ReportRun`
