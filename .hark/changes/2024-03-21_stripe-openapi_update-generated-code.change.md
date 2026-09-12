---
title: Update generated code for beta
pr_url: https://github.com/stripe/stripe-dotnet/pull/2875
is_stripe_api_change: true
released_in_version: 43.21.0-beta.1
---

* Add support for new resources `Entitlements.ActiveEntitlementSummary` and `Entitlements.ActiveEntitlement`
* Add support for `List` method on resource `ActiveEntitlement`
* Add support for `Mobilepay` on `ConfirmationTokenPaymentMethodDataOptions` and `ConfirmationTokenPaymentMethodPreview`
* Add support for `UseStripeSdk` on `ConfirmationToken`
* Remove support for `PaymentMethod` on `ConfirmationToken`
* Add support for `Metadata` on `Entitlements.FeatureCreateOptions` and `EntitlementsFeature`
* Add support for `Active` on `EntitlementsFeature`
