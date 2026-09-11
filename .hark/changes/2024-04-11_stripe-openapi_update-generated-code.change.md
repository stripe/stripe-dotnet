---
title: Update generated code
pr_link: https://github.com/stripe/stripe-dotnet/pull/2889
is_stripe_api_change: true
released_in_version: 44.1.0
---

* Add support for `AccountManagement` and `NotificationBanner` on `AccountSessionComponentsOptions` and `AccountSessionComponents`
* Add support for `ExternalAccountCollection` on `AccountSessionComponentsAccountOnboardingFeaturesOptions` and `AccountSessionComponentsAccountOnboardingFeatures`
* Change type of `BillingMeterEventAdjustmentCancel` from `BillingMeterResourceBillingMeterEventAdjustmentCancel` to `nullable(BillingMeterResourceBillingMeterEventAdjustmentCancel)`
* Add support for `AmazonPay` on `ChargePaymentMethodDetails`, `CheckoutSessionPaymentMethodOptionsOptions`, `CheckoutSessionPaymentMethodOptions`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `RefundDestinationDetails`, `SetupIntentPaymentMethodDataOptions`, `SetupIntentPaymentMethodOptionsOptions`, and `SetupIntentPaymentMethodOptions`
* Add support for `NextRefreshAvailableAt` on `FinancialConnectionsAccountOwnershipRefresh`
