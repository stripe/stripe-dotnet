---
title: Update generated code for beta
pr_url: https://github.com/stripe/stripe-dotnet/pull/3156
is_stripe_api_change: true
released_in_version: 48.6.0-beta.1
---

* Add support for `Get` and `List` methods on resource `InvoicePayment`
* Add support for `List` method on resource `Mandate`
* Add support for `Applied` on `V2.Core.Account.Configuration.Customer`, `V2.Core.Account.Configuration.Merchant`, `V2.Core.Account.Configuration.Recipient`, `V2.Core.Account.Configuration.Storer`, `V2CoreAccountConfigurationCustomerOptions`, `V2CoreAccountConfigurationMerchantOptions`, `V2CoreAccountConfigurationRecipientOptions`, and `V2CoreAccountConfigurationStorerOptions`
* Change type of `Billing.AlertTriggered.Value` from `longInteger` to `decimal_string`
* Add support for `DisplayName` on `V2.MoneyManagement.FinancialAccountCreateOptions` and `V2.MoneyManagement.FinancialAccount`
* Add support for `CurrencyConversion` on `V2.MoneyManagement.Transaction.Flow` and `V2.MoneyManagement.TransactionEntry.TransactionDetails.Flow`
* Add support for `Payments` on `BalanceSettingsUpdateOptions` and `BalanceSettings`
* Remove support for `DebitNegativeBalances`, `Payouts`, and `SettlementTiming` on `BalanceSettingsUpdateOptions` and `BalanceSettings`
* Add support for `Mandate` on `Charge.PaymentMethodDetails.Pix`, `PaymentAttemptRecord.PaymentMethodDetails.Pix`, and `PaymentRecord.PaymentMethodDetails.Pix`
* Add support for `CouponData` on `CheckoutSessionDiscountOptions`
* Add support for `MandateOptions` on `Checkout.Session.PaymentMethodOptions.Pix`, `CheckoutSessionPaymentMethodOptionsPixOptions`, `PaymentIntent.PaymentMethodOptions.Pix`, and `PaymentIntentPaymentMethodOptionsPixOptions`
* Change type of `Checkout.Session.PaymentMethodOptions.Pix.SetupFutureUsage`, `CheckoutSessionPaymentMethodOptionsPixOptions.SetupFutureUsage`, `PaymentIntent.PaymentMethodOptions.Pix.SetupFutureUsage`, and `PaymentIntentPaymentMethodOptionsPixOptions.SetupFutureUsage` from `literal('none')` to `enum('none'|'off_session')`
* Add support for `Amount` on `Mandate.MultiUse`, `PaymentAttemptRecord`, and `PaymentRecord`
* Add support for `Currency` on `Mandate.MultiUse`
* Add support for `Pix` on `Mandate.PaymentMethodDetails`, `SetupAttempt.PaymentMethodDetails`, `SetupIntent.PaymentMethodOptions`, and `SetupIntentPaymentMethodOptionsOptions`
* Add support for `Limit` on `PaymentAttemptRecordListOptions`
* Add support for `AmountAuthorized`, `AmountRefunded`, and `Application` on `PaymentAttemptRecord` and `PaymentRecord`
* Add support for `ProcessorDetails` on `PaymentAttemptRecord`, `PaymentRecordReportPaymentOptions`, and `PaymentRecord`
* Remove support for `PaymentReference` on `PaymentAttemptRecord`, `PaymentRecordReportPaymentOptions`, and `PaymentRecord`
* Add support for `Installments` on `PaymentAttemptRecord.PaymentMethodDetails.Alma` and `PaymentRecord.PaymentMethodDetails.Alma`
* Add support for `TransactionId` on `PaymentAttemptRecord.PaymentMethodDetails.Alma`, `PaymentAttemptRecord.PaymentMethodDetails.AmazonPay`, `PaymentAttemptRecord.PaymentMethodDetails.Billie`, `PaymentAttemptRecord.PaymentMethodDetails.KakaoPay`, `PaymentAttemptRecord.PaymentMethodDetails.KrCard`, `PaymentAttemptRecord.PaymentMethodDetails.NaverPay`, `PaymentAttemptRecord.PaymentMethodDetails.Payco`, `PaymentAttemptRecord.PaymentMethodDetails.RevolutPay`, `PaymentAttemptRecord.PaymentMethodDetails.SamsungPay`, `PaymentAttemptRecord.PaymentMethodDetails.Satispay`, `PaymentRecord.PaymentMethodDetails.Alma`, `PaymentRecord.PaymentMethodDetails.AmazonPay`, `PaymentRecord.PaymentMethodDetails.Billie`, `PaymentRecord.PaymentMethodDetails.KakaoPay`, `PaymentRecord.PaymentMethodDetails.KrCard`, `PaymentRecord.PaymentMethodDetails.NaverPay`, `PaymentRecord.PaymentMethodDetails.Payco`, `PaymentRecord.PaymentMethodDetails.RevolutPay`, `PaymentRecord.PaymentMethodDetails.SamsungPay`, and `PaymentRecord.PaymentMethodDetails.Satispay`
* Add support for `Location` and `Reader` on `PaymentAttemptRecord.PaymentMethodDetails.Paynow` and `PaymentRecord.PaymentMethodDetails.Paynow`
* Add support for `LatestActiveMandate` on `PaymentMethod`
* Add support for `Metadata` and `Period` on `QuotePreviewSubscriptionSchedule.Phase.AddInvoiceItem`
* Add support for `PixDisplayQrCode` on `SetupIntent.NextAction`
* Add support for `ReaderSecurity` on `Terminal.ConfigurationCreateOptions`, `Terminal.ConfigurationUpdateOptions`, and `Terminal.Configuration`
