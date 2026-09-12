---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/2906
is_stripe_api_change: true
released_in_version: 44.6.0
---

* Add support for `Update` test helper method on resources `Treasury.OutboundPayment` and `Treasury.OutboundTransfer`
* Add support for `AllowRedisplay` on `ConfirmationTokenPaymentMethodPreview` and `PaymentMethod`
* Change type of `EntitlementsFeatureMetadataOptions` from `map(string: string)` to `emptyable(map(string: string))`
* Add support for `PreviewMode` on `InvoiceCreatePreviewOptions`, `InvoiceUpcomingLinesOptions`, and `InvoiceUpcomingOptions`
* Add support for `TrackingDetails` on `TreasuryOutboundPayment` and `TreasuryOutboundTransfer`
