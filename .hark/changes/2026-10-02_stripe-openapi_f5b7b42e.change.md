---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3475
semver_level: major
is_stripe_api_change: true
---

* Add support for new resources `Radar.Rule` and `V2.MoneyManagement.FundingSession`
* Add support for `Create` method on resource `V2.MoneyManagement.FundingSession`
* Add support for `PaymentSettings` on `Checkout.SessionCreateOptions` and `Checkout.Session`
* Add support for `OnBehalfOf` on `Checkout.Session`
* Add support for `Fuels` on `Issuing.Transaction.PurchaseDetails`
* Add support for `Fleet` on `PaymentIntent.PaymentMethodOptions.CardPresent` and `PaymentIntentPaymentMethodOptionsCardPresentOptions`
* Add support for `SubscriptionReference` on `PaymentIntent.PaymentMethodOptions.Paypay` and `PaymentIntentPaymentMethodOptionsPaypayOptions`
* Add support for `UsBankAccount` on `Radar.PaymentEvaluation.PaymentDetails.MoneyMovementDetails` and `RadarPaymentEvaluationPaymentDetailsMoneyMovementDetailsOptions`
* Change type of `RadarPaymentEvaluationPaymentDetailsMoneyMovementDetailsOptions.MoneyMovementType` from `literal('card')` to `enum('card'|'us_bank_account')`
* Add support for `Rules` on `Radar.PaymentEvaluation`
* ⚠️ Change type of `Radar.PaymentEvaluation.PaymentDetails.MoneyMovementDetails.MoneyMovementType` from `literal('card')` to `enum('card'|'us_bank_account')`
* Add support for `BankInitiatedReturn` on `Radar.PaymentEvaluation.Signals`
* Add support for `Account` on `V2.MoneyManagement.FinancialAddressCreateOptions`, `V2.MoneyManagement.FinancialAddressListOptions`, and `V2.MoneyManagement.FinancialAddress`
* Add support for `SupportedNetworkDetails` on `V2.MoneyManagement.FinancialAddress.CryptoWallet`
* Add support for `NetworkDetails` on `V2.MoneyManagement.InboundTransferCreateOptions` and `V2.MoneyManagement.InboundTransfer`
* Add support for `OriginatingCryptoWallet`, `TokenCurrency`, and `TransactionHash` on `V2.MoneyManagement.ReceivedCredit.CryptoWalletTransfer`
* Add support for `Customer` and `Subscription` on `EventsV1InvoiceUpcomingEvent`
