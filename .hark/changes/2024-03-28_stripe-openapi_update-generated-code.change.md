---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/2877
is_stripe_api_change: true
released_in_version: 43.21.0
---

* Add support for new resources `Billing.MeterEventAdjustment`, `Billing.MeterEvent`, and `Billing.Meter`
* Add support for `Create`, `Deactivate`, `Get`, `List`, `Reactivate`, and `Update` methods on resource `Meter`
* Add support for `Create` method on resources `MeterEventAdjustment` and `MeterEvent`
* Add support for `AmazonPayPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
* Add support for `DestinationOnBehalfOfChargeManagement` on `AccountSessionComponentsPaymentDetailsFeaturesOptions`, `AccountSessionComponentsPaymentDetailsFeatures`, `AccountSessionComponentsPaymentsFeaturesOptions`, and `AccountSessionComponentsPaymentsFeatures`
* Add support for `Mandate` on `ChargePaymentMethodDetailsUsBankAccount`, `TreasuryInboundTransferOriginPaymentMethodDetailsUsBankAccount`, `TreasuryOutboundPaymentDestinationPaymentMethodDetailsUsBankAccount`, and `TreasuryOutboundTransferDestinationPaymentMethodDetailsUsBankAccount`
* Add support for `SecondLine` on `Issuing.CardCreateOptions`
* Add support for `Meter` on `PlanCreateOptions`, `Plan`, `PriceRecurringOptions`, and `PriceRecurring`
