---
title: Update generated code for beta
pr_url: https://github.com/stripe/stripe-dotnet/pull/2788
is_stripe_api_change: true
released_in_version: 43.2.0-beta.1
---

* Add support for `AttachPaymentIntent` method on resource `Invoice`
* Add support for `RevolutPay` on `ConfirmationTokenPaymentMethodPreview`
* Add support for `Refunds` on `CreditNoteCreateOptions`, `CreditNotePreviewLinesOptions`, `CreditNotePreviewOptions`, and `CreditNote`
* Add support for `PostPaymentAmount` and `PrePaymentAmount` on `CreditNote`
* Add support for `ScheduleDetails` on `InvoiceUpcomingLinesOptions` and `InvoiceUpcomingOptions`
* Add support for `AmountsDue` on `InvoiceCreateOptions`, `InvoiceUpdateOptions`, and `Invoice`
* Add support for `Payments` on `Invoice`
* Add support for `Created` on `IssuingPersonalizationDesign`
* Add support for `EndingBefore`, `Limit`, and `StartingAfter` on `Tax.RegistrationListOptions`
* Change type of `TaxRegistrationActiveFromOptions` and `TaxRegistrationExpiresAtOptions` to `literal('now') | DateTime`
* Change type of `TaxRegistrationActiveFrom`, `TaxRegistrationCreated`, `TaxRegistrationExpiresAtOptions`, and `TaxRegistrationExpiresAt` from `longInteger` to `DateTime`
