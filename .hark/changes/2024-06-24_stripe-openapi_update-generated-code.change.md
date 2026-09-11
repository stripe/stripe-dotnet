---
title: Update generated code
pr_link: https://github.com/stripe/stripe-dotnet/pull/2929
is_stripe_api_change: true
released_in_version: 45.0.0
---

This release changes the pinned API version to 2024-06-20. Please read the [API Changelog](https://docs.stripe.com/changelog/2024-06-20) and carefully review the API changes before upgrading.

### ⚠️ Breaking changes

  * Remove the unused resource `PlatformTaxFee`
  * Rename `VolumeDecimal` to `QuantityDecimal` on `IssuingAuthorizationPurchaseDetailsFuelOptions`, `IssuingTransactionPurchaseDetailsFuelOptions`, and `IssuingTransactionPurchaseDetailsFuel`

### Additions

* Add support for `FinalizeAmount` test helper method on resource `Issuing.Authorization`
* Add support for new values `platform_disabled`, `paused.inactivity` and `other` on enums `CapabilityRequirements.DisabledReason` and `CapabilityFutureRequirements.DisabledReason`
* Add support for `Fleet` on `Issuing.TestHelpersAuthorizationCreateOptions`, `IssuingAuthorizationPurchaseDetailsOptions`, `IssuingAuthorization`, `IssuingTransactionPurchaseDetailsOptions`, and `IssuingTransactionPurchaseDetails`
* Add support for `Fuel` on `Issuing.TestHelpersAuthorizationCreateOptions` and `IssuingAuthorization`
* Add support for `IndustryProductCode` and `QuantityDecimal` on `IssuingAuthorizationPurchaseDetailsFuelOptions`, `IssuingTransactionPurchaseDetailsFuelOptions`, and `IssuingTransactionPurchaseDetailsFuel`
