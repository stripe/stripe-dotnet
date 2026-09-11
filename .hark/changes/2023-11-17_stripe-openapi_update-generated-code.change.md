---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/2795
is_stripe_api_change: true
released_in_version: 43.4.0-beta.1
---

* Add support for `IssuingCard` and `IssuingCardsList` on `AccountSessionComponentsOptions`
* Add support for `EventDetails` and `Subscription` on `ChargePaymentDetailsOptions`, `PaymentIntentPaymentDetailsOptions`, and `PaymentIntentPaymentDetails`
* Add support for `Affiliate` and `Delivery` on `ChargePaymentDetailsCarRentalOptions`, `ChargePaymentDetailsFlightOptions`, `ChargePaymentDetailsLodgingOptions`, `PaymentIntentPaymentDetailsCarRentalOptions`, `PaymentIntentPaymentDetailsCarRental`, `PaymentIntentPaymentDetailsFlightOptions`, and `PaymentIntentPaymentDetailsLodgingOptions`
* Add support for `Drivers` on `ChargePaymentDetailsCarRentalOptions`, `PaymentIntentPaymentDetailsCarRentalOptions`, and `PaymentIntentPaymentDetailsCarRental`
* Add support for `Passengers` on `ChargePaymentDetailsFlightOptions`, `ChargePaymentDetailsLodgingOptions`, `PaymentIntentPaymentDetailsFlightOptions`, and `PaymentIntentPaymentDetailsLodgingOptions`
* Add support for `Created` on `CustomerSession`
* Change type of `Timestamp` property from `long` to `DateTime` on `InvoiceInvoiceItemDiscountDiscountEndOptions`, `InvoiceScheduleDetailsAmendmentAmendmentEndOptions`, `InvoiceScheduleDetailsAmendmentAmendmentStartOptions`, `InvoiceScheduleDetailsAmendmentItemActionAddDiscountDiscountEndOptions`, `InvoiceScheduleDetailsAmendmentItemActionSetDiscountDiscountEndOptions`, `InvoiceScheduleDetailsPhaseAddInvoiceItemDiscountDiscountEndOptions`, `InvoiceScheduleDetailsPhaseDiscountDiscountEndOptions`, `InvoiceScheduleDetailsPhaseItemDiscountDiscountEndOptions`,`InvoiceScheduleDetailsPrebillingBillUntilOptions`, and `InvoiceSubscriptionItemDiscountDiscountEndOptions`
* Change `long` to `DateTime` in `AnyOf` type for `EndDate`, `StartDate`, and `TrialEnd` on `InvoiceScheduleDetailsPhaseOptions`
