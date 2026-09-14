---
title: Support for APIs in the new API version 2025-03-31.basil
pr_url: https://github.com/stripe/stripe-dotnet/pull/3056
is_stripe_api_change: true
released_in_version: 48.0.0
---

This release changes the pinned API version to `2025-03-31.basil`.

### ⚠️ Breaking changes  due to changes in the Stripe API

Please review details for the breaking changes and alternatives in the [Stripe API changelog](https://docs.stripe.com/changelog/basil) before upgrading.

* Remove support for resources `SubscriptionItemUsageRecordSummary` and `SubscriptionItemUsageRecord`
* Remove support for `Create` method on resource `SubscriptionItemUsageRecord`
* Remove support for `List`, `ListAsync`, `ListAutoPaginating`, and `ListAutoPaginatingAsync` methods on resource `SubscriptionItemUsageRecordSummary`
* Remove support for `Upcoming` and `UpcomingAsync` methods on resource `Invoice`
* Remove support for `Invoice` on `Charge` and `PaymentIntent`
* Remove support for `ShippingDetails` on `CheckoutSession`
* Remove support for `Carrier`, `Phone`, and `TrackingNumber` on `SessionCollectedInformationShippingDetails`
* Remove support for `Refund` on `CreditNoteCreateOptions`, `CreditNotePreviewLinesListOptions`, `CreditNotePreviewOptions`, and `CreditNote`
* Remove support for `TaxAmounts` on `CreditNoteLineItem`, `CreditNote`, and `InvoiceLineItem`
* Remove support for `AmountExcludingTax` and `UnitAmountExcludingTax` on `CreditNoteLineItem` and `InvoiceLineItem`
* Remove support for `Coupon` on `CustomerCreateOptions`, `CustomerUpdateOptions`, `InvoiceCreatePreviewOptions`, `InvoiceScheduleDetailsPhasesOptions`, `SubscriptionCreateOptions`, `SubscriptionSchedulePhasesOptions`, `SubscriptionSchedulePhases`, and `SubscriptionUpdateOptions`
* Remove support for `PromotionCode` on `CustomerCreateOptions`, `CustomerUpdateOptions`, `SubscriptionCreateOptions`, and `SubscriptionUpdateOptions`
* Remove support for `Price` on `InvoiceItemCreateOptions`, `InvoiceItemUpdateOptions`, `InvoiceItem`, `InvoiceLineItemUpdateOptions`, `InvoiceLineItem`, and `InvoiceLinesOptions`
* Remove support for `BillingThresholds` on `InvoiceScheduleDetailsPhaseItemOptions`, `InvoiceScheduleDetailsPhaseOptions`, `InvoiceSubscriptionDetailsItemOptions`, `SubscriptionCreateOptions`, `SubscriptionItemCreateOptions`, `SubscriptionItemUpdateOptions`, `SubscriptionItem`, `SubscriptionItemsOptions`, `SubscriptionScheduleDefaultSettingsOptions`, `SubscriptionScheduleDefaultSettings`, `SubscriptionSchedulePhaseItemOptions`, `SubscriptionSchedulePhaseItem`, `SubscriptionSchedulePhaseOptions`, `SubscriptionSchedulePhase`, `SubscriptionUpdateOptions`, and `Subscription`
* Remove support for `ApplicationFeeAmount`, `Charge`, `PaidOutOfBand`, `Paid`, `PaymentIntent`, `Quote`, `Subscription`, `SubscriptionDetails`, `SubscriptionProrationDate`, `Tax`, `TotalTaxAmounts`, and `TransferData` on `Invoice`
* Remove support for `Discount` on `Invoice` and `Subscription`
* Remove support for `InvoiceItem`, `ProrationDetails`, `Proration`, `TaxRates`, and `Type` on `InvoiceLineItem`
* Remove support for `Plan` and `SubscriptionItem` on `InvoiceItem` and `InvoiceLineItem`
* Remove support for `UnitAmount` on `InvoiceItemCreateOptions`, `InvoiceItemUpdateOptions`, and `InvoiceItem`
* Remove support for `SubscriptionItems` on `InvoiceLineItemListOptions` and `InvoiceLineItemsListOptions`
* Remove support for `Subscription` and `UnitAmountDecimal` on `InvoiceItem`
* Remove support for `NaverPay` on `PaymentMethodUpdateOptions`
* Remove support for `AggregateUsage` on `PlanCreateOptions`, `Plan`, `PriceRecurringOptions`, and `PriceRecurring`
* Remove support for `CurrentPeriodEnd` and `CurrentPeriodStart` on `Subscription`
* Remove support for Page on `V2.EventDestinationListOptions` and `V2.EventListOptions`

### Additions

* Add support for new resource `InvoicePayment`
* Add support for `Get` and `List` methods on resource `InvoicePayment`
* Add support for `BilliePayments`, `NzBankAccountBecsDebitPayments`, and `SatispayPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
* Add support for `HostedPaymentMethodSave` on `AccountSettingsInvoicesOptions` and `AccountSettingsInvoices`
* Add support for `Invoices` on `AccountSettingsOptions`
* Add support for `PresentmentDetails` on `Charge`, `CheckoutSession`, `PaymentIntent`, and `Refund`
* Add support for `Billie` and `Satispay` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `CustomerPaymentMethod`, `PaymentIntentPaymentMethodDataOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `NzBankAccount` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `CustomerPaymentMethod`, `MandatePaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `SetupAttemptPaymentMethodDetails`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `OptionalItems` on `Checkout.SessionCreateOptions`, `CheckoutSession`, `PaymentLinkCreateOptions`, and `PaymentLink`
* Add support for `Permissions` on `Checkout.SessionCreateOptions` and `CheckoutSession`
* Add support for `ShippingOptions` on `Checkout.SessionUpdateOptions`
* Add support for `BuyerId` on `ConfirmationTokenPaymentMethodPreviewNaverPay`, `CustomerPaymentMethodNaverPay`, and `PaymentMethodNaverPay`
* Add support for `Refunds` on `CreditNoteCreateOptions`, `CreditNotePreviewLinesListOptions`, `CreditNotePreviewOptions`, and `CreditNote`
* Add support for `TotalTaxes` on `CreditNote` and `Invoice`
* Add support for `Taxes` on `CreditNoteLineItem` and `InvoiceLineItem`
* Add support for `TaxabilityReason` on `InvoiceLineItemTaxAmountsOptions` and `InvoiceLinesTaxAmountsOptions`
* Add support for `JurisdictionLevel` on `InvoiceLineItemTaxAmountsTaxRateDataOptions` and `InvoiceLinesTaxAmountsTaxRateDataOptions`
* Add support for `AmountOverpaid`, `ConfirmationSecret`, and `Payments` on `Invoice`
* Add support for `Parent` on `InvoiceItem`, `InvoiceLineItem`, and `Invoice`
* Add support for `NaverPay` on `MandatePaymentMethodDetails` and `SetupAttemptPaymentMethodDetails`
* Add support for `SetupFutureUsage` on `PaymentIntentPaymentMethodOptionsNaverPayOptions` and `PaymentIntentPaymentMethodOptionsNaverPay`
* Add support for `DefaultValue` on `PaymentLinkCustomFieldsDropdownOptions`, `PaymentLinkCustomFieldsDropdown`, `PaymentLinkCustomFieldsNumericOptions`, `PaymentLinkCustomFieldsNumeric`, `PaymentLinkCustomFieldsTextOptions`, and `PaymentLinkCustomFieldsText`
* Add support for `NzBankTransfer` on `RefundDestinationDetails`
* Add support for `CurrentPeriodEnd` and `CurrentPeriodStart` on `SubscriptionItem`
* Add support for `Wifi` on `Terminal.ConfigurationCreateOptions`, `Terminal.ConfigurationUpdateOptions`, and `TerminalConfiguration`

### ⚠️ Other Breaking changes in the SDK
