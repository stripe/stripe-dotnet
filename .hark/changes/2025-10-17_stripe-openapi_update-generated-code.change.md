---
title: Update generated code for private-preview
pr_url: https://github.com/stripe/stripe-dotnet/pull/3220
is_stripe_api_change: true
released_in_version: 49.1.0-alpha.3
---

* Add support for new resources `DelegatedCheckout.RequestedSession` and `Identity.BlocklistEntry`
* Add support for `Confirm`, `Create`, `Expire`, `Get`, and `Update` methods on resource `DelegatedCheckout.RequestedSession`
* Add support for `Create`, `Disable`, `Get`, and `List` methods on resource `Identity.BlocklistEntry`
* Add support for `BlockedByEntry` on `Identity.VerificationReport.Document`, `Identity.VerificationReport.Selfie`, and `Identity.VerificationReportListOptions`
