---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/2667
is_stripe_api_change: true
released_in_version: 41.12.0
---

* Remove support for `Create` method on resource `Tax.Transaction`
  * This is not a breaking change, as this method was deprecated before the Tax Transactions API was released in favor of the `CreateFromCalculation ` method.
* Add support for `ExportLicenseId` and `ExportPurposeCode` on `AccountCompanyOptions`, `AccountCompany`, and `TokenAccountCompanyOptions`
* Add support for `AmountTip` on `TestHelpersTerminal.ReaderPresentPaymentMethodOptions`
