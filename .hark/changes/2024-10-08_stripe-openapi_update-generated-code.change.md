---
title: Update generated code for beta
pr_url: https://github.com/stripe/stripe-dotnet/pull/2975
is_stripe_api_change: true
released_in_version: 46.2.0-beta.3
---

* Add support for `SubmitCard` test helper method on resource `Issuing.Card`
* Add support for `Groups` on `AccountCreateOptions`, `AccountUpdateOptions`, and `Account`
* Add support for `DisableStripeUserAuthentication` on `AccountSessionComponentsAccountManagementFeaturesOptions`, `AccountSessionComponentsAccountManagementFeatures`, `AccountSessionComponentsAccountOnboardingFeaturesOptions`, `AccountSessionComponentsAccountOnboardingFeatures`, `AccountSessionComponentsBalancesFeaturesOptions`, `AccountSessionComponentsBalancesFeatures`, `AccountSessionComponentsFinancialAccountFeaturesOptions`, `AccountSessionComponentsNotificationBannerFeaturesOptions`, `AccountSessionComponentsNotificationBannerFeatures`, `AccountSessionComponentsPayoutsFeaturesOptions`, and `AccountSessionComponentsPayoutsFeatures`
* Add support for `CardSpendDisputeManagement` and `SpendControlManagement` on `AccountSessionComponentsIssuingCardsListFeaturesOptions`
* Add support for `KakaoPay` and `KrCard` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `MandatePaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, `SetupAttemptPaymentMethodDetails`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `NaverPay` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethodUpdateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `Payco` and `SamsungPay` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `Metadata` on `ForwardingRequest`
* Add support for `LineItems` on `OrderPaymentSettingsPaymentMethodOptionsPaypalOptions`, `OrderPaymentSettingsPaymentMethodOptionsPaypal`, `PaymentIntentPaymentMethodOptionsPaypalOptions`, and `PaymentIntentPaymentMethodOptionsPaypal`
* Add support for `FlatAmount` and `RateType` on `TaxCalculationTaxBreakdownTaxRateDetails` and `TaxRate`
* Add support for `By`, `Cr`, `Ec`, `Ma`, `Md`, `Rs`, `Ru`, `Tz`, and `Uz` on `TaxRegistrationCountryOptionsOptions` and `TaxRegistrationCountryOptions`
