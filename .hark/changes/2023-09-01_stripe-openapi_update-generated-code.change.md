---
title: Update generated code for beta
pr_url: https://github.com/stripe/stripe-dotnet/pull/2759
is_stripe_api_change: true
released_in_version: 42.5.0-beta.1
---

* Rename `QuoteService.ListPreviewInvoices` to `QuotePreviewInvoiceService.List` and `QuoteService.ListPreviewSubscriptionSchedules` to `QuotePreviewScheduleService.List`
* Add support for `TaxForms` on `AccountSettingsOptions` and `AccountSettings`
* Add support for `Components` on `AccountSessionCreateOptions` and `AccountSession`
