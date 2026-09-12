---
title: Update generated code for beta
pr_url: https://github.com/stripe/stripe-dotnet/pull/3022
is_stripe_api_change: true
released_in_version: 47.1.0-beta.2
---

* Add support for new resources `Issuing.FraudLiabilityDebit`, `PaymentAttemptRecord`, and `PaymentRecord`
* Add support for `Get` and `List` methods on resources `FraudLiabilityDebit` and `PaymentAttemptRecord`
* Add support for `Get`, `ReportPaymentAttemptCanceled`, `ReportPaymentAttemptFailed`, `ReportPaymentAttemptGuaranteed`, `ReportPaymentAttempt`, and `ReportPayment` methods on resource `PaymentRecord`
* Remove support for `MoneyMovement` on `AccountSessionComponentsFinancialAccountFeaturesOptions`
* Add support for `CardManagement`, `CardSpendDisputeManagement`, `CardholderManagement`, and `SpendControlManagement` on `AccountSessionComponentsIssuingCardFeaturesOptions`
* Add support for `DisableStripeUserAuthentication` on `AccountSessionComponentsIssuingCardsListFeaturesOptions`
* Add support for `AdaptivePricing` on `Checkout.SessionCreateOptions` and `CheckoutSession`
* Add support for `MandateOptions` on `CheckoutSessionPaymentMethodOptionsBacsDebitOptions`, `CheckoutSessionPaymentMethodOptionsBacsDebit`, `CheckoutSessionPaymentMethodOptionsSepaDebitOptions`, and `CheckoutSessionPaymentMethodOptionsSepaDebit`
* Add support for `RequestDecrementalAuthorization`, `RequestExtendedAuthorization`, `RequestIncrementalAuthorization`, `RequestMulticapture`, and `RequestOvercapture` on `CheckoutSessionPaymentMethodOptionsCardOptions` and `CheckoutSessionPaymentMethodOptionsCard`
* Add support for `CaptureMethod` on `CheckoutSessionPaymentMethodOptionsKakaoPayOptions`, `CheckoutSessionPaymentMethodOptionsKrCardOptions`, `CheckoutSessionPaymentMethodOptionsNaverPayOptions`, `CheckoutSessionPaymentMethodOptionsPaycoOptions`, and `CheckoutSessionPaymentMethodOptionsSamsungPayOptions`
* Add support for `AccountHolderAddress`, `AccountHolderName`, `AccountType`, and `BankAddress` on `FundingInstructionsBankTransferFinancialAddressesAba`, `FundingInstructionsBankTransferFinancialAddressesSwift`, `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesAba`, and `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesSwift`
* Add support for `PaymentRecordData` and `PaymentRecord` on `InvoiceAttachPaymentOptions`
* Remove support for `OutOfBandPayment` on `InvoiceAttachPaymentOptions`
* Add support for `AmountOverpaid` on `Invoice`
* Add support for `MerchantAmount` and `MerchantCurrency` on `Issuing.TestHelpersAuthorizationCreateOptions`
* Add support for `SubmitType` on `PaymentLinkUpdateOptions`
