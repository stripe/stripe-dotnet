---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/3099
is_stripe_api_change: true
released_in_version: 48.1.0-beta.4
---

* Add support for new resources `FxQuote` and `PaymentIntentAmountDetailsLineItem`
* Add support for `Create`, `Get`, and `List` methods on resource `FxQuote`
* Remove support for `AttachPaymentIntent` method on resource `Invoice`
* Add support for `RegistrationDate` on `AccountCompanyOptions`, `AccountCompany`, and `TokenAccountCompanyOptions`
* Add support for `CustomerReference` and `OrderReference` on `ChargePaymentDetailsOptions`, `PaymentIntentPaymentDetailsOptions`, and `PaymentIntentPaymentDetails`
* Add support for `TaxId` on `ChargeBillingDetails`, `ConfirmationTokenPaymentMethodDataBillingDetailsOptions`, `ConfirmationTokenPaymentMethodPreviewBillingDetails`, `PaymentIntentPaymentMethodDataBillingDetailsOptions`, `PaymentMethodBillingDetailsOptions`, `PaymentMethodBillingDetails`, `SetupIntentPaymentMethodDataBillingDetailsOptions`, and `TreasuryOutboundPaymentDestinationPaymentMethodDataBillingDetailsOptions`
* Add support for `PriceData` on `CheckoutSessionLineItemsOptions`
* Change type of `CheckoutSessionLineItemsOptions.Quantity` from `longInteger` to `emptyable(longInteger)`
* Add support for `Script` on `CouponCreateOptions` and `Coupon`
* Add support for `Type` on `Coupon`
* Add support for `FxQuote` on `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `PaymentIntentUpdateOptions`, `PaymentIntent`, `TransferCreateOptions`, and `Transfer`
* Add support for `DiscountAmount`, `LineItems`, `Shipping`, and `Tax` on `PaymentIntentAmountDetails`
* Add support for `Pix` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
* Add support for `UsCfpbData` on `Person` and `TokenPersonOptions`
* Add support for `PendingReason` on `Refund`
* Add support for `Aw`, `Az`, `Bd`, `Bj`, `Et`, `Kg`, `La`, and `Ph` on `TaxRegistrationCountryOptionsOptions` and `TaxRegistrationCountryOptions`
* Add support for snapshot event `FxQuoteExpired` with resource `FxQuote`
