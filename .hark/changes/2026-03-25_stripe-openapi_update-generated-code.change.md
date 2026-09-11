---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3352
is_breaking: true
is_stripe_api_change: true
released_in_version: 51.1.0-alpha.1
---

* Add support for new resource `RiskSignals`
* Add support for `FinancialAccountRewards` and `NestingDemo` on `AccountSession.Components`
* Add support for `UpiPayments` on `Account.Capabilities` and `AccountCapabilitiesOptions`
* Add support for `RiskSignals` on `Account`
* Add support for `FraudIntent` on `AccountSignals`
* Add support for `RiskReserved` on `Balance`
* ⚠️ Remove support for `BillableItems` on `Billing.Alert.SpendThreshold.Filters`
* Add support for `Upi` on `Charge.PaymentMethodDetails`, `Checkout.Session.PaymentMethodOptions`, `CheckoutSessionPaymentMethodOptionsOptions`, `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `Mandate.PaymentMethodDetails`, `PaymentAttemptRecord.PaymentMethodDetails`, `PaymentIntent.PaymentMethodOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `PaymentRecord.PaymentMethodDetails`, `SetupAttempt.PaymentMethodDetails`, `SetupIntent.PaymentMethodOptions`, `SetupIntentPaymentMethodDataOptions`, and `SetupIntentPaymentMethodOptionsOptions`
* ⚠️ Remove support for `SourceType` on `Charge.PaymentMethodDetails.StripeBalance`, `ConfirmationToken.PaymentMethodPreview.StripeBalance`, `ConfirmationTokenPaymentMethodDataStripeBalanceOptions`, `PaymentAttemptRecord.PaymentMethodDetails.StripeBalance`, `PaymentIntentPaymentMethodDataStripeBalanceOptions`, `PaymentMethod.StripeBalance`, `PaymentMethodStripeBalanceOptions`, `PaymentRecord.PaymentMethodDetails.StripeBalance`, and `SetupIntentPaymentMethodDataStripeBalanceOptions`
* Add support for `IntegrationIdentifier` on `Checkout.SessionCreateOptions` and `Checkout.Session`
* Change type of `CheckoutSessionLineItemPriceDataProductDataTaxDetailsOptions.TaxCode`, `InvoiceLineItemPriceDataProductDataTaxDetailsOptions.TaxCode`, `InvoiceLinePriceDataProductDataTaxDetailsOptions.TaxCode`, `PaymentLinkLineItemPriceDataProductDataTaxDetailsOptions.TaxCode`, `PlanProductTaxDetailsOptions.TaxCode`, `PriceProductDataTaxDetailsOptions.TaxCode`, and `ProductTaxDetailsOptions.TaxCode` from `string` to `emptyable(string)`
* Add support for `Crypto` on `CheckoutSessionPaymentMethodOptionsOptions`
* Add support for `PendingInvoiceItemInterval` on `CheckoutSessionSubscriptionDataOptions`
* Add support for `AuBecsDebit`, `BacsDebit`, `Boleto`, `Link`, `SepaDebit`, and `UsBankAccount` on `Checkout.Session.CurrentAttempt.PaymentMethodDetails`
* Add support for `Metadata` on `CreditNoteLineItem` and `CreditNoteLineOptions`
* Add support for `SelectedFulfillmentOptionOverrides` on `DelegatedCheckout.RequestedSession.FulfillmentDetails`
* Add support for `LineItemKeys` on `DelegatedCheckout.RequestedSession.FulfillmentDetails.FulfillmentOptions.Digital.DigitalOptions` and `DelegatedCheckout.RequestedSession.FulfillmentDetails.FulfillmentOptions.Shipping.ShippingOptions`
* Add support for `QuantityDecimal` on `InvoiceInvoiceItemOptions`, `InvoiceItemCreateOptions`, `InvoiceItemUpdateOptions`, `InvoiceItem`, `InvoiceLineItemUpdateOptions`, `InvoiceLineItem`, and `InvoiceLineOptions`
* Add support for `ExpiresAfterSeconds` on `Invoice.PaymentSettings.PaymentMethodOptions.Pix`, `InvoicePaymentSettingsPaymentMethodOptionsPixOptions`, `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions.Pix`, `Subscription.PaymentSettings.PaymentMethodOptions.Pix`, and `SubscriptionPaymentSettingsPaymentMethodOptionsPixOptions`
* ⚠️ Add support for `Level` on `IssuingAuthorizationRiskAssessmentCardTestingRiskOptions` and `IssuingAuthorizationRiskAssessmentMerchantDisputeRiskOptions`
* ⚠️ Remove support for `RiskLevel` on `IssuingAuthorizationRiskAssessmentCardTestingRiskOptions` and `IssuingAuthorizationRiskAssessmentMerchantDisputeRiskOptions`
* Add support for `LifecycleControls` on `Issuing.CardCreateOptions` and `Issuing.Card`
* ⚠️ Change type of `PaymentAttemptRecord.PaymentMethodDetails.Card.ExpMonth` and `PaymentRecord.PaymentMethodDetails.Card.ExpMonth` from `longInteger` to `nullable(longInteger)`
* ⚠️ Change type of `PaymentAttemptRecord.PaymentMethodDetails.Card.ExpYear` and `PaymentRecord.PaymentMethodDetails.Card.ExpYear` from `longInteger` to `nullable(longInteger)`
* ⚠️ Change type of `PaymentAttemptRecord.PaymentMethodDetails.Card.Moto` and `PaymentRecord.PaymentMethodDetails.Card.Moto` from `boolean` to `nullable(boolean)`
* Add support for `Cryptogram`, `ElectronicCommerceIndicator`, `ExemptionIndicatorApplied`, and `ExemptionIndicator` on `PaymentAttemptRecord.PaymentMethodDetails.Card.ThreeDSecure` and `PaymentRecord.PaymentMethodDetails.Card.ThreeDSecure`
* Add support for `Surcharge` on `PaymentIntent.AmountDetails` and `PaymentIntentAmountDetailsOptions`
* Add support for `MandateOptions` on `PaymentIntent.PaymentMethodOptions.StripeBalance` and `PaymentIntentPaymentMethodOptionsStripeBalanceOptions`
* Add support for `AmountDetails` and `PaymentDetails` on `PaymentIntentDecrementAuthorizationOptions`
* Add support for `UpiHandleRedirectOrDisplayQrCode` on `PaymentIntent.NextAction` and `SetupIntent.NextAction`
* Add support for `ManagedPayments` on `PaymentLinkCreateOptions` and `PaymentLink`
* Add support for `RecommendedAction` and `Signals` on `Radar.PaymentEvaluation`
* ⚠️ Remove support for `Insights` on `Radar.PaymentEvaluation`
* Add support for `StripeBalance` on `SetupIntent.PaymentMethodOptions` and `SetupIntentPaymentMethodOptionsOptions`
* Add support for `RecurringInterval` on `SharedPayment.GrantedToken.UsageLimits`
* ⚠️ Change type of `SharedPayment.GrantedToken.UsageLimits.ExpiresAt` from `DateTime` to `nullable(DateTime)`
* Add support for `PresentmentDetails` on `Subscription`
* ⚠️ Remove support for `InvoiceResources` on `V2.Billing.Intent`
* ⚠️ Remove support for `AmountDue` and `CustomerBalanceApplied` on `V2.Billing.Intent.AmountDetails`
* Add support for `RecurringCreditGrant` on `V2.Billing.IntentAction.Modify.PricingPlanSubscriptionDetails.Overrides.PartialPeriodBehavior`, `V2.Billing.IntentAction.Subscribe.PricingPlanSubscriptionDetails.Overrides.PartialPeriodBehavior`, `V2BillingIntentActionModifyPricingPlanSubscriptionDetailsOverridesPartialPeriodBehaviorOptions`, and `V2BillingIntentActionSubscribePricingPlanSubscriptionDetailsOverridesPartialPeriodBehaviorOptions`
* Add support for `ConsumerPrivacyDisclosures` and `ConsumerStorer` on `V2.Core.Account.Identity.Attestations.TermsOfService` and `V2CoreAccountIdentityAttestationsTermsOfServiceOptions`
* ⚠️ Remove support for `Include` on `V2.Billing.IntentCreateOptions` and `V2.Billing.IntentReserveOptions`
