---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3361
is_stripe_api_change: true
released_in_version: 51.1.0-alpha.3
---

* Add support for `PaymentRecord` on `ApplicationFee.FeeSource`
* Add support for `FleetData` on `ChargePaymentDetailsOptions`, `PaymentIntent.PaymentDetails`, `PaymentIntentAmountDetailsLineItem.PaymentMethodOptions.Card`, `PaymentIntentAmountDetailsLineItemsPaymentMethodOptionsCardOptions`, and `PaymentIntentPaymentDetailsOptions`
* Add support for `BeneficiaryAccount`, `BeneficiaryDetails`, `SenderAccount`, and `SenderDetails` on `ChargePaymentDetailsMoneyServicesAccountFundingOptions` and `PaymentIntentPaymentDetailsMoneyServicesAccountFundingOptions`
* Change type of `ChargePaymentDetailsMoneyServicesOptions.TransactionType` and `PaymentIntentPaymentDetailsMoneyServicesOptions.TransactionType` from `literal('account_funding')` to `emptyable(literal('account_funding'))`
* Add support for `Bizum` on `Invoice.PaymentSettings.PaymentMethodOptions`, `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions`, `Subscription.PaymentSettings.PaymentMethodOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`
* Add support for `QuantityPrecision` on `PaymentIntentAmountDetailsLineItem` and `PaymentIntentAmountDetailsLineItemsOptions`
* Add support for `LiquidAsset` and `Wallet` on `PaymentIntentPaymentMethodOptionsCardPaymentDetailsMoneyServicesAccountFundingOptions` and `PaymentIntentPaymentMethodOptionsCardPresentPaymentDetailsMoneyServicesAccountFundingOptions`
* Add support for `SharedPaymentGrantedToken` on `PaymentMethod`
* Add support for `Data` on `Radar.PaymentEvaluation.ClientDeviceMetadataDetails` and `RadarPaymentEvaluationClientDeviceMetadataDetailsOptions`
* Add support for `Sunbit` on `SharedPayment.GrantedToken.PaymentMethodDetails`
* Add support for error type `CannotProceedException`
