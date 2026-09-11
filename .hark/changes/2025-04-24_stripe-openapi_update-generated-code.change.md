---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/3107
is_stripe_api_change: true
released_in_version: 48.2.0-beta.1
---

This release changes the pinned API version to `2025-04-30.preview`.

* Add support for `BillingMode` on `CheckoutSessionSubscriptionDataOptions`, `InvoiceScheduleDetailsOptions`, `InvoiceSubscriptionDetailsOptions`, `Quote.SubscriptionData`, `QuotePreviewSubscriptionSchedule`, `QuoteSubscriptionDataOptions`, `SubscriptionCreateOptions`, `SubscriptionScheduleCreateOptions`, `SubscriptionSchedule`, and `Subscription`
* Add support for `AccountNumber` on `ConfirmationToken.PaymentMethodPreview.AcssDebit` and `PaymentMethod.AcssDebit`
