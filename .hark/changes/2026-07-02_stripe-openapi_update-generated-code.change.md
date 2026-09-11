---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3405
is_breaking: true
is_stripe_api_change: true
released_in_version: 52.2.0-alpha.2
---

* Add support for new resources `Crypto.CustomerConsumerWallet`, `Crypto.CustomerPaymentToken`, `Crypto.Customer`, `Crypto.OnrampSession`, and `Crypto.OnrampTransactionLimits`
* Add support for `Get` and `List` methods on resource `Crypto.Customer`
* Add support for `Checkout`, `Create`, `Get`, `List`, and `Quote` methods on resource `Crypto.OnrampSession`
* Add support for `Get` method on resource `Crypto.OnrampTransactionLimits`
* Add support for `ElectronicCommerceIndicator` on `Charge.PaymentMethodDetails.Card`
* Add support for `AmountReceived` and `AmountRequested` on `Charge.PaymentMethodDetails.Crypto`, `PaymentAttemptRecord.PaymentMethodDetails.Crypto`, and `PaymentRecord.PaymentMethodDetails.Crypto`
* Add support for `Fingerprint` on `Charge.PaymentMethodDetails.GiftCard`, `PaymentAttemptRecord.PaymentMethodDetails.GiftCard`, and `PaymentRecord.PaymentMethodDetails.GiftCard`
* Add support for `AddressCollectionPrecision` on `CheckoutSessionAutomaticTaxOptions`
* Add support for `Subscription` on `Checkout.Session.Item`
* ⚠️  Remove support for `Deactivation` on `GiftCardOperation`
* Add support for `MerchantAmountExchangeRate` on `Issuing.Authorization` and `Issuing.Transaction`
* Add support for `DeviceId` on `Issuing.Authorization.TokenDetails.NetworkData.Device` and `Issuing.Token.NetworkData.Device`
* Add support for `Program` on `Issuing.Card`
* Add support for `PaymentMethodDetails` on `PaymentAttemptRecordReportFailedOptions` and `PaymentRecordReportPaymentAttemptFailedOptions`
* Add support for `Reason` on `PaymentAttemptRecordReportRefundOptions` and `PaymentRecordReportRefundOptions`
* Add support for `AmountReconciliation` on `PaymentIntent.PaymentMethodOptions.Crypto` and `PaymentIntentPaymentMethodOptionsCryptoOptions`
* Add support for `ConnectPermissions` and `Permissions` on `V2.Iam.ApiKeyCreateOptions`, `V2.Iam.ApiKeyUpdateOptions`, and `V2.Iam.ApiKey`
* Add support for `Credit` on `V2.MoneyManagement.FinancialAccount`
* Add support for `Account`, `IssuingAuthorization`, `IssuingDispute`, and `IssuingTransaction` on `V2.MoneyManagement.Transaction.Flow` and `V2.MoneyManagement.TransactionEntry.TransactionDetails.Flow`
* Change type of `V2.MoneyManagement.FinancialAccountCreateOptions.Type` from `literal('storage')` to `enum('credit'|'storage')`
* Add support for `ExpiresAt` on `V2.Iam.ApiKeyCreateOptions`
