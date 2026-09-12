---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/2881
is_stripe_api_change: true
released_in_version: 43.22.0
---

* Change type of `CheckoutSessionPaymentMethodOptionsSwishReferenceOptions` from `emptyable(string)` to `string`
* Add support for `SubscriptionItem` on `Discount`
* Add support for `Email` and `Phone` on `IdentityVerificationReport`, `IdentityVerificationSessionOptionsOptions`, `IdentityVerificationSessionOptions`, and `IdentityVerificationSessionVerifiedOutputs`
* Add support for `VerificationFlow` on `Identity.VerificationSessionCreateOptions`, `IdentityVerificationReport`, and `IdentityVerificationSession`
* Add support for `ProvidedDetails` on `Identity.VerificationSessionCreateOptions`, `Identity.VerificationSessionUpdateOptions`, and `IdentityVerificationSession`
* Add support for `PromotionCode` on `InvoiceDiscountsOptions`, `InvoiceItemDiscountsOptions`, and `QuoteDiscountsOptions`
* Add support for `Discounts` on `InvoiceSubscriptionItemsOptions`, `QuoteLineItemsOptions`, `SubscriptionAddInvoiceItemsOptions`, `SubscriptionCreateOptions`, `SubscriptionItemCreateOptions`, `SubscriptionItemUpdateOptions`, `SubscriptionItem`, `SubscriptionItemsOptions`, `SubscriptionSchedulePhasesAddInvoiceItemsOptions`, `SubscriptionSchedulePhasesAddInvoiceItems`, `SubscriptionSchedulePhasesItemsOptions`, `SubscriptionSchedulePhasesItems`, `SubscriptionSchedulePhasesOptions`, `SubscriptionSchedulePhases`, `SubscriptionUpdateOptions`, and `Subscription`
* Add support for `AllowedMerchantCountries` and `BlockedMerchantCountries` on `IssuingCardSpendingControlsOptions`, `IssuingCardSpendingControls`, `IssuingCardholderSpendingControlsOptions`, and `IssuingCardholderSpendingControls`
* Add support for `Zip` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
* Add support for `Offline` on `SetupAttemptPaymentMethodDetailsCardPresent`
* Add support for `CardPresent` on `SetupIntentPaymentMethodOptionsOptions` and `SetupIntentPaymentMethodOptions`
