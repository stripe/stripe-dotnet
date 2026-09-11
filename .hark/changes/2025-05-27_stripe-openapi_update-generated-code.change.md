---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/3123
is_stripe_api_change: true
released_in_version: 48.3.0-beta.1
---

### Breaking changes
* Remove support for deprecated previews
  * Remove support for resources `Billing.MeterErrorReport`, `GiftCards.Card`, `GiftCards.Transaction`, and `Privacy.RedactionJobRootObjects`
  * Remove support for `Create`, `Get`, `List`, `Update`, and `Validate` methods on resource `GiftCards.Card`
  * Remove support for `Cancel`, `Confirm`, `Create`, `Get`, `List`, and `Update` methods on resource `GiftCards.Transaction`
  * Remove support for `Provisioning` on `ProductCreateOptions` and `Product`
* Change type of `CheckoutSessionLineItemOptions.Quantity` from `emptyable(longInteger)` to `longInteger`
* Change type of `InvoiceSubscriptionDetailsOptions.CancelAt`, `SubscriptionCreateOptions.CancelAt`, and `SubscriptionUpdateOptions.CancelAt` from `DateTime` to `DateTime | enum('max_period_end'|'min_period_end')`
* Remove support for `Credits` on `OrderCreateOptions`, `OrderUpdateOptions`, and `Order`
* Remove support for `AmountRemaining` on `Order`
* Remove support for `AmountCredit` on `Order.TotalDetails`
* Remove support for `AsyncWorkflows` on `PaymentIntentCaptureOptions`, `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `PaymentIntentDecrementAuthorizationOptions`, `PaymentIntentIncrementAuthorizationOptions`, `PaymentIntentUpdateOptions`, and `PaymentIntent`
* Change type of `PaymentRecordReportPaymentAttemptCanceledOptions.Metadata`, `PaymentRecordReportPaymentAttemptFailedOptions.Metadata`, `PaymentRecordReportPaymentAttemptGuaranteedOptions.Metadata`, `PaymentRecordReportPaymentAttemptOptions.Metadata`, and `PaymentRecordReportPaymentOptions.Metadata` from `map(string: string)` to `emptyable(map(string: string))`
* Change type of `Privacy.RedactionJob.Objects` from `$Privacy.RedactionJobRootObjects` to `RedactionResourceRootObjects`
* Change type of `Privacy.RedactionJobValidationError.ErroringObject` from `map(string: string)` to `RedactionResourceErroringObject`
* Remove support for `StatusDetails` and `Status` on `Tax.Association`
* Remove support for snapshot event `BillingMeterErrorReportTriggered` with resource `Billing.MeterErrorReport`

### Other changes
* Add support for `Migrate` method on resource `Subscription`
* Add support for `Distance`, `PickupLocationName`, `ReturnLocationName`, and `VehicleIdentificationNumber` on `ChargePaymentDetailsCarRentalOptions`, `PaymentIntent.PaymentDetails.CarRental`, and `PaymentIntentPaymentDetailsCarRentalOptions`
* Add support for `DriverIdentificationNumber` and `DriverTaxNumber` on `ChargePaymentDetailsCarRentalDriverOptions`, `PaymentIntent.PaymentDetails.CarRental.Driver`, and `PaymentIntentPaymentDetailsCarRentalDriverOptions`
* Add support for `Institution` on `FinancialConnections.Account`
* Add support for `Countries` on `FinancialConnections.Institution`
* Add support for `Location` and `Reader` on `PaymentAttemptRecord.PaymentMethodDetails.Affirm`, `PaymentAttemptRecord.PaymentMethodDetails.WechatPay`, `PaymentRecord.PaymentMethodDetails.Affirm`, and `PaymentRecord.PaymentMethodDetails.WechatPay`
* Add support for `Hooks` on `PaymentIntentCaptureOptions`, `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `PaymentIntentDecrementAuthorizationOptions`, `PaymentIntentIncrementAuthorizationOptions`, `PaymentIntentUpdateOptions`, and `PaymentIntent`
* Add support for `CardPresent` on `PaymentIntentAmountDetailsLineItem.PaymentMethodOptions`
* Add support for `Livemode` on `Privacy.RedactionJob`
* Add support for `BillingThresholds` on `QuotePreviewSubscriptionSchedule.DefaultSettings`, `QuotePreviewSubscriptionSchedule.Phase.Item`, and `QuotePreviewSubscriptionSchedule.Phase`
* Add support for `BillingModeDetails` on `Subscription`
* Add support for `TaxTransactionAttempts` on `Tax.Association`
* Add support for `ConfirmConfig` on `Terminal.Reader.Action.ConfirmPaymentIntent` and `Terminal.ReaderConfirmPaymentIntentOptions`
