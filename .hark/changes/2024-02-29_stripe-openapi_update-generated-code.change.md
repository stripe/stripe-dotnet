---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/2853
is_stripe_api_change: true
released_in_version: 43.18.0-beta.1
---

* Remove support for resource `Entitlements.Event`
* Remove support for `Quantity` and `Type` on `Entitlements.FeatureCreateOptions` and `EntitlementsFeature`
* Add support for `Livemode` on `IssuingPersonalizationDesign`
* Add support for `ApplicationFeeAmount`, `Description`, `Metadata`, and `TransferData` on `PaymentIntentDecrementAuthorizationOptions`
* Add support for `EnableCustomerCancellation` on `TerminalReaderActionCollectPaymentMethodCollectConfig` and `TerminalReaderCollectConfigOptions`
