---
title: Update generated code
pr_link: https://github.com/stripe/stripe-dotnet/pull/3365
is_breaking: true
is_stripe_api_change: true
released_in_version: 51.1.0
---

* Add support for `BalanceReport` and `PayoutReconciliationReport` on `AccountSession.Components` and `AccountSessionComponentsOptions`
* Add support for `AppDistribution` and `SunbitPayments` on `Account.Capabilities` and `AccountCapabilitiesOptions`
* Add support for `Sunbit` on `Charge.PaymentMethodDetails`, `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `PaymentAttemptRecord.PaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `PaymentRecord.PaymentMethodDetails`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `Location` and `Reader` on `Charge.PaymentMethodDetails.Klarna`, `PaymentAttemptRecord.PaymentMethodDetails.Klarna`, and `PaymentRecord.PaymentMethodDetails.Klarna`
* Add support for `Mandate` on `Charge.PaymentMethodDetails.Pix`, `PaymentAttemptRecord.PaymentMethodDetails.Pix`, and `PaymentRecord.PaymentMethodDetails.Pix`
* Add support for `ManagedPayments` on `Checkout.SessionCreateOptions`, `Checkout.Session`, `PaymentIntent`, `PaymentLinkCreateOptions`, `PaymentLink`, `SetupIntent`, and `Subscription`
* Add support for `MandateOptions` on `Checkout.Session.PaymentMethodOptions.Pix`, `CheckoutSessionPaymentMethodOptionsPixOptions`, `PaymentIntent.PaymentMethodOptions.Pix`, and `PaymentIntentPaymentMethodOptionsPixOptions`
* Change type of `CheckoutSessionPaymentMethodOptionsPixOptions.SetupFutureUsage` and `PaymentIntentPaymentMethodOptionsPixOptions.SetupFutureUsage` from `literal('none')` to `enum('none'|'off_session')`
* ⚠️ Change type of `Checkout.Session.PaymentMethodOptions.Pix.SetupFutureUsage` and `PaymentIntent.PaymentMethodOptions.Pix.SetupFutureUsage` from `literal('none')` to `enum('none'|'off_session')`
* Add support for `Pix` on `Invoice.PaymentSettings.PaymentMethodOptions`, `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `Mandate.PaymentMethodDetails`, `SetupAttempt.PaymentMethodDetails`, `SetupIntent.PaymentMethodOptions`, `SetupIntentPaymentMethodOptionsOptions`, `Subscription.PaymentSettings.PaymentMethodOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`
* Add support for `Upi` on `Invoice.PaymentSettings.PaymentMethodOptions`, `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `Subscription.PaymentSettings.PaymentMethodOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`
* Add support for `CardPresence` on `Issuing.Authorization`
* Add support for `AllowedCardPresences` and `BlockedCardPresences` on `Issuing.Card.SpendingControls`, `Issuing.Cardholder.SpendingControls`, `IssuingCardSpendingControlsOptions`, and `IssuingCardholderSpendingControlsOptions`
* Add support for `Amount` and `Currency` on `Mandate.MultiUse`
* Add support for `AmountToConfirm` on `PaymentIntentConfirmOptions`
* Add support for `KlarnaDisplayQrCode` on `PaymentIntent.NextAction`
* Add support for `Moto` on `SetupAttempt.PaymentMethodDetails.Card`
* Add support for `PixDisplayQrCode` on `SetupIntent.NextAction`
