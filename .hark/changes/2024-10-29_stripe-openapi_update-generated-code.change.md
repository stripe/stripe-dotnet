---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/2997
is_stripe_api_change: true
released_in_version: 47.0.0
---

* Add support for new resource `V2.EventDestinations`
* Add support for `Create`, `Get`, `Update`, `List`, `Delete`, `Disable`, `Enable` and `Ping` methods on resource `V2.EventDestinations`
* Add support for `SubmitCard` test helper method on resource `Issuing.Card`
* Add support for `Groups` on `AccountCreateOptions`, `AccountUpdateOptions`, and `Account`
* Add support for `AlmaPayments`, `KakaoPayPayments`, `KrCardPayments`, `NaverPayPayments`, `PaycoPayments`, and `SamsungPayPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
* Add support for `DisableStripeUserAuthentication` on `AccountSessionComponentsAccountManagementFeaturesOptions`, `AccountSessionComponentsAccountManagementFeatures`, `AccountSessionComponentsAccountOnboardingFeaturesOptions`, `AccountSessionComponentsAccountOnboardingFeatures`, `AccountSessionComponentsBalancesFeaturesOptions`, `AccountSessionComponentsBalancesFeatures`, `AccountSessionComponentsNotificationBannerFeaturesOptions`, `AccountSessionComponentsNotificationBannerFeatures`, `AccountSessionComponentsPayoutsFeaturesOptions`, and `AccountSessionComponentsPayoutsFeatures`
* Add support for `ScheduleAtPeriodEnd` on `BillingPortalConfigurationFeaturesSubscriptionUpdateOptions` and `BillingPortalConfigurationFeaturesSubscriptionUpdate`
* Add support for `Alma` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `RefundDestinationDetails`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `KakaoPay` and `KrCard` on `ChargePaymentMethodDetails`, `CheckoutSessionPaymentMethodOptionsOptions`, `CheckoutSessionPaymentMethodOptions`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `MandatePaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, `SetupAttemptPaymentMethodDetails`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `NaverPay` on `ChargePaymentMethodDetails`, `CheckoutSessionPaymentMethodOptionsOptions`, `CheckoutSessionPaymentMethodOptions`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethodUpdateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `Payco` and `SamsungPay` on `ChargePaymentMethodDetails`, `CheckoutSessionPaymentMethodOptionsOptions`, `CheckoutSessionPaymentMethodOptions`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `EnhancedEvidence` on `DisputeEvidenceOptions` and `DisputeEvidence`
* Add support for `EnhancedEligibilityTypes` on `Dispute`
* Add support for `EnhancedEligibility` on `DisputeEvidenceDetails`
* Add support for `Metadata` on `Forwarding.RequestCreateOptions` and `ForwardingRequest`
* Add support for `AutomaticallyFinalizesAt` on `InvoiceCreateOptions` and `InvoiceUpdateOptions`
* Add support for `AmazonPay` on `PaymentMethodDomain`
* Add support for `FlatAmount` and `RateType` on `TaxCalculationTaxBreakdownTaxRateDetails` and `TaxRate`
* Add support for `By`, `Cr`, `Ec`, `Ma`, `Md`, `Rs`, `Ru`, `Tz`, and `Uz` on `TaxRegistrationCountryOptionsOptions` and `TaxRegistrationCountryOptions`
* Add support for `Pln` on `TerminalConfigurationTippingOptions` and `TerminalConfigurationTipping`
