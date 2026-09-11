---
title: API Updates
pr_link: https://github.com/stripe/stripe-dotnet/pull/2643
is_stripe_api_change: true
released_in_version: 41.7.0
---

* Add support for `RefundPayment` method on resource `Terminal.Reader`
* Add support for `CustomFields` on `Checkout.SessionCreateOptions`, `Checkout.Session`, `PaymentLinkCreateOptions`, `PaymentLinkUpdateOptions`, and `PaymentLink`
* Add support for `InteracPresent` on `TestHelpersTerminal.ReaderPresentPaymentMethodOptions`
* Change type of `Terminal.ReaderTypeOptions` from `literal('card_present')` to `enum('card_present'|'interac_present')`
* Add support for `RefundPayment` on `Terminal.ReaderAction`
* Update `ShippingAddress` on `SessionCustomTextOptions` and `PaymentLinkCustomTextOptions` to use `SessionCustomTextShippingAddressOptions` and `PaymentLinkCustomTextShippingAddressOptions` instead of shared `AddressOptions`. This did not work before and did not align with the API definitions (extension of https://github.com/stripe/stripe-dotnet/pull/2644).
