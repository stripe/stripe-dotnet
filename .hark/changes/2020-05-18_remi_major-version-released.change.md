---
title: "Major version released with the following breaking changes in it:"
pr_url: https://github.com/stripe/stripe-dotnet/pull/2039
released_in_version: 37.0.0
---

* [#2036](https://github.com/stripe/stripe-dotnet/pull/2036) Fix `Quantity` to be nullable on `CreditNoteLineItem`
* [#2037](https://github.com/stripe/stripe-dotnet/pull/2037) Removed deprecated `ExchangeRate` resource and APIs
  * The `ExchangeRate` APIs have been in a small private beta for a few years and have never been used in stripe-dotnet this year. We are considering this API mostly deprecated as we're working on re-building the feature. This will require large changes to the resource and APIs once we are ready to ship it.
* [#2038](https://github.com/stripe/stripe-dotnet/pull/2038) Removed deprecated parameters
  * Removed `PrimaryColor` in `AccountBusinessProfileOptions`. Use `PrimaryColor` in `AccountSettingsBrandingOptions` instead.
  * Removed `metadata` on `CreditNoteLineOptions` as it was never supported
* [#2043](https://github.com/stripe/stripe-dotnet/pull/2043) Multiple properties renamed
  * Properties lost their `Id` suffix such as `PaymentMethodId` renamed to `PaymentMethod` on `Charge`
  * `IIN` is now `Iin` on `Card`
  * `AmountReceivd` is now `AmountReceived` on `ChargePaymentMethodDetailsBitcoin`
  * `BankCode` is now `Bank` on `ChargePaymentMethodDetailsIdeal`.
  * `CustomerPurchaseIP` is now `CustomerPurchaseIp` on `DisputeEvidence` and `DisputeEvidenceOptions`
  * `OrderItems` is now `Items` on `Order` and `OrderReturn`
  * `CardList` is now `Cards` on `Recipient`
  * `BankAddressLinePostalCode` is now `BankAddressPostalCode` on `SourceAcssDebit`
  * Properties on `StripeError` have been renamed, `ChargeId` is `Charge`, `ErrorType` is `Type` and `Parameter` is `Param`
