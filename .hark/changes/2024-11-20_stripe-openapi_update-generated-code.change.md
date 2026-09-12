---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3025
is_stripe_api_change: true
released_in_version: 47.1.0
---

* Add support for `Respond` test helper method on resource `Issuing.Authorization`
* Add support for `Authorizer` on `AccountRelationshipOptions` and `TokenPersonRelationshipOptions`
* Add support for `AdaptivePricing` on `Checkout.SessionCreateOptions` and `CheckoutSession`
* Add support for `MandateOptions` on `CheckoutSessionPaymentMethodOptionsBacsDebitOptions`, `CheckoutSessionPaymentMethodOptionsBacsDebit`, `CheckoutSessionPaymentMethodOptionsSepaDebitOptions`, and `CheckoutSessionPaymentMethodOptionsSepaDebit`
* Add support for `RequestExtendedAuthorization`, `RequestIncrementalAuthorization`, `RequestMulticapture`, and `RequestOvercapture` on `CheckoutSessionPaymentMethodOptionsCardOptions` and `CheckoutSessionPaymentMethodOptionsCard`
* Add support for `CaptureMethod` on `CheckoutSessionPaymentMethodOptionsKakaoPayOptions`, `CheckoutSessionPaymentMethodOptionsKrCardOptions`, `CheckoutSessionPaymentMethodOptionsNaverPayOptions`, `CheckoutSessionPaymentMethodOptionsPaycoOptions`, and `CheckoutSessionPaymentMethodOptionsSamsungPayOptions`
* Add support for `AccountHolderAddress`, `AccountHolderName`, `AccountType`, and `BankAddress` on `FundingInstructionsBankTransferFinancialAddressesAba`, `FundingInstructionsBankTransferFinancialAddressesSwift`, `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesAba`, and `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesSwift`
* Add support for `MerchantAmount` and `MerchantCurrency` on `Issuing.TestHelpersAuthorizationCreateOptions`
* Add support for `FraudChallenges` and `VerifiedByFraudChallenge` on `IssuingAuthorization`
* Add support for `SubmitType` on `PaymentLinkUpdateOptions`
* Add support for `TraceId` on `Payout`
* Add support for `NetworkDeclineCode` on `RefundDestinationDetailsBlik` and `RefundDestinationDetailsSwish`
