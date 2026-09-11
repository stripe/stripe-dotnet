---
title: ", [#3190](https://github.com/stripe/stripe-dotnet/pull/3190), [#3205](https://github.com/stripe/stripe-dotnet/pull/3205) Update generated code based on incoming API changes in the `2025-09-30.clover` API version."
pr_link: https://github.com/stripe/stripe-dotnet/pull/3175
is_breaking: true
is_stripe_api_change: true
released_in_version: 49.0.0
---

* ⚠️ Remove support for `BalanceReport` and `PayoutReconciliationReport` on `AccountSession.Components` and `AccountSessionComponentsOptions`
* ⚠️ Change type of `InvoiceSubscriptionDetailsOptions.CancelAt`, `SubscriptionCreateOptions.CancelAt` and `SubscriptionUpdateOptions.CancelAt` from `DateTime` to `DateTime | enum('max_period_end'|'min_period_end')`
* ⚠️ Remove support for `Coupon` on `Discount`, `PromotionCodeCreateOptions`, and `PromotionCode`. Use `Discount.Source.Coupon`, `PromotionCodeCreateOptions.Promotion.Coupon`, and `PromotionCode.Promotion.Coupon` instead.
* ⚠️ Remove support for `Link` and `PayByBank` on `PaymentMethodUpdateOptions`
* Add support for new resource `BalanceSettings`
* Add support for `Get` and `Update` methods on resource `BalanceSettings`
* Add support for `Source` on `Discount`
* Add support for `MbWayPayments` on `Account.Capabilities` and `AccountCapabilitiesOptions`
* Add support for `TrialUpdateBehavior` on `BillingPortal.Configuration.Features.SubscriptionUpdate` and `BillingPortalConfigurationFeaturesSubscriptionUpdateOptions`
* Add support for `MbWay` on `Charge.PaymentMethodDetails`, `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `PaymentIntent.PaymentMethodOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `BrandingSettings` and `NameCollection` on `Checkout.SessionCreateOptions` and `Checkout.Session`
* Add support for `ExcludedPaymentMethodTypes` on `Checkout.SessionCreateOptions`, `Checkout.Session`, `PaymentIntentConfirmOptions`, and `PaymentIntentUpdateOptions`
* Add support for `UnitLabel` on `CheckoutSessionLineItemPriceDataProductDataOptions`, `InvoiceLineItemPriceDataProductDataOptions`, `InvoiceLinePriceDataProductDataOptions`, and `PaymentLinkLineItemPriceDataProductDataOptions`
* Add support for `Alma`, `Billie`, and `Satispay` on `Checkout.Session.PaymentMethodOptions` and `CheckoutSessionPaymentMethodOptionsOptions`
* Add support for `DemoPay` on `CheckoutSessionPaymentMethodOptionsOptions`
* Add support for `CaptureMethod` on `Checkout.Session.PaymentMethodOptions.Affirm`, `Checkout.Session.PaymentMethodOptions.AfterpayClearpay`, `Checkout.Session.PaymentMethodOptions.AmazonPay`, `Checkout.Session.PaymentMethodOptions.Card`, `Checkout.Session.PaymentMethodOptions.Cashapp`, `Checkout.Session.PaymentMethodOptions.Klarna`, `Checkout.Session.PaymentMethodOptions.Link`, `Checkout.Session.PaymentMethodOptions.Mobilepay`, `Checkout.Session.PaymentMethodOptions.RevolutPay`, `CheckoutSessionPaymentMethodOptionsAffirmOptions`, `CheckoutSessionPaymentMethodOptionsAfterpayClearpayOptions`, `CheckoutSessionPaymentMethodOptionsAmazonPayOptions`, `CheckoutSessionPaymentMethodOptionsCardOptions`, `CheckoutSessionPaymentMethodOptionsCashappOptions`, `CheckoutSessionPaymentMethodOptionsKlarnaOptions`, `CheckoutSessionPaymentMethodOptionsLinkOptions`, `CheckoutSessionPaymentMethodOptionsMobilepayOptions`, and `CheckoutSessionPaymentMethodOptionsRevolutPayOptions`
* Add support for `Flexible` on `CheckoutSessionSubscriptionDataBillingModeOptions`, `InvoiceScheduleDetailsBillingModeOptions`, `InvoiceSubscriptionDetailsBillingModeOptions`, `Quote.SubscriptionData.BillingMode`, `QuoteSubscriptionDataBillingModeOptions`, `Subscription.BillingMode`, `SubscriptionBillingModeOptions`, `SubscriptionSchedule.BillingMode`, and `SubscriptionScheduleBillingModeOptions`
* Add support for `BusinessName` and `IndividualName` on `Checkout.Session.CollectedInformation`, `Checkout.Session.CustomerDetails`, `CustomerCreateOptions`, `CustomerUpdateOptions`, and `Customer`
* Add support for `ChargebackLossReasonCode` on `Dispute.PaymentMethodDetails.Klarna`
* Add support for `NetAmount` and `ProrationDetails` on `InvoiceItem`
* Remove support for `Iterations` on `InvoiceScheduleDetailsPhaseOptions` and `SubscriptionSchedulePhaseOptions`
* Add support for `FraudDisputabilityLikelihood` and `RiskAssessment` on `Issuing.TestHelpersAuthorizationCreateOptions`
* Add support for `SecondLine` on `Issuing.Card`
* Add support for `FrMealVoucherConecs` on `PaymentMethodConfigurationCreateOptions` and `PaymentMethodConfigurationUpdateOptions`
* Add support for `Promotion` on `PromotionCodeCreateOptions` and `PromotionCode`
* Add support for `Provider` on `Tax.Settings.Defaults`
* Add support for `BbposWisepad3` on `Terminal.ConfigurationCreateOptions`, `Terminal.ConfigurationUpdateOptions`, and `Terminal.Configuration`
* Add support for `AddressKana`, `AddressKanji`, `DisplayNameKana`, `DisplayNameKanji`, and `Phone` on `Terminal.LocationCreateOptions`, `Terminal.LocationUpdateOptions`, and `Terminal.Location`
