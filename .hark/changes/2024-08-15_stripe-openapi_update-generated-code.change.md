---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/2949
is_stripe_api_change: true
released_in_version: 45.8.0
---

* Add support for `AuthorizationCode` on `ChargePaymentMethodDetailsCard`
* Add support for `Wallet` on `ChargePaymentMethodDetailsCardPresent`, `ConfirmationTokenPaymentMethodPreviewCardGeneratedFromPaymentMethodDetailsCardPresent`, `ConfirmationTokenPaymentMethodPreviewCardPresent`, `PaymentMethodCardGeneratedFromPaymentMethodDetailsCardPresent`, and `PaymentMethodCardPresent`
* Add support for `MandateOptions` on `PaymentIntentPaymentMethodOptionsBacsDebitOptions` and `PaymentIntentPaymentMethodOptionsBacsDebit`
* Add support for `BacsDebit` on `SetupIntentPaymentMethodOptionsOptions` and `SetupIntentPaymentMethodOptions`
* Add support for `Chips` on `TreasuryOutboundPaymentTrackingDetailsUsDomesticWireOptions`, `TreasuryOutboundPaymentTrackingDetailsUsDomesticWire`, `TreasuryOutboundTransferTrackingDetailsUsDomesticWireOptions`, and `TreasuryOutboundTransferTrackingDetailsUsDomesticWire`
