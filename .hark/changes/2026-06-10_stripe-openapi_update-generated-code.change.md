---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3395
is_breaking: true
is_stripe_api_change: true
released_in_version: 52.1.0-alpha.1
---

* Add support for new resources `GiftCardOperation`, `GiftCard`, and `TaxFund`
* Add support for `Get` method on resource `GiftCardOperation`
* Add support for `Activate`, `Cashout`, `CheckBalance`, `Create`, `Get`, `Reload`, and `VoidOperation` methods on resource `GiftCard`
* Add support for `Get` and `List` methods on resource `TaxFund`
* Add support for `UpdateCryptoRefundAddress` method on resource `PaymentIntent`
* Add support for `PerformanceLocationDetails` on `Tax.CalculationLineItem`, `Tax.TransactionLineItem`, and `TaxCalculationLineItemOptions`
* ⚠️ Remove support for `MoneyServices` on `ChargePaymentDetailsOptions` and `PaymentIntentPaymentDetailsOptions`
* Add support for `FrMealVoucher` on `Charge.PaymentMethodDetails.Card.Benefits`
* Add support for `Multicapture` on `Charge.PaymentMethodDetails.CardPresent`, `ConfirmationToken.PaymentMethodPreview.Card.GeneratedFrom.PaymentMethodDetails.CardPresent`, `PaymentAttemptRecord.PaymentMethodDetails.CardPresent`, `PaymentMethod.Card.GeneratedFrom.PaymentMethodDetails.CardPresent`, and `PaymentRecord.PaymentMethodDetails.CardPresent`
* Add support for `Pix` on `Checkout.Session.CurrentAttempt.PaymentMethodDetails`
* Add support for `ProvisionalCredit` on `Issuing.DisputeUpdateOptions` and `Issuing.Dispute`
* Add support for `Reason` on `PaymentAttemptRecordReportCanceledOptions` and `PaymentRecordReportPaymentAttemptCanceledOptions`
* Add support for `FiservValuelink`, `Givex`, and `Svs` on `PaymentAttemptRecord.ProcessorDetails` and `PaymentRecord.ProcessorDetails`
* ⚠️ Change type of `PaymentAttemptRecord.ProcessorDetails.Type` and `PaymentRecord.ProcessorDetails.Type` from `literal('custom')` to `enum('custom'|'fiserv_valuelink'|'givex'|'svs')`
* Add support for `CaptureBy` and `CaptureDelay` on `PaymentIntent.PaymentMethodOptions.CardPresent`, `PaymentIntent.PaymentMethodOptions.Card`, `PaymentIntentPaymentMethodOptionsCardOptions`, and `PaymentIntentPaymentMethodOptionsCardPresentOptions`
* ⚠️ Remove support for `LiquidAsset` on `PaymentIntentPaymentMethodOptionsCardPaymentDetailsMoneyServicesAccountFundingOptions` and `PaymentIntentPaymentMethodOptionsCardPresentPaymentDetailsMoneyServicesAccountFundingOptions`
* Add support for `RequestMulticapture` on `PaymentIntent.PaymentMethodOptions.CardPresent` and `PaymentIntentPaymentMethodOptionsCardPresentOptions`
* Add support for `IgnoreApplicationFee`, `IgnoreTransferData`, and `RequestPartialAuthorization` on `PaymentIntentPaymentMethodOptionsGiftCardOptions`
* Add support for `LatestPaymentAttemptRecord` and `PaymentRecord` on `PaymentIntent`
* ⚠️ Remove support for `Reauthorization` and `ReauthorizeBefore` on `PaymentIntent.AdvancedFeatureDetails`
* Add support for `RefundAddress` on `PaymentIntent.NextAction.CryptoDisplayDetails.DepositAddresses.Base`, `PaymentIntent.NextAction.CryptoDisplayDetails.DepositAddresses.Solana`, and `PaymentIntent.NextAction.CryptoDisplayDetails.DepositAddresses.Tempo`
* Add support for `Location` on `PaymentIntent.PaymentDetails` and `SetupIntent.SetupDetails`
* Add support for `Data` on `RadarAccountEvaluationLoginInitiatedClientDeviceMetadataDetailsOptions`, `RadarAccountEvaluationRegistrationInitiatedClientDeviceMetadataDetailsOptions`, and `RadarCustomerEvaluationEvaluationContextClientDetailsOptions`
* ⚠️ Change type of `V2.Core.FeeBatch.Adjustments.TaxAdjustment` from `amount` to `an object`
* ⚠️ Change type of `V2.Core.FeeBatch.Amount`, `V2.Core.FeeBatch.CollectionRecord.Amount`, `V2.Core.FeeBatch.CollectionRecord.Tax.Amount`, `V2.Core.FeeBatch.Tax.Amount`, `V2.Core.FeeEntry.Amount`, and `V2.Core.FeeEntry.Tax.Amount` from `amount` to `an object`
* Add support for `TaxFund` on `V2.MoneyManagement.Transaction.Flow` and `V2.MoneyManagement.TransactionEntry.TransactionDetails.Flow`
