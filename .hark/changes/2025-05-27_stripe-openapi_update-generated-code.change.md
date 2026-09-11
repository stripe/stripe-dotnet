---
title: Update generated code.
pr_link: https://github.com/stripe/stripe-dotnet/pull/3128
is_stripe_api_change: true
released_in_version: 48.2.0
---

* Add support for `AttachPayment` method on resource `Invoice`
* Add support for `CollectInputs` method on resource `Terminal.Reader`
* Add support for `SucceedInputCollection` and `TimeoutInputCollection` test helper methods on resource `Terminal.Reader`
* Add support for `PixPayments` on `Account.Capabilities` and `AccountCapabilitiesOptions`
* Add support for `DisputesList` and `PaymentDisputes` on `AccountSession.Components` and `AccountSessionComponentsOptions`
* Add support for `RefundAndDisputePrefunding` on `Balance`
* Add support for `BalanceType` on `BalanceTransaction`
* Add support for `Location` and `Reader` on `Charge.PaymentMethodDetails.Affirm` and `Charge.PaymentMethodDetails.WechatPay`
* Add support for `PaymentMethodRemove` on `CheckoutSessionSavedPaymentMethodOptionsOptions`
* Add support for `SetupFutureUsage` on `Checkout.Session.PaymentMethodOptions.NaverPay`
* Add support for `PostPaymentAmount` and `PrePaymentAmount` on `CreditNote`
* Add support for `Sex`, `UnparsedPlaceOfBirth`, and `UnparsedSex` on `Identity.VerificationReport.Document` and `Identity.VerificationSession.VerifiedOutputs`
* Add support for `BillingThresholds` on `InvoiceScheduleDetailsPhaseItemOptions`, `InvoiceScheduleDetailsPhaseOptions`, `InvoiceSubscriptionDetailsItemOptions`, `SubscriptionCreateOptions`, `SubscriptionItemCreateOptions`, `SubscriptionItemOptions`, `SubscriptionItemUpdateOptions`, `SubscriptionItem`, `SubscriptionSchedule.DefaultSettings`, `SubscriptionSchedule.Phase.Item`, `SubscriptionSchedule.Phase`, `SubscriptionScheduleDefaultSettingsOptions`, `SubscriptionSchedulePhaseItemOptions`, `SubscriptionSchedulePhaseOptions`, `SubscriptionUpdateOptions`, and `Subscription`
* Add support for `Satispay` on `PaymentIntent.PaymentMethodOptions` and `PaymentIntentPaymentMethodOptionsOptions`
* Add support for `CaptureMethod` on `PaymentIntent.PaymentMethodOptions.Billie`
* Add support for `KakaoPay`, `KrCard`, `NaverPay`, `Payco`, and `SamsungPay` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
* Add support for `NetworkDeclineCode` on `Refund.DestinationDetails.Paypal`
* Add support for `Metadata` on `Tax.CalculationLineItem` and `TaxCalculationLineItemOptions`
* Add support for `ReturnUrl` on `Terminal.Reader.Action.ProcessPaymentIntent.ProcessConfig` and `TerminalReaderProcessConfigOptions`
* Add support for `CollectInputs` on `Terminal.Reader.Action`
* Add support for snapshot event `InvoicePaymentPaid` with resource `InvoicePayment`
