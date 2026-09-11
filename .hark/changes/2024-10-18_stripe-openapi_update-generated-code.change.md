---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/3000
is_stripe_api_change: true
released_in_version: 46.3.0-beta.1
---

* Add support for `AlmaPayments`, `GopayPayments`, `KakaoPayPayments`, `KrCardPayments`, `NaverPayPayments`, `PaycoPayments`, `QrisPayments`, `SamsungPayPayments`, `ShopeepayPayments`, `TreasuryEvolve`, `TreasuryFifthThird`, and `TreasuryGoldmanSachs` on `AccountCapabilitiesOptions` and `AccountCapabilities`
* Add support for `ScheduleAtPeriodEnd` on `BillingPortalConfigurationFeaturesSubscriptionUpdateOptions` and `BillingPortalConfigurationFeaturesSubscriptionUpdate`
* Add support for `Alma` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `RefundDestinationDetails`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `Gopay`, `Qris`, and `Shopeepay` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `Metadata` on `Forwarding.RequestCreateOptions`
* Add support for `AmazonPay` on `PaymentMethodDomain`
* Add support for `ExternalReference` on `TaxFormPayeeOptions` and `TaxFormPayee`
* Change type of `TaxFormPayeeTypeOptions` and `TaxFormPayeeType` from `literal('account')` to `enum('account'|'external_reference')`
* Add support for `AuSerr`, `CaMrdp`, `EuDac7`, `GbMrdp`, and `NzMrdp` on `TaxForm`
* Add support for `Pln` on `TerminalConfigurationTippingOptions` and `TerminalConfigurationTipping`
* Add support for `Bank` on `TreasuryFinancialAccountFeaturesFinancialAddressesAbaOptions`, `TreasuryFinancialAccountFeaturesFinancialAddressesAba`, and `TreasuryFinancialAccountFinancialAddressesAbaOptions`
