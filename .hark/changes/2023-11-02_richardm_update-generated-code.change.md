---
title: Update generated code
pr_link: https://github.com/stripe/stripe-dotnet/pull/2787
is_stripe_api_change: true
released_in_version: 43.1.0
---

* Add support for new resource `Tax.Registration`
* Add support for `Create`, `List`, and `Update` methods on resource `Registration`
* Add support for `RevolutPay` throughout the API.
* Add support for `Aba` and `Swift` on `FundingInstructionsBankTransferFinancialAddresses` and `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddresses`
* Add support for `Url` on `IssuingAuthorizationMerchantDataOptions`, `IssuingAuthorizationMerchantData`, `IssuingTransactionMerchantDataOptions`, and `IssuingTransactionMerchantData`
* Add support for `AuthenticationExemption` and `ThreeDSecure` on `IssuingAuthorizationVerificationDataOptions` and `IssuingAuthorizationVerificationData`
* Add support for `Description` on `PaymentLinkPaymentIntentDataOptions` and `PaymentLinkPaymentIntentData`
