---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/2768
is_stripe_api_change: true
released_in_version: 42.7.0-beta.1
---

* Remove support for `Customer` on `ConfirmationToken`
* Add support for `Issuer` on `InvoiceCreateOptions`, `InvoiceUpcomingLinesOptions`, `InvoiceUpcomingOptions`, `InvoiceUpdateOptions`, `Invoice`, `QuoteInvoiceSettingsOptions`, `QuoteInvoiceSettings`, `SubscriptionScheduleDefaultSettingsInvoiceSettingsOptions`, `SubscriptionScheduleDefaultSettingsInvoiceSettings`, `SubscriptionSchedulePhasesInvoiceSettingsOptions`, and `SubscriptionSchedulePhasesInvoiceSettings`
* Add support for `OnBehalfOf` on `InvoiceUpcomingLinesOptions` and `InvoiceUpcomingOptions`
* Add support for `Liability` on `InvoiceAutomaticTaxOptions`, `InvoiceAutomaticTax`, `QuoteAutomaticTaxOptions`, `QuoteAutomaticTax`, `SubscriptionAutomaticTaxOptions`, `SubscriptionAutomaticTax`, `SubscriptionScheduleDefaultSettingsAutomaticTaxOptions`, `SubscriptionScheduleDefaultSettingsAutomaticTax`, `SubscriptionSchedulePhasesAutomaticTaxOptions`, and `SubscriptionSchedulePhasesAutomaticTax`
* Change type of `IssuingCardDesignCarrierTextOptions` from `carrier_text_param` to `emptyStringable(carrier_text_param)`
* Add support for `InvoiceSettings` on `SubscriptionCreateOptions` and `SubscriptionUpdateOptions`
* Remove `InvoiceLineItemDiscountDiscountEndDurationOptions`, `InvoiceLineItemDiscountDiscountEndOptions`, `InvoiceLineItemInvoiceItemDiscountDiscountEndDurationOptions`, `InvoiceLineItemInvoiceItemDiscountDiscountEndOptions`, `InvoiceLineItemSubscriptionItemDiscountDiscountEndDurationOptions`, `InvoiceLineItemSubscriptionItemDiscountDiscountEndOptions.cs`, `InvoiceLineItemSubscriptionItemDiscountOptions`, `InvoiceLineItemSubscriptionPrebillingOptions`. These are obsolete and not used anywhere.
