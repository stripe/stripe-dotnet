---
title: Update generated code
pr_link: https://github.com/stripe/stripe-dotnet/pull/3139
is_stripe_api_change: true
released_in_version: 48.3.0
---

* Add support for `Migrate` method on resource `Subscription`
* Add support for `CollectPaymentMethod` and `ConfirmPaymentIntent` methods on resource `Terminal.Reader`
* Add support for `CryptoPayments` on `Account.Capabilities` and `AccountCapabilitiesOptions`
* Add support for `ProofOfAddress` on `AccountDocumentsOptions`
* Add support for `MonthlyPayoutDays` and `WeeklyPayoutDays` on `Account.Settings.Payouts.Schedule` and `AccountSettingsPayoutsScheduleOptions`
* Add support for `Crypto` on `Charge.PaymentMethodDetails`, `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `PaymentIntent.PaymentMethodOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
* Change type of `Charge.PaymentMethodDetails.Card.Installments.Plan.Type`, `ConfirmationToken.PaymentMethodOptions.Card.Installments.Plan.Type`, `ConfirmationTokenPaymentMethodOptionsCardInstallmentsPlanOptions.Type`, `InvoicePaymentSettingsPaymentMethodOptionsCardInstallmentsPlanOptions.Type`, `PaymentIntent.PaymentMethodOptions.Card.Installments.AvailablePlans.Type`, `PaymentIntent.PaymentMethodOptions.Card.Installments.Plan.Type`, and `PaymentIntentPaymentMethodOptionsCardInstallmentsPlanOptions.Type` from `literal('fixed_count')` to `enum('bonus'|'fixed_count'|'revolving')`
* Add support for `Subscriptions` on `CheckoutSessionPaymentMethodOptionsKlarnaOptions` and `PaymentIntentPaymentMethodOptionsKlarnaOptions`
* Add support for `BillingMode` on `CheckoutSessionSubscriptionDataOptions`, `InvoiceScheduleDetailsOptions`, `InvoiceSubscriptionDetailsOptions`, `Quote.SubscriptionData`, `QuoteSubscriptionDataOptions`, `SubscriptionCreateOptions`, `SubscriptionScheduleCreateOptions`, `SubscriptionSchedule`, and `Subscription`
* Change type of `Dispute.EnhancedEligibilityTypes` from `literal('visa_compelling_evidence_3')` to `enum('visa_compelling_evidence_3'|'visa_compliance')`
* Add support for `RelatedPerson` on `Identity.VerificationSessionCreateOptions` and `Identity.VerificationSession`
* Add support for `Matching` on `Identity.VerificationSession.Options`
* Add support for `Klarna` on `Mandate.PaymentMethodDetails`, `SetupIntent.PaymentMethodOptions`, and `SetupIntentPaymentMethodOptionsOptions`
* Add support for `OnDemand` on `PaymentIntentPaymentMethodOptionsKlarnaOptions`
* Change type of `PaymentIntent.PaymentMethodOptions.Klarna.SetupFutureUsage` and `PaymentIntentPaymentMethodOptionsKlarnaOptions.SetupFutureUsage` from `literal('none')` to `enum('none'|'off_session'|'on_session')`
* Add support for `Ua` on `Tax.Registration.CountryOptions` and `TaxRegistrationCountryOptionsOptions`
* Change type of `Terminal.LocationUpdateOptions.DisplayName` from `string` to `emptyable(string)`
* Add support for `CollectPaymentMethod` and `ConfirmPaymentIntent` on `Terminal.Reader.Action`
* Add support for `Status` on `Treasury.FinancialAccountListOptions`
* Add support for snapshot event `TerminalReaderActionUpdated` with resource `Terminal.Reader`
